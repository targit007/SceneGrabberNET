Imports System.Xml.Serialization
Imports System.IO

Public Class ProfileManager
    Public Shared defaultProfile As String = "default"

    Private Shared _me As ProfileManager = New ProfileManager
    Private Const EXTENSION_XML As String = ".xml"
    'Private profilePath As String = My.Application.Info.DirectoryPath + "\" + "profiles"

    Private profilePath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\" + "Profiles for " + Util.APP_TITLE


    Public Shared Function getInstance() As ProfileManager
        Return _me
    End Function

    Public Sub deleteProfile(ByVal name As String)
        Dim filepath As String = profilePath + "\" + name + EXTENSION_XML
        IO.File.Delete(filepath)
    End Sub

    Public Sub saveProfile(ByVal name As String, ByVal conf As Configuration)
        Dim filepath As String = profilePath + "\" + name + EXTENSION_XML
        IO.Directory.CreateDirectory(profilePath)
        Dim serializer As XmlSerializer = New XmlSerializer(conf.GetType)
        Dim writer As StreamWriter = New StreamWriter(filepath)
        serializer.Serialize(writer, conf)
        writer.Close()
    End Sub

    Public Function loadProfile(ByVal name As String) As Configuration
        Dim filepath As String = profilePath + "\" + name + EXTENSION_XML
        Dim serializer As New XmlSerializer(GetType(Configuration))
        Dim fs As New FileStream(filepath, FileMode.Open)
        Dim conf As Configuration = serializer.Deserialize(fs)
        fs.Close()
        Return conf
    End Function

    Public Sub checkForCorrectDefaultProfile()
        Dim filepath As String = profilePath + "\" + ProfileManager.defaultProfile + EXTENSION_XML
        If Not (File.Exists(filepath)) Then
            Configuration.getInstance.createIntial()
            ProfileManager.getInstance.saveProfile(ProfileManager.defaultProfile, Configuration.getInstance)
        End If
    End Sub


    Public Function getProfiles() As String()
        Try
            Dim profiles() As String = Directory.GetFiles(profilePath, "*" + EXTENSION_XML)
            Dim profilNameList As ArrayList = New ArrayList()
            For Each profil In profiles
                profilNameList.Add(Path.GetFileNameWithoutExtension(profil))
            Next
            Return profilNameList.ToArray(GetType(String))

        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
