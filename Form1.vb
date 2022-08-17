Public Class FRM_CALCULADORA
    Public OPERANDO1, OPERANDO2 As Double
    Public ACUMULA As String
    Public OPERACION As Char
    Public RESULTADO As Double

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        ACUMULA = ACUMULA & "0"
        TXT_DISPLAY.Text = ACUMULA
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ACUMULA = ACUMULA & "1"
        TXT_DISPLAY.Text = ACUMULA
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ACUMULA = ACUMULA & "2"
        TXT_DISPLAY.Text = ACUMULA
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ACUMULA = ACUMULA & "3"
        TXT_DISPLAY.Text = ACUMULA
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ACUMULA = ACUMULA & "4"
        TXT_DISPLAY.Text = ACUMULA
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ACUMULA = ACUMULA & "5"
        TXT_DISPLAY.Text = ACUMULA
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ACUMULA = ACUMULA & "6"
        TXT_DISPLAY.Text = ACUMULA
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ACUMULA = ACUMULA & "7"
        TXT_DISPLAY.Text = ACUMULA
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ACUMULA = ACUMULA & "8"
        TXT_DISPLAY.Text = ACUMULA
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ACUMULA = ACUMULA & "9"
        TXT_DISPLAY.Text = ACUMULA
    End Sub

    Private Sub ButtonC_Click(sender As Object, e As EventArgs) Handles ButtonC.Click
        ACUMULA = ACUMULA & ""
        TXT_DISPLAY.Text = ACUMULA
    End Sub

    Private Sub ButtonSUMA_Click(sender As Object, e As EventArgs) Handles ButtonSUMA.Click
        TXT_DISPLAY.Text = ""
        OPERANDO1 = Val(ACUMULA)
        OPERACION = "+"
        ACUMULA = ""
    End Sub

    Private Sub buttonRESULTADO_Click(sender As Object, e As EventArgs) Handles buttonRESULTADO.Click
        TXT_DISPLAY.Text = ""
        OPERANDO2 = Val(ACUMULA)
        Select Case OPERACION
            Case "+"
                RESULTADO = OPERANDO1 + OPERANDO2
                TXT_DISPLAY.Text = RESULTADO
            Case "-"
                RESULTADO = OPERANDO1 - OPERANDO2
                TXT_DISPLAY.Text = RESULTADO
            Case "/"
                RESULTADO = OPERANDO1 / OPERANDO2
                TXT_DISPLAY.Text = RESULTADO
            Case "*"
                RESULTADO = OPERANDO1 * OPERANDO2
                TXT_DISPLAY.Text = RESULTADO

        End Select

        ACUMULA = ""

    End Sub

    Private Sub ButtonRESTA_Click(sender As Object, e As EventArgs) Handles ButtonRESTA.Click
        TXT_DISPLAY.Text = ""
        OPERANDO1 = Val(ACUMULA)
        OPERACION = "-"
        ACUMULA = ""
    End Sub

    Private Sub ButtonDIVIDIR_Click(sender As Object, e As EventArgs) Handles ButtonDIVIDIR.Click
        TXT_DISPLAY.Text = ""
        OPERANDO1 = Val(ACUMULA)
        OPERACION = "/"
        ACUMULA = ""
    End Sub

    Private Sub ButtonMULTIPLICA_Click(sender As Object, e As EventArgs) Handles ButtonMULTIPLICA.Click
        TXT_DISPLAY.Text = ""
        OPERANDO1 = Val(ACUMULA)
        OPERACION = "*"
        ACUMULA = ""
    End Sub

    Private Sub ButtonPUNTO_Click(sender As Object, e As EventArgs) Handles ButtonPUNTO.Click
        ACUMULA = ACUMULA & "."
        TXT_DISPLAY.Text = ACUMULA
    End Sub



End Class
