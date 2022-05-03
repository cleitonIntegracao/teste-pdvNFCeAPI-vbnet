Imports System.Data
Imports System.IO
Public Class Functions
    Public Class LeArqTxt
        Public Shared Function lerArquivo(ByVal arquivo As String)
            Try
                Return Split(System.IO.File.OpenText(arquivo).ReadToEnd())
            Catch e As FileNotFoundException
                MessageBox.Show("Erro = " & e.Message, "Não Localizado", MessageBoxButtons.OK, MessageBoxIcon.Error,
                                         MessageBoxDefaultButton.Button1)
            End Try

#Disable Warning BC42105 ' A função não retorna um valor em todos os caminhos de código
        End Function
#Enable Warning BC42105 ' A função não retorna um valor em todos os caminhos de código
    End Class
End Class
