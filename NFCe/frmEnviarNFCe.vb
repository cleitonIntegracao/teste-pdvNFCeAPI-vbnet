Imports NFCe.src.Classes
Imports System.IO
Imports Newtonsoft.Json




Public Class frmEnviarNFCe
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Dados da NFCe
        Dim notaFiscal As TNFCe = New TNFCe()
        notaFiscal.infNFe = New TNFeInfNFe()
        notaFiscal.infNFe.versao = "4.00"
        notaFiscal.infNFe.ide = New TNFeInfNFeIde()
        Dim cUF As Integer = 43
        notaFiscal.infNFe.ide.cUF = CType([Enum].Parse(GetType(TCodUfIBGE), "Item" & cUF), TCodUfIBGE)
        notaFiscal.infNFe.ide.natOp = txtNatOp.Text
        notaFiscal.infNFe.ide.[mod] = TMod.Item65
        notaFiscal.infNFe.ide.cNF = "12345670"
        notaFiscal.infNFe.ide.serie = txtSerie.Text
        notaFiscal.infNFe.ide.nNF = txtNumNFCe.Text
        notaFiscal.infNFe.ide.dhEmi = Date.Now.ToString("s") & "-03:00"
        notaFiscal.infNFe.ide.tpNF = TNFeInfNFeIdeTpNF.Item1
        notaFiscal.infNFe.ide.idDest = TNFeInfNFeIdeIdDest.Item1
        notaFiscal.infNFe.ide.cMunFG = txtcMunFG.Text
        notaFiscal.infNFe.ide.tpImp = TNFeInfNFeIdeTpImp.Item4
        notaFiscal.infNFe.ide.tpEmis = TNFeInfNFeIdeTpEmis.Item1
        notaFiscal.infNFe.ide.tpAmb = TAmb.Item2
        notaFiscal.infNFe.ide.finNFe = TFinNFe.Item1
        notaFiscal.infNFe.ide.procEmi = TProcEmi.Item0
        notaFiscal.infNFe.ide.indFinal = TNFeInfNFeIdeIndFinal.Item1
        notaFiscal.infNFe.ide.indPres = TNFeInfNFeIdeIndPres.Item1
        notaFiscal.infNFe.ide.procEmi = TProcEmi.Item0
        notaFiscal.infNFe.ide.tpNF = TNFeInfNFeIdeTpNF.Item1
        notaFiscal.infNFe.ide.indPres = TNFeInfNFeIdeIndPres.Item1
        notaFiscal.infNFe.ide.indIntermed = TNFeInfNFeIdeIndIntermed.Item0
        notaFiscal.infNFe.ide.verProc = "4.00"

        notaFiscal.infNFe.emit = New TNFeInfNFeEmit()
        notaFiscal.infNFe.emit.ItemElementName = ItemChoiceType2.CNPJ
        notaFiscal.infNFe.emit.Item = txtCnpjEmit.Text
        notaFiscal.infNFe.emit.xNome = txtNomeEmit.Text
        notaFiscal.infNFe.emit.IE = txtIEEmit.Text
        notaFiscal.infNFe.emit.CRT = TNFeInfNFeEmitCRT.Item2

        notaFiscal.infNFe.emit.enderEmit = New TEnderEmi()
        notaFiscal.infNFe.emit.enderEmit.xLgr = txtLgrEmit.Text
        notaFiscal.infNFe.emit.enderEmit.nro = txtNumEmit.Text
        notaFiscal.infNFe.emit.enderEmit.xCpl = txtCplEmit.Text
        notaFiscal.infNFe.emit.enderEmit.xBairro = txtBairroEmit.Text
        notaFiscal.infNFe.emit.enderEmit.cMun = txtCodMunEmit.Text
        notaFiscal.infNFe.emit.enderEmit.xMun = txtMunEmit.Text
        notaFiscal.infNFe.emit.enderEmit.UF = TUfEmi.RS
        notaFiscal.infNFe.emit.enderEmit.CEP = txtCepEmit.Text
        notaFiscal.infNFe.emit.enderEmit.fone = txtTelEmit.Text

        notaFiscal.infNFe.dest = New TNFeInfNFeDest()
        notaFiscal.infNFe.dest.ItemElementName = ItemChoiceType3.CPF
        notaFiscal.infNFe.dest.Item = txtCnpjDest.Text
        notaFiscal.infNFe.dest.xNome = txtNomeDest.Text
        notaFiscal.infNFe.dest.indIEDest = TNFeInfNFeDestIndIEDest.Item9

        notaFiscal.infNFe.dest.enderDest = New TEndereco()
        notaFiscal.infNFe.dest.enderDest.xLgr = txtLgrDest.Text
        notaFiscal.infNFe.dest.enderDest.nro = txtNumDest.Text
        notaFiscal.infNFe.dest.enderDest.xBairro = txtBairroDest.Text
        notaFiscal.infNFe.dest.enderDest.cMun = txtCodMunDest.Text
        notaFiscal.infNFe.dest.enderDest.xMun = txtMunDest.Text
        notaFiscal.infNFe.dest.enderDest.UF = TUf.RS
        notaFiscal.infNFe.dest.enderDest.CEP = txtCepDest.Text
        notaFiscal.infNFe.dest.enderDest.cPais = txtCodPaisDest.Text
        notaFiscal.infNFe.dest.enderDest.xPais = txtPaisDest.Text

        notaFiscal.infNFe.det = New TNFeInfNFeDet(GridProdutos.Rows.Count()) {}

        Dim indice As Integer = 0

        For Each produto As DataGridViewRow In GridProdutos.Rows
            If Not produto.IsNewRow Then
                notaFiscal.infNFe.det(indice) = New TNFeInfNFeDet()
                notaFiscal.infNFe.det(indice).nItem = indice + 1
                notaFiscal.infNFe.det(indice).prod = New TNFeInfNFeDetProd()
                notaFiscal.infNFe.det(indice).prod.cProd = produto.Cells("cProd").Value.ToString()
                notaFiscal.infNFe.det(indice).prod.xProd = produto.Cells("xProd").Value.ToString()
                notaFiscal.infNFe.det(indice).prod.cEAN = produto.Cells("cEAN").Value.ToString()
                notaFiscal.infNFe.det(indice).prod.cEANTrib = produto.Cells("cEAN").Value.ToString()
                notaFiscal.infNFe.det(indice).prod.NCM = produto.Cells("NCM").Value.ToString()
                notaFiscal.infNFe.det(indice).prod.CFOP = produto.Cells("CFOP").Value.ToString()
                notaFiscal.infNFe.det(indice).prod.uCom = produto.Cells("uCom").Value.ToString()
                notaFiscal.infNFe.det(indice).prod.qCom = produto.Cells("qCom").Value.ToString()
                notaFiscal.infNFe.det(indice).prod.vUnCom = produto.Cells("vUnCom").Value.ToString()
                notaFiscal.infNFe.det(indice).prod.vProd = produto.Cells("vProd").Value.ToString()
                notaFiscal.infNFe.det(indice).prod.uTrib = produto.Cells("uCom").Value.ToString()
                notaFiscal.infNFe.det(indice).prod.qTrib = produto.Cells("qCom").Value.ToString()
                notaFiscal.infNFe.det(indice).prod.vUnTrib = produto.Cells("vUnCom").Value.ToString()
                notaFiscal.infNFe.det(indice).prod.indTot = produto.Cells("indTot").Value.ToString()

                'DADOS DO IMPOSTO
                notaFiscal.infNFe.det(indice).imposto = New TNFeInfNFeDetImposto()
                notaFiscal.infNFe.det(indice).imposto.vTotTrib = "0.00"
                Dim impICMS = New TNFeInfNFeDetImpostoICMS()

                'DADOS DO ICMS
                notaFiscal.infNFe.det(indice).imposto.Items = New TNFeInfNFeDetImpostoICMS(0) {}

                Dim icms00 = New TNFeInfNFeDetImpostoICMSICMS00()
                icms00.CST = "00"
                icms00.orig = "0"
                icms00.modBC = "3"
                icms00.vBC = txtBCicms.Text
                icms00.pICMS = txtPicms.Text
                icms00.vFCP = txtVfcp.Text
                icms00.pFCP = txtPfcp.Text
                icms00.vICMS = txtVicms.Text
                impICMS.Item = icms00

                notaFiscal.infNFe.det(indice).imposto.Items(0) = impICMS

                notaFiscal.infNFe.det(indice).imposto.PIS = New TNFeInfNFeDetImpostoPIS()
                Dim impPIS = New TNFeInfNFeDetImpostoPIS()
                Dim pisAliq = New TNFeInfNFeDetImpostoPISPISAliq()
                pisAliq.CST = TNFeInfNFeDetImpostoPISPISAliqCST.Item01
                pisAliq.vBC = "2300.00"
                pisAliq.pPIS = "1.65"
                pisAliq.vPIS = "37.95"
                impPIS.Item = pisAliq
                notaFiscal.infNFe.det(indice).imposto.PIS = impPIS

                'DADOS DO COFINS
                notaFiscal.infNFe.det(indice).imposto.COFINS = New TNFeInfNFeDetImpostoCOFINS()
                Dim impCOFINS = New TNFeInfNFeDetImpostoCOFINS()
                Dim cofinsAliq = New TNFeInfNFeDetImpostoCOFINSCOFINSAliq()
                cofinsAliq.CST = TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST.Item01
                cofinsAliq.vBC = "2300.00"
                cofinsAliq.pCOFINS = "7.60"
                cofinsAliq.vCOFINS = "147.80"
                impCOFINS.Item = cofinsAliq
                notaFiscal.infNFe.det(indice).imposto.COFINS = impCOFINS

                indice += 1
            End If
        Next

        'DADOS TOTAIS DA NFE
        notaFiscal.infNFe.total = New TNFeInfNFeTotal()
        notaFiscal.infNFe.total.ICMSTot = New TNFeInfNFeTotalICMSTot()
        If Not String.IsNullOrWhiteSpace(txtBCicms.Text) Then
            notaFiscal.infNFe.total.ICMSTot.vBC = txtBCicms.Text
        Else
            notaFiscal.infNFe.total.ICMSTot.vBC = txtBCicms.Text
        End If
        notaFiscal.infNFe.total.ICMSTot.vICMS = txtVicms.Text
        notaFiscal.infNFe.total.ICMSTot.vBCST = "0.00"
        notaFiscal.infNFe.total.ICMSTot.vST = "0.00"
        notaFiscal.infNFe.total.ICMSTot.vICMSDeson = "0.00"
        notaFiscal.infNFe.total.ICMSTot.vFCPUFDest = "0.00"
        notaFiscal.infNFe.total.ICMSTot.vICMSUFDest = "0.00"
        notaFiscal.infNFe.total.ICMSTot.vICMSUFRemet = "0.00"
        notaFiscal.infNFe.total.ICMSTot.vFCP = "5.52"
        notaFiscal.infNFe.total.ICMSTot.vFCPST = "0.00"
        notaFiscal.infNFe.total.ICMSTot.vFCPSTRet = "0.00"
        notaFiscal.infNFe.total.ICMSTot.vProd = txtVTnota.Text
        notaFiscal.infNFe.total.ICMSTot.vFrete = "0.00"
        notaFiscal.infNFe.total.ICMSTot.vSeg = "0.00"
        notaFiscal.infNFe.total.ICMSTot.vDesc = txtVdesc.Text
        notaFiscal.infNFe.total.ICMSTot.vII = "0.00"
        notaFiscal.infNFe.total.ICMSTot.vIPI = "0.00"
        notaFiscal.infNFe.total.ICMSTot.vIPIDevol = "0.00"
        notaFiscal.infNFe.total.ICMSTot.vPIS = "37.95"
        notaFiscal.infNFe.total.ICMSTot.vCOFINS = "147.80"
        notaFiscal.infNFe.total.ICMSTot.vOutro = "0.00"
        notaFiscal.infNFe.total.ICMSTot.vNF = txtVTnota.Text
        notaFiscal.infNFe.total.ICMSTot.vTotTrib = "0.00"

        notaFiscal.infNFe.transp = New TNFeInfNFeTransp()
        notaFiscal.infNFe.transp.modFrete = TNFeInfNFeTranspModFrete.Item9

        notaFiscal.infNFe.pag = New TNFeInfNFePag()
        notaFiscal.infNFe.pag.vTroco = "0.00"

        notaFiscal.infNFe.pag.detPag = New TNFeInfNFePagDetPag(1) {}

        notaFiscal.infNFe.pag.detPag(0) = New TNFeInfNFePagDetPag()
        notaFiscal.infNFe.pag.detPag(0).indPag = "0"
        notaFiscal.infNFe.pag.detPag(0).tPag = "01"
        notaFiscal.infNFe.pag.detPag(0).vPag = txtVTnota.Text

        notaFiscal.infNFe.infAdic = New TNFeInfNFeInfAdic()
        notaFiscal.infNFe.infAdic.infAdFisco = "DESCRICAO PADRAO DA SEFAZ"

        notaFiscal.infNFe.infAdic.obsCont = New TNFeInfNFeInfAdicObsCont(1) {}

        notaFiscal.infNFe.infAdic.obsCont(0) = New TNFeInfNFeInfAdicObsCont()
        notaFiscal.infNFe.infAdic.obsCont(0).xCampo = "enviaEmail"
        notaFiscal.infNFe.infAdic.obsCont(0).xTexto = "cleiton.fagundes@nstecnologia.com.br"

        notaFiscal.infNFe.infAdic.obsCont(1) = New TNFeInfNFeInfAdicObsCont()
        notaFiscal.infNFe.infAdic.obsCont(1).xCampo = "enviaEmail"
        notaFiscal.infNFe.infAdic.obsCont(1).xTexto = "cleiton.fagundes@nstecnologia.com.br"


        Console.WriteLine(notaFiscal.ToXMLString())

        'Nesta parte é feito o salvamento do XML na pasta Remessas do NSNFCe Cloud;
        'Genericos.salvarXML(notaFiscal.ToXMLString, "C:\NSNFCe\Remessas\", txtNumNFCe.Text)

        'Nesta parte é feito o salvamente do mesmo XML dentro de uma pasta de Backup para que se preciar possa reenviar ele;
        'Genericos.salvarXML(notaFiscal.ToXMLString, "C:\XMLs de NFCe do Cloud\", txtNumNFCe.Text)

        'Dim retorno As String = NSSuite.emitirNFCeSincrono(notaFiscal.ToXMLString, "xml", txtCnpjEmit.Text, "2", "C:\XMLs de NFCe do Cloud\", True)
        Dim retorno As String = NSSuite.previaDocumento("55", "xml", notaFiscal.ToXMLString)


        Console.ReadLine()
    End Sub

    Private Sub btnNotas_Click(sender As Object, e As EventArgs) Handles btnNotas.Click
        frmConfNotas.Show()
    End Sub

    Private Sub btnProdutoCarr_Click(sender As Object, e As EventArgs) Handles btnProdutoCarr.Click
        Dim sConnectionString As String
        Dim id As Integer = -1
        Try
            'define string de conexão com banco de dados SQLite - Macoratti.db criado na pasta c:\dados
            'usando a criptografia
            sConnectionString = "Data Source=C:\Users\User\Documents\GitHub\teste-pdvNFCeAPI-vbnet\NFCe\BancoDadosProd.db;Version=3;New=True;Compress=True;"
            'abre a conexão
            Dim oConn As New SQLite.SQLiteConnection(sConnectionString)
            oConn.Open()
            'define o comando SQL para retornar todos os dados da tabela Cadastro
            Dim daCadastro As New SQLite.SQLiteDataAdapter("Select cProd,cEAN,xProd,NCM,CFOP,uCom,qCom,vUnCom,vProd,uTrib,qTrib,vUnTrib,indTot From Produto order by cProd", oConn)
            'define o dataset
            Dim ds As New DataSet("Northwind")
            'define o esquema da tabela
            daCadastro.FillSchema(ds, SchemaType.Source, "Produto")
            'preenche o dataset
            daCadastro.Fill(ds, "Produto")
            'exibe os dados no datagridview
            GridProdutos.DataSource = ds.Tables("Produto")
            'fecha a conexao
            oConn.Close()
        Catch ex As Exception
            MsgBox("Erro ao acessar o banco de dados SQLite: " & ex.Message)
        End Try
    End Sub

    Private Sub GridProdutos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridProdutos.CellContentClick

    End Sub

    Private Sub btnPrevia_Click(sender As Object, e As EventArgs) Handles btnPrevia.Click

        'Dados da NFCe
        Dim notaFiscal As TNFCe = New TNFCe()
        notaFiscal.infNFe = New TNFeInfNFe()
        notaFiscal.infNFe.versao = "4.00"
        notaFiscal.infNFe.ide = New TNFeInfNFeIde()
        Dim cUF As Integer = 43
        notaFiscal.infNFe.ide.cUF = CType([Enum].Parse(GetType(TCodUfIBGE), "Item" & cUF), TCodUfIBGE)
        notaFiscal.infNFe.ide.natOp = txtNatOp.Text
        notaFiscal.infNFe.ide.[mod] = TMod.Item55
        notaFiscal.infNFe.ide.cNF = "12345670"
        notaFiscal.infNFe.ide.serie = txtSerie.Text
        notaFiscal.infNFe.ide.nNF = txtNumNFCe.Text
        notaFiscal.infNFe.ide.dhEmi = Date.Now.ToString("s") & "-03:00"
        notaFiscal.infNFe.ide.tpNF = TNFeInfNFeIdeTpNF.Item1
        notaFiscal.infNFe.ide.idDest = TNFeInfNFeIdeIdDest.Item1
        notaFiscal.infNFe.ide.cMunFG = txtcMunFG.Text
        notaFiscal.infNFe.ide.tpImp = TNFeInfNFeIdeTpImp.Item4
        notaFiscal.infNFe.ide.tpEmis = TNFeInfNFeIdeTpEmis.Item1
        notaFiscal.infNFe.ide.tpAmb = TAmb.Item2
        notaFiscal.infNFe.ide.finNFe = TFinNFe.Item1
        notaFiscal.infNFe.ide.procEmi = TProcEmi.Item0
        notaFiscal.infNFe.ide.indFinal = TNFeInfNFeIdeIndFinal.Item1
        notaFiscal.infNFe.ide.indPres = TNFeInfNFeIdeIndPres.Item1
        notaFiscal.infNFe.ide.procEmi = TProcEmi.Item0
        notaFiscal.infNFe.ide.tpNF = TNFeInfNFeIdeTpNF.Item1
        notaFiscal.infNFe.ide.indPres = TNFeInfNFeIdeIndPres.Item1
        notaFiscal.infNFe.ide.indIntermed = TNFeInfNFeIdeIndIntermed.Item0
        notaFiscal.infNFe.ide.verProc = "4.00"

        notaFiscal.infNFe.emit = New TNFeInfNFeEmit()
        notaFiscal.infNFe.emit.ItemElementName = ItemChoiceType2.CNPJ
        notaFiscal.infNFe.emit.Item = txtCnpjEmit.Text
        notaFiscal.infNFe.emit.xNome = txtNomeEmit.Text
        notaFiscal.infNFe.emit.IE = txtIEEmit.Text
        notaFiscal.infNFe.emit.CRT = TNFeInfNFeEmitCRT.Item2

        notaFiscal.infNFe.emit.enderEmit = New TEnderEmi()
        notaFiscal.infNFe.emit.enderEmit.xLgr = txtLgrEmit.Text
        notaFiscal.infNFe.emit.enderEmit.nro = txtNumEmit.Text
        notaFiscal.infNFe.emit.enderEmit.xCpl = txtCplEmit.Text
        notaFiscal.infNFe.emit.enderEmit.xBairro = txtBairroEmit.Text
        notaFiscal.infNFe.emit.enderEmit.cMun = txtCodMunEmit.Text
        notaFiscal.infNFe.emit.enderEmit.xMun = txtMunEmit.Text
        notaFiscal.infNFe.emit.enderEmit.UF = TUfEmi.RS
        notaFiscal.infNFe.emit.enderEmit.CEP = txtCepEmit.Text
        notaFiscal.infNFe.emit.enderEmit.fone = txtTelEmit.Text

        notaFiscal.infNFe.dest = New TNFeInfNFeDest()
        notaFiscal.infNFe.dest.ItemElementName = ItemChoiceType3.CPF
        notaFiscal.infNFe.dest.Item = txtCnpjDest.Text
        notaFiscal.infNFe.dest.xNome = txtNomeDest.Text
        notaFiscal.infNFe.dest.indIEDest = TNFeInfNFeDestIndIEDest.Item9

        notaFiscal.infNFe.dest.enderDest = New TEndereco()
        notaFiscal.infNFe.dest.enderDest.xLgr = txtLgrDest.Text
        notaFiscal.infNFe.dest.enderDest.nro = txtNumDest.Text
        notaFiscal.infNFe.dest.enderDest.xBairro = txtBairroDest.Text
        notaFiscal.infNFe.dest.enderDest.cMun = txtCodMunDest.Text
        notaFiscal.infNFe.dest.enderDest.xMun = txtMunDest.Text
        notaFiscal.infNFe.dest.enderDest.UF = TUf.RS
        notaFiscal.infNFe.dest.enderDest.CEP = txtCepDest.Text
        notaFiscal.infNFe.dest.enderDest.cPais = txtCodPaisDest.Text
        notaFiscal.infNFe.dest.enderDest.xPais = txtPaisDest.Text

        notaFiscal.infNFe.det = New TNFeInfNFeDet(GridProdutos.Rows.Count()) {}

        Dim indice As Integer = 0

        For Each produto As DataGridViewRow In GridProdutos.Rows
            If Not produto.IsNewRow Then
                notaFiscal.infNFe.det(indice) = New TNFeInfNFeDet()
                notaFiscal.infNFe.det(indice).nItem = indice + 1
                notaFiscal.infNFe.det(indice).prod = New TNFeInfNFeDetProd()
                notaFiscal.infNFe.det(indice).prod.cProd = produto.Cells("cProd").Value.ToString()
                notaFiscal.infNFe.det(indice).prod.xProd = produto.Cells("xProd").Value.ToString()
                notaFiscal.infNFe.det(indice).prod.cEAN = produto.Cells("cEAN").Value.ToString()
                notaFiscal.infNFe.det(indice).prod.cEANTrib = produto.Cells("cEAN").Value.ToString()
                notaFiscal.infNFe.det(indice).prod.NCM = produto.Cells("NCM").Value.ToString()
                notaFiscal.infNFe.det(indice).prod.CFOP = produto.Cells("CFOP").Value.ToString()
                notaFiscal.infNFe.det(indice).prod.uCom = produto.Cells("uCom").Value.ToString()
                notaFiscal.infNFe.det(indice).prod.qCom = produto.Cells("qCom").Value.ToString()
                notaFiscal.infNFe.det(indice).prod.vUnCom = produto.Cells("vUnCom").Value.ToString()
                notaFiscal.infNFe.det(indice).prod.vProd = produto.Cells("vProd").Value.ToString()
                notaFiscal.infNFe.det(indice).prod.uTrib = produto.Cells("uCom").Value.ToString()
                notaFiscal.infNFe.det(indice).prod.qTrib = produto.Cells("qCom").Value.ToString()
                notaFiscal.infNFe.det(indice).prod.vUnTrib = produto.Cells("vUnCom").Value.ToString()
                notaFiscal.infNFe.det(indice).prod.indTot = produto.Cells("indTot").Value.ToString()

                'DADOS DO IMPOSTO
                notaFiscal.infNFe.det(indice).imposto = New TNFeInfNFeDetImposto()
                notaFiscal.infNFe.det(indice).imposto.vTotTrib = "0.00"
                Dim impICMS = New TNFeInfNFeDetImpostoICMS()

                'DADOS DO ICMS
                notaFiscal.infNFe.det(indice).imposto.Items = New TNFeInfNFeDetImpostoICMS(0) {}

                Dim icms00 = New TNFeInfNFeDetImpostoICMSICMS00()
                icms00.CST = "00"
                icms00.orig = "0"
                icms00.modBC = "3"
                icms00.vBC = txtBCicms.Text
                icms00.pICMS = txtPicms.Text
                icms00.vFCP = txtVfcp.Text
                icms00.pFCP = txtPfcp.Text
                icms00.vICMS = txtVicms.Text
                impICMS.Item = icms00

                notaFiscal.infNFe.det(indice).imposto.Items(0) = impICMS

                notaFiscal.infNFe.det(indice).imposto.PIS = New TNFeInfNFeDetImpostoPIS()
                Dim impPIS = New TNFeInfNFeDetImpostoPIS()
                Dim pisAliq = New TNFeInfNFeDetImpostoPISPISAliq()
                pisAliq.CST = TNFeInfNFeDetImpostoPISPISAliqCST.Item01
                pisAliq.vBC = "2300.00"
                pisAliq.pPIS = "1.65"
                pisAliq.vPIS = "37.95"
                impPIS.Item = pisAliq
                notaFiscal.infNFe.det(indice).imposto.PIS = impPIS

                'DADOS DO COFINS
                notaFiscal.infNFe.det(indice).imposto.COFINS = New TNFeInfNFeDetImpostoCOFINS()
                Dim impCOFINS = New TNFeInfNFeDetImpostoCOFINS()
                Dim cofinsAliq = New TNFeInfNFeDetImpostoCOFINSCOFINSAliq()
                cofinsAliq.CST = TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST.Item01
                cofinsAliq.vBC = "2300.00"
                cofinsAliq.pCOFINS = "7.60"
                cofinsAliq.vCOFINS = "147.80"
                impCOFINS.Item = cofinsAliq
                notaFiscal.infNFe.det(indice).imposto.COFINS = impCOFINS

                indice += 1
            End If
        Next

        'DADOS TOTAIS DA NFE
        notaFiscal.infNFe.total = New TNFeInfNFeTotal()
        notaFiscal.infNFe.total.ICMSTot = New TNFeInfNFeTotalICMSTot()
        If Not String.IsNullOrWhiteSpace(txtBCicms.Text) Then
            notaFiscal.infNFe.total.ICMSTot.vBC = txtBCicms.Text
        Else
            notaFiscal.infNFe.total.ICMSTot.vBC = txtBCicms.Text
        End If
        notaFiscal.infNFe.total.ICMSTot.vICMS = txtVicms.Text
        notaFiscal.infNFe.total.ICMSTot.vBCST = "0.00"
        notaFiscal.infNFe.total.ICMSTot.vST = "0.00"
        notaFiscal.infNFe.total.ICMSTot.vICMSDeson = "0.00"
        notaFiscal.infNFe.total.ICMSTot.vFCPUFDest = "0.00"
        notaFiscal.infNFe.total.ICMSTot.vICMSUFDest = "0.00"
        notaFiscal.infNFe.total.ICMSTot.vICMSUFRemet = "0.00"
        notaFiscal.infNFe.total.ICMSTot.vFCP = "5.52"
        notaFiscal.infNFe.total.ICMSTot.vFCPST = "0.00"
        notaFiscal.infNFe.total.ICMSTot.vFCPSTRet = "0.00"
        notaFiscal.infNFe.total.ICMSTot.vProd = txtVTnota.Text
        notaFiscal.infNFe.total.ICMSTot.vFrete = "0.00"
        notaFiscal.infNFe.total.ICMSTot.vSeg = "0.00"
        notaFiscal.infNFe.total.ICMSTot.vDesc = txtVdesc.Text
        notaFiscal.infNFe.total.ICMSTot.vII = "0.00"
        notaFiscal.infNFe.total.ICMSTot.vIPI = "0.00"
        notaFiscal.infNFe.total.ICMSTot.vIPIDevol = "0.00"
        notaFiscal.infNFe.total.ICMSTot.vPIS = "37.95"
        notaFiscal.infNFe.total.ICMSTot.vCOFINS = "147.80"
        notaFiscal.infNFe.total.ICMSTot.vOutro = "0.00"
        notaFiscal.infNFe.total.ICMSTot.vNF = txtVTnota.Text
        notaFiscal.infNFe.total.ICMSTot.vTotTrib = "0.00"

        notaFiscal.infNFe.transp = New TNFeInfNFeTransp()
        notaFiscal.infNFe.transp.modFrete = TNFeInfNFeTranspModFrete.Item9

        notaFiscal.infNFe.pag = New TNFeInfNFePag()
        notaFiscal.infNFe.pag.vTroco = "0.00"

        notaFiscal.infNFe.pag.detPag = New TNFeInfNFePagDetPag(1) {}

        notaFiscal.infNFe.pag.detPag(0) = New TNFeInfNFePagDetPag()
        notaFiscal.infNFe.pag.detPag(0).indPag = "0"
        notaFiscal.infNFe.pag.detPag(0).tPag = "01"
        notaFiscal.infNFe.pag.detPag(0).vPag = txtVTnota.Text

        notaFiscal.infNFe.infAdic = New TNFeInfNFeInfAdic()
        notaFiscal.infNFe.infAdic.infAdFisco = "DESCRICAO PADRAO DA SEFAZ"

        notaFiscal.infNFe.infAdic.obsCont = New TNFeInfNFeInfAdicObsCont(1) {}

        notaFiscal.infNFe.infAdic.obsCont(0) = New TNFeInfNFeInfAdicObsCont()
        notaFiscal.infNFe.infAdic.obsCont(0).xCampo = "enviaEmail"
        notaFiscal.infNFe.infAdic.obsCont(0).xTexto = "cleiton.fagundes@nstecnologia.com.br"

        notaFiscal.infNFe.infAdic.obsCont(1) = New TNFeInfNFeInfAdicObsCont()
        notaFiscal.infNFe.infAdic.obsCont(1).xCampo = "enviaEmail"
        notaFiscal.infNFe.infAdic.obsCont(1).xTexto = "cleiton.fagundes@nstecnologia.com.br"


        Console.WriteLine(notaFiscal.ToXMLString())

        Dim retorno As String = NSSuite.previaDocumento("55", "xml", notaFiscal.ToXMLString)

        MsgBox(retorno)

        Console.ReadLine()
    End Sub
End Class