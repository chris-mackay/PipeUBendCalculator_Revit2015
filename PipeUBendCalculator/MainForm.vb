Public Class MainForm

    Dim steelPipeSizes As New List(Of String) From {"1/4""", "3/8""", "1/2""", "3/4""", "1""", "1 1/4""", "1 1/2""", "2""", "2 1/2""", "3""", "4""", "6""", "8""", "10""", "12""", "14""", "16""", "18""", "20"""}
    Dim copperPipeSizes As New List(Of String) From {"1/4""", "3/8""", "1/2""", "5/8""", "3/4""", "1 1/4""", "1 1/2""", "2""", "2 1/2""", "3""", "4""", "5""", "6""", "8""", "10""", "12"""}

    Dim copperOutsideDiameters() As Double = {0.375, 0.5, 0.625, 0.75, 0.875, 1.125, 1.375, 1.625, 2.125, 2.625, 3.125, 4.125, 5.125, 6.125, 8.125, 10.125, 12.125}
    Dim steelOutsideDiameters() As Double = {0.54, 0.675, 0.84, 1.05, 1.315, 1.66, 1.9, 2.375, 2.875, 3.5, 4.5, 6.625, 8.625, 10.75, 12.75, 14, 16, 18, 20}

    Dim steelExpansionCoefficients() As Double = {0.76, 0.91, 1.06, 1.22, 1.37, 1.52, 1.62, 1.69, 1.85}
    Dim copperExpansionCoefficients() As Double = {1.13, 1.37, 1.59, 1.8, 2.05, 2.3, 2.43, 2.52, 2.76}

    Public Sub performCalculation()

        If Not cbTemperature.SelectedIndex = -1 And Not cbPipeSizes.SelectedIndex = -1 And Not txtPipeLength.Text = "" And Not txtLinearExpansion.Text = "" And Not txtAllowableStressRange.Text = "" And Not txtModulus.Text = "" Then

            Dim pipeLength As Double = Nothing
            Dim linearExpansion As Double = Nothing
            Dim delta As Double = Nothing
            Dim pipeOD As Double = Nothing
            Dim modulus As Double = Nothing
            Dim allowableStressRange As Double = Nothing
            Dim dimensionL As Double = Nothing
            Dim dimensionW As Double = Nothing
            Dim dimensionH As Double = Nothing

            pipeLength = CType(txtPipeLength.Text, Double)
            linearExpansion = CType(txtLinearExpansion.Text, Double)
            modulus = CType(txtModulus.Text, Double)
            allowableStressRange = CType(txtAllowableStressRange.Text, Double)

            delta = calculateDelta(pipeLength, linearExpansion)

            pipeOD = determinePipeOD()

            dimensionL = calculateL(delta, pipeOD, modulus, allowableStressRange)
            dimensionW = calculateW(dimensionL)
            dimensionH = calculateH(dimensionW)

            txtDimensionL.Text = Math.Round(dimensionL, 2)

            txtDimensionW.Text = Math.Round(dimensionW, 2)

            txtDimensionH.Text = Math.Round(dimensionH, 2)

        Else

            txtDimensionL.Text = ""
            txtDimensionW.Text = ""
            txtDimensionH.Text = ""

        End If

    End Sub

    Public Sub determineMaterialProperties()

        Dim strTemp As Double
        strTemp = Nothing
        Dim dblLinearExpansion As Double
        Dim intSelectedTemperature As Integer = cbTemperature.SelectedIndex

        'CHECKS TO SEE WHICH PIPE MATERIAL IS SELECTED
        If Not intSelectedTemperature = -1 Then

            strTemp = CType(cbTemperature.Text.Replace("°F", ""), Double)
            If rbCarbonSteel.Checked = True Then

                txtAllowableStressRange.Text = "22,500"
                txtModulus.Text = "27,500,000"

                'SELECTS LINEAR EXPANSION MULTIPLIER BASED ON SELECTED TEMPERATURE
                dblLinearExpansion = steelExpansionCoefficients(intSelectedTemperature)

                'SETS THE TEXTBOX TEXT TO LINEAR EXPANSION MULTIPLIER
                txtLinearExpansion.Text = dblLinearExpansion

            ElseIf rbCopper.Checked = True Then

                txtAllowableStressRange.Text = "13,500"
                txtModulus.Text = "17,000,000"

                'SELECTS LINEAR EXPANSION MULTIPLIER BASED ON SELECTED TEMPERATURE
                dblLinearExpansion = copperExpansionCoefficients(intSelectedTemperature)

                'SETS THE TEXTBOX TEXT TO LINEAR EXPANSION MULTIPLIER
                txtLinearExpansion.Text = dblLinearExpansion

            End If

        End If

    End Sub

    Private Sub txtPipeLength_TextChanged(sender As Object, e As EventArgs) Handles txtPipeLength.TextChanged

        performCalculation()

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadPipeSizes()

        determineMaterialProperties()

    End Sub

    Private Sub cbTemperature_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTemperature.SelectedIndexChanged

        loadPipeSizes()

        determineMaterialProperties()

        performCalculation()

    End Sub

    Private Sub rbCarbonSteel_CheckedChanged(sender As Object, e As EventArgs) Handles rbCarbonSteel.CheckedChanged

        loadPipeSizes()

        determineMaterialProperties()

        performCalculation()

    End Sub

    Private Sub rbCopper_CheckedChanged(sender As Object, e As EventArgs) Handles rbCopper.CheckedChanged

        loadPipeSizes()

        determineMaterialProperties()

        performCalculation()

    End Sub

    Private Sub cbPipeSizes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPipeSizes.SelectedIndexChanged

        performCalculation()

    End Sub

    Function determinePipeOD() As Double

        'DECLARES AND INITIALIZES VARIABLES
        Dim strTabletoSelectFrom As String = String.Empty
        Dim intSelectedPipeSize As Integer
        Dim dblPipeOD As Double

        intSelectedPipeSize = cbPipeSizes.SelectedIndex

        If rbCarbonSteel.Checked = True Then

            'SELECTS PIPE OUTSIDE DIAMETER BASED ON SELECTED PIPE SIZE
            dblPipeOD = steelOutsideDiameters(intSelectedPipeSize)

        ElseIf rbCopper.Checked = True Then

            'SELECTS PIPE OUTSIDE DIAMETER BASED ON SELECTED PIPE SIZE
            dblPipeOD = copperOutsideDiameters(intSelectedPipeSize)

        End If

        Return dblPipeOD
    End Function

    Function calculateDelta(_linearExpansion As Double, _pipeLength As Double) As Double

        Dim delta As Double

        delta = (_linearExpansion / 100) * _pipeLength

        Return delta
    End Function

    Function calculateL(_delta As Double, _diameter As Double, _modulus As Double, _allowableStressRange As Double) As Double

        Dim dimensionL As Double

        dimensionL = Math.Sqrt((3 * _delta * _diameter * _modulus) / (144 * _allowableStressRange))

        Return dimensionL
    End Function

    Function calculateW(_dimensionL As Double) As Double

        Dim dimensionW As Double

        dimensionW = _dimensionL / 5

        Return dimensionW
    End Function

    Function calculateH(_dimensionW As Double) As Double

        Dim dimensionH As Double

        dimensionH = 2 * _dimensionW

        Return dimensionH
    End Function

    Private Sub loadPipeSizes()

        Dim previousSelectedSize As String = String.Empty

        If Not cbPipeSizes.SelectedIndex = -1 Then

            previousSelectedSize = cbPipeSizes.SelectedItem.ToString 'REMEMBERS THE PREVIOUSLY SELECTED PIPE SIZE

        End If

        If rbCarbonSteel.Checked = True Then

            cbPipeSizes.Items.Clear()

            For Each size As String In steelPipeSizes

                cbPipeSizes.Items.Add(size)

            Next

        ElseIf rbCopper.Checked = True Then

            cbPipeSizes.Items.Clear()

            For Each size As String In copperPipeSizes

                cbPipeSizes.Items.Add(size)

            Next

        End If

        cbPipeSizes.SelectedIndex = cbPipeSizes.FindStringExact(previousSelectedSize) 'IF THE PREVIOUS SELECTED PIPE SIZE EXISTS IT WILL KEEP IT SELECTED

    End Sub

End Class
