Imports Microsoft.Win32
Public Class G4HDURegistry
    Private regKey As RegistryKey

    Public Function openRegistryKey(ByVal appKeyname As String, ByVal appVersion As String) As Boolean
        openRegistryKey = False
        ' @todo make a try catch
        regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\G4HDU\\" & appKeyname & "\\" & appVersion, True)
        If regKey Is Nothing Then
            ' Key doesn't exist; create it.
            regKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\G4HDU\\" & appKeyname & "\\" & appVersion)
        End If
        openRegistryKey = True
    End Function
    Public Function getKeyValue(ByVal appKey As String) As String
        If (Not regKey Is Nothing) Then
            getKeyValue = regKey.GetValue(appKey, 0)
        Else
            getKeyValue = False
        End If
    End Function
    Public Function setKeyValue(ByVal appKey As String, ByVal appValue As String) As Boolean

        If (Not regKey Is Nothing) Then
            regKey.SetValue(appKey, appValue)
            setKeyValue = True
        Else
            setKeyValue = False
        End If
    End Function
    Public Function closeRegistryKey() As Boolean
        closeRegistryKey = True
        If (Not regKey Is Nothing) Then
            regKey.Close()
        End If
    End Function
End Class
