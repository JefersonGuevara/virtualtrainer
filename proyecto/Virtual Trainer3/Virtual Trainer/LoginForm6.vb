Public Class LoginForm6

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "vih" Or UsernameTextBox.Text = "sida" Then
            UsernameTextBox.Text = ""
            VIH.Show()
        Else
            If UsernameTextBox.Text = "cancer" Then
                UsernameTextBox.Text = ""
                cancer.Show()
            Else

                If UsernameTextBox.Text = "ah1n1" Or UsernameTextBox.Text = "porcina" Then
                    UsernameTextBox.Text = ""
                    ah1n1.Show()

                Else
                    MsgBox("La enfermedad no esta registrada en la base de datos")

                End If
            End If
        End If


    End Sub


    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Form7.Show()
        Me.Close()
    End Sub

End Class
