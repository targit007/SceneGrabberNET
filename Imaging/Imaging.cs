using System;
using System.Drawing;
using DexterLib;
using System.Runtime.InteropServices;
using System.Text;

namespace Imaging
{
    public class Imaging
    {

        public enum CaptureType
        {
            @internal = 0,
            mplayer=1,
            ffmpeg=2
        }

        private static int MeasureDisplayStringWidth(Graphics graphics, string text,
                                                    Font font)
        {
            System.Drawing.StringFormat format = new System.Drawing.StringFormat();
            System.Drawing.RectangleF rect = new System.Drawing.RectangleF(0, 0,
                                                                          1000, 1000);
            System.Drawing.CharacterRange[] ranges = 
                                       { new System.Drawing.CharacterRange(0, 
                                                               text.Length) };
            System.Drawing.Region[] regions = new System.Drawing.Region[1];

            format.SetMeasurableCharacterRanges(ranges);

            regions = graphics.MeasureCharacterRanges(text, font, rect, format);
            rect = regions[0].GetBounds(graphics);

            return (int)(rect.Right + 1.0f);
        }

        private static int MeasureDisplayStringHeight(Graphics graphics, string text,
                                            Font font)
         {
             System.Drawing.StringFormat format = new System.Drawing.StringFormat();
             System.Drawing.RectangleF rect = new System.Drawing.RectangleF(0, 0,
                                                                           1000, 1000);
             System.Drawing.CharacterRange[] ranges = 
                                       { new System.Drawing.CharacterRange(0, 
                                                               text.Length) };
             System.Drawing.Region[] regions = new System.Drawing.Region[1];

             format.SetMeasurableCharacterRanges(ranges);

             regions = graphics.MeasureCharacterRanges(text, font, rect, format);
             rect = regions[0].GetBounds(graphics);

             return (int)(rect.Bottom + 1.0f);
         }


        public static Bitmap generateSceneshot(CaptureType type, String exePath, MediaDetClass mediaDet, double position, int width, int height)
         {
             if (type == CaptureType.mplayer)
             {
                 return generateMPlayerSceneShotOnDisk(exePath, mediaDet, position, width, height);
             }
             else if (type == CaptureType.ffmpeg)
             {
                 return generateFFMpegSceneShotOnDisk(exePath, mediaDet, position, width, height);
             }
             else if (type == CaptureType.@internal)
             {
                 return generateSceneshotInMemory(mediaDet, position, width, height);
             }
             else
             {
                 return null;
             }

         }

        private static Bitmap generateMPlayerSceneShotOnDisk(String path, MediaDetClass mediaDet, double position, int width, int height)
        {
            String filename = System.IO.Path.GetTempPath() + System.Guid.NewGuid().ToString();
            System.IO.Directory.CreateDirectory(filename);
            String usingFilename = null;
            String format = "{0}:{1}:{2}.{3}";
            TimeSpan tspan = TimeSpan.FromSeconds((double)position);
            format = string.Format(format, tspan.Hours, tspan.Minutes, tspan.Seconds, tspan.Milliseconds);
            String cmdArgs = " -vo jpeg:quality=100:outdir=\\\"" + filename + "\\\" -frames 1 -nosound -noframedrop -ss " +format + " \""+ mediaDet.Filename + "\"";
            System.Diagnostics.Process n = new System.Diagnostics.Process();
            n.StartInfo.FileName = path;
            n.StartInfo.Arguments = cmdArgs;
            n.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            n.Start();
            n.WaitForExit();
            n.Dispose();
            n = null;

            usingFilename = filename + "\\00000001.jpg";
            Bitmap bmp = null;
            if (System.IO.File.Exists(usingFilename))
            {
                bmp = new Bitmap(usingFilename);
            }
            //cleanup
            return bmp;
        }



        private static Bitmap generateFFMpegSceneShotOnDisk(String ffmpegpath, MediaDetClass mediaDet, double position, int width, int height) {
                        
            String filename = System.IO.Path.GetTempPath() + System.Guid.NewGuid().ToString();
            String usingFilename = null;
            String format = "{0}:{1}:{2}.{3}"; 
            TimeSpan tspan = TimeSpan.FromSeconds((double)position);
            format = string.Format(format, tspan.Hours, tspan.Minutes, tspan.Seconds, tspan.Milliseconds);
            String cmdArgs = " -an -ss " + format + " -r 1 -t 1 -i \"" + mediaDet.Filename + "\" -f image2 -s " + width + "x" + height + " \"" + filename + "\"";
            System.Diagnostics.Process n = new System.Diagnostics.Process();
            n.StartInfo.FileName = ffmpegpath;
            n.StartInfo.Arguments = cmdArgs;
            n.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            n.Start();
            n.WaitForExit();
            n.Dispose();
            n = null;

            //Drecks Filenamenbestimmung wegen DropFrames
//            if (System.IO.File.Exists(filename + "_2"))
//            {
//                usingFilename = filename + "_2";
//            }    
//                else
//            {
//                usingFilename = filename + "_1";
//            }
            usingFilename = filename;
            Bitmap bmp = null;
            if (System.IO.File.Exists(usingFilename))
            {
                bmp = new Bitmap(usingFilename);
            }
           
            //cleanup
            return bmp;
        }

       private static Bitmap generateSceneshotOnDisk(MediaDetClass mediaDet, double position, int width, int height)
         {
                 //Gen unique Filepath
                 String filename = System.IO.Path.GetTempPath() + System.Guid.NewGuid().ToString();
                 mediaDet.WriteBitmapBits(position, width, height, filename);
                 Bitmap bmp = new Bitmap(filename);
                 return bmp;
             
         }

       
       private static Bitmap generateSceneshotInMemory(MediaDetClass mediaDet, double position, int width, int height)
        {
            Bitmap bmp = null;
            unsafe 
            {

                //equal to sizeof(CommonClasses.BITMAPINFOHEADER);
                int bmpinfoheaderSize = 40;

                //get size for buffer
                int bufferSize = (((width * height) * 24) / 8) + bmpinfoheaderSize;
                //equal to mediaDet.GetBitmapBits
                //    (0d, ref bufferSize, ref *buffer, target.Width, target.Height);    

                //allocates enough memory to store the frame
                IntPtr frameBuffer =
                    System.Runtime.InteropServices.Marshal.AllocHGlobal(bufferSize);
                byte* frameBuffer2 = (byte*)frameBuffer.ToPointer();
                
                //gets bitmap, save in frameBuffer2
                mediaDet.GetBitmapBits(position,
                        ref bufferSize, ref *frameBuffer2, width, height);

                //now in buffer2 we have a BITMAPINFOHEADER structure 
                //followed by the DIB bits
                IntPtr newImage = new IntPtr(frameBuffer2 + bmpinfoheaderSize);
                
                bmp = new Bitmap(width, height, width * 3,
                     System.Drawing.Imaging.PixelFormat.Format24bppRgb, newImage);

                //1. Version
                //bmp.RotateFlip(RotateFlipType.Rotate180FlipX);
                //2. Version
                //bmp.RotateFlip(RotateFlipType.Rotate90FlipX);
                //bmp.RotateFlip(RotateFlipType.Rotate90FlipY);

                //Test
                bmp.RotateFlip(RotateFlipType.RotateNoneFlipY);
                System.Runtime.InteropServices.Marshal.FreeHGlobal(frameBuffer);

            }
            return bmp;
        }
    }
}
