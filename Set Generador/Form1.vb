Option Strict Off
Imports System.IO
Public Class ventana
    Dim directorio As String = My.Application.Info.DirectoryPath
    'Dim Entrada As String = "M:\Practicas Mercedes Benz Vitoria\Proyecto CruceSet\CodigosComercialesPorCategoriaTab.txt"
    Dim Entrada As String = directorio & "\CodigosComercialesPorCategoriaTab.txt"


    Private Sub cambioTexto(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlevel.TextChanged, tFunction.TextChanged, tAligment.TextChanged
        componerSet()
    End Sub

    Private Sub cambioChek(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cVariantesPais.SelectedIndexChanged, cTransmision.SelectedIndexChanged, cTipo.SelectedIndexChanged, cNoAsignado.SelectedIndexChanged, cNivelCarga.SelectedIndexChanged, cMontajeBruto.SelectedIndexChanged, cConduccion.SelectedIndexChanged
        componerSet()
    End Sub

    Private Sub componerSet()
        Dim i As Integer = 0
        Dim cruceSet As String = "SET,"

        'Incluimos level
        cruceSet = cruceSet & "$" & tlevel.Text

        'Incluimos function
        cruceSet = cruceSet & "$§" & tFunction.Text

        'Incluimos Aligment
        cruceSet = cruceSet & "&" & tAligment.Text

        'Incluimos Conduccion
        cruceSet = cruceSet & "&"

        Dim hayuno As Boolean = False
        For i = 0 To cConduccion.Items.Count - 1
            If (cConduccion.GetItemChecked(i)) Then
                If (hayuno = True) Then
                    cruceSet = cruceSet & "!"
                End If
                cruceSet = cruceSet & cConduccion.Items(i).ToString
                hayuno = True
            Else
                Dim x As Integer = 0
                For x = 0 To cConduccion.Items.Count - 1
                    cConduccion.SetItemChecked(i, False)
                Next
            End If
        Next
        Tset.Text = cruceSet

        'Incluimos NoAsignado
        cruceSet = cruceSet & "&"

        hayuno = False
        For i = 0 To cNoAsignado.Items.Count - 1
            If (cNoAsignado.GetItemChecked(i)) Then
                If (hayuno = True) Then
                    cruceSet = cruceSet & "!"
                End If
                cruceSet = cruceSet & cNoAsignado.Items(i).ToString
                hayuno = True
            Else
                Dim x As Integer = 0
                For x = 0 To cNoAsignado.Items.Count - 1
                    cNoAsignado.SetItemChecked(i, False)
                Next
            End If
        Next
        Tset.Text = cruceSet

        'Incluimos Montaje Bruto
        cruceSet = cruceSet & "&"

        hayuno = False
        For i = 0 To cMontajeBruto.Items.Count - 1
            If (cMontajeBruto.GetItemChecked(i)) Then
                If (hayuno = True) Then
                    cruceSet = cruceSet & "!"
                End If
                cruceSet = cruceSet & cMontajeBruto.Items(i).ToString
                hayuno = True
            Else
                Dim x As Integer = 0
                For x = 0 To cMontajeBruto.Items.Count - 1
                    cMontajeBruto.SetItemChecked(i, False)
                Next
            End If
        Next
        Tset.Text = cruceSet

        'Incluimos Transmision
        cruceSet = cruceSet & "&"

        hayuno = False
        For i = 0 To cTransmision.Items.Count - 1
            If (cTransmision.GetItemChecked(i)) Then
                If (hayuno = True) Then
                    cruceSet = cruceSet & "!"
                End If
                cruceSet = cruceSet & cTransmision.Items(i).ToString
                hayuno = True
            Else
                Dim x As Integer = 0
                For x = 0 To cTransmision.Items.Count - 1
                    cTransmision.SetItemChecked(i, False)
                Next
            End If
        Next
        Tset.Text = cruceSet

        'Incluimos Nivel de Carga
        cruceSet = cruceSet & "&"

        hayuno = False
        For i = 0 To cNivelCarga.Items.Count - 1
            If (cNivelCarga.GetItemChecked(i)) Then
                If (hayuno = True) Then
                    cruceSet = cruceSet & "!"
                End If
                cruceSet = cruceSet & cNivelCarga.Items(i).ToString
                hayuno = True
            Else
                Dim x As Integer = 0
                For x = 0 To cNivelCarga.Items.Count - 1
                    cNivelCarga.SetItemChecked(i, False)
                Next
            End If
        Next
        Tset.Text = cruceSet

        'Incluimos Variante de Pais
        cruceSet = cruceSet & "&"

        hayuno = False
        For i = 0 To cVariantesPais.Items.Count - 1
            If (cVariantesPais.GetItemChecked(i)) Then
                If (hayuno = True) Then
                    cruceSet = cruceSet & "!"
                End If
                cruceSet = cruceSet & cVariantesPais.Items(i).ToString
                hayuno = True
            Else
                Dim x As Integer = 0
                For x = 0 To cVariantesPais.Items.Count - 1
                    cVariantesPais.SetItemChecked(i, False)
                Next
            End If
        Next
        Tset.Text = cruceSet


        'Incluimos Tipo
        cruceSet = cruceSet & "&"

        hayuno = False
        For i = 0 To cTipo.Items.Count - 1
            If (cTipo.GetItemChecked(i)) Then
                If (hayuno = True) Then
                    cruceSet = cruceSet & "!"
                End If
                cruceSet = cruceSet & cTipo.Items(i).ToString
                hayuno = True
            Else
                Dim x As Integer = 0
                For x = 0 To cTipo.Items.Count - 1
                    cTipo.SetItemChecked(i, False)
                Next
            End If
        Next

        'Incluimos Final clave Sol

        cruceSet = cruceSet & "§"

        Tset.Text = cruceSet
        'Copiar al Portapapeles
        My.Computer.Clipboard.SetText(Tset.Text)


    End Sub

    Private Sub ventana_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        visualizarCodigos()
        
    End Sub

    Private Sub visualizarCodigos()
        Try
            Dim Separo() As String
            Dim ficheroTxt() As String = File.ReadAllLines(Entrada)
            For Each linea In ficheroTxt
                If linea.Substring(0, 2) <> "1-" Then
                    Separo = Split(linea, vbTab)
                    If Separo(0) <> "" Then
                        cTipo.Items.Add(Separo(0))
                    End If
                    If Separo(1) <> "" Then
                        cConduccion.Items.Add(Separo(1))
                    End If
                    If Separo(2) <> "" Then
                        cMontajeBruto.Items.Add(Separo(2))
                    End If
                    If Separo(3) <> "" Then
                        cTransmision.Items.Add(Separo(3))
                    End If
                    If Separo(4) <> "" Then
                        cNivelCarga.Items.Add(Separo(4))
                    End If
                    If Separo(5) <> "" Then
                        cVariantesPais.Items.Add(Separo(5))
                    End If
                    If Separo(6) <> "" Then
                        cNoAsignado.Items.Add(Separo(6))
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox("Probablemente tengas el fichero abierto, Cierralo.")
        End Try

    End Sub

    'Private Sub Beditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Beditar.Click
    '    Dim XL = New Microsoft.Office.Interop.Excel.Application
    '    XL.Workbooks.Open(Entrada, , False)
    '    XL.Visible = True
    'End Sub
    Private Sub Beditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Beditar.Click
        Dim Arch = Shell("notepad " & Entrada, vbNormalFocus)
    End Sub

    Private Sub BRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BRefrescar.Click
        borrarListas()
        visualizarCodigos()
    End Sub

    Private Sub borrarListas()
        tlevel.Text = ""
        tFunction.Text = ""
        tAligment.Text = ""
        cTipo.Items.Clear()
        cConduccion.Items.Clear()
        cMontajeBruto.Items.Clear()
        cTransmision.Items.Clear()
        cNivelCarga.Items.Clear()
        cVariantesPais.Items.Clear()
        cNoAsignado.Items.Clear()
    End Sub


End Class
