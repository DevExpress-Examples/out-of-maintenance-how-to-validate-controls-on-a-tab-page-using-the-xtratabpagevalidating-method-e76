Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace ValidatingTabs
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Function ValidatePage1() As Boolean
			Dim validated As Boolean = spinEdit1.Value > 10
			If (Not validated) Then
				MessageBox.Show("The value must be greater than 10")
			Else
				validated = DateTime.Today.Equals(dateEdit1.DateTime)
				If (Not validated) Then
					MessageBox.Show("The date must be equal the today date")
				End If
			End If
			Return validated
		End Function

		Private Sub xtraTabPage1_Validating(ByVal sender As Object, ByVal e As CancelEventArgs) Handles xtraTabPage1.Validating
			e.Cancel = Not ValidatePage1()
		End Sub
	End Class
End Namespace