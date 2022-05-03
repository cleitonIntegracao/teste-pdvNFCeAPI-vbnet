Imports System.Data.SQLite
Imports System.Data
Imports System.IO
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity


Public Class Funcoes

    Private Shared Function BlobToImage(ByVal blob)
        Dim mStream As New System.IO.MemoryStream
        Dim pData() As Byte = DirectCast(blob, Byte())
        mStream.Write(pData, 0, Convert.ToInt32(pData.Length))
        Dim bm As Bitmap = New Bitmap(mStream, False)
        mStream.Dispose()
        Return bm
    End Function

    Public Overloads Shared Function ImageToBlob(ByVal id As String, ByVal filePath As String)
        Dim fs As FileStream = New FileStream(filePath, FileMode.Open, FileAccess.Read)
        Dim br As BinaryReader = New BinaryReader(fs)
        Dim bm() As Byte = br.ReadBytes(fs.Length)
        br.Close()
        fs.Close()
        'Cria Parm
        Dim photo() As Byte = bm
        Dim SQLparm As New SQLiteParameter("@image", photo)
        SQLparm.DbType = DbType.Binary
        SQLparm.Value = photo
        Return SQLparm
    End Function

    Public Overloads Shared Function ImageToBlob(ByVal id As String, ByVal image As Image)
        Dim ms As New MemoryStream()
        image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
        'Cria Parm
        Dim photo() As Byte = ms.ToArray()
        Dim SQLparm As New SQLiteParameter("@image", photo)
        SQLparm.DbType = DbType.Binary
        SQLparm.Value = photo
        Return SQLparm
    End Function
End Class

<Table("Contingencia")>
Public Class Contingencia

    <Key()>
    Public Property Chave As Integer
    Public Property Retorno As String
    Public Property Status As String

End Class

Public Class ContigenciaBD
    Inherits DbContext

    Public Property Contingencias() As DbSet(Of Contingencia)

End Class