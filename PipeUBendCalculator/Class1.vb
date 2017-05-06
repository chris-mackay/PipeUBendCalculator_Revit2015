Imports Autodesk.Revit.DB
Imports Autodesk.Revit.UI
Imports Autodesk.Revit.UI.Selection

<Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)> _
<Autodesk.Revit.Attributes.Regeneration(Autodesk.Revit.Attributes.RegenerationOption.Manual)> _
<Autodesk.Revit.Attributes.Journaling(Autodesk.Revit.Attributes.JournalingMode.NoCommandData)> _
Public Class Class1

    Implements IExternalCommand

    Public Function Execute(commandData As ExternalCommandData, ByRef message As String, elements As ElementSet) As Result Implements IExternalCommand.Execute

        Dim app As UIApplication = commandData.Application
        Dim uidoc As UIDocument = commandData.Application.ActiveUIDocument
        Dim document As Autodesk.Revit.DB.Document = commandData.Application.ActiveUIDocument.Document

        Dim selectedElements As Selection

        selectedElements = app.ActiveUIDocument.Selection

        Dim selectedIDs As ICollection(Of ElementId) = uidoc.Selection.GetElementIds

        If selectedIDs.Count > 0 Then

            For each id As ElementId In selectedIDs

                Dim elem As Element = document.GetElement(id)

                If Not IsDBNull(elem) Then

                    If elem.Category.Name = "Pipes" Then

                        Dim myMainForm As New MainForm
                        myMainForm.Show()

                        Dim length As Double = elem.LookupParameter("Length").AsDouble()
                        Dim diameter As String = elem.LookupParameter("Diameter").AsValueString()

                        With myMainForm

                            .cbTemperature.SelectedIndex = .cbTemperature.FindStringExact("180°F")
                            .cbPipeSizes.SelectedIndex = .cbPipeSizes.FindStringExact(diameter)
                            .txtPipeLength.Text = length

                            myMainForm.determineMaterialProperties()
                            myMainForm.performCalculation()

                        End With

                    Else

                        TaskDialog.Show("Invalid Selection", "The element you have selected is not a pipe. Select a length of pipe and run the program again.")

                    End If

                End If
                
            Next
            
        Else

            TaskDialog.Show("No Pipe Selected", "Select a length of pipe and run the program again.")

        End If

            Return Result.Succeeded
    End Function

End Class
