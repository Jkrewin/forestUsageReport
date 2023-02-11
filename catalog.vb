Imports System.Xml.Serialization


''' <summary>
''' это для Базы данных НСИ которую надо скачивать с сайта в sFile > commons.xml
''' использует только нужные элементы
''' есть проблемы с ID оно строковый тип и там могут быть пробелы см. TRIM_REFERENCE
''' </summary>
<XmlRoot([Namespace]:="http://rosleshoz.gov.ru/xmlns/catalogs/3.1", IsNullable:=False)>
Public Structure catalog
    Public subject As List(Of mainClass.element)

    Public Structure mainClass
        Public Structure element
            <XmlAttribute("id")>
            Public id As String
            <XmlAttribute("name")>
            Public name As String
            <XmlElement([Namespace]:="http://rosleshoz.gov.ru/xmlns/catalogsTypes/3.1")>
            Public subject As subjectStructure
            Public Structure subjectStructure
                <XmlAttribute("id")>
                Public id As String
                <XmlAttribute("name")>
                Public name As String
            End Structure
            <XmlElement([Namespace]:="http://rosleshoz.gov.ru/xmlns/catalogsTypes/3.1")>
            Public landType As landTypeStructure
            Public Structure landTypeStructure
                <XmlAttribute("id")>
                Public id As String
                <XmlAttribute("name")>
                Public name As String
            End Structure
            <XmlElement([Namespace]:="http://rosleshoz.gov.ru/xmlns/catalogsTypes/3.1")>
            Public okpd As String
            <XmlElement([Namespace]:="http://rosleshoz.gov.ru/xmlns/catalogsTypes/3.1")>
            Public tnved As String
            <XmlElement([Namespace]:="http://rosleshoz.gov.ru/xmlns/catalogsTypes/3.1")>
            Public abbreviation As String
            <XmlElement([Namespace]:="http://rosleshoz.gov.ru/xmlns/catalogsTypes/3.1")>
            Public typeObject As String
        End Structure


    End Structure

    Public landType As List(Of mainClass.element)
    Public executiveAuthority As List(Of mainClass.element)
    Public forestry As List(Of mainClass.element)
    Public subforestry As List(Of mainClass.element)
    Public tract As List(Of mainClass.element)
    Public wood As List(Of mainClass.element)
    Public typeCutting As List(Of mainClass.element)
    Public unitType As List(Of mainClass.element)
    Public usageType As List(Of mainClass.element)
    Public resource As List(Of mainClass.element)
    Public measure As List(Of mainClass.element)
    Public [object] As List(Of mainClass.element)


End Structure