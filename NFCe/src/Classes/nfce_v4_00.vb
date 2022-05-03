Imports System.IO
Imports System.Xml.Serialization
Namespace src.Classes

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    <Xml.Serialization.XmlRootAttribute("NFe", [Namespace]:="http://www.portalfiscal.inf.br/nfe", IsNullable:=False)>
    Partial Public Class TNFCe
        Private infNFeField As TNFeInfNFe
        Private infNFeSuplField As TNFeInfNFeSupl

        Public Function ToXMLString() As String
            Dim xs As XmlSerializer = New XmlSerializer(GetType(TNFCe))
            Dim sw As StringWriter = New StringWriter()
            xs.Serialize(sw, Me)
            Return sw.ToString()
        End Function

        'private SignatureType signatureField;

        ''' <remarks/>
        Public Property infNFe As TNFeInfNFe
            Get
                Return infNFeField
            End Get
            Set(ByVal value As TNFeInfNFe)
                infNFeField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property infNFeSupl As TNFeInfNFeSupl
            Get
                Return infNFeSuplField
            End Get
            Set(ByVal value As TNFeInfNFeSupl)
                infNFeSuplField = value
            End Set
        End Property

        ''' <remarks/>
        '[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        'public SignatureType Signature
        '{
        '    get
        '    {
        '        return this.signatureField;
        '    }
        '    set
        '    {
        '        this.signatureField = value;
        '    }
        '}
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFe
        Private ideField As TNFeInfNFeIde
        Private emitField As TNFeInfNFeEmit
        Private avulsaField As TNFeInfNFeAvulsa
        Private destField As TNFeInfNFeDest
        Private retiradaField As TLocal
        Private entregaField As TLocal
        Private autXMLField As TNFeInfNFeAutXML()
        Private detField As TNFeInfNFeDet()
        Private totalField As TNFeInfNFeTotal
        Private transpField As TNFeInfNFeTransp
        Private cobrField As TNFeInfNFeCobr
        Private pagField As TNFeInfNFePag
        Private infIntermedField As TNFeInfNFeInfIntermed
        Private infAdicField As TNFeInfNFeInfAdic
        Private exportaField As TNFeInfNFeExporta
        Private compraField As TNFeInfNFeCompra
        Private canaField As TNFeInfNFeCana
        Private infRespTecField As TInfRespTec
        Private infSolicNFFField As TNFeInfNFeInfSolicNFF
        Private versaoField As String
        Private idField As String

        ''' <remarks/>
        Public Property ide As TNFeInfNFeIde
            Get
                Return ideField
            End Get
            Set(ByVal value As TNFeInfNFeIde)
                ideField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property emit As TNFeInfNFeEmit
            Get
                Return emitField
            End Get
            Set(ByVal value As TNFeInfNFeEmit)
                emitField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property avulsa As TNFeInfNFeAvulsa
            Get
                Return avulsaField
            End Get
            Set(ByVal value As TNFeInfNFeAvulsa)
                avulsaField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property dest As TNFeInfNFeDest
            Get
                Return destField
            End Get
            Set(ByVal value As TNFeInfNFeDest)
                destField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property retirada As TLocal
            Get
                Return retiradaField
            End Get
            Set(ByVal value As TLocal)
                retiradaField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property entrega As TLocal
            Get
                Return entregaField
            End Get
            Set(ByVal value As TLocal)
                entregaField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("autXML")>
        Public Property autXML As TNFeInfNFeAutXML()
            Get
                Return autXMLField
            End Get
            Set(ByVal value As TNFeInfNFeAutXML())
                autXMLField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("det")>
        Public Property det As TNFeInfNFeDet()
            Get
                Return detField
            End Get
            Set(ByVal value As TNFeInfNFeDet())
                detField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property total As TNFeInfNFeTotal
            Get
                Return totalField
            End Get
            Set(ByVal value As TNFeInfNFeTotal)
                totalField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property transp As TNFeInfNFeTransp
            Get
                Return transpField
            End Get
            Set(ByVal value As TNFeInfNFeTransp)
                transpField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cobr As TNFeInfNFeCobr
            Get
                Return cobrField
            End Get
            Set(ByVal value As TNFeInfNFeCobr)
                cobrField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pag As TNFeInfNFePag
            Get
                Return pagField
            End Get
            Set(ByVal value As TNFeInfNFePag)
                pagField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property infIntermed As TNFeInfNFeInfIntermed
            Get
                Return infIntermedField
            End Get
            Set(ByVal value As TNFeInfNFeInfIntermed)
                infIntermedField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property infAdic As TNFeInfNFeInfAdic
            Get
                Return infAdicField
            End Get
            Set(ByVal value As TNFeInfNFeInfAdic)
                infAdicField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property exporta As TNFeInfNFeExporta
            Get
                Return exportaField
            End Get
            Set(ByVal value As TNFeInfNFeExporta)
                exportaField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property compra As TNFeInfNFeCompra
            Get
                Return compraField
            End Get
            Set(ByVal value As TNFeInfNFeCompra)
                compraField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cana As TNFeInfNFeCana
            Get
                Return canaField
            End Get
            Set(ByVal value As TNFeInfNFeCana)
                canaField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property infRespTec As TInfRespTec
            Get
                Return infRespTecField
            End Get
            Set(ByVal value As TInfRespTec)
                infRespTecField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property infSolicNFF As TNFeInfNFeInfSolicNFF
            Get
                Return infSolicNFFField
            End Get
            Set(ByVal value As TNFeInfNFeInfSolicNFF)
                infSolicNFFField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlAttributeAttribute()>
        Public Property versao As String
            Get
                Return versaoField
            End Get
            Set(ByVal value As String)
                versaoField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlAttributeAttribute(DataType:="ID")>
        Public Property Id As String
            Get
                Return idField
            End Get
            Set(ByVal value As String)
                idField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeIde
        Private cUFField As TCodUfIBGE
        Private cNFField As String
        Private natOpField As String
        Private modField As TMod
        Private serieField As String
        Private nNFField As String
        Private dhEmiField As String
        Private dhSaiEntField As String
        Private tpNFField As TNFeInfNFeIdeTpNF
        Private idDestField As TNFeInfNFeIdeIdDest
        Private cMunFGField As String
        Private tpImpField As TNFeInfNFeIdeTpImp
        Private tpEmisField As TNFeInfNFeIdeTpEmis
        Private cDVField As String
        Private tpAmbField As TAmb
        Private finNFeField As TFinNFe
        Private indFinalField As TNFeInfNFeIdeIndFinal
        Private indPresField As TNFeInfNFeIdeIndPres
        Private indIntermedField As TNFeInfNFeIdeIndIntermed
        Private indIntermedFieldSpecified As Boolean
        Private procEmiField As TProcEmi
        Private verProcField As String
        Private dhContField As String
        Private xJustField As String
        Private nFrefField As TNFeInfNFeIdeNFref()

        ''' <remarks/>
        Public Property cUF As TCodUfIBGE
            Get
                Return cUFField
            End Get
            Set(ByVal value As TCodUfIBGE)
                cUFField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cNF As String
            Get
                Return cNFField
            End Get
            Set(ByVal value As String)
                cNFField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property natOp As String
            Get
                Return natOpField
            End Get
            Set(ByVal value As String)
                natOpField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property [mod] As TMod
            Get
                Return modField
            End Get
            Set(ByVal value As TMod)
                modField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property serie As String
            Get
                Return serieField
            End Get
            Set(ByVal value As String)
                serieField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property nNF As String
            Get
                Return nNFField
            End Get
            Set(ByVal value As String)
                nNFField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property dhEmi As String
            Get
                Return dhEmiField
            End Get
            Set(ByVal value As String)
                dhEmiField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property dhSaiEnt As String
            Get
                Return dhSaiEntField
            End Get
            Set(ByVal value As String)
                dhSaiEntField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property tpNF As TNFeInfNFeIdeTpNF
            Get
                Return tpNFField
            End Get
            Set(ByVal value As TNFeInfNFeIdeTpNF)
                tpNFField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property idDest As TNFeInfNFeIdeIdDest
            Get
                Return idDestField
            End Get
            Set(ByVal value As TNFeInfNFeIdeIdDest)
                idDestField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cMunFG As String
            Get
                Return cMunFGField
            End Get
            Set(ByVal value As String)
                cMunFGField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property tpImp As TNFeInfNFeIdeTpImp
            Get
                Return tpImpField
            End Get
            Set(ByVal value As TNFeInfNFeIdeTpImp)
                tpImpField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property tpEmis As TNFeInfNFeIdeTpEmis
            Get
                Return tpEmisField
            End Get
            Set(ByVal value As TNFeInfNFeIdeTpEmis)
                tpEmisField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cDV As String
            Get
                Return cDVField
            End Get
            Set(ByVal value As String)
                cDVField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property tpAmb As TAmb
            Get
                Return tpAmbField
            End Get
            Set(ByVal value As TAmb)
                tpAmbField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property finNFe As TFinNFe
            Get
                Return finNFeField
            End Get
            Set(ByVal value As TFinNFe)
                finNFeField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property indFinal As TNFeInfNFeIdeIndFinal
            Get
                Return indFinalField
            End Get
            Set(ByVal value As TNFeInfNFeIdeIndFinal)
                indFinalField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property indPres As TNFeInfNFeIdeIndPres
            Get
                Return indPresField
            End Get
            Set(ByVal value As TNFeInfNFeIdeIndPres)
                indPresField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property indIntermed As TNFeInfNFeIdeIndIntermed
            Get
                Return indIntermedField
            End Get
            Set(ByVal value As TNFeInfNFeIdeIndIntermed)
                indIntermedField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlIgnoreAttribute()>
        Public Property indIntermedSpecified As Boolean
            Get
                Return indIntermedFieldSpecified
            End Get
            Set(ByVal value As Boolean)
                indIntermedFieldSpecified = value
            End Set
        End Property

        ''' <remarks/>
        Public Property procEmi As TProcEmi
            Get
                Return procEmiField
            End Get
            Set(ByVal value As TProcEmi)
                procEmiField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property verProc As String
            Get
                Return verProcField
            End Get
            Set(ByVal value As String)
                verProcField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property dhCont As String
            Get
                Return dhContField
            End Get
            Set(ByVal value As String)
                dhContField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xJust As String
            Get
                Return xJustField
            End Get
            Set(ByVal value As String)
                xJustField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("NFref")>
        Public Property NFref As TNFeInfNFeIdeNFref()
            Get
                Return nFrefField
            End Get
            Set(ByVal value As TNFeInfNFeIdeNFref())
                nFrefField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TCodUfIBGE

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("11")>
        Item11

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("12")>
        Item12

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("13")>
        Item13

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("14")>
        Item14

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("15")>
        Item15

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("16")>
        Item16

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("17")>
        Item17

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("21")>
        Item21

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("22")>
        Item22

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("23")>
        Item23

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("24")>
        Item24

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("25")>
        Item25

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("26")>
        Item26

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("27")>
        Item27

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("28")>
        Item28

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("29")>
        Item29

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("31")>
        Item31

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("32")>
        Item32

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("33")>
        Item33

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("35")>
        Item35

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("41")>
        Item41

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("42")>
        Item42

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("43")>
        Item43

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("50")>
        Item50

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("51")>
        Item51

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("52")>
        Item52

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("53")>
        Item53
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TMod

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("55")>
        Item55

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("65")>
        Item65
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeIdeTpNF

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeIdeIdDest

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeIdeTpImp

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("4")>
        Item4

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("5")>
        Item5
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeIdeTpEmis

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("4")>
        Item4

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("5")>
        Item5

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("6")>
        Item6

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("7")>
        Item7

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("9")>
        Item9
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TAmb

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TFinNFe

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("4")>
        Item4
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeIdeIndFinal

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeIdeIndPres

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("4")>
        Item4

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("5")>
        Item5

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("9")>
        Item9
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeIdeIndIntermed

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TProcEmi

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeIdeNFref
        Private itemField As Object
        Private itemElementNameField As ItemChoiceType1

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("refCTe", GetType(String))>
        <Xml.Serialization.XmlElementAttribute("refECF", GetType(TNFeInfNFeIdeNFrefRefECF))>
        <Xml.Serialization.XmlElementAttribute("refNF", GetType(TNFeInfNFeIdeNFrefRefNF))>
        <Xml.Serialization.XmlElementAttribute("refNFP", GetType(TNFeInfNFeIdeNFrefRefNFP))>
        <Xml.Serialization.XmlElementAttribute("refNFe", GetType(String))>
        <Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")>
        Public Property Item As Object
            Get
                Return itemField
            End Get
            Set(ByVal value As Object)
                itemField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlIgnoreAttribute()>
        Public Property ItemElementName As ItemChoiceType1
            Get
                Return itemElementNameField
            End Get
            Set(ByVal value As ItemChoiceType1)
                itemElementNameField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeIdeNFrefRefECF
        Private modField As TNFeInfNFeIdeNFrefRefECFMod
        Private nECFField As String
        Private nCOOField As String

        ''' <remarks/>
        Public Property [mod] As TNFeInfNFeIdeNFrefRefECFMod
            Get
                Return modField
            End Get
            Set(ByVal value As TNFeInfNFeIdeNFrefRefECFMod)
                modField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property nECF As String
            Get
                Return nECFField
            End Get
            Set(ByVal value As String)
                nECFField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property nCOO As String
            Get
                Return nCOOField
            End Get
            Set(ByVal value As String)
                nCOOField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeIdeNFrefRefECFMod

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2B")>
        Item2B

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2C")>
        Item2C

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2D")>
        Item2D
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeIdeNFrefRefNF
        Private cUFField As TCodUfIBGE
        Private aAMMField As String
        Private cNPJField As String
        Private modField As TNFeInfNFeIdeNFrefRefNFMod
        Private serieField As String
        Private nNFField As String

        ''' <remarks/>
        Public Property cUF As TCodUfIBGE
            Get
                Return cUFField
            End Get
            Set(ByVal value As TCodUfIBGE)
                cUFField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property AAMM As String
            Get
                Return aAMMField
            End Get
            Set(ByVal value As String)
                aAMMField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CNPJ As String
            Get
                Return cNPJField
            End Get
            Set(ByVal value As String)
                cNPJField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property [mod] As TNFeInfNFeIdeNFrefRefNFMod
            Get
                Return modField
            End Get
            Set(ByVal value As TNFeInfNFeIdeNFrefRefNFMod)
                modField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property serie As String
            Get
                Return serieField
            End Get
            Set(ByVal value As String)
                serieField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property nNF As String
            Get
                Return nNFField
            End Get
            Set(ByVal value As String)
                nNFField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeIdeNFrefRefNFMod

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("01")>
        Item01

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("02")>
        Item02
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeIdeNFrefRefNFP
        Private cUFField As TCodUfIBGE
        Private aAMMField As String
        Private itemField As String
        Private itemElementNameField As ItemChoiceType
        Private ieField As String
        Private modField As TNFeInfNFeIdeNFrefRefNFPMod
        Private serieField As String
        Private nNFField As String

        ''' <remarks/>
        Public Property cUF As TCodUfIBGE
            Get
                Return cUFField
            End Get
            Set(ByVal value As TCodUfIBGE)
                cUFField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property AAMM As String
            Get
                Return aAMMField
            End Get
            Set(ByVal value As String)
                aAMMField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("CNPJ", GetType(String))>
        <Xml.Serialization.XmlElementAttribute("CPF", GetType(String))>
        <Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")>
        Public Property Item As String
            Get
                Return itemField
            End Get
            Set(ByVal value As String)
                itemField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlIgnoreAttribute()>
        Public Property ItemElementName As ItemChoiceType
            Get
                Return itemElementNameField
            End Get
            Set(ByVal value As ItemChoiceType)
                itemElementNameField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property IE As String
            Get
                Return ieField
            End Get
            Set(ByVal value As String)
                ieField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property [mod] As TNFeInfNFeIdeNFrefRefNFPMod
            Get
                Return modField
            End Get
            Set(ByVal value As TNFeInfNFeIdeNFrefRefNFPMod)
                modField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property serie As String
            Get
                Return serieField
            End Get
            Set(ByVal value As String)
                serieField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property nNF As String
            Get
                Return nNFField
            End Get
            Set(ByVal value As String)
                nNFField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe", IncludeInSchema:=False)>
    Public Enum ItemChoiceType

        ''' <remarks/>
        CNPJ

        ''' <remarks/>
        CPF
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeIdeNFrefRefNFPMod

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("01")>
        Item01

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("04")>
        Item04
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe", IncludeInSchema:=False)>
    Public Enum ItemChoiceType1

        ''' <remarks/>
        refCTe

        ''' <remarks/>
        refECF

        ''' <remarks/>
        refNF

        ''' <remarks/>
        refNFP

        ''' <remarks/>
        refNFe
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeEmit
        Private itemField As String
        Private itemElementNameField As ItemChoiceType2
        Private xNomeField As String
        Private xFantField As String
        Private enderEmitField As TEnderEmi
        Private ieField As String
        Private iESTField As String
        Private imField As String
        Private cNAEField As String
        Private cRTField As TNFeInfNFeEmitCRT

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("CNPJ", GetType(String))>
        <Xml.Serialization.XmlElementAttribute("CPF", GetType(String))>
        <Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")>
        Public Property Item As String
            Get
                Return itemField
            End Get
            Set(ByVal value As String)
                itemField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlIgnoreAttribute()>
        Public Property ItemElementName As ItemChoiceType2
            Get
                Return itemElementNameField
            End Get
            Set(ByVal value As ItemChoiceType2)
                itemElementNameField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xNome As String
            Get
                Return xNomeField
            End Get
            Set(ByVal value As String)
                xNomeField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xFant As String
            Get
                Return xFantField
            End Get
            Set(ByVal value As String)
                xFantField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property enderEmit As TEnderEmi
            Get
                Return enderEmitField
            End Get
            Set(ByVal value As TEnderEmi)
                enderEmitField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property IE As String
            Get
                Return ieField
            End Get
            Set(ByVal value As String)
                ieField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property IEST As String
            Get
                Return iESTField
            End Get
            Set(ByVal value As String)
                iESTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property IM As String
            Get
                Return imField
            End Get
            Set(ByVal value As String)
                imField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CNAE As String
            Get
                Return cNAEField
            End Get
            Set(ByVal value As String)
                cNAEField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CRT As TNFeInfNFeEmitCRT
            Get
                Return cRTField
            End Get
            Set(ByVal value As TNFeInfNFeEmitCRT)
                cRTField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe", IncludeInSchema:=False)>
    Public Enum ItemChoiceType2

        ''' <remarks/>
        CNPJ

        ''' <remarks/>
        CPF
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TEnderEmi
        Private xLgrField As String
        Private nroField As String
        Private xCplField As String
        Private xBairroField As String
        Private cMunField As String
        Private xMunField As String
        Private ufField As TUfEmi
        Private cEPField As String
        Private cPaisField As TEnderEmiCPais
        Private cPaisFieldSpecified As Boolean
        Private xPaisField As TEnderEmiXPais
        Private xPaisFieldSpecified As Boolean
        Private foneField As String

        ''' <remarks/>
        Public Property xLgr As String
            Get
                Return xLgrField
            End Get
            Set(ByVal value As String)
                xLgrField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property nro As String
            Get
                Return nroField
            End Get
            Set(ByVal value As String)
                nroField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xCpl As String
            Get
                Return xCplField
            End Get
            Set(ByVal value As String)
                xCplField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xBairro As String
            Get
                Return xBairroField
            End Get
            Set(ByVal value As String)
                xBairroField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cMun As String
            Get
                Return cMunField
            End Get
            Set(ByVal value As String)
                cMunField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xMun As String
            Get
                Return xMunField
            End Get
            Set(ByVal value As String)
                xMunField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property UF As TUfEmi
            Get
                Return ufField
            End Get
            Set(ByVal value As TUfEmi)
                ufField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CEP As String
            Get
                Return cEPField
            End Get
            Set(ByVal value As String)
                cEPField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cPais As TEnderEmiCPais
            Get
                Return cPaisField
            End Get
            Set(ByVal value As TEnderEmiCPais)
                cPaisField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlIgnoreAttribute()>
        Public Property cPaisSpecified As Boolean
            Get
                Return cPaisFieldSpecified
            End Get
            Set(ByVal value As Boolean)
                cPaisFieldSpecified = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xPais As TEnderEmiXPais
            Get
                Return xPaisField
            End Get
            Set(ByVal value As TEnderEmiXPais)
                xPaisField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlIgnoreAttribute()>
        Public Property xPaisSpecified As Boolean
            Get
                Return xPaisFieldSpecified
            End Get
            Set(ByVal value As Boolean)
                xPaisFieldSpecified = value
            End Set
        End Property

        ''' <remarks/>
        Public Property fone As String
            Get
                Return foneField
            End Get
            Set(ByVal value As String)
                foneField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TUfEmi

        ''' <remarks/>
        AC

        ''' <remarks/>
        AL

        ''' <remarks/>
        AM

        ''' <remarks/>
        AP

        ''' <remarks/>
        BA

        ''' <remarks/>
        CE

        ''' <remarks/>
        DF

        ''' <remarks/>
        ES

        ''' <remarks/>
        GO

        ''' <remarks/>
        MA

        ''' <remarks/>
        MG

        ''' <remarks/>
        MS

        ''' <remarks/>
        MT

        ''' <remarks/>
        PA

        ''' <remarks/>
        PB

        ''' <remarks/>
        PE

        ''' <remarks/>
        PI

        ''' <remarks/>
        PR

        ''' <remarks/>
        RJ

        ''' <remarks/>
        RN

        ''' <remarks/>
        RO

        ''' <remarks/>
        RR

        ''' <remarks/>
        RS

        ''' <remarks/>
        SC

        ''' <remarks/>
        SE

        ''' <remarks/>
        SP

        ''' <remarks/>
        [TO]
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TEnderEmiCPais

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1058")>
        Item1058
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TEnderEmiXPais

        ''' <remarks/>
        Brasil

        ''' <remarks/>
        BRASILField
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeEmitCRT

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeAvulsa
        Private cNPJField As String
        Private xOrgaoField As String
        Private matrField As String
        Private xAgenteField As String
        Private foneField As String
        Private ufField As TUfEmi
        Private nDARField As String
        Private dEmiField As String
        Private vDARField As String
        Private repEmiField As String
        Private dPagField As String

        ''' <remarks/>
        Public Property CNPJ As String
            Get
                Return cNPJField
            End Get
            Set(ByVal value As String)
                cNPJField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xOrgao As String
            Get
                Return xOrgaoField
            End Get
            Set(ByVal value As String)
                xOrgaoField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property matr As String
            Get
                Return matrField
            End Get
            Set(ByVal value As String)
                matrField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xAgente As String
            Get
                Return xAgenteField
            End Get
            Set(ByVal value As String)
                xAgenteField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property fone As String
            Get
                Return foneField
            End Get
            Set(ByVal value As String)
                foneField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property UF As TUfEmi
            Get
                Return ufField
            End Get
            Set(ByVal value As TUfEmi)
                ufField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property nDAR As String
            Get
                Return nDARField
            End Get
            Set(ByVal value As String)
                nDARField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property dEmi As String
            Get
                Return dEmiField
            End Get
            Set(ByVal value As String)
                dEmiField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vDAR As String
            Get
                Return vDARField
            End Get
            Set(ByVal value As String)
                vDARField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property repEmi As String
            Get
                Return repEmiField
            End Get
            Set(ByVal value As String)
                repEmiField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property dPag As String
            Get
                Return dPagField
            End Get
            Set(ByVal value As String)
                dPagField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDest
        Private itemField As String
        Private itemElementNameField As ItemChoiceType3
        Private xNomeField As String
        Private enderDestField As TEndereco
        Private indIEDestField As TNFeInfNFeDestIndIEDest
        Private ieField As String
        Private iSUFField As String
        Private imField As String
        Private emailField As String

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("CNPJ", GetType(String))>
        <Xml.Serialization.XmlElementAttribute("CPF", GetType(String))>
        <Xml.Serialization.XmlElementAttribute("idEstrangeiro", GetType(String))>
        <Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")>
        Public Property Item As String
            Get
                Return itemField
            End Get
            Set(ByVal value As String)
                itemField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlIgnoreAttribute()>
        Public Property ItemElementName As ItemChoiceType3
            Get
                Return itemElementNameField
            End Get
            Set(ByVal value As ItemChoiceType3)
                itemElementNameField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xNome As String
            Get
                Return xNomeField
            End Get
            Set(ByVal value As String)
                xNomeField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property enderDest As TEndereco
            Get
                Return enderDestField
            End Get
            Set(ByVal value As TEndereco)
                enderDestField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property indIEDest As TNFeInfNFeDestIndIEDest
            Get
                Return indIEDestField
            End Get
            Set(ByVal value As TNFeInfNFeDestIndIEDest)
                indIEDestField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property IE As String
            Get
                Return ieField
            End Get
            Set(ByVal value As String)
                ieField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property ISUF As String
            Get
                Return iSUFField
            End Get
            Set(ByVal value As String)
                iSUFField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property IM As String
            Get
                Return imField
            End Get
            Set(ByVal value As String)
                imField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property email As String
            Get
                Return emailField
            End Get
            Set(ByVal value As String)
                emailField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe", IncludeInSchema:=False)>
    Public Enum ItemChoiceType3

        ''' <remarks/>
        CNPJ

        ''' <remarks/>
        CPF

        ''' <remarks/>
        idEstrangeiro
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TEndereco
        Private xLgrField As String
        Private nroField As String
        Private xCplField As String
        Private xBairroField As String
        Private cMunField As String
        Private xMunField As String
        Private ufField As TUf
        Private cEPField As String
        Private cPaisField As String
        Private xPaisField As String
        Private foneField As String

        ''' <remarks/>
        Public Property xLgr As String
            Get
                Return xLgrField
            End Get
            Set(ByVal value As String)
                xLgrField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property nro As String
            Get
                Return nroField
            End Get
            Set(ByVal value As String)
                nroField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xCpl As String
            Get
                Return xCplField
            End Get
            Set(ByVal value As String)
                xCplField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xBairro As String
            Get
                Return xBairroField
            End Get
            Set(ByVal value As String)
                xBairroField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cMun As String
            Get
                Return cMunField
            End Get
            Set(ByVal value As String)
                cMunField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xMun As String
            Get
                Return xMunField
            End Get
            Set(ByVal value As String)
                xMunField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property UF As TUf
            Get
                Return ufField
            End Get
            Set(ByVal value As TUf)
                ufField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CEP As String
            Get
                Return cEPField
            End Get
            Set(ByVal value As String)
                cEPField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cPais As String
            Get
                Return cPaisField
            End Get
            Set(ByVal value As String)
                cPaisField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xPais As String
            Get
                Return xPaisField
            End Get
            Set(ByVal value As String)
                xPaisField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property fone As String
            Get
                Return foneField
            End Get
            Set(ByVal value As String)
                foneField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TUf

        ''' <remarks/>
        AC

        ''' <remarks/>
        AL

        ''' <remarks/>
        AM

        ''' <remarks/>
        AP

        ''' <remarks/>
        BA

        ''' <remarks/>
        CE

        ''' <remarks/>
        DF

        ''' <remarks/>
        ES

        ''' <remarks/>
        GO

        ''' <remarks/>
        MA

        ''' <remarks/>
        MG

        ''' <remarks/>
        MS

        ''' <remarks/>
        MT

        ''' <remarks/>
        PA

        ''' <remarks/>
        PB

        ''' <remarks/>
        PE

        ''' <remarks/>
        PI

        ''' <remarks/>
        PR

        ''' <remarks/>
        RJ

        ''' <remarks/>
        RN

        ''' <remarks/>
        RO

        ''' <remarks/>
        RR

        ''' <remarks/>
        RS

        ''' <remarks/>
        SC

        ''' <remarks/>
        SE

        ''' <remarks/>
        SP

        ''' <remarks/>
        [TO]

        ''' <remarks/>
        EX
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDestIndIEDest

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("9")>
        Item9
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TLocal
        Private itemField As String
        Private itemElementNameField As ItemChoiceType4
        Private xNomeField As String
        Private xLgrField As String
        Private nroField As String
        Private xCplField As String
        Private xBairroField As String
        Private cMunField As String
        Private xMunField As String
        Private ufField As TUf
        Private cEPField As String
        Private cPaisField As String
        Private xPaisField As String
        Private foneField As String
        Private emailField As String
        Private ieField As String

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("CNPJ", GetType(String))>
        <Xml.Serialization.XmlElementAttribute("CPF", GetType(String))>
        <Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")>
        Public Property Item As String
            Get
                Return itemField
            End Get
            Set(ByVal value As String)
                itemField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlIgnoreAttribute()>
        Public Property ItemElementName As ItemChoiceType4
            Get
                Return itemElementNameField
            End Get
            Set(ByVal value As ItemChoiceType4)
                itemElementNameField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xNome As String
            Get
                Return xNomeField
            End Get
            Set(ByVal value As String)
                xNomeField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xLgr As String
            Get
                Return xLgrField
            End Get
            Set(ByVal value As String)
                xLgrField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property nro As String
            Get
                Return nroField
            End Get
            Set(ByVal value As String)
                nroField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xCpl As String
            Get
                Return xCplField
            End Get
            Set(ByVal value As String)
                xCplField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xBairro As String
            Get
                Return xBairroField
            End Get
            Set(ByVal value As String)
                xBairroField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cMun As String
            Get
                Return cMunField
            End Get
            Set(ByVal value As String)
                cMunField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xMun As String
            Get
                Return xMunField
            End Get
            Set(ByVal value As String)
                xMunField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property UF As TUf
            Get
                Return ufField
            End Get
            Set(ByVal value As TUf)
                ufField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CEP As String
            Get
                Return cEPField
            End Get
            Set(ByVal value As String)
                cEPField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cPais As String
            Get
                Return cPaisField
            End Get
            Set(ByVal value As String)
                cPaisField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xPais As String
            Get
                Return xPaisField
            End Get
            Set(ByVal value As String)
                xPaisField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property fone As String
            Get
                Return foneField
            End Get
            Set(ByVal value As String)
                foneField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property email As String
            Get
                Return emailField
            End Get
            Set(ByVal value As String)
                emailField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property IE As String
            Get
                Return ieField
            End Get
            Set(ByVal value As String)
                ieField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe", IncludeInSchema:=False)>
    Public Enum ItemChoiceType4

        ''' <remarks/>
        CNPJ

        ''' <remarks/>
        CPF
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeAutXML
        Private itemField As String
        Private itemElementNameField As ItemChoiceType5

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("CNPJ", GetType(String))>
        <Xml.Serialization.XmlElementAttribute("CPF", GetType(String))>
        <Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")>
        Public Property Item As String
            Get
                Return itemField
            End Get
            Set(ByVal value As String)
                itemField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlIgnoreAttribute()>
        Public Property ItemElementName As ItemChoiceType5
            Get
                Return itemElementNameField
            End Get
            Set(ByVal value As ItemChoiceType5)
                itemElementNameField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe", IncludeInSchema:=False)>
    Public Enum ItemChoiceType5

        ''' <remarks/>
        CNPJ

        ''' <remarks/>
        CPF
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDet
        Private prodField As TNFeInfNFeDetProd
        Private impostoField As TNFeInfNFeDetImposto
        Private impostoDevolField As TNFeInfNFeDetImpostoDevol
        Private infAdProdField As String
        Private nItemField As String

        ''' <remarks/>
        Public Property prod As TNFeInfNFeDetProd
            Get
                Return prodField
            End Get
            Set(ByVal value As TNFeInfNFeDetProd)
                prodField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property imposto As TNFeInfNFeDetImposto
            Get
                Return impostoField
            End Get
            Set(ByVal value As TNFeInfNFeDetImposto)
                impostoField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property impostoDevol As TNFeInfNFeDetImpostoDevol
            Get
                Return impostoDevolField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoDevol)
                impostoDevolField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property infAdProd As String
            Get
                Return infAdProdField
            End Get
            Set(ByVal value As String)
                infAdProdField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlAttributeAttribute()>
        Public Property nItem As String
            Get
                Return nItemField
            End Get
            Set(ByVal value As String)
                nItemField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetProd
        Private cProdField As String
        Private cEANField As String
        Private cBarraField As String
        Private xProdField As String
        Private nCMField As String
        Private nVEField As String()
        Private cESTField As String
        Private indEscalaField As TNFeInfNFeDetProdIndEscala
        Private indEscalaFieldSpecified As Boolean
        Private cNPJFabField As String
        Private cBenefField As String
        Private eXTIPIField As String
        Private cFOPField As String
        Private uComField As String
        Private qComField As String
        Private vUnComField As String
        Private vProdField As String
        Private cEANTribField As String
        Private cBarraTribField As String
        Private uTribField As String
        Private qTribField As String
        Private vUnTribField As String
        Private vFreteField As String
        Private vSegField As String
        Private vDescField As String
        Private vOutroField As String
        Private indTotField As TNFeInfNFeDetProdIndTot
        Private diField As TNFeInfNFeDetProdDI()
        Private detExportField As TNFeInfNFeDetProdDetExport()
        Private xPedField As String
        Private nItemPedField As String
        Private nFCIField As String
        Private rastroField As TNFeInfNFeDetProdRastro()
        Private infProdNFFField As TNFeInfNFeDetProdInfProdNFF
        Private infProdEmbField As TNFeInfNFeDetProdInfProdEmb
        Private itemsField As Object()

        ''' <remarks/>
        Public Property cProd As String
            Get
                Return cProdField
            End Get
            Set(ByVal value As String)
                cProdField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cEAN As String
            Get
                Return cEANField
            End Get
            Set(ByVal value As String)
                cEANField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cBarra As String
            Get
                Return cBarraField
            End Get
            Set(ByVal value As String)
                cBarraField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xProd As String
            Get
                Return xProdField
            End Get
            Set(ByVal value As String)
                xProdField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property NCM As String
            Get
                Return nCMField
            End Get
            Set(ByVal value As String)
                nCMField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("NVE")>
        Public Property NVE As String()
            Get
                Return nVEField
            End Get
            Set(ByVal value As String())
                nVEField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CEST As String
            Get
                Return cESTField
            End Get
            Set(ByVal value As String)
                cESTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property indEscala As TNFeInfNFeDetProdIndEscala
            Get
                Return indEscalaField
            End Get
            Set(ByVal value As TNFeInfNFeDetProdIndEscala)
                indEscalaField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlIgnoreAttribute()>
        Public Property indEscalaSpecified As Boolean
            Get
                Return indEscalaFieldSpecified
            End Get
            Set(ByVal value As Boolean)
                indEscalaFieldSpecified = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CNPJFab As String
            Get
                Return cNPJFabField
            End Get
            Set(ByVal value As String)
                cNPJFabField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cBenef As String
            Get
                Return cBenefField
            End Get
            Set(ByVal value As String)
                cBenefField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property EXTIPI As String
            Get
                Return eXTIPIField
            End Get
            Set(ByVal value As String)
                eXTIPIField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CFOP As String
            Get
                Return cFOPField
            End Get
            Set(ByVal value As String)
                cFOPField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property uCom As String
            Get
                Return uComField
            End Get
            Set(ByVal value As String)
                uComField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property qCom As String
            Get
                Return qComField
            End Get
            Set(ByVal value As String)
                qComField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vUnCom As String
            Get
                Return vUnComField
            End Get
            Set(ByVal value As String)
                vUnComField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vProd As String
            Get
                Return vProdField
            End Get
            Set(ByVal value As String)
                vProdField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cEANTrib As String
            Get
                Return cEANTribField
            End Get
            Set(ByVal value As String)
                cEANTribField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cBarraTrib As String
            Get
                Return cBarraTribField
            End Get
            Set(ByVal value As String)
                cBarraTribField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property uTrib As String
            Get
                Return uTribField
            End Get
            Set(ByVal value As String)
                uTribField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property qTrib As String
            Get
                Return qTribField
            End Get
            Set(ByVal value As String)
                qTribField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vUnTrib As String
            Get
                Return vUnTribField
            End Get
            Set(ByVal value As String)
                vUnTribField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vFrete As String
            Get
                Return vFreteField
            End Get
            Set(ByVal value As String)
                vFreteField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vSeg As String
            Get
                Return vSegField
            End Get
            Set(ByVal value As String)
                vSegField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vDesc As String
            Get
                Return vDescField
            End Get
            Set(ByVal value As String)
                vDescField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vOutro As String
            Get
                Return vOutroField
            End Get
            Set(ByVal value As String)
                vOutroField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property indTot As TNFeInfNFeDetProdIndTot
            Get
                Return indTotField
            End Get
            Set(ByVal value As TNFeInfNFeDetProdIndTot)
                indTotField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("DI")>
        Public Property DI As TNFeInfNFeDetProdDI()
            Get
                Return diField
            End Get
            Set(ByVal value As TNFeInfNFeDetProdDI())
                diField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("detExport")>
        Public Property detExport As TNFeInfNFeDetProdDetExport()
            Get
                Return detExportField
            End Get
            Set(ByVal value As TNFeInfNFeDetProdDetExport())
                detExportField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xPed As String
            Get
                Return xPedField
            End Get
            Set(ByVal value As String)
                xPedField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property nItemPed As String
            Get
                Return nItemPedField
            End Get
            Set(ByVal value As String)
                nItemPedField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property nFCI As String
            Get
                Return nFCIField
            End Get
            Set(ByVal value As String)
                nFCIField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("rastro")>
        Public Property rastro As TNFeInfNFeDetProdRastro()
            Get
                Return rastroField
            End Get
            Set(ByVal value As TNFeInfNFeDetProdRastro())
                rastroField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property infProdNFF As TNFeInfNFeDetProdInfProdNFF
            Get
                Return infProdNFFField
            End Get
            Set(ByVal value As TNFeInfNFeDetProdInfProdNFF)
                infProdNFFField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property infProdEmb As TNFeInfNFeDetProdInfProdEmb
            Get
                Return infProdEmbField
            End Get
            Set(ByVal value As TNFeInfNFeDetProdInfProdEmb)
                infProdEmbField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("arma", GetType(TNFeInfNFeDetProdArma))>
        <Xml.Serialization.XmlElementAttribute("comb", GetType(TNFeInfNFeDetProdComb))>
        <Xml.Serialization.XmlElementAttribute("med", GetType(TNFeInfNFeDetProdMed))>
        <Xml.Serialization.XmlElementAttribute("nRECOPI", GetType(String))>
        <Xml.Serialization.XmlElementAttribute("veicProd", GetType(TNFeInfNFeDetProdVeicProd))>
        Public Property Items As Object()
            Get
                Return itemsField
            End Get
            Set(ByVal value As Object())
                itemsField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetProdIndEscala

        ''' <remarks/>
        S

        ''' <remarks/>
        N
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetProdIndTot

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetProdDI
        Private nDIField As String
        Private dDIField As String
        Private xLocDesembField As String
        Private uFDesembField As TUfEmi
        Private dDesembField As String
        Private tpViaTranspField As TNFeInfNFeDetProdDITpViaTransp
        Private vAFRMMField As String
        Private tpIntermedioField As TNFeInfNFeDetProdDITpIntermedio
        Private cNPJField As String
        Private uFTerceiroField As TUfEmi
        Private uFTerceiroFieldSpecified As Boolean
        Private cExportadorField As String
        Private adiField As TNFeInfNFeDetProdDIAdi()

        ''' <remarks/>
        Public Property nDI As String
            Get
                Return nDIField
            End Get
            Set(ByVal value As String)
                nDIField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property dDI As String
            Get
                Return dDIField
            End Get
            Set(ByVal value As String)
                dDIField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xLocDesemb As String
            Get
                Return xLocDesembField
            End Get
            Set(ByVal value As String)
                xLocDesembField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property UFDesemb As TUfEmi
            Get
                Return uFDesembField
            End Get
            Set(ByVal value As TUfEmi)
                uFDesembField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property dDesemb As String
            Get
                Return dDesembField
            End Get
            Set(ByVal value As String)
                dDesembField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property tpViaTransp As TNFeInfNFeDetProdDITpViaTransp
            Get
                Return tpViaTranspField
            End Get
            Set(ByVal value As TNFeInfNFeDetProdDITpViaTransp)
                tpViaTranspField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vAFRMM As String
            Get
                Return vAFRMMField
            End Get
            Set(ByVal value As String)
                vAFRMMField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property tpIntermedio As TNFeInfNFeDetProdDITpIntermedio
            Get
                Return tpIntermedioField
            End Get
            Set(ByVal value As TNFeInfNFeDetProdDITpIntermedio)
                tpIntermedioField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CNPJ As String
            Get
                Return cNPJField
            End Get
            Set(ByVal value As String)
                cNPJField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property UFTerceiro As TUfEmi
            Get
                Return uFTerceiroField
            End Get
            Set(ByVal value As TUfEmi)
                uFTerceiroField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlIgnoreAttribute()>
        Public Property UFTerceiroSpecified As Boolean
            Get
                Return uFTerceiroFieldSpecified
            End Get
            Set(ByVal value As Boolean)
                uFTerceiroFieldSpecified = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cExportador As String
            Get
                Return cExportadorField
            End Get
            Set(ByVal value As String)
                cExportadorField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("adi")>
        Public Property adi As TNFeInfNFeDetProdDIAdi()
            Get
                Return adiField
            End Get
            Set(ByVal value As TNFeInfNFeDetProdDIAdi())
                adiField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetProdDITpViaTransp

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("4")>
        Item4

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("5")>
        Item5

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("6")>
        Item6

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("7")>
        Item7

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("8")>
        Item8

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("9")>
        Item9

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("10")>
        Item10

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("11")>
        Item11

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("12")>
        Item12

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("13")>
        Item13
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetProdDITpIntermedio

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetProdDIAdi
        Private nAdicaoField As String
        Private nSeqAdicField As String
        Private cFabricanteField As String
        Private vDescDIField As String
        Private nDrawField As String

        ''' <remarks/>
        Public Property nAdicao As String
            Get
                Return nAdicaoField
            End Get
            Set(ByVal value As String)
                nAdicaoField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property nSeqAdic As String
            Get
                Return nSeqAdicField
            End Get
            Set(ByVal value As String)
                nSeqAdicField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cFabricante As String
            Get
                Return cFabricanteField
            End Get
            Set(ByVal value As String)
                cFabricanteField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vDescDI As String
            Get
                Return vDescDIField
            End Get
            Set(ByVal value As String)
                vDescDIField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property nDraw As String
            Get
                Return nDrawField
            End Get
            Set(ByVal value As String)
                nDrawField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetProdDetExport
        Private nDrawField As String
        Private exportIndField As TNFeInfNFeDetProdDetExportExportInd

        ''' <remarks/>
        Public Property nDraw As String
            Get
                Return nDrawField
            End Get
            Set(ByVal value As String)
                nDrawField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property exportInd As TNFeInfNFeDetProdDetExportExportInd
            Get
                Return exportIndField
            End Get
            Set(ByVal value As TNFeInfNFeDetProdDetExportExportInd)
                exportIndField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetProdDetExportExportInd
        Private nREField As String
        Private chNFeField As String
        Private qExportField As String

        ''' <remarks/>
        Public Property nRE As String
            Get
                Return nREField
            End Get
            Set(ByVal value As String)
                nREField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property chNFe As String
            Get
                Return chNFeField
            End Get
            Set(ByVal value As String)
                chNFeField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property qExport As String
            Get
                Return qExportField
            End Get
            Set(ByVal value As String)
                qExportField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetProdRastro
        Private nLoteField As String
        Private qLoteField As String
        Private dFabField As String
        Private dValField As String
        Private cAgregField As String

        ''' <remarks/>
        Public Property nLote As String
            Get
                Return nLoteField
            End Get
            Set(ByVal value As String)
                nLoteField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property qLote As String
            Get
                Return qLoteField
            End Get
            Set(ByVal value As String)
                qLoteField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property dFab As String
            Get
                Return dFabField
            End Get
            Set(ByVal value As String)
                dFabField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property dVal As String
            Get
                Return dValField
            End Get
            Set(ByVal value As String)
                dValField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cAgreg As String
            Get
                Return cAgregField
            End Get
            Set(ByVal value As String)
                cAgregField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetProdInfProdNFF
        Private cProdFiscoField As String
        Private cOperNFFField As String

        ''' <remarks/>
        Public Property cProdFisco As String
            Get
                Return cProdFiscoField
            End Get
            Set(ByVal value As String)
                cProdFiscoField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cOperNFF As String
            Get
                Return cOperNFFField
            End Get
            Set(ByVal value As String)
                cOperNFFField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetProdInfProdEmb
        Private xEmbField As String
        Private qVolEmbField As String
        Private uEmbField As String

        ''' <remarks/>
        Public Property xEmb As String
            Get
                Return xEmbField
            End Get
            Set(ByVal value As String)
                xEmbField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property qVolEmb As String
            Get
                Return qVolEmbField
            End Get
            Set(ByVal value As String)
                qVolEmbField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property uEmb As String
            Get
                Return uEmbField
            End Get
            Set(ByVal value As String)
                uEmbField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetProdArma
        Private tpArmaField As TNFeInfNFeDetProdArmaTpArma
        Private nSerieField As String
        Private nCanoField As String
        Private descrField As String

        ''' <remarks/>
        Public Property tpArma As TNFeInfNFeDetProdArmaTpArma
            Get
                Return tpArmaField
            End Get
            Set(ByVal value As TNFeInfNFeDetProdArmaTpArma)
                tpArmaField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property nSerie As String
            Get
                Return nSerieField
            End Get
            Set(ByVal value As String)
                nSerieField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property nCano As String
            Get
                Return nCanoField
            End Get
            Set(ByVal value As String)
                nCanoField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property descr As String
            Get
                Return descrField
            End Get
            Set(ByVal value As String)
                descrField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetProdArmaTpArma

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetProdComb
        Private cProdANPField As String
        Private descANPField As String
        Private pGLPField As String
        Private pGNnField As String
        Private pGNiField As String
        Private vPartField As String
        Private cODIFField As String
        Private qTempField As String
        Private uFConsField As TUf
        Private cIDEField As TNFeInfNFeDetProdCombCIDE
        Private encerranteField As TNFeInfNFeDetProdCombEncerrante

        ''' <remarks/>
        Public Property cProdANP As String
            Get
                Return cProdANPField
            End Get
            Set(ByVal value As String)
                cProdANPField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property descANP As String
            Get
                Return descANPField
            End Get
            Set(ByVal value As String)
                descANPField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pGLP As String
            Get
                Return pGLPField
            End Get
            Set(ByVal value As String)
                pGLPField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pGNn As String
            Get
                Return pGNnField
            End Get
            Set(ByVal value As String)
                pGNnField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pGNi As String
            Get
                Return pGNiField
            End Get
            Set(ByVal value As String)
                pGNiField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vPart As String
            Get
                Return vPartField
            End Get
            Set(ByVal value As String)
                vPartField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CODIF As String
            Get
                Return cODIFField
            End Get
            Set(ByVal value As String)
                cODIFField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property qTemp As String
            Get
                Return qTempField
            End Get
            Set(ByVal value As String)
                qTempField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property UFCons As TUf
            Get
                Return uFConsField
            End Get
            Set(ByVal value As TUf)
                uFConsField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CIDE As TNFeInfNFeDetProdCombCIDE
            Get
                Return cIDEField
            End Get
            Set(ByVal value As TNFeInfNFeDetProdCombCIDE)
                cIDEField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property encerrante As TNFeInfNFeDetProdCombEncerrante
            Get
                Return encerranteField
            End Get
            Set(ByVal value As TNFeInfNFeDetProdCombEncerrante)
                encerranteField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetProdCombCIDE
        Private qBCProdField As String
        Private vAliqProdField As String
        Private vCIDEField As String

        ''' <remarks/>
        Public Property qBCProd As String
            Get
                Return qBCProdField
            End Get
            Set(ByVal value As String)
                qBCProdField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vAliqProd As String
            Get
                Return vAliqProdField
            End Get
            Set(ByVal value As String)
                vAliqProdField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vCIDE As String
            Get
                Return vCIDEField
            End Get
            Set(ByVal value As String)
                vCIDEField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetProdCombEncerrante
        Private nBicoField As String
        Private nBombaField As String
        Private nTanqueField As String
        Private vEncIniField As String
        Private vEncFinField As String

        ''' <remarks/>
        Public Property nBico As String
            Get
                Return nBicoField
            End Get
            Set(ByVal value As String)
                nBicoField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property nBomba As String
            Get
                Return nBombaField
            End Get
            Set(ByVal value As String)
                nBombaField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property nTanque As String
            Get
                Return nTanqueField
            End Get
            Set(ByVal value As String)
                nTanqueField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vEncIni As String
            Get
                Return vEncIniField
            End Get
            Set(ByVal value As String)
                vEncIniField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vEncFin As String
            Get
                Return vEncFinField
            End Get
            Set(ByVal value As String)
                vEncFinField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetProdMed
        Private cProdANVISAField As String
        Private xMotivoIsencaoField As String
        Private vPMCField As String

        ''' <remarks/>
        Public Property cProdANVISA As String
            Get
                Return cProdANVISAField
            End Get
            Set(ByVal value As String)
                cProdANVISAField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xMotivoIsencao As String
            Get
                Return xMotivoIsencaoField
            End Get
            Set(ByVal value As String)
                xMotivoIsencaoField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vPMC As String
            Get
                Return vPMCField
            End Get
            Set(ByVal value As String)
                vPMCField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetProdVeicProd
        Private tpOpField As TNFeInfNFeDetProdVeicProdTpOp
        Private chassiField As String
        Private cCorField As String
        Private xCorField As String
        Private potField As String
        Private cilinField As String
        Private pesoLField As String
        Private pesoBField As String
        Private nSerieField As String
        Private tpCombField As String
        Private nMotorField As String
        Private cMTField As String
        Private distField As String
        Private anoModField As String
        Private anoFabField As String
        Private tpPintField As String
        Private tpVeicField As String
        Private espVeicField As String
        Private vINField As TNFeInfNFeDetProdVeicProdVIN
        Private condVeicField As TNFeInfNFeDetProdVeicProdCondVeic
        Private cModField As String
        Private cCorDENATRANField As String
        Private lotaField As String
        Private tpRestField As TNFeInfNFeDetProdVeicProdTpRest

        ''' <remarks/>
        Public Property tpOp As TNFeInfNFeDetProdVeicProdTpOp
            Get
                Return tpOpField
            End Get
            Set(ByVal value As TNFeInfNFeDetProdVeicProdTpOp)
                tpOpField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property chassi As String
            Get
                Return chassiField
            End Get
            Set(ByVal value As String)
                chassiField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cCor As String
            Get
                Return cCorField
            End Get
            Set(ByVal value As String)
                cCorField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xCor As String
            Get
                Return xCorField
            End Get
            Set(ByVal value As String)
                xCorField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pot As String
            Get
                Return potField
            End Get
            Set(ByVal value As String)
                potField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cilin As String
            Get
                Return cilinField
            End Get
            Set(ByVal value As String)
                cilinField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pesoL As String
            Get
                Return pesoLField
            End Get
            Set(ByVal value As String)
                pesoLField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pesoB As String
            Get
                Return pesoBField
            End Get
            Set(ByVal value As String)
                pesoBField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property nSerie As String
            Get
                Return nSerieField
            End Get
            Set(ByVal value As String)
                nSerieField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property tpComb As String
            Get
                Return tpCombField
            End Get
            Set(ByVal value As String)
                tpCombField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property nMotor As String
            Get
                Return nMotorField
            End Get
            Set(ByVal value As String)
                nMotorField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CMT As String
            Get
                Return cMTField
            End Get
            Set(ByVal value As String)
                cMTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property dist As String
            Get
                Return distField
            End Get
            Set(ByVal value As String)
                distField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property anoMod As String
            Get
                Return anoModField
            End Get
            Set(ByVal value As String)
                anoModField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property anoFab As String
            Get
                Return anoFabField
            End Get
            Set(ByVal value As String)
                anoFabField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property tpPint As String
            Get
                Return tpPintField
            End Get
            Set(ByVal value As String)
                tpPintField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property tpVeic As String
            Get
                Return tpVeicField
            End Get
            Set(ByVal value As String)
                tpVeicField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property espVeic As String
            Get
                Return espVeicField
            End Get
            Set(ByVal value As String)
                espVeicField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property VIN As TNFeInfNFeDetProdVeicProdVIN
            Get
                Return vINField
            End Get
            Set(ByVal value As TNFeInfNFeDetProdVeicProdVIN)
                vINField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property condVeic As TNFeInfNFeDetProdVeicProdCondVeic
            Get
                Return condVeicField
            End Get
            Set(ByVal value As TNFeInfNFeDetProdVeicProdCondVeic)
                condVeicField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cMod As String
            Get
                Return cModField
            End Get
            Set(ByVal value As String)
                cModField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cCorDENATRAN As String
            Get
                Return cCorDENATRANField
            End Get
            Set(ByVal value As String)
                cCorDENATRANField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property lota As String
            Get
                Return lotaField
            End Get
            Set(ByVal value As String)
                lotaField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property tpRest As TNFeInfNFeDetProdVeicProdTpRest
            Get
                Return tpRestField
            End Get
            Set(ByVal value As TNFeInfNFeDetProdVeicProdTpRest)
                tpRestField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetProdVeicProdTpOp

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetProdVeicProdVIN

        ''' <remarks/>
        R

        ''' <remarks/>
        N
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetProdVeicProdCondVeic

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetProdVeicProdTpRest

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("4")>
        Item4

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("9")>
        Item9
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImposto
        Private vTotTribField As String
        Private itemsField As Object()
        Private pISField As TNFeInfNFeDetImpostoPIS
        Private pISSTField As TNFeInfNFeDetImpostoPISST
        Private cOFINSField As TNFeInfNFeDetImpostoCOFINS
        Private cOFINSSTField As TNFeInfNFeDetImpostoCOFINSST
        Private iCMSUFDestField As TNFeInfNFeDetImpostoICMSUFDest

        ''' <remarks/>
        Public Property vTotTrib As String
            Get
                Return vTotTribField
            End Get
            Set(ByVal value As String)
                vTotTribField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("ICMS", GetType(TNFeInfNFeDetImpostoICMS))>
        <Xml.Serialization.XmlElementAttribute("II", GetType(TNFeInfNFeDetImpostoII))>
        <Xml.Serialization.XmlElementAttribute("IPI", GetType(TIpi))>
        <Xml.Serialization.XmlElementAttribute("ISSQN", GetType(TNFeInfNFeDetImpostoISSQN))>
        Public Property Items As Object()
            Get
                Return itemsField
            End Get
            Set(ByVal value As Object())
                itemsField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property PIS As TNFeInfNFeDetImpostoPIS
            Get
                Return pISField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoPIS)
                pISField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property PISST As TNFeInfNFeDetImpostoPISST
            Get
                Return pISSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoPISST)
                pISSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property COFINS As TNFeInfNFeDetImpostoCOFINS
            Get
                Return cOFINSField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoCOFINS)
                cOFINSField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property COFINSST As TNFeInfNFeDetImpostoCOFINSST
            Get
                Return cOFINSSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoCOFINSST)
                cOFINSSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property ICMSUFDest As TNFeInfNFeDetImpostoICMSUFDest
            Get
                Return iCMSUFDestField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSUFDest)
                iCMSUFDestField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMS
        Private itemField As Object

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("ICMS00", GetType(TNFeInfNFeDetImpostoICMSICMS00))>
        <Xml.Serialization.XmlElementAttribute("ICMS10", GetType(TNFeInfNFeDetImpostoICMSICMS10))>
        <Xml.Serialization.XmlElementAttribute("ICMS20", GetType(TNFeInfNFeDetImpostoICMSICMS20))>
        <Xml.Serialization.XmlElementAttribute("ICMS30", GetType(TNFeInfNFeDetImpostoICMSICMS30))>
        <Xml.Serialization.XmlElementAttribute("ICMS40", GetType(TNFeInfNFeDetImpostoICMSICMS40))>
        <Xml.Serialization.XmlElementAttribute("ICMS51", GetType(TNFeInfNFeDetImpostoICMSICMS51))>
        <Xml.Serialization.XmlElementAttribute("ICMS60", GetType(TNFeInfNFeDetImpostoICMSICMS60))>
        <Xml.Serialization.XmlElementAttribute("ICMS70", GetType(TNFeInfNFeDetImpostoICMSICMS70))>
        <Xml.Serialization.XmlElementAttribute("ICMS90", GetType(TNFeInfNFeDetImpostoICMSICMS90))>
        <Xml.Serialization.XmlElementAttribute("ICMSPart", GetType(TNFeInfNFeDetImpostoICMSICMSPart))>
        <Xml.Serialization.XmlElementAttribute("ICMSSN101", GetType(TNFeInfNFeDetImpostoICMSICMSSN101))>
        <Xml.Serialization.XmlElementAttribute("ICMSSN102", GetType(TNFeInfNFeDetImpostoICMSICMSSN102))>
        <Xml.Serialization.XmlElementAttribute("ICMSSN201", GetType(TNFeInfNFeDetImpostoICMSICMSSN201))>
        <Xml.Serialization.XmlElementAttribute("ICMSSN202", GetType(TNFeInfNFeDetImpostoICMSICMSSN202))>
        <Xml.Serialization.XmlElementAttribute("ICMSSN500", GetType(TNFeInfNFeDetImpostoICMSICMSSN500))>
        <Xml.Serialization.XmlElementAttribute("ICMSSN900", GetType(TNFeInfNFeDetImpostoICMSICMSSN900))>
        <Xml.Serialization.XmlElementAttribute("ICMSST", GetType(TNFeInfNFeDetImpostoICMSICMSST))>
        Public Property Item As Object
            Get
                Return itemField
            End Get
            Set(ByVal value As Object)
                itemField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMS00
        Private origField As Torig
        Private cSTField As TNFeInfNFeDetImpostoICMSICMS00CST
        Private modBCField As TNFeInfNFeDetImpostoICMSICMS00ModBC
        Private vBCField As String
        Private pICMSField As String
        Private vICMSField As String
        Private pFCPField As String
        Private vFCPField As String

        ''' <remarks/>
        Public Property orig As Torig
            Get
                Return origField
            End Get
            Set(ByVal value As Torig)
                origField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CST As TNFeInfNFeDetImpostoICMSICMS00CST
            Get
                Return cSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMS00CST)
                cSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property modBC As TNFeInfNFeDetImpostoICMSICMS00ModBC
            Get
                Return modBCField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMS00ModBC)
                modBCField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBC As String
            Get
                Return vBCField
            End Get
            Set(ByVal value As String)
                vBCField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pICMS As String
            Get
                Return pICMSField
            End Get
            Set(ByVal value As String)
                pICMSField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMS As String
            Get
                Return vICMSField
            End Get
            Set(ByVal value As String)
                vICMSField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pFCP As String
            Get
                Return pFCPField
            End Get
            Set(ByVal value As String)
                pFCPField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vFCP As String
            Get
                Return vFCPField
            End Get
            Set(ByVal value As String)
                vFCPField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum Torig

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("4")>
        Item4

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("5")>
        Item5

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("6")>
        Item6

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("7")>
        Item7

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("8")>
        Item8
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS00CST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("00")>
        Item00
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS00ModBC

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMS10
        Private origField As Torig
        Private cSTField As TNFeInfNFeDetImpostoICMSICMS10CST
        Private modBCField As TNFeInfNFeDetImpostoICMSICMS10ModBC
        Private vBCField As String
        Private pICMSField As String
        Private vICMSField As String
        Private vBCFCPField As String
        Private pFCPField As String
        Private vFCPField As String
        Private modBCSTField As TNFeInfNFeDetImpostoICMSICMS10ModBCST
        Private pMVASTField As String
        Private pRedBCSTField As String
        Private vBCSTField As String
        Private pICMSSTField As String
        Private vICMSSTField As String
        Private vBCFCPSTField As String
        Private pFCPSTField As String
        Private vFCPSTField As String
        Private vICMSSTDesonField As String
        Private motDesICMSSTField As TNFeInfNFeDetImpostoICMSICMS10MotDesICMSST

        ''' <remarks/>
        Public Property orig As Torig
            Get
                Return origField
            End Get
            Set(ByVal value As Torig)
                origField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CST As TNFeInfNFeDetImpostoICMSICMS10CST
            Get
                Return cSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMS10CST)
                cSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property modBC As TNFeInfNFeDetImpostoICMSICMS10ModBC
            Get
                Return modBCField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMS10ModBC)
                modBCField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBC As String
            Get
                Return vBCField
            End Get
            Set(ByVal value As String)
                vBCField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pICMS As String
            Get
                Return pICMSField
            End Get
            Set(ByVal value As String)
                pICMSField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMS As String
            Get
                Return vICMSField
            End Get
            Set(ByVal value As String)
                vICMSField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCFCP As String
            Get
                Return vBCFCPField
            End Get
            Set(ByVal value As String)
                vBCFCPField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pFCP As String
            Get
                Return pFCPField
            End Get
            Set(ByVal value As String)
                pFCPField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vFCP As String
            Get
                Return vFCPField
            End Get
            Set(ByVal value As String)
                vFCPField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property modBCST As TNFeInfNFeDetImpostoICMSICMS10ModBCST
            Get
                Return modBCSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMS10ModBCST)
                modBCSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pMVAST As String
            Get
                Return pMVASTField
            End Get
            Set(ByVal value As String)
                pMVASTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pRedBCST As String
            Get
                Return pRedBCSTField
            End Get
            Set(ByVal value As String)
                pRedBCSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCST As String
            Get
                Return vBCSTField
            End Get
            Set(ByVal value As String)
                vBCSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pICMSST As String
            Get
                Return pICMSSTField
            End Get
            Set(ByVal value As String)
                pICMSSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSST As String
            Get
                Return vICMSSTField
            End Get
            Set(ByVal value As String)
                vICMSSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCFCPST As String
            Get
                Return vBCFCPSTField
            End Get
            Set(ByVal value As String)
                vBCFCPSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pFCPST As String
            Get
                Return pFCPSTField
            End Get
            Set(ByVal value As String)
                pFCPSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vFCPST As String
            Get
                Return vFCPSTField
            End Get
            Set(ByVal value As String)
                vFCPSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSSTDeson As String
            Get
                Return vICMSSTDesonField
            End Get
            Set(ByVal value As String)
                vICMSSTDesonField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property motDesICMSST As TNFeInfNFeDetImpostoICMSICMS10MotDesICMSST
            Get
                Return motDesICMSSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMS10MotDesICMSST)
                motDesICMSSTField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS10CST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("10")>
        Item10
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS10ModBC

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS10ModBCST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("4")>
        Item4

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("5")>
        Item5

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("6")>
        Item6
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS10MotDesICMSST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("9")>
        Item9

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("12")>
        Item12
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMS20
        Private origField As Torig
        Private cSTField As TNFeInfNFeDetImpostoICMSICMS20CST
        Private modBCField As TNFeInfNFeDetImpostoICMSICMS20ModBC
        Private pRedBCField As String
        Private vBCField As String
        Private pICMSField As String
        Private vICMSField As String
        Private vBCFCPField As String
        Private pFCPField As String
        Private vFCPField As String
        Private vICMSDesonField As String
        Private motDesICMSField As TNFeInfNFeDetImpostoICMSICMS20MotDesICMS

        ''' <remarks/>
        Public Property orig As Torig
            Get
                Return origField
            End Get
            Set(ByVal value As Torig)
                origField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CST As TNFeInfNFeDetImpostoICMSICMS20CST
            Get
                Return cSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMS20CST)
                cSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property modBC As TNFeInfNFeDetImpostoICMSICMS20ModBC
            Get
                Return modBCField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMS20ModBC)
                modBCField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pRedBC As String
            Get
                Return pRedBCField
            End Get
            Set(ByVal value As String)
                pRedBCField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBC As String
            Get
                Return vBCField
            End Get
            Set(ByVal value As String)
                vBCField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pICMS As String
            Get
                Return pICMSField
            End Get
            Set(ByVal value As String)
                pICMSField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMS As String
            Get
                Return vICMSField
            End Get
            Set(ByVal value As String)
                vICMSField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCFCP As String
            Get
                Return vBCFCPField
            End Get
            Set(ByVal value As String)
                vBCFCPField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pFCP As String
            Get
                Return pFCPField
            End Get
            Set(ByVal value As String)
                pFCPField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vFCP As String
            Get
                Return vFCPField
            End Get
            Set(ByVal value As String)
                vFCPField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSDeson As String
            Get
                Return vICMSDesonField
            End Get
            Set(ByVal value As String)
                vICMSDesonField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property motDesICMS As TNFeInfNFeDetImpostoICMSICMS20MotDesICMS
            Get
                Return motDesICMSField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMS20MotDesICMS)
                motDesICMSField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS20CST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("20")>
        Item20
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS20ModBC

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS20MotDesICMS

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("9")>
        Item9

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("12")>
        Item12
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMS30
        Private origField As Torig
        Private cSTField As TNFeInfNFeDetImpostoICMSICMS30CST
        Private modBCSTField As TNFeInfNFeDetImpostoICMSICMS30ModBCST
        Private pMVASTField As String
        Private pRedBCSTField As String
        Private vBCSTField As String
        Private pICMSSTField As String
        Private vICMSSTField As String
        Private vBCFCPSTField As String
        Private pFCPSTField As String
        Private vFCPSTField As String
        Private vICMSDesonField As String
        Private motDesICMSField As TNFeInfNFeDetImpostoICMSICMS30MotDesICMS

        ''' <remarks/>
        Public Property orig As Torig
            Get
                Return origField
            End Get
            Set(ByVal value As Torig)
                origField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CST As TNFeInfNFeDetImpostoICMSICMS30CST
            Get
                Return cSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMS30CST)
                cSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property modBCST As TNFeInfNFeDetImpostoICMSICMS30ModBCST
            Get
                Return modBCSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMS30ModBCST)
                modBCSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pMVAST As String
            Get
                Return pMVASTField
            End Get
            Set(ByVal value As String)
                pMVASTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pRedBCST As String
            Get
                Return pRedBCSTField
            End Get
            Set(ByVal value As String)
                pRedBCSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCST As String
            Get
                Return vBCSTField
            End Get
            Set(ByVal value As String)
                vBCSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pICMSST As String
            Get
                Return pICMSSTField
            End Get
            Set(ByVal value As String)
                pICMSSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSST As String
            Get
                Return vICMSSTField
            End Get
            Set(ByVal value As String)
                vICMSSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCFCPST As String
            Get
                Return vBCFCPSTField
            End Get
            Set(ByVal value As String)
                vBCFCPSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pFCPST As String
            Get
                Return pFCPSTField
            End Get
            Set(ByVal value As String)
                pFCPSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vFCPST As String
            Get
                Return vFCPSTField
            End Get
            Set(ByVal value As String)
                vFCPSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSDeson As String
            Get
                Return vICMSDesonField
            End Get
            Set(ByVal value As String)
                vICMSDesonField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property motDesICMS As TNFeInfNFeDetImpostoICMSICMS30MotDesICMS
            Get
                Return motDesICMSField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMS30MotDesICMS)
                motDesICMSField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS30CST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("30")>
        Item30
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS30ModBCST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("4")>
        Item4

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("5")>
        Item5

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("6")>
        Item6
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS30MotDesICMS

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("6")>
        Item6

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("7")>
        Item7

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("9")>
        Item9
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMS40
        Private origField As Torig
        Private cSTField As TNFeInfNFeDetImpostoICMSICMS40CST
        Private vICMSDesonField As String
        Private motDesICMSField As TNFeInfNFeDetImpostoICMSICMS40MotDesICMS

        ''' <remarks/>
        Public Property orig As Torig
            Get
                Return origField
            End Get
            Set(ByVal value As Torig)
                origField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CST As TNFeInfNFeDetImpostoICMSICMS40CST
            Get
                Return cSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMS40CST)
                cSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSDeson As String
            Get
                Return vICMSDesonField
            End Get
            Set(ByVal value As String)
                vICMSDesonField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property motDesICMS As TNFeInfNFeDetImpostoICMSICMS40MotDesICMS
            Get
                Return motDesICMSField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMS40MotDesICMS)
                motDesICMSField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS40CST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("40")>
        Item40

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("41")>
        Item41

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("50")>
        Item50
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS40MotDesICMS

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("4")>
        Item4

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("5")>
        Item5

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("6")>
        Item6

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("7")>
        Item7

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("8")>
        Item8

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("9")>
        Item9

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("10")>
        Item10

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("11")>
        Item11

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("16")>
        Item16

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("90")>
        Item90
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMS51
        Private origField As Torig
        Private cSTField As TNFeInfNFeDetImpostoICMSICMS51CST
        Private modBCField As TNFeInfNFeDetImpostoICMSICMS51ModBC
        Private modBCFieldSpecified As Boolean
        Private pRedBCField As String
        Private vBCField As String
        Private pICMSField As String
        Private vICMSOpField As String
        Private pDifField As String
        Private vICMSDifField As String
        Private vICMSField As String
        Private vBCFCPField As String
        Private pFCPField As String
        Private vFCPField As String
        Private pFCPDifField As String
        Private vFCPDifField As String
        Private vFCPEfetField As String

        ''' <remarks/>
        Public Property orig As Torig
            Get
                Return origField
            End Get
            Set(ByVal value As Torig)
                origField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CST As TNFeInfNFeDetImpostoICMSICMS51CST
            Get
                Return cSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMS51CST)
                cSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property modBC As TNFeInfNFeDetImpostoICMSICMS51ModBC
            Get
                Return modBCField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMS51ModBC)
                modBCField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlIgnoreAttribute()>
        Public Property modBCSpecified As Boolean
            Get
                Return modBCFieldSpecified
            End Get
            Set(ByVal value As Boolean)
                modBCFieldSpecified = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pRedBC As String
            Get
                Return pRedBCField
            End Get
            Set(ByVal value As String)
                pRedBCField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBC As String
            Get
                Return vBCField
            End Get
            Set(ByVal value As String)
                vBCField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pICMS As String
            Get
                Return pICMSField
            End Get
            Set(ByVal value As String)
                pICMSField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSOp As String
            Get
                Return vICMSOpField
            End Get
            Set(ByVal value As String)
                vICMSOpField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pDif As String
            Get
                Return pDifField
            End Get
            Set(ByVal value As String)
                pDifField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSDif As String
            Get
                Return vICMSDifField
            End Get
            Set(ByVal value As String)
                vICMSDifField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMS As String
            Get
                Return vICMSField
            End Get
            Set(ByVal value As String)
                vICMSField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCFCP As String
            Get
                Return vBCFCPField
            End Get
            Set(ByVal value As String)
                vBCFCPField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pFCP As String
            Get
                Return pFCPField
            End Get
            Set(ByVal value As String)
                pFCPField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vFCP As String
            Get
                Return vFCPField
            End Get
            Set(ByVal value As String)
                vFCPField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pFCPDif As String
            Get
                Return pFCPDifField
            End Get
            Set(ByVal value As String)
                pFCPDifField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vFCPDif As String
            Get
                Return vFCPDifField
            End Get
            Set(ByVal value As String)
                vFCPDifField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vFCPEfet As String
            Get
                Return vFCPEfetField
            End Get
            Set(ByVal value As String)
                vFCPEfetField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS51CST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("51")>
        Item51
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS51ModBC

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMS60
        Private origField As Torig
        Private cSTField As TNFeInfNFeDetImpostoICMSICMS60CST
        Private vBCSTRetField As String
        Private pSTField As String
        Private vICMSSubstitutoField As String
        Private vICMSSTRetField As String
        Private vBCFCPSTRetField As String
        Private pFCPSTRetField As String
        Private vFCPSTRetField As String
        Private pRedBCEfetField As String
        Private vBCEfetField As String
        Private pICMSEfetField As String
        Private vICMSEfetField As String

        ''' <remarks/>
        Public Property orig As Torig
            Get
                Return origField
            End Get
            Set(ByVal value As Torig)
                origField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CST As TNFeInfNFeDetImpostoICMSICMS60CST
            Get
                Return cSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMS60CST)
                cSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCSTRet As String
            Get
                Return vBCSTRetField
            End Get
            Set(ByVal value As String)
                vBCSTRetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pST As String
            Get
                Return pSTField
            End Get
            Set(ByVal value As String)
                pSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSSubstituto As String
            Get
                Return vICMSSubstitutoField
            End Get
            Set(ByVal value As String)
                vICMSSubstitutoField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSSTRet As String
            Get
                Return vICMSSTRetField
            End Get
            Set(ByVal value As String)
                vICMSSTRetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCFCPSTRet As String
            Get
                Return vBCFCPSTRetField
            End Get
            Set(ByVal value As String)
                vBCFCPSTRetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pFCPSTRet As String
            Get
                Return pFCPSTRetField
            End Get
            Set(ByVal value As String)
                pFCPSTRetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vFCPSTRet As String
            Get
                Return vFCPSTRetField
            End Get
            Set(ByVal value As String)
                vFCPSTRetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pRedBCEfet As String
            Get
                Return pRedBCEfetField
            End Get
            Set(ByVal value As String)
                pRedBCEfetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCEfet As String
            Get
                Return vBCEfetField
            End Get
            Set(ByVal value As String)
                vBCEfetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pICMSEfet As String
            Get
                Return pICMSEfetField
            End Get
            Set(ByVal value As String)
                pICMSEfetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSEfet As String
            Get
                Return vICMSEfetField
            End Get
            Set(ByVal value As String)
                vICMSEfetField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS60CST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("60")>
        Item60
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMS70
        Private origField As Torig
        Private cSTField As TNFeInfNFeDetImpostoICMSICMS70CST
        Private modBCField As TNFeInfNFeDetImpostoICMSICMS70ModBC
        Private pRedBCField As String
        Private vBCField As String
        Private pICMSField As String
        Private vICMSField As String
        Private vBCFCPField As String
        Private pFCPField As String
        Private vFCPField As String
        Private modBCSTField As TNFeInfNFeDetImpostoICMSICMS70ModBCST
        Private pMVASTField As String
        Private pRedBCSTField As String
        Private vBCSTField As String
        Private pICMSSTField As String
        Private vICMSSTField As String
        Private vBCFCPSTField As String
        Private pFCPSTField As String
        Private vFCPSTField As String
        Private vICMSDesonField As String
        Private motDesICMSField As TNFeInfNFeDetImpostoICMSICMS70MotDesICMS
        Private vICMSSTDesonField As String
        Private motDesICMSSTField As TNFeInfNFeDetImpostoICMSICMS70MotDesICMSST

        ''' <remarks/>
        Public Property orig As Torig
            Get
                Return origField
            End Get
            Set(ByVal value As Torig)
                origField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CST As TNFeInfNFeDetImpostoICMSICMS70CST
            Get
                Return cSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMS70CST)
                cSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property modBC As TNFeInfNFeDetImpostoICMSICMS70ModBC
            Get
                Return modBCField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMS70ModBC)
                modBCField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pRedBC As String
            Get
                Return pRedBCField
            End Get
            Set(ByVal value As String)
                pRedBCField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBC As String
            Get
                Return vBCField
            End Get
            Set(ByVal value As String)
                vBCField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pICMS As String
            Get
                Return pICMSField
            End Get
            Set(ByVal value As String)
                pICMSField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMS As String
            Get
                Return vICMSField
            End Get
            Set(ByVal value As String)
                vICMSField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCFCP As String
            Get
                Return vBCFCPField
            End Get
            Set(ByVal value As String)
                vBCFCPField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pFCP As String
            Get
                Return pFCPField
            End Get
            Set(ByVal value As String)
                pFCPField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vFCP As String
            Get
                Return vFCPField
            End Get
            Set(ByVal value As String)
                vFCPField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property modBCST As TNFeInfNFeDetImpostoICMSICMS70ModBCST
            Get
                Return modBCSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMS70ModBCST)
                modBCSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pMVAST As String
            Get
                Return pMVASTField
            End Get
            Set(ByVal value As String)
                pMVASTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pRedBCST As String
            Get
                Return pRedBCSTField
            End Get
            Set(ByVal value As String)
                pRedBCSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCST As String
            Get
                Return vBCSTField
            End Get
            Set(ByVal value As String)
                vBCSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pICMSST As String
            Get
                Return pICMSSTField
            End Get
            Set(ByVal value As String)
                pICMSSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSST As String
            Get
                Return vICMSSTField
            End Get
            Set(ByVal value As String)
                vICMSSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCFCPST As String
            Get
                Return vBCFCPSTField
            End Get
            Set(ByVal value As String)
                vBCFCPSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pFCPST As String
            Get
                Return pFCPSTField
            End Get
            Set(ByVal value As String)
                pFCPSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vFCPST As String
            Get
                Return vFCPSTField
            End Get
            Set(ByVal value As String)
                vFCPSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSDeson As String
            Get
                Return vICMSDesonField
            End Get
            Set(ByVal value As String)
                vICMSDesonField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property motDesICMS As TNFeInfNFeDetImpostoICMSICMS70MotDesICMS
            Get
                Return motDesICMSField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMS70MotDesICMS)
                motDesICMSField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSSTDeson As String
            Get
                Return vICMSSTDesonField
            End Get
            Set(ByVal value As String)
                vICMSSTDesonField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property motDesICMSST As TNFeInfNFeDetImpostoICMSICMS70MotDesICMSST
            Get
                Return motDesICMSSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMS70MotDesICMSST)
                motDesICMSSTField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS70CST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("70")>
        Item70
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS70ModBC

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS70ModBCST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("4")>
        Item4

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("5")>
        Item5

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("6")>
        Item6
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS70MotDesICMS

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("9")>
        Item9

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("12")>
        Item12
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS70MotDesICMSST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("9")>
        Item9

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("12")>
        Item12
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMS90
        Private origField As Torig
        Private cSTField As TNFeInfNFeDetImpostoICMSICMS90CST
        Private modBCField As TNFeInfNFeDetImpostoICMSICMS90ModBC
        Private vBCField As String
        Private pRedBCField As String
        Private pICMSField As String
        Private vICMSField As String
        Private vBCFCPField As String
        Private pFCPField As String
        Private vFCPField As String
        Private modBCSTField As TNFeInfNFeDetImpostoICMSICMS90ModBCST
        Private pMVASTField As String
        Private pRedBCSTField As String
        Private vBCSTField As String
        Private pICMSSTField As String
        Private vICMSSTField As String
        Private vBCFCPSTField As String
        Private pFCPSTField As String
        Private vFCPSTField As String
        Private vICMSDesonField As String
        Private motDesICMSField As TNFeInfNFeDetImpostoICMSICMS90MotDesICMS
        Private vICMSSTDesonField As String
        Private motDesICMSSTField As TNFeInfNFeDetImpostoICMSICMS90MotDesICMSST

        ''' <remarks/>
        Public Property orig As Torig
            Get
                Return origField
            End Get
            Set(ByVal value As Torig)
                origField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CST As TNFeInfNFeDetImpostoICMSICMS90CST
            Get
                Return cSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMS90CST)
                cSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property modBC As TNFeInfNFeDetImpostoICMSICMS90ModBC
            Get
                Return modBCField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMS90ModBC)
                modBCField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBC As String
            Get
                Return vBCField
            End Get
            Set(ByVal value As String)
                vBCField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pRedBC As String
            Get
                Return pRedBCField
            End Get
            Set(ByVal value As String)
                pRedBCField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pICMS As String
            Get
                Return pICMSField
            End Get
            Set(ByVal value As String)
                pICMSField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMS As String
            Get
                Return vICMSField
            End Get
            Set(ByVal value As String)
                vICMSField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCFCP As String
            Get
                Return vBCFCPField
            End Get
            Set(ByVal value As String)
                vBCFCPField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pFCP As String
            Get
                Return pFCPField
            End Get
            Set(ByVal value As String)
                pFCPField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vFCP As String
            Get
                Return vFCPField
            End Get
            Set(ByVal value As String)
                vFCPField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property modBCST As TNFeInfNFeDetImpostoICMSICMS90ModBCST
            Get
                Return modBCSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMS90ModBCST)
                modBCSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pMVAST As String
            Get
                Return pMVASTField
            End Get
            Set(ByVal value As String)
                pMVASTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pRedBCST As String
            Get
                Return pRedBCSTField
            End Get
            Set(ByVal value As String)
                pRedBCSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCST As String
            Get
                Return vBCSTField
            End Get
            Set(ByVal value As String)
                vBCSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pICMSST As String
            Get
                Return pICMSSTField
            End Get
            Set(ByVal value As String)
                pICMSSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSST As String
            Get
                Return vICMSSTField
            End Get
            Set(ByVal value As String)
                vICMSSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCFCPST As String
            Get
                Return vBCFCPSTField
            End Get
            Set(ByVal value As String)
                vBCFCPSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pFCPST As String
            Get
                Return pFCPSTField
            End Get
            Set(ByVal value As String)
                pFCPSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vFCPST As String
            Get
                Return vFCPSTField
            End Get
            Set(ByVal value As String)
                vFCPSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSDeson As String
            Get
                Return vICMSDesonField
            End Get
            Set(ByVal value As String)
                vICMSDesonField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property motDesICMS As TNFeInfNFeDetImpostoICMSICMS90MotDesICMS
            Get
                Return motDesICMSField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMS90MotDesICMS)
                motDesICMSField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSSTDeson As String
            Get
                Return vICMSSTDesonField
            End Get
            Set(ByVal value As String)
                vICMSSTDesonField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property motDesICMSST As TNFeInfNFeDetImpostoICMSICMS90MotDesICMSST
            Get
                Return motDesICMSSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMS90MotDesICMSST)
                motDesICMSSTField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS90CST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("90")>
        Item90
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS90ModBC

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS90ModBCST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("4")>
        Item4

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("5")>
        Item5

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("6")>
        Item6
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS90MotDesICMS

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("9")>
        Item9

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("12")>
        Item12
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS90MotDesICMSST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("9")>
        Item9

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("12")>
        Item12
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMSPart
        Private origField As Torig
        Private cSTField As TNFeInfNFeDetImpostoICMSICMSPartCST
        Private modBCField As TNFeInfNFeDetImpostoICMSICMSPartModBC
        Private vBCField As String
        Private pRedBCField As String
        Private pICMSField As String
        Private vICMSField As String
        Private modBCSTField As TNFeInfNFeDetImpostoICMSICMSPartModBCST
        Private pMVASTField As String
        Private pRedBCSTField As String
        Private vBCSTField As String
        Private pICMSSTField As String
        Private vICMSSTField As String
        Private pBCOpField As String
        Private uFSTField As TUf

        ''' <remarks/>
        Public Property orig As Torig
            Get
                Return origField
            End Get
            Set(ByVal value As Torig)
                origField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CST As TNFeInfNFeDetImpostoICMSICMSPartCST
            Get
                Return cSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMSPartCST)
                cSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property modBC As TNFeInfNFeDetImpostoICMSICMSPartModBC
            Get
                Return modBCField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMSPartModBC)
                modBCField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBC As String
            Get
                Return vBCField
            End Get
            Set(ByVal value As String)
                vBCField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pRedBC As String
            Get
                Return pRedBCField
            End Get
            Set(ByVal value As String)
                pRedBCField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pICMS As String
            Get
                Return pICMSField
            End Get
            Set(ByVal value As String)
                pICMSField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMS As String
            Get
                Return vICMSField
            End Get
            Set(ByVal value As String)
                vICMSField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property modBCST As TNFeInfNFeDetImpostoICMSICMSPartModBCST
            Get
                Return modBCSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMSPartModBCST)
                modBCSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pMVAST As String
            Get
                Return pMVASTField
            End Get
            Set(ByVal value As String)
                pMVASTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pRedBCST As String
            Get
                Return pRedBCSTField
            End Get
            Set(ByVal value As String)
                pRedBCSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCST As String
            Get
                Return vBCSTField
            End Get
            Set(ByVal value As String)
                vBCSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pICMSST As String
            Get
                Return pICMSSTField
            End Get
            Set(ByVal value As String)
                pICMSSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSST As String
            Get
                Return vICMSSTField
            End Get
            Set(ByVal value As String)
                vICMSSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pBCOp As String
            Get
                Return pBCOpField
            End Get
            Set(ByVal value As String)
                pBCOpField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property UFST As TUf
            Get
                Return uFSTField
            End Get
            Set(ByVal value As TUf)
                uFSTField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMSPartCST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("10")>
        Item10

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("90")>
        Item90
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMSPartModBC

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMSPartModBCST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("4")>
        Item4

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("5")>
        Item5

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("6")>
        Item6
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMSSN101
        Private origField As Torig
        Private cSOSNField As TNFeInfNFeDetImpostoICMSICMSSN101CSOSN
        Private pCredSNField As String
        Private vCredICMSSNField As String

        ''' <remarks/>
        Public Property orig As Torig
            Get
                Return origField
            End Get
            Set(ByVal value As Torig)
                origField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CSOSN As TNFeInfNFeDetImpostoICMSICMSSN101CSOSN
            Get
                Return cSOSNField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMSSN101CSOSN)
                cSOSNField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pCredSN As String
            Get
                Return pCredSNField
            End Get
            Set(ByVal value As String)
                pCredSNField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vCredICMSSN As String
            Get
                Return vCredICMSSNField
            End Get
            Set(ByVal value As String)
                vCredICMSSNField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMSSN101CSOSN

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("101")>
        Item101
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMSSN102
        Private origField As Torig
        Private cSOSNField As TNFeInfNFeDetImpostoICMSICMSSN102CSOSN

        ''' <remarks/>
        Public Property orig As Torig
            Get
                Return origField
            End Get
            Set(ByVal value As Torig)
                origField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CSOSN As TNFeInfNFeDetImpostoICMSICMSSN102CSOSN
            Get
                Return cSOSNField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMSSN102CSOSN)
                cSOSNField = value
            End Set
        End Property

        'Public Shared Narrowing Operator CType(v As Object) As TNFeInfNFeDetImpostoICMSICMSSN102
        'Throw New NotImplementedException()
        'End Operator
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMSSN102CSOSN

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("102")>
        Item102

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("103")>
        Item103

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("300")>
        Item300

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("400")>
        Item400
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMSSN201
        Private origField As Torig
        Private cSOSNField As TNFeInfNFeDetImpostoICMSICMSSN201CSOSN
        Private modBCSTField As TNFeInfNFeDetImpostoICMSICMSSN201ModBCST
        Private pMVASTField As String
        Private pRedBCSTField As String
        Private vBCSTField As String
        Private pICMSSTField As String
        Private vICMSSTField As String
        Private vBCFCPSTField As String
        Private pFCPSTField As String
        Private vFCPSTField As String
        Private pCredSNField As String
        Private vCredICMSSNField As String

        ''' <remarks/>
        Public Property orig As Torig
            Get
                Return origField
            End Get
            Set(ByVal value As Torig)
                origField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CSOSN As TNFeInfNFeDetImpostoICMSICMSSN201CSOSN
            Get
                Return cSOSNField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMSSN201CSOSN)
                cSOSNField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property modBCST As TNFeInfNFeDetImpostoICMSICMSSN201ModBCST
            Get
                Return modBCSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMSSN201ModBCST)
                modBCSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pMVAST As String
            Get
                Return pMVASTField
            End Get
            Set(ByVal value As String)
                pMVASTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pRedBCST As String
            Get
                Return pRedBCSTField
            End Get
            Set(ByVal value As String)
                pRedBCSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCST As String
            Get
                Return vBCSTField
            End Get
            Set(ByVal value As String)
                vBCSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pICMSST As String
            Get
                Return pICMSSTField
            End Get
            Set(ByVal value As String)
                pICMSSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSST As String
            Get
                Return vICMSSTField
            End Get
            Set(ByVal value As String)
                vICMSSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCFCPST As String
            Get
                Return vBCFCPSTField
            End Get
            Set(ByVal value As String)
                vBCFCPSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pFCPST As String
            Get
                Return pFCPSTField
            End Get
            Set(ByVal value As String)
                pFCPSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vFCPST As String
            Get
                Return vFCPSTField
            End Get
            Set(ByVal value As String)
                vFCPSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pCredSN As String
            Get
                Return pCredSNField
            End Get
            Set(ByVal value As String)
                pCredSNField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vCredICMSSN As String
            Get
                Return vCredICMSSNField
            End Get
            Set(ByVal value As String)
                vCredICMSSNField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMSSN201CSOSN

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("201")>
        Item201
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMSSN201ModBCST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("4")>
        Item4

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("5")>
        Item5

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("6")>
        Item6
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMSSN202
        Private origField As Torig
        Private cSOSNField As TNFeInfNFeDetImpostoICMSICMSSN202CSOSN
        Private modBCSTField As TNFeInfNFeDetImpostoICMSICMSSN202ModBCST
        Private pMVASTField As String
        Private pRedBCSTField As String
        Private vBCSTField As String
        Private pICMSSTField As String
        Private vICMSSTField As String
        Private vBCFCPSTField As String
        Private pFCPSTField As String
        Private vFCPSTField As String

        ''' <remarks/>
        Public Property orig As Torig
            Get
                Return origField
            End Get
            Set(ByVal value As Torig)
                origField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CSOSN As TNFeInfNFeDetImpostoICMSICMSSN202CSOSN
            Get
                Return cSOSNField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMSSN202CSOSN)
                cSOSNField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property modBCST As TNFeInfNFeDetImpostoICMSICMSSN202ModBCST
            Get
                Return modBCSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMSSN202ModBCST)
                modBCSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pMVAST As String
            Get
                Return pMVASTField
            End Get
            Set(ByVal value As String)
                pMVASTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pRedBCST As String
            Get
                Return pRedBCSTField
            End Get
            Set(ByVal value As String)
                pRedBCSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCST As String
            Get
                Return vBCSTField
            End Get
            Set(ByVal value As String)
                vBCSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pICMSST As String
            Get
                Return pICMSSTField
            End Get
            Set(ByVal value As String)
                pICMSSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSST As String
            Get
                Return vICMSSTField
            End Get
            Set(ByVal value As String)
                vICMSSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCFCPST As String
            Get
                Return vBCFCPSTField
            End Get
            Set(ByVal value As String)
                vBCFCPSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pFCPST As String
            Get
                Return pFCPSTField
            End Get
            Set(ByVal value As String)
                pFCPSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vFCPST As String
            Get
                Return vFCPSTField
            End Get
            Set(ByVal value As String)
                vFCPSTField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMSSN202CSOSN

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("202")>
        Item202

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("203")>
        Item203
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMSSN202ModBCST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("4")>
        Item4

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("5")>
        Item5

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("6")>
        Item6
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMSSN500
        Private origField As Torig
        Private cSOSNField As TNFeInfNFeDetImpostoICMSICMSSN500CSOSN
        Private vBCSTRetField As String
        Private pSTField As String
        Private vICMSSubstitutoField As String
        Private vICMSSTRetField As String
        Private vBCFCPSTRetField As String
        Private pFCPSTRetField As String
        Private vFCPSTRetField As String
        Private pRedBCEfetField As String
        Private vBCEfetField As String
        Private pICMSEfetField As String
        Private vICMSEfetField As String

        ''' <remarks/>
        Public Property orig As Torig
            Get
                Return origField
            End Get
            Set(ByVal value As Torig)
                origField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CSOSN As TNFeInfNFeDetImpostoICMSICMSSN500CSOSN
            Get
                Return cSOSNField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMSSN500CSOSN)
                cSOSNField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCSTRet As String
            Get
                Return vBCSTRetField
            End Get
            Set(ByVal value As String)
                vBCSTRetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pST As String
            Get
                Return pSTField
            End Get
            Set(ByVal value As String)
                pSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSSubstituto As String
            Get
                Return vICMSSubstitutoField
            End Get
            Set(ByVal value As String)
                vICMSSubstitutoField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSSTRet As String
            Get
                Return vICMSSTRetField
            End Get
            Set(ByVal value As String)
                vICMSSTRetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCFCPSTRet As String
            Get
                Return vBCFCPSTRetField
            End Get
            Set(ByVal value As String)
                vBCFCPSTRetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pFCPSTRet As String
            Get
                Return pFCPSTRetField
            End Get
            Set(ByVal value As String)
                pFCPSTRetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vFCPSTRet As String
            Get
                Return vFCPSTRetField
            End Get
            Set(ByVal value As String)
                vFCPSTRetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pRedBCEfet As String
            Get
                Return pRedBCEfetField
            End Get
            Set(ByVal value As String)
                pRedBCEfetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCEfet As String
            Get
                Return vBCEfetField
            End Get
            Set(ByVal value As String)
                vBCEfetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pICMSEfet As String
            Get
                Return pICMSEfetField
            End Get
            Set(ByVal value As String)
                pICMSEfetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSEfet As String
            Get
                Return vICMSEfetField
            End Get
            Set(ByVal value As String)
                vICMSEfetField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMSSN500CSOSN

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("500")>
        Item500
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMSSN900
        Private origField As Torig
        Private cSOSNField As TNFeInfNFeDetImpostoICMSICMSSN900CSOSN
        Private modBCField As TNFeInfNFeDetImpostoICMSICMSSN900ModBC
        Private vBCField As String
        Private pRedBCField As String
        Private pICMSField As String
        Private vICMSField As String
        Private modBCSTField As TNFeInfNFeDetImpostoICMSICMSSN900ModBCST
        Private pMVASTField As String
        Private pRedBCSTField As String
        Private vBCSTField As String
        Private pICMSSTField As String
        Private vICMSSTField As String
        Private vBCFCPSTField As String
        Private pFCPSTField As String
        Private vFCPSTField As String
        Private pCredSNField As String
        Private vCredICMSSNField As String

        ''' <remarks/>
        Public Property orig As Torig
            Get
                Return origField
            End Get
            Set(ByVal value As Torig)
                origField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CSOSN As TNFeInfNFeDetImpostoICMSICMSSN900CSOSN
            Get
                Return cSOSNField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMSSN900CSOSN)
                cSOSNField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property modBC As TNFeInfNFeDetImpostoICMSICMSSN900ModBC
            Get
                Return modBCField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMSSN900ModBC)
                modBCField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBC As String
            Get
                Return vBCField
            End Get
            Set(ByVal value As String)
                vBCField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pRedBC As String
            Get
                Return pRedBCField
            End Get
            Set(ByVal value As String)
                pRedBCField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pICMS As String
            Get
                Return pICMSField
            End Get
            Set(ByVal value As String)
                pICMSField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMS As String
            Get
                Return vICMSField
            End Get
            Set(ByVal value As String)
                vICMSField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property modBCST As TNFeInfNFeDetImpostoICMSICMSSN900ModBCST
            Get
                Return modBCSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMSSN900ModBCST)
                modBCSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pMVAST As String
            Get
                Return pMVASTField
            End Get
            Set(ByVal value As String)
                pMVASTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pRedBCST As String
            Get
                Return pRedBCSTField
            End Get
            Set(ByVal value As String)
                pRedBCSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCST As String
            Get
                Return vBCSTField
            End Get
            Set(ByVal value As String)
                vBCSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pICMSST As String
            Get
                Return pICMSSTField
            End Get
            Set(ByVal value As String)
                pICMSSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSST As String
            Get
                Return vICMSSTField
            End Get
            Set(ByVal value As String)
                vICMSSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCFCPST As String
            Get
                Return vBCFCPSTField
            End Get
            Set(ByVal value As String)
                vBCFCPSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pFCPST As String
            Get
                Return pFCPSTField
            End Get
            Set(ByVal value As String)
                pFCPSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vFCPST As String
            Get
                Return vFCPSTField
            End Get
            Set(ByVal value As String)
                vFCPSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pCredSN As String
            Get
                Return pCredSNField
            End Get
            Set(ByVal value As String)
                pCredSNField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vCredICMSSN As String
            Get
                Return vCredICMSSNField
            End Get
            Set(ByVal value As String)
                vCredICMSSNField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMSSN900CSOSN

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("900")>
        Item900
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMSSN900ModBC

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMSSN900ModBCST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("4")>
        Item4

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("5")>
        Item5

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("6")>
        Item6
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMSST
        Private origField As Torig
        Private cSTField As TNFeInfNFeDetImpostoICMSICMSSTCST
        Private vBCSTRetField As String
        Private pSTField As String
        Private vICMSSubstitutoField As String
        Private vICMSSTRetField As String
        Private vBCFCPSTRetField As String
        Private pFCPSTRetField As String
        Private vFCPSTRetField As String
        Private vBCSTDestField As String
        Private vICMSSTDestField As String
        Private pRedBCEfetField As String
        Private vBCEfetField As String
        Private pICMSEfetField As String
        Private vICMSEfetField As String

        ''' <remarks/>
        Public Property orig As Torig
            Get
                Return origField
            End Get
            Set(ByVal value As Torig)
                origField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CST As TNFeInfNFeDetImpostoICMSICMSSTCST
            Get
                Return cSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSICMSSTCST)
                cSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCSTRet As String
            Get
                Return vBCSTRetField
            End Get
            Set(ByVal value As String)
                vBCSTRetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pST As String
            Get
                Return pSTField
            End Get
            Set(ByVal value As String)
                pSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSSubstituto As String
            Get
                Return vICMSSubstitutoField
            End Get
            Set(ByVal value As String)
                vICMSSubstitutoField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSSTRet As String
            Get
                Return vICMSSTRetField
            End Get
            Set(ByVal value As String)
                vICMSSTRetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCFCPSTRet As String
            Get
                Return vBCFCPSTRetField
            End Get
            Set(ByVal value As String)
                vBCFCPSTRetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pFCPSTRet As String
            Get
                Return pFCPSTRetField
            End Get
            Set(ByVal value As String)
                pFCPSTRetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vFCPSTRet As String
            Get
                Return vFCPSTRetField
            End Get
            Set(ByVal value As String)
                vFCPSTRetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCSTDest As String
            Get
                Return vBCSTDestField
            End Get
            Set(ByVal value As String)
                vBCSTDestField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSSTDest As String
            Get
                Return vICMSSTDestField
            End Get
            Set(ByVal value As String)
                vICMSSTDestField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pRedBCEfet As String
            Get
                Return pRedBCEfetField
            End Get
            Set(ByVal value As String)
                pRedBCEfetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCEfet As String
            Get
                Return vBCEfetField
            End Get
            Set(ByVal value As String)
                vBCEfetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pICMSEfet As String
            Get
                Return pICMSEfetField
            End Get
            Set(ByVal value As String)
                pICMSEfetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSEfet As String
            Get
                Return vICMSEfetField
            End Get
            Set(ByVal value As String)
                vICMSEfetField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMSSTCST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("41")>
        Item41

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("60")>
        Item60
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoII
        Private vBCField As String
        Private vDespAduField As String
        Private vIIField As String
        Private vIOFField As String

        ''' <remarks/>
        Public Property vBC As String
            Get
                Return vBCField
            End Get
            Set(ByVal value As String)
                vBCField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vDespAdu As String
            Get
                Return vDespAduField
            End Get
            Set(ByVal value As String)
                vDespAduField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vII As String
            Get
                Return vIIField
            End Get
            Set(ByVal value As String)
                vIIField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vIOF As String
            Get
                Return vIOFField
            End Get
            Set(ByVal value As String)
                vIOFField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TIpi
        Private cNPJProdField As String
        Private cSeloField As String
        Private qSeloField As String
        Private cEnqField As String
        Private itemField As Object

        ''' <remarks/>
        Public Property CNPJProd As String
            Get
                Return cNPJProdField
            End Get
            Set(ByVal value As String)
                cNPJProdField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cSelo As String
            Get
                Return cSeloField
            End Get
            Set(ByVal value As String)
                cSeloField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property qSelo As String
            Get
                Return qSeloField
            End Get
            Set(ByVal value As String)
                qSeloField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cEnq As String
            Get
                Return cEnqField
            End Get
            Set(ByVal value As String)
                cEnqField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("IPINT", GetType(TIpiIPINT))>
        <Xml.Serialization.XmlElementAttribute("IPITrib", GetType(TIpiIPITrib))>
        Public Property Item As Object
            Get
                Return itemField
            End Get
            Set(ByVal value As Object)
                itemField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TIpiIPINT
        Private cSTField As TIpiIPINTCST

        ''' <remarks/>
        Public Property CST As TIpiIPINTCST
            Get
                Return cSTField
            End Get
            Set(ByVal value As TIpiIPINTCST)
                cSTField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TIpiIPINTCST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("01")>
        Item01

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("02")>
        Item02

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("03")>
        Item03

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("04")>
        Item04

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("05")>
        Item05

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("51")>
        Item51

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("52")>
        Item52

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("53")>
        Item53

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("54")>
        Item54

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("55")>
        Item55
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TIpiIPITrib
        Private cSTField As TIpiIPITribCST
        Private itemsField As String()
        Private itemsElementNameField As ItemsChoiceType()
        Private vIPIField As String

        ''' <remarks/>
        Public Property CST As TIpiIPITribCST
            Get
                Return cSTField
            End Get
            Set(ByVal value As TIpiIPITribCST)
                cSTField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("pIPI", GetType(String))>
        <Xml.Serialization.XmlElementAttribute("qUnid", GetType(String))>
        <Xml.Serialization.XmlElementAttribute("vBC", GetType(String))>
        <Xml.Serialization.XmlElementAttribute("vUnid", GetType(String))>
        <Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")>
        Public Property Items As String()
            Get
                Return itemsField
            End Get
            Set(ByVal value As String())
                itemsField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("ItemsElementName")>
        <Xml.Serialization.XmlIgnoreAttribute()>
        Public Property ItemsElementName As ItemsChoiceType()
            Get
                Return itemsElementNameField
            End Get
            Set(ByVal value As ItemsChoiceType())
                itemsElementNameField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vIPI As String
            Get
                Return vIPIField
            End Get
            Set(ByVal value As String)
                vIPIField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TIpiIPITribCST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("00")>
        Item00

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("49")>
        Item49

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("50")>
        Item50

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("99")>
        Item99
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe", IncludeInSchema:=False)>
    Public Enum ItemsChoiceType

        ''' <remarks/>
        pIPI

        ''' <remarks/>
        qUnid

        ''' <remarks/>
        vBC

        ''' <remarks/>
        vUnid
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoISSQN
        Private vBCField As String
        Private vAliqField As String
        Private vISSQNField As String
        Private cMunFGField As String
        Private cListServField As TCListServ
        Private vDeducaoField As String
        Private vOutroField As String
        Private vDescIncondField As String
        Private vDescCondField As String
        Private vISSRetField As String
        Private indISSField As TNFeInfNFeDetImpostoISSQNIndISS
        Private cServicoField As String
        Private cMunField As String
        Private cPaisField As String
        Private nProcessoField As String
        Private indIncentivoField As TNFeInfNFeDetImpostoISSQNIndIncentivo

        ''' <remarks/>
        Public Property vBC As String
            Get
                Return vBCField
            End Get
            Set(ByVal value As String)
                vBCField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vAliq As String
            Get
                Return vAliqField
            End Get
            Set(ByVal value As String)
                vAliqField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vISSQN As String
            Get
                Return vISSQNField
            End Get
            Set(ByVal value As String)
                vISSQNField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cMunFG As String
            Get
                Return cMunFGField
            End Get
            Set(ByVal value As String)
                cMunFGField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cListServ As TCListServ
            Get
                Return cListServField
            End Get
            Set(ByVal value As TCListServ)
                cListServField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vDeducao As String
            Get
                Return vDeducaoField
            End Get
            Set(ByVal value As String)
                vDeducaoField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vOutro As String
            Get
                Return vOutroField
            End Get
            Set(ByVal value As String)
                vOutroField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vDescIncond As String
            Get
                Return vDescIncondField
            End Get
            Set(ByVal value As String)
                vDescIncondField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vDescCond As String
            Get
                Return vDescCondField
            End Get
            Set(ByVal value As String)
                vDescCondField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vISSRet As String
            Get
                Return vISSRetField
            End Get
            Set(ByVal value As String)
                vISSRetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property indISS As TNFeInfNFeDetImpostoISSQNIndISS
            Get
                Return indISSField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoISSQNIndISS)
                indISSField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cServico As String
            Get
                Return cServicoField
            End Get
            Set(ByVal value As String)
                cServicoField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cMun As String
            Get
                Return cMunField
            End Get
            Set(ByVal value As String)
                cMunField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cPais As String
            Get
                Return cPaisField
            End Get
            Set(ByVal value As String)
                cPaisField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property nProcesso As String
            Get
                Return nProcessoField
            End Get
            Set(ByVal value As String)
                nProcessoField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property indIncentivo As TNFeInfNFeDetImpostoISSQNIndIncentivo
            Get
                Return indIncentivoField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoISSQNIndIncentivo)
                indIncentivoField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TCListServ

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("01.01")>
        Item0101

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("01.02")>
        Item0102

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("01.03")>
        Item0103

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("01.04")>
        Item0104

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("01.05")>
        Item0105

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("01.06")>
        Item0106

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("01.07")>
        Item0107

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("01.08")>
        Item0108

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("01.09")>
        Item0109

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("02.01")>
        Item0201

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("03.02")>
        Item0302

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("03.03")>
        Item0303

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("03.04")>
        Item0304

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("03.05")>
        Item0305

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("04.01")>
        Item0401

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("04.02")>
        Item0402

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("04.03")>
        Item0403

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("04.04")>
        Item0404

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("04.05")>
        Item0405

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("04.06")>
        Item0406

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("04.07")>
        Item0407

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("04.08")>
        Item0408

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("04.09")>
        Item0409

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("04.10")>
        Item0410

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("04.11")>
        Item0411

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("04.12")>
        Item0412

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("04.13")>
        Item0413

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("04.14")>
        Item0414

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("04.15")>
        Item0415

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("04.16")>
        Item0416

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("04.17")>
        Item0417

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("04.18")>
        Item0418

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("04.19")>
        Item0419

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("04.20")>
        Item0420

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("04.21")>
        Item0421

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("04.22")>
        Item0422

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("04.23")>
        Item0423

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("05.01")>
        Item0501

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("05.02")>
        Item0502

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("05.03")>
        Item0503

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("05.04")>
        Item0504

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("05.05")>
        Item0505

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("05.06")>
        Item0506

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("05.07")>
        Item0507

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("05.08")>
        Item0508

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("05.09")>
        Item0509

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("06.01")>
        Item0601

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("06.02")>
        Item0602

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("06.03")>
        Item0603

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("06.04")>
        Item0604

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("06.05")>
        Item0605

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("06.06")>
        Item0606

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("07.01")>
        Item0701

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("07.02")>
        Item0702

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("07.03")>
        Item0703

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("07.04")>
        Item0704

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("07.05")>
        Item0705

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("07.06")>
        Item0706

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("07.07")>
        Item0707

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("07.08")>
        Item0708

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("07.09")>
        Item0709

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("07.10")>
        Item0710

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("07.11")>
        Item0711

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("07.12")>
        Item0712

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("07.13")>
        Item0713

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("07.16")>
        Item0716

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("07.17")>
        Item0717

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("07.18")>
        Item0718

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("07.19")>
        Item0719

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("07.20")>
        Item0720

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("07.21")>
        Item0721

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("07.22")>
        Item0722

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("08.01")>
        Item0801

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("08.02")>
        Item0802

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("09.01")>
        Item0901

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("09.02")>
        Item0902

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("09.03")>
        Item0903

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("10.01")>
        Item1001

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("10.02")>
        Item1002

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("10.03")>
        Item1003

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("10.04")>
        Item1004

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("10.05")>
        Item1005

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("10.06")>
        Item1006

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("10.07")>
        Item1007

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("10.08")>
        Item1008

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("10.09")>
        Item1009

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("10.10")>
        Item1010

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("11.01")>
        Item1101

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("11.02")>
        Item1102

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("11.03")>
        Item1103

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("11.04")>
        Item1104

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("12.01")>
        Item1201

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("12.02")>
        Item1202

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("12.03")>
        Item1203

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("12.04")>
        Item1204

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("12.05")>
        Item1205

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("12.06")>
        Item1206

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("12.07")>
        Item1207

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("12.08")>
        Item1208

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("12.09")>
        Item1209

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("12.10")>
        Item1210

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("12.11")>
        Item1211

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("12.12")>
        Item1212

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("12.13")>
        Item1213

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("12.14")>
        Item1214

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("12.15")>
        Item1215

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("12.16")>
        Item1216

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("12.17")>
        Item1217

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("13.02")>
        Item1302

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("13.03")>
        Item1303

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("13.04")>
        Item1304

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("13.05")>
        Item1305

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("14.01")>
        Item1401

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("14.02")>
        Item1402

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("14.03")>
        Item1403

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("14.04")>
        Item1404

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("14.05")>
        Item1405

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("14.06")>
        Item1406

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("14.07")>
        Item1407

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("14.08")>
        Item1408

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("14.09")>
        Item1409

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("14.10")>
        Item1410

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("14.11")>
        Item1411

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("14.12")>
        Item1412

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("14.13")>
        Item1413

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("14.14")>
        Item1414

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("15.01")>
        Item1501

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("15.02")>
        Item1502

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("15.03")>
        Item1503

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("15.04")>
        Item1504

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("15.05")>
        Item1505

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("15.06")>
        Item1506

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("15.07")>
        Item1507

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("15.08")>
        Item1508

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("15.09")>
        Item1509

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("15.10")>
        Item1510

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("15.11")>
        Item1511

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("15.12")>
        Item1512

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("15.13")>
        Item1513

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("15.14")>
        Item1514

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("15.15")>
        Item1515

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("15.16")>
        Item1516

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("15.17")>
        Item1517

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("15.18")>
        Item1518

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("16.01")>
        Item1601

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("16.02")>
        Item1602

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("17.01")>
        Item1701

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("17.02")>
        Item1702

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("17.03")>
        Item1703

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("17.04")>
        Item1704

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("17.05")>
        Item1705

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("17.06")>
        Item1706

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("17.08")>
        Item1708

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("17.09")>
        Item1709

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("17.10")>
        Item1710

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("17.11")>
        Item1711

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("17.12")>
        Item1712

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("17.13")>
        Item1713

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("17.14")>
        Item1714

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("17.15")>
        Item1715

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("17.16")>
        Item1716

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("17.17")>
        Item1717

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("17.18")>
        Item1718

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("17.19")>
        Item1719

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("17.20")>
        Item1720

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("17.21")>
        Item1721

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("17.22")>
        Item1722

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("17.23")>
        Item1723

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("17.24")>
        Item1724

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("17.25")>
        Item1725

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("18.01")>
        Item1801

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("19.01")>
        Item1901

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("20.01")>
        Item2001

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("20.02")>
        Item2002

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("20.03")>
        Item2003

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("21.01")>
        Item2101

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("22.01")>
        Item2201

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("23.01")>
        Item2301

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("24.01")>
        Item2401

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("25.01")>
        Item2501

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("25.02")>
        Item2502

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("25.03")>
        Item2503

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("25.04")>
        Item2504

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("25.05")>
        Item2505

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("26.01")>
        Item2601

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("27.01")>
        Item2701

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("28.01")>
        Item2801

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("29.01")>
        Item2901

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("30.01")>
        Item3001

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("31.01")>
        Item3101

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("32.01")>
        Item3201

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("33.01")>
        Item3301

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("34.01")>
        Item3401

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("35.01")>
        Item3501

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("36.01")>
        Item3601

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("37.01")>
        Item3701

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("38.01")>
        Item3801

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("39.01")>
        Item3901

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("40.01")>
        Item4001
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoISSQNIndISS

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("4")>
        Item4

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("5")>
        Item5

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("6")>
        Item6

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("7")>
        Item7
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoISSQNIndIncentivo

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoPIS
        Private itemField As Object

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("PISAliq", GetType(TNFeInfNFeDetImpostoPISPISAliq))>
        <Xml.Serialization.XmlElementAttribute("PISNT", GetType(TNFeInfNFeDetImpostoPISPISNT))>
        <Xml.Serialization.XmlElementAttribute("PISOutr", GetType(TNFeInfNFeDetImpostoPISPISOutr))>
        <Xml.Serialization.XmlElementAttribute("PISQtde", GetType(TNFeInfNFeDetImpostoPISPISQtde))>
        Public Property Item As Object
            Get
                Return itemField
            End Get
            Set(ByVal value As Object)
                itemField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoPISPISAliq
        Private cSTField As TNFeInfNFeDetImpostoPISPISAliqCST
        Private vBCField As String
        Private pPISField As String
        Private vPISField As String

        ''' <remarks/>
        Public Property CST As TNFeInfNFeDetImpostoPISPISAliqCST
            Get
                Return cSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoPISPISAliqCST)
                cSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBC As String
            Get
                Return vBCField
            End Get
            Set(ByVal value As String)
                vBCField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pPIS As String
            Get
                Return pPISField
            End Get
            Set(ByVal value As String)
                pPISField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vPIS As String
            Get
                Return vPISField
            End Get
            Set(ByVal value As String)
                vPISField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoPISPISAliqCST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("01")>
        Item01

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("02")>
        Item02
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoPISPISNT
        Private cSTField As TNFeInfNFeDetImpostoPISPISNTCST

        ''' <remarks/>
        Public Property CST As TNFeInfNFeDetImpostoPISPISNTCST
            Get
                Return cSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoPISPISNTCST)
                cSTField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoPISPISNTCST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("04")>
        Item04

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("05")>
        Item05

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("06")>
        Item06

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("07")>
        Item07

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("08")>
        Item08

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("09")>
        Item09
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoPISPISOutr
        Private cSTField As TNFeInfNFeDetImpostoPISPISOutrCST
        Private itemsField As String()
        Private itemsElementNameField As ItemsChoiceType1()
        Private vPISField As String

        ''' <remarks/>
        Public Property CST As TNFeInfNFeDetImpostoPISPISOutrCST
            Get
                Return cSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoPISPISOutrCST)
                cSTField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("pPIS", GetType(String))>
        <Xml.Serialization.XmlElementAttribute("qBCProd", GetType(String))>
        <Xml.Serialization.XmlElementAttribute("vAliqProd", GetType(String))>
        <Xml.Serialization.XmlElementAttribute("vBC", GetType(String))>
        <Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")>
        Public Property Items As String()
            Get
                Return itemsField
            End Get
            Set(ByVal value As String())
                itemsField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("ItemsElementName")>
        <Xml.Serialization.XmlIgnoreAttribute()>
        Public Property ItemsElementName As ItemsChoiceType1()
            Get
                Return itemsElementNameField
            End Get
            Set(ByVal value As ItemsChoiceType1())
                itemsElementNameField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vPIS As String
            Get
                Return vPISField
            End Get
            Set(ByVal value As String)
                vPISField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoPISPISOutrCST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("49")>
        Item49

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("50")>
        Item50

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("51")>
        Item51

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("52")>
        Item52

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("53")>
        Item53

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("54")>
        Item54

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("55")>
        Item55

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("56")>
        Item56

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("60")>
        Item60

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("61")>
        Item61

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("62")>
        Item62

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("63")>
        Item63

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("64")>
        Item64

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("65")>
        Item65

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("66")>
        Item66

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("67")>
        Item67

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("70")>
        Item70

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("71")>
        Item71

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("72")>
        Item72

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("73")>
        Item73

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("74")>
        Item74

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("75")>
        Item75

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("98")>
        Item98

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("99")>
        Item99
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe", IncludeInSchema:=False)>
    Public Enum ItemsChoiceType1

        ''' <remarks/>
        pPIS

        ''' <remarks/>
        qBCProd

        ''' <remarks/>
        vAliqProd

        ''' <remarks/>
        vBC
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoPISPISQtde
        Private cSTField As TNFeInfNFeDetImpostoPISPISQtdeCST
        Private qBCProdField As String
        Private vAliqProdField As String
        Private vPISField As String

        ''' <remarks/>
        Public Property CST As TNFeInfNFeDetImpostoPISPISQtdeCST
            Get
                Return cSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoPISPISQtdeCST)
                cSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property qBCProd As String
            Get
                Return qBCProdField
            End Get
            Set(ByVal value As String)
                qBCProdField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vAliqProd As String
            Get
                Return vAliqProdField
            End Get
            Set(ByVal value As String)
                vAliqProdField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vPIS As String
            Get
                Return vPISField
            End Get
            Set(ByVal value As String)
                vPISField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoPISPISQtdeCST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("03")>
        Item03
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoPISST
        Private itemsField As String()
        Private itemsElementNameField As ItemsChoiceType2()
        Private vPISField As String
        Private indSomaPISSTField As TNFeInfNFeDetImpostoPISSTIndSomaPISST
        Private indSomaPISSTFieldSpecified As Boolean

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("pPIS", GetType(String))>
        <Xml.Serialization.XmlElementAttribute("qBCProd", GetType(String))>
        <Xml.Serialization.XmlElementAttribute("vAliqProd", GetType(String))>
        <Xml.Serialization.XmlElementAttribute("vBC", GetType(String))>
        <Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")>
        Public Property Items As String()
            Get
                Return itemsField
            End Get
            Set(ByVal value As String())
                itemsField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("ItemsElementName")>
        <Xml.Serialization.XmlIgnoreAttribute()>
        Public Property ItemsElementName As ItemsChoiceType2()
            Get
                Return itemsElementNameField
            End Get
            Set(ByVal value As ItemsChoiceType2())
                itemsElementNameField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vPIS As String
            Get
                Return vPISField
            End Get
            Set(ByVal value As String)
                vPISField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property indSomaPISST As TNFeInfNFeDetImpostoPISSTIndSomaPISST
            Get
                Return indSomaPISSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoPISSTIndSomaPISST)
                indSomaPISSTField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlIgnoreAttribute()>
        Public Property indSomaPISSTSpecified As Boolean
            Get
                Return indSomaPISSTFieldSpecified
            End Get
            Set(ByVal value As Boolean)
                indSomaPISSTFieldSpecified = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe", IncludeInSchema:=False)>
    Public Enum ItemsChoiceType2

        ''' <remarks/>
        pPIS

        ''' <remarks/>
        qBCProd

        ''' <remarks/>
        vAliqProd

        ''' <remarks/>
        vBC
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoPISSTIndSomaPISST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoCOFINS
        Private itemField As Object

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("COFINSAliq", GetType(TNFeInfNFeDetImpostoCOFINSCOFINSAliq))>
        <Xml.Serialization.XmlElementAttribute("COFINSNT", GetType(TNFeInfNFeDetImpostoCOFINSCOFINSNT))>
        <Xml.Serialization.XmlElementAttribute("COFINSOutr", GetType(TNFeInfNFeDetImpostoCOFINSCOFINSOutr))>
        <Xml.Serialization.XmlElementAttribute("COFINSQtde", GetType(TNFeInfNFeDetImpostoCOFINSCOFINSQtde))>
        Public Property Item As Object
            Get
                Return itemField
            End Get
            Set(ByVal value As Object)
                itemField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoCOFINSCOFINSAliq
        Private cSTField As TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST
        Private vBCField As String
        Private pCOFINSField As String
        Private vCOFINSField As String

        ''' <remarks/>
        Public Property CST As TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST
            Get
                Return cSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST)
                cSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBC As String
            Get
                Return vBCField
            End Get
            Set(ByVal value As String)
                vBCField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pCOFINS As String
            Get
                Return pCOFINSField
            End Get
            Set(ByVal value As String)
                pCOFINSField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vCOFINS As String
            Get
                Return vCOFINSField
            End Get
            Set(ByVal value As String)
                vCOFINSField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("01")>
        Item01

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("02")>
        Item02
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoCOFINSCOFINSNT
        Private cSTField As TNFeInfNFeDetImpostoCOFINSCOFINSNTCST

        ''' <remarks/>
        Public Property CST As TNFeInfNFeDetImpostoCOFINSCOFINSNTCST
            Get
                Return cSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoCOFINSCOFINSNTCST)
                cSTField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoCOFINSCOFINSNTCST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("04")>
        Item04

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("05")>
        Item05

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("06")>
        Item06

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("07")>
        Item07

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("08")>
        Item08

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("09")>
        Item09
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoCOFINSCOFINSOutr
        Private cSTField As TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST
        Private itemsField As String()
        Private itemsElementNameField As ItemsChoiceType3()
        Private vCOFINSField As String

        ''' <remarks/>
        Public Property CST As TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST
            Get
                Return cSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST)
                cSTField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("pCOFINS", GetType(String))>
        <Xml.Serialization.XmlElementAttribute("qBCProd", GetType(String))>
        <Xml.Serialization.XmlElementAttribute("vAliqProd", GetType(String))>
        <Xml.Serialization.XmlElementAttribute("vBC", GetType(String))>
        <Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")>
        Public Property Items As String()
            Get
                Return itemsField
            End Get
            Set(ByVal value As String())
                itemsField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("ItemsElementName")>
        <Xml.Serialization.XmlIgnoreAttribute()>
        Public Property ItemsElementName As ItemsChoiceType3()
            Get
                Return itemsElementNameField
            End Get
            Set(ByVal value As ItemsChoiceType3())
                itemsElementNameField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vCOFINS As String
            Get
                Return vCOFINSField
            End Get
            Set(ByVal value As String)
                vCOFINSField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("49")>
        Item49

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("50")>
        Item50

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("51")>
        Item51

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("52")>
        Item52

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("53")>
        Item53

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("54")>
        Item54

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("55")>
        Item55

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("56")>
        Item56

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("60")>
        Item60

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("61")>
        Item61

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("62")>
        Item62

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("63")>
        Item63

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("64")>
        Item64

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("65")>
        Item65

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("66")>
        Item66

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("67")>
        Item67

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("70")>
        Item70

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("71")>
        Item71

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("72")>
        Item72

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("73")>
        Item73

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("74")>
        Item74

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("75")>
        Item75

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("98")>
        Item98

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("99")>
        Item99
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe", IncludeInSchema:=False)>
    Public Enum ItemsChoiceType3

        ''' <remarks/>
        pCOFINS

        ''' <remarks/>
        qBCProd

        ''' <remarks/>
        vAliqProd

        ''' <remarks/>
        vBC
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoCOFINSCOFINSQtde
        Private cSTField As TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST
        Private qBCProdField As String
        Private vAliqProdField As String
        Private vCOFINSField As String

        ''' <remarks/>
        Public Property CST As TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST
            Get
                Return cSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST)
                cSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property qBCProd As String
            Get
                Return qBCProdField
            End Get
            Set(ByVal value As String)
                qBCProdField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vAliqProd As String
            Get
                Return vAliqProdField
            End Get
            Set(ByVal value As String)
                vAliqProdField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vCOFINS As String
            Get
                Return vCOFINSField
            End Get
            Set(ByVal value As String)
                vCOFINSField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("03")>
        Item03
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoCOFINSST
        Private itemsField As String()
        Private itemsElementNameField As ItemsChoiceType4()
        Private vCOFINSField As String
        Private indSomaCOFINSSTField As TNFeInfNFeDetImpostoCOFINSSTIndSomaCOFINSST
        Private indSomaCOFINSSTFieldSpecified As Boolean

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("pCOFINS", GetType(String))>
        <Xml.Serialization.XmlElementAttribute("qBCProd", GetType(String))>
        <Xml.Serialization.XmlElementAttribute("vAliqProd", GetType(String))>
        <Xml.Serialization.XmlElementAttribute("vBC", GetType(String))>
        <Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")>
        Public Property Items As String()
            Get
                Return itemsField
            End Get
            Set(ByVal value As String())
                itemsField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("ItemsElementName")>
        <Xml.Serialization.XmlIgnoreAttribute()>
        Public Property ItemsElementName As ItemsChoiceType4()
            Get
                Return itemsElementNameField
            End Get
            Set(ByVal value As ItemsChoiceType4())
                itemsElementNameField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vCOFINS As String
            Get
                Return vCOFINSField
            End Get
            Set(ByVal value As String)
                vCOFINSField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property indSomaCOFINSST As TNFeInfNFeDetImpostoCOFINSSTIndSomaCOFINSST
            Get
                Return indSomaCOFINSSTField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoCOFINSSTIndSomaCOFINSST)
                indSomaCOFINSSTField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlIgnoreAttribute()>
        Public Property indSomaCOFINSSTSpecified As Boolean
            Get
                Return indSomaCOFINSSTFieldSpecified
            End Get
            Set(ByVal value As Boolean)
                indSomaCOFINSSTFieldSpecified = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe", IncludeInSchema:=False)>
    Public Enum ItemsChoiceType4

        ''' <remarks/>
        pCOFINS

        ''' <remarks/>
        qBCProd

        ''' <remarks/>
        vAliqProd

        ''' <remarks/>
        vBC
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoCOFINSSTIndSomaCOFINSST

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSUFDest
        Private vBCUFDestField As String
        Private vBCFCPUFDestField As String
        Private pFCPUFDestField As String
        Private pICMSUFDestField As String
        Private pICMSInterField As TNFeInfNFeDetImpostoICMSUFDestPICMSInter
        Private pICMSInterPartField As String
        Private vFCPUFDestField As String
        Private vICMSUFDestField As String
        Private vICMSUFRemetField As String

        ''' <remarks/>
        Public Property vBCUFDest As String
            Get
                Return vBCUFDestField
            End Get
            Set(ByVal value As String)
                vBCUFDestField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCFCPUFDest As String
            Get
                Return vBCFCPUFDestField
            End Get
            Set(ByVal value As String)
                vBCFCPUFDestField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pFCPUFDest As String
            Get
                Return pFCPUFDestField
            End Get
            Set(ByVal value As String)
                pFCPUFDestField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pICMSUFDest As String
            Get
                Return pICMSUFDestField
            End Get
            Set(ByVal value As String)
                pICMSUFDestField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pICMSInter As TNFeInfNFeDetImpostoICMSUFDestPICMSInter
            Get
                Return pICMSInterField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoICMSUFDestPICMSInter)
                pICMSInterField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pICMSInterPart As String
            Get
                Return pICMSInterPartField
            End Get
            Set(ByVal value As String)
                pICMSInterPartField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vFCPUFDest As String
            Get
                Return vFCPUFDestField
            End Get
            Set(ByVal value As String)
                vFCPUFDestField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSUFDest As String
            Get
                Return vICMSUFDestField
            End Get
            Set(ByVal value As String)
                vICMSUFDestField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSUFRemet As String
            Get
                Return vICMSUFRemetField
            End Get
            Set(ByVal value As String)
                vICMSUFRemetField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSUFDestPICMSInter

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("4.00")>
        Item400

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("7.00")>
        Item700

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("12.00")>
        Item1200
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoDevol
        Private pDevolField As String
        Private iPIField As TNFeInfNFeDetImpostoDevolIPI

        ''' <remarks/>
        Public Property pDevol As String
            Get
                Return pDevolField
            End Get
            Set(ByVal value As String)
                pDevolField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property IPI As TNFeInfNFeDetImpostoDevolIPI
            Get
                Return iPIField
            End Get
            Set(ByVal value As TNFeInfNFeDetImpostoDevolIPI)
                iPIField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoDevolIPI
        Private vIPIDevolField As String

        ''' <remarks/>
        Public Property vIPIDevol As String
            Get
                Return vIPIDevolField
            End Get
            Set(ByVal value As String)
                vIPIDevolField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeTotal
        Private iCMSTotField As TNFeInfNFeTotalICMSTot
        Private iSSQNtotField As TNFeInfNFeTotalISSQNtot
        Private retTribField As TNFeInfNFeTotalRetTrib

        ''' <remarks/>
        Public Property ICMSTot As TNFeInfNFeTotalICMSTot
            Get
                Return iCMSTotField
            End Get
            Set(ByVal value As TNFeInfNFeTotalICMSTot)
                iCMSTotField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property ISSQNtot As TNFeInfNFeTotalISSQNtot
            Get
                Return iSSQNtotField
            End Get
            Set(ByVal value As TNFeInfNFeTotalISSQNtot)
                iSSQNtotField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property retTrib As TNFeInfNFeTotalRetTrib
            Get
                Return retTribField
            End Get
            Set(ByVal value As TNFeInfNFeTotalRetTrib)
                retTribField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeTotalICMSTot
        Private vBCField As String
        Private vICMSField As String
        Private vICMSDesonField As String
        Private vFCPUFDestField As String
        Private vICMSUFDestField As String
        Private vICMSUFRemetField As String
        Private vFCPField As String
        Private vBCSTField As String
        Private vSTField As String
        Private vFCPSTField As String
        Private vFCPSTRetField As String
        Private vProdField As String
        Private vFreteField As String
        Private vSegField As String
        Private vDescField As String
        Private vIIField As String
        Private vIPIField As String
        Private vIPIDevolField As String
        Private vPISField As String
        Private vCOFINSField As String
        Private vOutroField As String
        Private vNFField As String
        Private vTotTribField As String

        ''' <remarks/>
        Public Property vBC As String
            Get
                Return vBCField
            End Get
            Set(ByVal value As String)
                vBCField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMS As String
            Get
                Return vICMSField
            End Get
            Set(ByVal value As String)
                vICMSField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSDeson As String
            Get
                Return vICMSDesonField
            End Get
            Set(ByVal value As String)
                vICMSDesonField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vFCPUFDest As String
            Get
                Return vFCPUFDestField
            End Get
            Set(ByVal value As String)
                vFCPUFDestField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSUFDest As String
            Get
                Return vICMSUFDestField
            End Get
            Set(ByVal value As String)
                vICMSUFDestField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSUFRemet As String
            Get
                Return vICMSUFRemetField
            End Get
            Set(ByVal value As String)
                vICMSUFRemetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vFCP As String
            Get
                Return vFCPField
            End Get
            Set(ByVal value As String)
                vFCPField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCST As String
            Get
                Return vBCSTField
            End Get
            Set(ByVal value As String)
                vBCSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vST As String
            Get
                Return vSTField
            End Get
            Set(ByVal value As String)
                vSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vFCPST As String
            Get
                Return vFCPSTField
            End Get
            Set(ByVal value As String)
                vFCPSTField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vFCPSTRet As String
            Get
                Return vFCPSTRetField
            End Get
            Set(ByVal value As String)
                vFCPSTRetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vProd As String
            Get
                Return vProdField
            End Get
            Set(ByVal value As String)
                vProdField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vFrete As String
            Get
                Return vFreteField
            End Get
            Set(ByVal value As String)
                vFreteField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vSeg As String
            Get
                Return vSegField
            End Get
            Set(ByVal value As String)
                vSegField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vDesc As String
            Get
                Return vDescField
            End Get
            Set(ByVal value As String)
                vDescField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vII As String
            Get
                Return vIIField
            End Get
            Set(ByVal value As String)
                vIIField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vIPI As String
            Get
                Return vIPIField
            End Get
            Set(ByVal value As String)
                vIPIField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vIPIDevol As String
            Get
                Return vIPIDevolField
            End Get
            Set(ByVal value As String)
                vIPIDevolField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vPIS As String
            Get
                Return vPISField
            End Get
            Set(ByVal value As String)
                vPISField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vCOFINS As String
            Get
                Return vCOFINSField
            End Get
            Set(ByVal value As String)
                vCOFINSField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vOutro As String
            Get
                Return vOutroField
            End Get
            Set(ByVal value As String)
                vOutroField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vNF As String
            Get
                Return vNFField
            End Get
            Set(ByVal value As String)
                vNFField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vTotTrib As String
            Get
                Return vTotTribField
            End Get
            Set(ByVal value As String)
                vTotTribField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeTotalISSQNtot
        Private vServField As String
        Private vBCField As String
        Private vISSField As String
        Private vPISField As String
        Private vCOFINSField As String
        Private dCompetField As String
        Private vDeducaoField As String
        Private vOutroField As String
        Private vDescIncondField As String
        Private vDescCondField As String
        Private vISSRetField As String
        Private cRegTribField As TNFeInfNFeTotalISSQNtotCRegTrib
        Private cRegTribFieldSpecified As Boolean

        ''' <remarks/>
        Public Property vServ As String
            Get
                Return vServField
            End Get
            Set(ByVal value As String)
                vServField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBC As String
            Get
                Return vBCField
            End Get
            Set(ByVal value As String)
                vBCField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vISS As String
            Get
                Return vISSField
            End Get
            Set(ByVal value As String)
                vISSField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vPIS As String
            Get
                Return vPISField
            End Get
            Set(ByVal value As String)
                vPISField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vCOFINS As String
            Get
                Return vCOFINSField
            End Get
            Set(ByVal value As String)
                vCOFINSField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property dCompet As String
            Get
                Return dCompetField
            End Get
            Set(ByVal value As String)
                dCompetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vDeducao As String
            Get
                Return vDeducaoField
            End Get
            Set(ByVal value As String)
                vDeducaoField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vOutro As String
            Get
                Return vOutroField
            End Get
            Set(ByVal value As String)
                vOutroField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vDescIncond As String
            Get
                Return vDescIncondField
            End Get
            Set(ByVal value As String)
                vDescIncondField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vDescCond As String
            Get
                Return vDescCondField
            End Get
            Set(ByVal value As String)
                vDescCondField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vISSRet As String
            Get
                Return vISSRetField
            End Get
            Set(ByVal value As String)
                vISSRetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cRegTrib As TNFeInfNFeTotalISSQNtotCRegTrib
            Get
                Return cRegTribField
            End Get
            Set(ByVal value As TNFeInfNFeTotalISSQNtotCRegTrib)
                cRegTribField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlIgnoreAttribute()>
        Public Property cRegTribSpecified As Boolean
            Get
                Return cRegTribFieldSpecified
            End Get
            Set(ByVal value As Boolean)
                cRegTribFieldSpecified = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeTotalISSQNtotCRegTrib

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("4")>
        Item4

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("5")>
        Item5

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("6")>
        Item6
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeTotalRetTrib
        Private vRetPISField As String
        Private vRetCOFINSField As String
        Private vRetCSLLField As String
        Private vBCIRRFField As String
        Private vIRRFField As String
        Private vBCRetPrevField As String
        Private vRetPrevField As String

        ''' <remarks/>
        Public Property vRetPIS As String
            Get
                Return vRetPISField
            End Get
            Set(ByVal value As String)
                vRetPISField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vRetCOFINS As String
            Get
                Return vRetCOFINSField
            End Get
            Set(ByVal value As String)
                vRetCOFINSField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vRetCSLL As String
            Get
                Return vRetCSLLField
            End Get
            Set(ByVal value As String)
                vRetCSLLField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCIRRF As String
            Get
                Return vBCIRRFField
            End Get
            Set(ByVal value As String)
                vBCIRRFField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vIRRF As String
            Get
                Return vIRRFField
            End Get
            Set(ByVal value As String)
                vIRRFField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCRetPrev As String
            Get
                Return vBCRetPrevField
            End Get
            Set(ByVal value As String)
                vBCRetPrevField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vRetPrev As String
            Get
                Return vRetPrevField
            End Get
            Set(ByVal value As String)
                vRetPrevField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeTransp
        Private modFreteField As TNFeInfNFeTranspModFrete
        Private transportaField As TNFeInfNFeTranspTransporta
        Private retTranspField As TNFeInfNFeTranspRetTransp
        Private itemsField As Object()
        Private itemsElementNameField As ItemsChoiceType5()
        Private volField As TNFeInfNFeTranspVol()

        ''' <remarks/>
        Public Property modFrete As TNFeInfNFeTranspModFrete
            Get
                Return modFreteField
            End Get
            Set(ByVal value As TNFeInfNFeTranspModFrete)
                modFreteField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property transporta As TNFeInfNFeTranspTransporta
            Get
                Return transportaField
            End Get
            Set(ByVal value As TNFeInfNFeTranspTransporta)
                transportaField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property retTransp As TNFeInfNFeTranspRetTransp
            Get
                Return retTranspField
            End Get
            Set(ByVal value As TNFeInfNFeTranspRetTransp)
                retTranspField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("balsa", GetType(String))>
        <Xml.Serialization.XmlElementAttribute("reboque", GetType(TVeiculo))>
        <Xml.Serialization.XmlElementAttribute("vagao", GetType(String))>
        <Xml.Serialization.XmlElementAttribute("veicTransp", GetType(TVeiculo))>
        <Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")>
        Public Property Items As Object()
            Get
                Return itemsField
            End Get
            Set(ByVal value As Object())
                itemsField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("ItemsElementName")>
        <Xml.Serialization.XmlIgnoreAttribute()>
        Public Property ItemsElementName As ItemsChoiceType5()
            Get
                Return itemsElementNameField
            End Get
            Set(ByVal value As ItemsChoiceType5())
                itemsElementNameField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("vol")>
        Public Property vol As TNFeInfNFeTranspVol()
            Get
                Return volField
            End Get
            Set(ByVal value As TNFeInfNFeTranspVol())
                volField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeTranspModFrete

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("4")>
        Item4

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("9")>
        Item9
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeTranspTransporta
        Private itemField As String
        Private itemElementNameField As ItemChoiceType6
        Private xNomeField As String
        Private ieField As String
        Private xEnderField As String
        Private xMunField As String
        Private ufField As TUf
        Private ufFieldSpecified As Boolean

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("CNPJ", GetType(String))>
        <Xml.Serialization.XmlElementAttribute("CPF", GetType(String))>
        <Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")>
        Public Property Item As String
            Get
                Return itemField
            End Get
            Set(ByVal value As String)
                itemField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlIgnoreAttribute()>
        Public Property ItemElementName As ItemChoiceType6
            Get
                Return itemElementNameField
            End Get
            Set(ByVal value As ItemChoiceType6)
                itemElementNameField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xNome As String
            Get
                Return xNomeField
            End Get
            Set(ByVal value As String)
                xNomeField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property IE As String
            Get
                Return ieField
            End Get
            Set(ByVal value As String)
                ieField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xEnder As String
            Get
                Return xEnderField
            End Get
            Set(ByVal value As String)
                xEnderField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xMun As String
            Get
                Return xMunField
            End Get
            Set(ByVal value As String)
                xMunField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property UF As TUf
            Get
                Return ufField
            End Get
            Set(ByVal value As TUf)
                ufField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlIgnoreAttribute()>
        Public Property UFSpecified As Boolean
            Get
                Return ufFieldSpecified
            End Get
            Set(ByVal value As Boolean)
                ufFieldSpecified = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe", IncludeInSchema:=False)>
    Public Enum ItemChoiceType6

        ''' <remarks/>
        CNPJ

        ''' <remarks/>
        CPF
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeTranspRetTransp
        Private vServField As String
        Private vBCRetField As String
        Private pICMSRetField As String
        Private vICMSRetField As String
        Private cFOPField As String
        Private cMunFGField As String

        ''' <remarks/>
        Public Property vServ As String
            Get
                Return vServField
            End Get
            Set(ByVal value As String)
                vServField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vBCRet As String
            Get
                Return vBCRetField
            End Get
            Set(ByVal value As String)
                vBCRetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pICMSRet As String
            Get
                Return pICMSRetField
            End Get
            Set(ByVal value As String)
                pICMSRetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vICMSRet As String
            Get
                Return vICMSRetField
            End Get
            Set(ByVal value As String)
                vICMSRetField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CFOP As String
            Get
                Return cFOPField
            End Get
            Set(ByVal value As String)
                cFOPField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cMunFG As String
            Get
                Return cMunFGField
            End Get
            Set(ByVal value As String)
                cMunFGField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TVeiculo
        Private placaField As String
        Private ufField As TUf
        Private ufFieldSpecified As Boolean
        Private rNTCField As String

        ''' <remarks/>
        Public Property placa As String
            Get
                Return placaField
            End Get
            Set(ByVal value As String)
                placaField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property UF As TUf
            Get
                Return ufField
            End Get
            Set(ByVal value As TUf)
                ufField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlIgnoreAttribute()>
        Public Property UFSpecified As Boolean
            Get
                Return ufFieldSpecified
            End Get
            Set(ByVal value As Boolean)
                ufFieldSpecified = value
            End Set
        End Property

        ''' <remarks/>
        Public Property RNTC As String
            Get
                Return rNTCField
            End Get
            Set(ByVal value As String)
                rNTCField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe", IncludeInSchema:=False)>
    Public Enum ItemsChoiceType5

        ''' <remarks/>
        balsa

        ''' <remarks/>
        reboque

        ''' <remarks/>
        vagao

        ''' <remarks/>
        veicTransp
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeTranspVol
        Private qVolField As String
        Private espField As String
        Private marcaField As String
        Private nVolField As String
        Private pesoLField As String
        Private pesoBField As String
        Private lacresField As TNFeInfNFeTranspVolLacres()

        ''' <remarks/>
        Public Property qVol As String
            Get
                Return qVolField
            End Get
            Set(ByVal value As String)
                qVolField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property esp As String
            Get
                Return espField
            End Get
            Set(ByVal value As String)
                espField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property marca As String
            Get
                Return marcaField
            End Get
            Set(ByVal value As String)
                marcaField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property nVol As String
            Get
                Return nVolField
            End Get
            Set(ByVal value As String)
                nVolField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pesoL As String
            Get
                Return pesoLField
            End Get
            Set(ByVal value As String)
                pesoLField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property pesoB As String
            Get
                Return pesoBField
            End Get
            Set(ByVal value As String)
                pesoBField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("lacres")>
        Public Property lacres As TNFeInfNFeTranspVolLacres()
            Get
                Return lacresField
            End Get
            Set(ByVal value As TNFeInfNFeTranspVolLacres())
                lacresField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeTranspVolLacres
        Private nLacreField As String

        ''' <remarks/>
        Public Property nLacre As String
            Get
                Return nLacreField
            End Get
            Set(ByVal value As String)
                nLacreField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeCobr
        Private fatField As TNFeInfNFeCobrFat
        Private dupField As TNFeInfNFeCobrDup()

        ''' <remarks/>
        Public Property fat As TNFeInfNFeCobrFat
            Get
                Return fatField
            End Get
            Set(ByVal value As TNFeInfNFeCobrFat)
                fatField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("dup")>
        Public Property dup As TNFeInfNFeCobrDup()
            Get
                Return dupField
            End Get
            Set(ByVal value As TNFeInfNFeCobrDup())
                dupField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeCobrFat
        Private nFatField As String
        Private vOrigField As String
        Private vDescField As String
        Private vLiqField As String

        ''' <remarks/>
        Public Property nFat As String
            Get
                Return nFatField
            End Get
            Set(ByVal value As String)
                nFatField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vOrig As String
            Get
                Return vOrigField
            End Get
            Set(ByVal value As String)
                vOrigField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vDesc As String
            Get
                Return vDescField
            End Get
            Set(ByVal value As String)
                vDescField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vLiq As String
            Get
                Return vLiqField
            End Get
            Set(ByVal value As String)
                vLiqField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeCobrDup
        Private nDupField As String
        Private dVencField As String
        Private vDupField As String

        ''' <remarks/>
        Public Property nDup As String
            Get
                Return nDupField
            End Get
            Set(ByVal value As String)
                nDupField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property dVenc As String
            Get
                Return dVencField
            End Get
            Set(ByVal value As String)
                dVencField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vDup As String
            Get
                Return vDupField
            End Get
            Set(ByVal value As String)
                vDupField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFePag
        Private detPagField As TNFeInfNFePagDetPag()
        Private vTrocoField As String

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("detPag")>
        Public Property detPag As TNFeInfNFePagDetPag()
            Get
                Return detPagField
            End Get
            Set(ByVal value As TNFeInfNFePagDetPag())
                detPagField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vTroco As String
            Get
                Return vTrocoField
            End Get
            Set(ByVal value As String)
                vTrocoField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFePagDetPag
        Private indPagField As TNFeInfNFePagDetPagIndPag
        Private indPagFieldSpecified As Boolean
        Private tPagField As TNFeInfNFePagDetPagTPag
        Private xPagField As String
        Private vPagField As String
        Private cardField As TNFeInfNFePagDetPagCard

        ''' <remarks/>
        Public Property indPag As TNFeInfNFePagDetPagIndPag
            Get
                Return indPagField
            End Get
            Set(ByVal value As TNFeInfNFePagDetPagIndPag)
                indPagField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlIgnoreAttribute()>
        Public Property indPagSpecified As Boolean
            Get
                Return indPagFieldSpecified
            End Get
            Set(ByVal value As Boolean)
                indPagFieldSpecified = value
            End Set
        End Property

        ''' <remarks/>
        Public Property tPag As TNFeInfNFePagDetPagTPag
            Get
                Return tPagField
            End Get
            Set(ByVal value As TNFeInfNFePagDetPagTPag)
                tPagField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xPag As String
            Get
                Return xPagField
            End Get
            Set(ByVal value As String)
                xPagField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vPag As String
            Get
                Return vPagField
            End Get
            Set(ByVal value As String)
                vPagField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property card As TNFeInfNFePagDetPagCard
            Get
                Return cardField
            End Get
            Set(ByVal value As TNFeInfNFePagDetPagCard)
                cardField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFePagDetPagIndPag

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFePagDetPagTPag

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("01")>
        Item01

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("02")>
        Item02

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("03")>
        Item03

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("04")>
        Item04

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("05")>
        Item05

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("10")>
        Item10

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("11")>
        Item11

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("12")>
        Item12

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("13")>
        Item13

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("14")>
        Item14

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("15")>
        Item15

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("16")>
        Item16

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("17")>
        Item17

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("18")>
        Item18

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("19")>
        Item19

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("90")>
        Item90

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("99")>
        Item99
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFePagDetPagCard
        Private tpIntegraField As TNFeInfNFePagDetPagCardTpIntegra
        Private cNPJField As String
        Private tBandField As TNFeInfNFePagDetPagCardTBand
        Private tBandFieldSpecified As Boolean
        Private cAutField As String

        ''' <remarks/>
        Public Property tpIntegra As TNFeInfNFePagDetPagCardTpIntegra
            Get
                Return tpIntegraField
            End Get
            Set(ByVal value As TNFeInfNFePagDetPagCardTpIntegra)
                tpIntegraField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property CNPJ As String
            Get
                Return cNPJField
            End Get
            Set(ByVal value As String)
                cNPJField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property tBand As TNFeInfNFePagDetPagCardTBand
            Get
                Return tBandField
            End Get
            Set(ByVal value As TNFeInfNFePagDetPagCardTBand)
                tBandField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlIgnoreAttribute()>
        Public Property tBandSpecified As Boolean
            Get
                Return tBandFieldSpecified
            End Get
            Set(ByVal value As Boolean)
                tBandFieldSpecified = value
            End Set
        End Property

        ''' <remarks/>
        Public Property cAut As String
            Get
                Return cAutField
            End Get
            Set(ByVal value As String)
                cAutField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFePagDetPagCardTpIntegra

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFePagDetPagCardTBand

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("01")>
        Item01

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("02")>
        Item02

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("03")>
        Item03

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("04")>
        Item04

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("05")>
        Item05

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("06")>
        Item06

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("07")>
        Item07

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("08")>
        Item08

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("09")>
        Item09

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("10")>
        Item10

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("11")>
        Item11

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("12")>
        Item12

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("13")>
        Item13

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("14")>
        Item14

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("15")>
        Item15

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("16")>
        Item16

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("17")>
        Item17

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("18")>
        Item18

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("19")>
        Item19

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("20")>
        Item20

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("21")>
        Item21

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("22")>
        Item22

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("23")>
        Item23

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("24")>
        Item24

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("25")>
        Item25

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("26")>
        Item26

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("27")>
        Item27

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("99")>
        Item99
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeInfIntermed
        Private cNPJField As String
        Private idCadIntTranField As String

        ''' <remarks/>
        Public Property CNPJ As String
            Get
                Return cNPJField
            End Get
            Set(ByVal value As String)
                cNPJField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property idCadIntTran As String
            Get
                Return idCadIntTranField
            End Get
            Set(ByVal value As String)
                idCadIntTranField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeInfAdic
        Private infAdFiscoField As String
        Private infCplField As String
        Private obsContField As TNFeInfNFeInfAdicObsCont()
        Private obsFiscoField As TNFeInfNFeInfAdicObsFisco()
        Private procRefField As TNFeInfNFeInfAdicProcRef()

        ''' <remarks/>
        Public Property infAdFisco As String
            Get
                Return infAdFiscoField
            End Get
            Set(ByVal value As String)
                infAdFiscoField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property infCpl As String
            Get
                Return infCplField
            End Get
            Set(ByVal value As String)
                infCplField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("obsCont")>
        Public Property obsCont As TNFeInfNFeInfAdicObsCont()
            Get
                Return obsContField
            End Get
            Set(ByVal value As TNFeInfNFeInfAdicObsCont())
                obsContField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("obsFisco")>
        Public Property obsFisco As TNFeInfNFeInfAdicObsFisco()
            Get
                Return obsFiscoField
            End Get
            Set(ByVal value As TNFeInfNFeInfAdicObsFisco())
                obsFiscoField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("procRef")>
        Public Property procRef As TNFeInfNFeInfAdicProcRef()
            Get
                Return procRefField
            End Get
            Set(ByVal value As TNFeInfNFeInfAdicProcRef())
                procRefField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeInfAdicObsCont
        Private xTextoField As String
        Private xCampoField As String

        ''' <remarks/>
        Public Property xTexto As String
            Get
                Return xTextoField
            End Get
            Set(ByVal value As String)
                xTextoField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlAttributeAttribute()>
        Public Property xCampo As String
            Get
                Return xCampoField
            End Get
            Set(ByVal value As String)
                xCampoField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeInfAdicObsFisco
        Private xTextoField As String
        Private xCampoField As String

        ''' <remarks/>
        Public Property xTexto As String
            Get
                Return xTextoField
            End Get
            Set(ByVal value As String)
                xTextoField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlAttributeAttribute()>
        Public Property xCampo As String
            Get
                Return xCampoField
            End Get
            Set(ByVal value As String)
                xCampoField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeInfAdicProcRef
        Private nProcField As String
        Private indProcField As TNFeInfNFeInfAdicProcRefIndProc

        ''' <remarks/>
        Public Property nProc As String
            Get
                Return nProcField
            End Get
            Set(ByVal value As String)
                nProcField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property indProc As TNFeInfNFeInfAdicProcRefIndProc
            Get
                Return indProcField
            End Get
            Set(ByVal value As TNFeInfNFeInfAdicProcRefIndProc)
                indProcField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeInfAdicProcRefIndProc

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("0")>
        Item0

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("3")>
        Item3

        ''' <remarks/>
        <Xml.Serialization.XmlEnumAttribute("9")>
        Item9
    End Enum

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeExporta
        Private uFSaidaPaisField As TUfEmi
        Private xLocExportaField As String
        Private xLocDespachoField As String

        ''' <remarks/>
        Public Property UFSaidaPais As TUfEmi
            Get
                Return uFSaidaPaisField
            End Get
            Set(ByVal value As TUfEmi)
                uFSaidaPaisField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xLocExporta As String
            Get
                Return xLocExportaField
            End Get
            Set(ByVal value As String)
                xLocExportaField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xLocDespacho As String
            Get
                Return xLocDespachoField
            End Get
            Set(ByVal value As String)
                xLocDespachoField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeCompra
        Private xNEmpField As String
        Private xPedField As String
        Private xContField As String

        ''' <remarks/>
        Public Property xNEmp As String
            Get
                Return xNEmpField
            End Get
            Set(ByVal value As String)
                xNEmpField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xPed As String
            Get
                Return xPedField
            End Get
            Set(ByVal value As String)
                xPedField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xCont As String
            Get
                Return xContField
            End Get
            Set(ByVal value As String)
                xContField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeCana
        Private safraField As String
        Private refField As String
        Private forDiaField As TNFeInfNFeCanaForDia()
        Private qTotMesField As String
        Private qTotAntField As String
        Private qTotGerField As String
        Private deducField As TNFeInfNFeCanaDeduc()
        Private vForField As String
        Private vTotDedField As String
        Private vLiqForField As String

        ''' <remarks/>
        Public Property safra As String
            Get
                Return safraField
            End Get
            Set(ByVal value As String)
                safraField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property ref As String
            Get
                Return refField
            End Get
            Set(ByVal value As String)
                refField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("forDia")>
        Public Property forDia As TNFeInfNFeCanaForDia()
            Get
                Return forDiaField
            End Get
            Set(ByVal value As TNFeInfNFeCanaForDia())
                forDiaField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property qTotMes As String
            Get
                Return qTotMesField
            End Get
            Set(ByVal value As String)
                qTotMesField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property qTotAnt As String
            Get
                Return qTotAntField
            End Get
            Set(ByVal value As String)
                qTotAntField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property qTotGer As String
            Get
                Return qTotGerField
            End Get
            Set(ByVal value As String)
                qTotGerField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute("deduc")>
        Public Property deduc As TNFeInfNFeCanaDeduc()
            Get
                Return deducField
            End Get
            Set(ByVal value As TNFeInfNFeCanaDeduc())
                deducField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vFor As String
            Get
                Return vForField
            End Get
            Set(ByVal value As String)
                vForField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vTotDed As String
            Get
                Return vTotDedField
            End Get
            Set(ByVal value As String)
                vTotDedField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vLiqFor As String
            Get
                Return vLiqForField
            End Get
            Set(ByVal value As String)
                vLiqForField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeCanaForDia
        Private qtdeField As String
        Private diaField As String

        ''' <remarks/>
        Public Property qtde As String
            Get
                Return qtdeField
            End Get
            Set(ByVal value As String)
                qtdeField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlAttributeAttribute()>
        Public Property dia As String
            Get
                Return diaField
            End Get
            Set(ByVal value As String)
                diaField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeCanaDeduc
        Private xDedField As String
        Private vDedField As String

        ''' <remarks/>
        Public Property xDed As String
            Get
                Return xDedField
            End Get
            Set(ByVal value As String)
                xDedField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property vDed As String
            Get
                Return vDedField
            End Get
            Set(ByVal value As String)
                vDedField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TInfRespTec
        Private cNPJField As String
        Private xContatoField As String
        Private emailField As String
        Private foneField As String
        Private idCSRTField As String
        Private hashCSRTField As Byte()

        ''' <remarks/>
        Public Property CNPJ As String
            Get
                Return cNPJField
            End Get
            Set(ByVal value As String)
                cNPJField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property xContato As String
            Get
                Return xContatoField
            End Get
            Set(ByVal value As String)
                xContatoField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property email As String
            Get
                Return emailField
            End Get
            Set(ByVal value As String)
                emailField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property fone As String
            Get
                Return foneField
            End Get
            Set(ByVal value As String)
                foneField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property idCSRT As String
            Get
                Return idCSRTField
            End Get
            Set(ByVal value As String)
                idCSRTField = value
            End Set
        End Property

        ''' <remarks/>
        <Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")>
        Public Property hashCSRT As Byte()
            Get
                Return hashCSRTField
            End Get
            Set(ByVal value As Byte())
                hashCSRTField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeInfSolicNFF
        Private xSolicField As String

        ''' <remarks/>
        Public Property xSolic As String
            Get
                Return xSolicField
            End Get
            Set(ByVal value As String)
                xSolicField = value
            End Set
        End Property
    End Class

    ''' <remarks/>
    <CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")>
    <SerializableAttribute()>
    <DebuggerStepThroughAttribute()>
    <ComponentModel.DesignerCategoryAttribute("code")>
    <Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeSupl
        Private qrCodeField As String
        Private urlChaveField As String

        ''' <remarks/>
        Public Property qrCode As String
            Get
                Return qrCodeField
            End Get
            Set(ByVal value As String)
                qrCodeField = value
            End Set
        End Property

        ''' <remarks/>
        Public Property urlChave As String
            Get
                Return urlChaveField
            End Get
            Set(ByVal value As String)
                urlChaveField = value
            End Set
        End Property
    End Class
End Namespace
