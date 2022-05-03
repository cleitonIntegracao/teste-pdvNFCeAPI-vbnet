Imports NFCe.Functions
Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Data.SQLite
Imports System.Windows.Forms

Public Class frmConfNotas
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    Private Sub btnConsContig_Click(sender As Object, e As EventArgs) Handles btnConsContig.Click
        Dim sConnectionString As String
        Dim id As Integer = -1
        Try
            'define string de conexão com banco de dados SQLite - Macoratti.db criado na pasta c:\dados
            'usando a criptografia
            sConnectionString = "Data Source = D:\Contingencia\Conti.db;Version=3;New=True;Compress=True;"
            'abre a conexão
            Dim oConn As New SQLiteConnection(sConnectionString)
            oConn.Open()
            'define o comando SQL para retornar todos os dados da tabela Cadastro
            Dim daCadastro As New SQLiteDataAdapter("Select Protocolo,cStat,Motivo,Chave,Serie,nNFe,DhAut From Conti order by Protocolo", oConn)
            'define o dataset
            Dim ds As New DataSet("Northwind")
            'define o esquema da tabela
            daCadastro.FillSchema(ds, SchemaType.Source, "Conti")
            'preenche o dataset
            daCadastro.Fill(ds, "Conti")
            'exibe os dados no datagridview
            GridConti.DataSource = ds.Tables("Conti")
            'fecha a conexao
            oConn.Close()
        Catch ex As Exception
            MsgBox("Erro ao acessar o banco de dados SQLite: " & ex.Message)
        End Try


    End Sub
End Class