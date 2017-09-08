Public Class ctlOptions4
    Private WithEvents _configuration As Configuration

    Public Event Configuration_Property_Changed()

    Public Property Configuration() As Configuration
        Get
            Return _configuration
        End Get
        Set(ByVal value As Configuration)
            _configuration = value
            initBindings()
        End Set
    End Property

    Private Sub raiseConfigPropertyChanged() Handles _configuration.PropertyChanged
        RaiseEvent Configuration_Property_Changed()
    End Sub


    Public Sub initBindings()
        Me.SuspendLayout()
        If (Not Configuration Is Nothing) Then
            'Layout
            txt_columns.DataBindings.Clear()
            txt_columns.DataBindings.Add(New Binding("text", Configuration, "columns", False, DataSourceUpdateMode.OnPropertyChanged))
            txt_gapwidth.DataBindings.Clear()
            txt_gapwidth.DataBindings.Add(New Binding("text", Configuration, "gapwidth", False, DataSourceUpdateMode.OnPropertyChanged))
            txt_gapheight.DataBindings.Clear()
            txt_gapheight.DataBindings.Add(New Binding("text", Configuration, "gapheight", False, DataSourceUpdateMode.OnPropertyChanged))
            txt_tilewidth.DataBindings.Clear()
            txt_tilewidth.DataBindings.Add(New Binding("text", Configuration, "tilewidth", False, DataSourceUpdateMode.OnPropertyChanged))
            txt_tileheight.DataBindings.Clear()
            txt_tileheight.DataBindings.Add(New Binding("text", Configuration, "tileheight", False, DataSourceUpdateMode.OnPropertyChanged))
            ll_tilesize.DataBindings.Clear()
            ll_tilesize.DataBindings.Add(New Binding("Value", Configuration, "imagesizemode", False, DataSourceUpdateMode.OnPropertyChanged))
            num_imagepercent.DataBindings.Clear()
            num_imagepercent.DataBindings.Add(New Binding("value", Configuration, "imagepercent", False, DataSourceUpdateMode.OnPropertyChanged))
            chk_progressive.DataBindings.Clear()
            chk_progressive.DataBindings.Add(New Binding("checked", Configuration, "progressive", False, DataSourceUpdateMode.OnPropertyChanged))

            'TimeCode Text
            chk_labeluse.DataBindings.Clear()
            chk_labeluse.DataBindings.Add(New Binding("checked", Configuration, "labels", False, DataSourceUpdateMode.OnPropertyChanged))
            ll_labellocation.DataBindings.Clear()
            ll_labellocation.DataBindings.Add(New Binding("Value", Configuration, "labeltextlocation", False, DataSourceUpdateMode.OnPropertyChanged))
            ll_labelfont.DataBindings.Clear()
            ll_labelfont.DataBindings.Add(New Binding("Value", Configuration, "labelfont", False, DataSourceUpdateMode.OnPropertyChanged))
            ll_labelcolor.DataBindings.Clear()
            ll_labelcolor.DataBindings.Add(New Binding("Value", Configuration, "labelcolor", False, DataSourceUpdateMode.OnPropertyChanged))

            'TimeCode Fx
            chk_labelbordershadow.DataBindings.Clear()
            chk_labelbordershadow.DataBindings.Add(New Binding("checked", Configuration, "border_shadow", False, DataSourceUpdateMode.OnPropertyChanged))
            ll_labelbordertype.DataBindings.Clear()
            ll_labelbordertype.DataBindings.Add(New Binding("Value", Configuration, "bordertype", False, DataSourceUpdateMode.OnPropertyChanged))
            num_labelbordersize.DataBindings.Clear()
            num_labelbordersize.DataBindings.Add(New Binding("Value", Configuration, "bordersize", False, DataSourceUpdateMode.OnPropertyChanged))
            ll_labelbordercolor.DataBindings.Clear()
            ll_labelbordercolor.DataBindings.Add(New Binding("Value", Configuration, "bordercolor", False, DataSourceUpdateMode.OnPropertyChanged))
            'Background
            ll_backgroundtype.DataBindings.Clear()
            ll_backgroundtype.DataBindings.Add(New Binding("Value", Configuration, "background", False, DataSourceUpdateMode.OnPropertyChanged))
            ll_backgroundtype.DataBindings.Add(New Binding("BrowseValue", Configuration, "backgroundimage", False, DataSourceUpdateMode.OnPropertyChanged))
            ll_backgroundcolor.DataBindings.Clear()
            ll_backgroundcolor.DataBindings.Add(New Binding("Value", Configuration, "color", False, DataSourceUpdateMode.OnPropertyChanged))
            'Detail
            cko_detailtext.DataBindings.Clear()
            cko_detailtext.DataBindings.Add(New Binding("checked", Configuration, "details", False, DataSourceUpdateMode.OnPropertyChanged))
            txt_detailtext.DataBindings.Clear()
            txt_detailtext.DataBindings.Add(New Binding("text", Configuration, "detailtext", False, DataSourceUpdateMode.OnPropertyChanged))
            ll_detaillocation.DataBindings.Clear()
            ll_detaillocation.DataBindings.Add(New Binding("Value", Configuration, "detailtextlocation", False, DataSourceUpdateMode.OnPropertyChanged))
            ll_detailfont.DataBindings.Clear()
            ll_detailfont.DataBindings.Add(New Binding("Value", Configuration, "detailfont", False, DataSourceUpdateMode.OnPropertyChanged))
            ll_detailcolor.DataBindings.Clear()
            ll_detailcolor.DataBindings.Add(New Binding("Value", Configuration, "detaillabelcolor", False, DataSourceUpdateMode.OnPropertyChanged))

            'output
            ll_imagetyp.DataBindings.Clear()
            ll_imagetyp.DataBindings.Add(New Binding("Value", Configuration, "imageFormat", False, DataSourceUpdateMode.OnPropertyChanged))
            num_imagequality.DataBindings.Clear()
            num_imagequality.DataBindings.Add(New Binding("Value", Configuration, "quality", False, DataSourceUpdateMode.OnPropertyChanged))
            ll_imagesavemode.DataBindings.Clear()
            ll_imagesavemode.DataBindings.Add(New Binding("Value", Configuration, "savemode", False, DataSourceUpdateMode.OnPropertyChanged))
            ll_imagesavemode.DataBindings.Add(New Binding("BrowseValue", Configuration, "savepath", False, DataSourceUpdateMode.OnPropertyChanged))
            ll_naming.DataBindings.Clear()
            ll_naming.DataBindings.Add(New Binding("Value", Configuration, "naming", False, DataSourceUpdateMode.OnPropertyChanged))

            'Watermark
            chk_watermark.DataBindings.Clear()
            chk_watermark.DataBindings.Add(New Binding("checked", Configuration, "use_watermark", False, DataSourceUpdateMode.OnPropertyChanged))
            ll_watermark_type.DataBindings.Clear()
            ll_watermark_type.DataBindings.Add(New Binding("Value", Configuration, "watermarktype", False, DataSourceUpdateMode.OnPropertyChanged))
            ll_watermark_type.DataBindings.Add(New Binding("BrowseValue", Configuration, "watermarkimage", False, DataSourceUpdateMode.OnPropertyChanged))
            ll_watermark_location.DataBindings.Clear()
            ll_watermark_location.DataBindings.Add(New Binding("Value", Configuration, "watermarktlocation", False, DataSourceUpdateMode.OnPropertyChanged))
            ll_watermarkfont.DataBindings.Clear()
            ll_watermarkfont.DataBindings.Add(New Binding("Value", Configuration, "watermarkfont", False, DataSourceUpdateMode.OnPropertyChanged))
            ll_watermarkcolor.DataBindings.Clear()
            ll_watermarkcolor.DataBindings.Add(New Binding("Value", Configuration, "watermarkcolor", False, DataSourceUpdateMode.OnPropertyChanged))
            ll_watermarktext.DataBindings.Clear()
            ll_watermarktext.DataBindings.Add(New Binding("Value", Configuration, "watermarktext", False, DataSourceUpdateMode.OnPropertyChanged))
            txt_watermark_offX.DataBindings.Clear()
            txt_watermark_offX.DataBindings.Add(New Binding("text", Configuration, "watermarkoffsetX", False, DataSourceUpdateMode.OnPropertyChanged))
            txt_watermark_offY.DataBindings.Clear()
            txt_watermark_offY.DataBindings.Add(New Binding("text", Configuration, "watermarkoffsetY", False, DataSourceUpdateMode.OnPropertyChanged))



        End If

        updateLayoutArea()
        updateTextcodeTextArea()
        updateTextcodeFxArea()
        updateBackgroundArea()
        updateDetailArea()
        updateWatermarkArea()
        Me.ResumeLayout()
    End Sub

    Private Sub updateDetailArea()
        If cko_detailtext.Checked Then
            ll_detailcolor.Enabled = True
            ll_detailfont.Enabled = True
            ll_detaillocation.Enabled = True
            txt_detailtext.Enabled = True
        Else
            ll_detailcolor.Enabled = False
            ll_detailfont.Enabled = False
            ll_detaillocation.Enabled = False
            txt_detailtext.Enabled = False
        End If
    End Sub

    Private Sub updateWatermarkArea()
        If chk_watermark.Checked = True Then
            ll_watermark_location.Enabled = True
            ll_watermark_type.Enabled = True
            txt_watermark_offX.Enabled = True
            txt_watermark_offY.Enabled = True
            lbl_watermark_x.Enabled = True
            lbl_watermark_y.Enabled = True
            If ll_watermark_type.Value = ImageUtil.WatermarkType.TEXT Then
                ll_watermarkcolor.Enabled = True
                ll_watermarkfont.Enabled = True
                ll_watermarktext.Enabled = True
            Else
                ll_watermarkcolor.Enabled = False
                ll_watermarkfont.Enabled = False
                ll_watermarktext.Enabled = False
            End If
        Else
            ll_watermark_location.Enabled = False
            ll_watermark_type.Enabled = False
            txt_watermark_offX.Enabled = False
            txt_watermark_offY.Enabled = False
            lbl_watermark_x.Enabled = False
            lbl_watermark_y.Enabled = False
            ll_watermarkcolor.Enabled = False
            ll_watermarkfont.Enabled = False
            ll_watermarktext.Enabled = False
        End If


    End Sub

    Private Sub updateTextcodeTextArea()
        If chk_labeluse.Checked = True Then
            ll_labellocation.Enabled = True
            ll_labelfont.Enabled = True
            ll_labelcolor.Enabled = True
        Else
            ll_labellocation.Enabled = False
            ll_labelfont.Enabled = False
            ll_labelcolor.Enabled = False
        End If

    End Sub

    Private Sub updateTextcodeFxArea()
        Select Case ll_labelbordertype.Value
            Case ImageUtil.BorderType.None
                num_labelbordersize.Enabled = False
                label_labelbordersize.Enabled = False
                ll_labelbordercolor.Enabled = False
            Case ImageUtil.BorderType.Solid
                num_labelbordersize.Enabled = True
                label_labelbordersize.Enabled = True
                ll_labelbordercolor.Enabled = True
        End Select
    End Sub



    Private Sub updateLayoutArea()
        txt_columns.Enabled = True
        txt_gapwidth.Enabled = True
        txt_gapheight.Enabled = True
        Select Case ll_tilesize.Value
            Case ImageUtil.ImageSizeMode.Custom
                label_tilewidth.Enabled = True
                txt_tilewidth.Enabled = True
                Label_tileheight.Enabled = True
                txt_tileheight.Enabled = True
                label_imagepercent.Enabled = False
                num_imagepercent.Enabled = False
            Case ImageUtil.ImageSizeMode.Percent
                label_tilewidth.Enabled = False
                txt_tilewidth.Enabled = False
                Label_tileheight.Enabled = False
                txt_tileheight.Enabled = False
                label_imagepercent.Enabled = True
                num_imagepercent.Enabled = True
            Case ImageUtil.ImageSizeMode.Source
                label_tilewidth.Enabled = False
                txt_tilewidth.Enabled = False
                Label_tileheight.Enabled = False
                txt_tileheight.Enabled = False
                label_imagepercent.Enabled = False
                num_imagepercent.Enabled = False
        End Select
    End Sub

    Private Sub updateBackgroundArea()
        If (ll_backgroundtype.Value = ImageUtil.Background.Color) Then
            ll_backgroundcolor.Enabled = True
        Else
            ll_backgroundcolor.Enabled = False
        End If
    End Sub

    Private Sub label_use_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_labeluse.CheckedChanged
        updateTextcodeTextArea()
    End Sub

    Private Sub ll_tilesize_PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs) Handles ll_tilesize.PropertyChanged
        updateLayoutArea()
    End Sub

    Private Sub ll_labelbordertype_PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs) Handles ll_labelbordertype.PropertyChanged
        updateTextcodeFxArea()
    End Sub

    Private Sub llabel_detailinfo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llabel_detailinfo.LinkClicked
        Dim _frmfrmMovieInfo As frmMovieInfo = New frmMovieInfo(frmMain.SceneshotsHolder.movieinfo, _configuration)
        _frmfrmMovieInfo.ShowDialog()
    End Sub

    Private Sub cko_detailtext_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cko_detailtext.CheckedChanged
        updateDetailArea()
    End Sub

    Private Sub ll_backgroundtype_PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs) Handles ll_backgroundtype.PropertyChanged
        updateBackgroundArea()
    End Sub

    Private Sub chk_watermark_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_watermark.CheckedChanged, ll_watermark_type.PropertyChanged
        updateWatermarkArea()
    End Sub

End Class

