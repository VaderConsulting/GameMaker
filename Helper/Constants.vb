Public Class Constants

    Public Function ColourValueFromName(ByVal Colourname As String) As Double
        Dim ReturnValue As Double = 0

        Select Case Colourname.ToLower
            Case "c_aqua", "aqua"
                ReturnValue = 16776960
            Case "c_black", "black"
                ReturnValue = 0
            Case "c_blue", "blue"
                ReturnValue = 16711680
            Case "c_dkgray", "darkgray", "dkgray", "dkgrey", "darkgrey"
                ReturnValue = 4210752
            Case "c_fuchsia", "fuchsia"
                ReturnValue = 16711935
            Case "c_gray", "gray", "grey"
                ReturnValue = 8421504
            Case "c_green", "green"
                ReturnValue = 32768
            Case "c_lime", "lime"
                ReturnValue = 65280
            Case "c_ltgray", "lightgray", "ltgray", "ltgrey", "lightgrey"
                ReturnValue = 12632256
            Case "c_maroon", "maroon"
                ReturnValue = 128
            Case "c_navy", "navy"
                ReturnValue = 8388608
            Case "c_olive", "olive"
                ReturnValue = 32896
            Case "c_orange", "orange"
                ReturnValue = 4235519
            Case "c_purple", "purple"
                ReturnValue = 8388736
            Case "c_red", "red"
                ReturnValue = 255
            Case "c_silver", "silver"
                ReturnValue = 12632256
            Case "c_teal", "teal"
                ReturnValue = 8421376
            Case "c_white", "white"
                ReturnValue = 16777215
            Case "c_yellow", "yellow"
                ReturnValue = 65535
            Case Else
                ReturnValue = -1
        End Select

        Return ReturnValue

    End Function

End Class
