Public Class Arrays

    Private m_NumericValues As New Collection
    Private m_StringValues As New Collection

    Public Sub New()

    End Sub

    Public Function ClearNumericValues(ByVal ArrayName As String) As Double

        m_NumericValues.Remove(ArrayName)

        Return 0
    End Function

    Public Function ClearStringValues(ByVal ArrayName As String) As Double

        m_StringValues.Remove(ArrayName)

        Return 0
    End Function

    Public Function GetNumericValue(ByVal ArrayName As String, ByVal ElementNumber As Double) As Double
        If m_NumericValues.Contains(ArrayName) Then
            Dim NewArray() As Double = m_NumericValues(ArrayName)
            Return NewArray(CInt(ElementNumber))
        Else
            Return 0
        End If
    End Function

    Public Function GetNumericValues(ByVal ArrayName As String) As String
        If m_NumericValues.Contains(ArrayName) Then
            Dim NewArray() As Double = m_NumericValues(ArrayName)
            Dim Results As String = ""

            For counter As Int32 = 0 To NewArray.Length - 1
                Results &= NewArray(counter) & "|"
            Next

            Return Results.Remove(Results.Length - 1)
        Else
            Return 0
        End If
    End Function

    Public Function GetStringValue(ByVal ArrayName As String, ByVal ElementNumber As Double) As String
        If m_StringValues.Contains(ArrayName) Then
            Dim NewArray As String = m_StringValues(ArrayName)(CInt(ElementNumber))
            Return NewArray
        Else
            Return ""
        End If
    End Function

    Public Function GetStringValues(ByVal ArrayName As String) As String
        If m_StringValues.Contains(ArrayName) Then
            Dim NewArray() As String = m_StringValues(ArrayName)
            Dim Results As String = ""

            For counter As Int32 = 0 To NewArray.Length - 1
                Results &= NewArray(counter) & "|"
            Next

            Return Results.Remove(Results.Length - 1)
        Else
            Return 0
        End If
    End Function

    Public Function SetStringValue(ByVal ArrayName As String, ByVal ElementNumber As Double, ByVal Value As String) As Double
        If m_StringValues.Contains(ArrayName) Then

            Dim NewArray() As String = m_StringValues(ArrayName) '(CInt(ElementNumber))
            If NewArray.Length - 1 >= ElementNumber Then
                NewArray(CInt(ElementNumber)) = Value
            Else
                ReDim Preserve NewArray(ElementNumber)
                NewArray(CInt(ElementNumber)) = Value
            End If

            'm_StringValues(ArrayName)(CInt(ElementNumber)) = Value
            m_StringValues.Remove(ArrayName)
            m_StringValues.Add(NewArray, ArrayName)
        Else
            Dim NewArray(CInt(ElementNumber)) As String
            NewArray(ElementNumber) = Value
            m_StringValues.Add(NewArray, ArrayName)
        End If

        Return 0
    End Function

    ' TODO: Element sizing needs work
    Public Function SetNumericValue(ByVal ArrayName As String, ByVal ElementNumber As Double, ByVal Value As Double) As Double
        If m_NumericValues.Contains(ArrayName) Then

            Dim NewArray() As Double = m_NumericValues(ArrayName) '(CInt(ElementNumber))
            If NewArray.Length - 1 >= ElementNumber Then
                NewArray(CInt(ElementNumber)) = Value
            Else
                ReDim Preserve NewArray(ElementNumber)
                NewArray(CInt(ElementNumber)) = Value
            End If

            'm_NumericValues(ArrayName)(CInt(ElementNumber)) = Value
            m_NumericValues.Remove(ArrayName)
            m_NumericValues.Add(NewArray, ArrayName)
        Else
            Dim NewArray(CInt(ElementNumber)) As Double
            NewArray(ElementNumber) = Value
            m_NumericValues.Add(NewArray, ArrayName)
        End If

        Return 0

    End Function

    Public Function SetNumericSize(ByVal ArrayName As String, ByVal Size As Double) As Double
        If m_NumericValues.Contains(ArrayName) Then
            Dim NewArray() As Double = m_NumericValues(ArrayName)

            ReDim Preserve NewArray(CInt(Size - 1))

            m_NumericValues(ArrayName)() = NewArray
        Else
            Dim NewArray() As Double = {}

            ReDim Preserve NewArray(CInt(Size - 1))

            m_NumericValues.Add(NewArray)
        End If

        Return 0

    End Function

    Public Function SetStringSize(ByVal ArrayName As String, ByVal Size As Double) As Double
        If m_StringValues.Contains(ArrayName) Then
            Dim NewArray() As String = m_StringValues(ArrayName)

            ReDim Preserve NewArray(CInt(Size - 1))

            m_StringValues(ArrayName)() = NewArray
        Else
            Dim NewArray() As String = {}

            ReDim Preserve NewArray(CInt(Size - 1))

            m_StringValues.Add(NewArray)
        End If

        Return 0

    End Function

    Public Function GetNumericSize(ByVal ArrayName As String) As Double
        If m_NumericValues.Contains(ArrayName) Then
            Dim NewArray() As Double = m_NumericValues(ArrayName)

            Return NewArray.Length
        Else
            Return 0
        End If

    End Function

    Public Function GetStringSize(ByVal ArrayName As String) As Double
        If m_StringValues.Contains(ArrayName) Then
            Dim NewArray() As String = m_StringValues(ArrayName)

            Return NewArray.Length
        Else
            Return 0
        End If

    End Function

    Public Function ContainsNumericName(ByVal ArrayName As String) As Double
        If m_NumericValues.Contains(ArrayName) Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Public Function ContainsStringName(ByVal ArrayName As String) As Double
        If m_StringValues.Contains(ArrayName) Then
            Return 1
        Else
            Return 0
        End If
    End Function

End Class
