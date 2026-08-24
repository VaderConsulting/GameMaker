Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim x As GameMaker.Arrays = New GameMaker.Arrays

        Debug.Print("-----Numeric-1---")

        x.SetNumericSize("Name1", 5)

        x.SetNumericValue("Name1", 0, 1)
        x.SetNumericValue("Name1", 1, 2)

        Debug.Print(x.GetNumericValue("Name1", 0) & " and " & x.GetNumericValue("Name1", 1))

        Debug.Print(x.GetNumericValues("Name1"))

        Debug.Print("-----Numeric-2---")

        x.SetNumericSize("Name2", 10)

        x.SetNumericValue("Name2", 0, 3)
        x.SetNumericValue("Name2", 1, 4)

        Debug.Print(x.GetNumericValue("Name2", 0) & " and " & x.GetNumericValue("Name2", 1))

        Debug.Print(x.GetNumericValues("Name2"))

        Debug.Print("Length of Numeric Name1 is : " & x.GetNumericSize("Name1"))

        ' Strings --------------------------------------------

        Debug.Print("-----String-1---")

        x.SetStringSize("Name1", 15)

        x.SetStringValue("Name1", 0, "aaa")
        x.SetStringValue("Name1", 1, "bbb")

        Debug.Print(x.GetStringValue("Name1", 0) & " and " & x.GetStringValue("Name1", 1))

        Debug.Print(x.GetStringValues("Name1"))

        Debug.Print("-----String-2---")

        x.SetStringSize("Name2", 20)

        x.SetStringValue("Name2", 0, "ccc")
        x.SetStringValue("Name2", 1, "ddd")

        Debug.Print(x.GetStringValue("Name2", 0) & " and " & x.GetStringValue("Name2", 1))

        Debug.Print(x.GetStringValues("Name2"))

        Debug.Print("Length of String Name2 is : " & x.GetStringSize("Name2"))

    End Sub
End Class
