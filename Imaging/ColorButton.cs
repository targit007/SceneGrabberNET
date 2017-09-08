using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Imaging
{
[
    ToolboxBitmap(typeof(Button)),
    DefaultProperty("ButtonColor")    
]
public class ColorButton : Button
{
    private Color buttonColor = SystemColors.ControlDark;
    private SolidBrush buttonColorBrush;
	
	public ColorButton()
	{
        buttonColorBrush = new SolidBrush(buttonColor);
        InitializeComponent();        
	}

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            //Make sure our brushes are cleaned up            
            if (buttonColorBrush != null)
                buttonColorBrush.Dispose();           
        }
        base.Dispose(disposing);
    }

    #region Component Designer generated code
    /// <summary>
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {        	
        this.Name = "ColorButton";        
        this.Size = new Size(75, 22);        
    }
    #endregion


    protected override void OnPaint(PaintEventArgs e)	
	{        
        base.OnPaint(e);
		
		Graphics g = e.Graphics ; 
		Rectangle r = ClientRectangle;	
		
		byte border = 4;
		byte right_border = 15;
		
		Rectangle rc = new Rectangle(r.Left + border, r.Top + border,
		                             r.Width - border - right_border - 1, r.Height - border * 2 - 1);
                
        g.FillRectangle(buttonColorBrush, rc);	
		g.DrawRectangle( Pens.Black, rc );		
		
		//draw the arrow
		Point p1 = new Point( r.Width - 9, r.Height / 2 - 1 );
		Point p2 = new Point(r.Width - 5, r.Height / 2 - 1 );
        g.DrawLine(Pens.Black, p1, p2);
		
		p1 = new Point( r.Width - 8, r.Height / 2 );
		p2 = new Point(r.Width - 6, r.Height / 2 );
        g.DrawLine(Pens.Black, p1, p2);
		
		p1 = new Point( r.Width - 7, r.Height / 2 );
		p2 = new Point(r.Width - 7, r.Height / 2 + 1 );
        g.DrawLine(Pens.Black, p1, p2);
		
		//draw the divider line		
		p1 = new Point( r.Width - 12, 4 );
		p2 = new Point(r.Width - 12, r.Height - 5 );		
		g.DrawLine(SystemPens.ControlDark, p1, p2);
				
		p1 = new Point( r.Width - 11, 4 );
		p2 = new Point(r.Width - 11, r.Height - 5 );		
		g.DrawLine(SystemPens.ControlLightLight, p1, p2);
	}

    #region Properties    
    [
    Browsable(false),
    EditorBrowsable(EditorBrowsableState.Never),
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)
    ]
    public override string Text
    {
        get
        {            
            return "";
        }
        set
        {
            throw new NotSupportedException();
        }
    }
    [
    Browsable(false),
    EditorBrowsable(EditorBrowsableState.Never),
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)
    ]
    public override Color ForeColor
    {
        get
        {
            return Color.Empty;
        }
        set
        {
            throw new NotSupportedException();
        }
    }
    [
    Browsable(true),
    Category("ButtonColor"),       
    AmbientValue(typeof(Color), "Blue"),
    DefaultValue(typeof(Color), "White"),
    Description("The color of the button")
    ]
    public Color ButtonColor
    {
        get
        {
            if (this.buttonColor == Color.Empty)            
                return SystemColors.ControlDark;
                        
            return this.buttonColor;            
        }
        set
        {        
            this.buttonColor = value;            
            buttonColorBrush = new SolidBrush(buttonColor);
            this.Invalidate();
        }        
    }    
    #endregion		
}

}

