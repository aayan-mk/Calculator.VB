Option Explict
Dim x As Double 
Dim operand1 As Double, operand2 As Double 
Dim operator As String 


Private Sub Command1_Click()
Text1.Text= Text.Text+"1"
End Sub


Private Sub Command10_Click()
Text1.Text=""
 End Sub


Private Sub Command11_Click()
Text1.Text=Text1.Text+"0"
End Sub


Private Sub Command12_Click()
Text1.Text=Text1.Text+"."
End Sub


Private Sub Command13_Click()
operand1=Val(Text1.Text)
operator="+"
Text1.Text=""
End Sub


Private Sub Command14_Click()
operand1=Val(Text1.Text)
operator="-"
Text1.Text=""
End Sub


Private Sub Command15_Click()
operand1=Val(Text1.Text)
operator="*"
Text1.Text=" "
End Sub


Private Sub Command16_Click()
operand1=Val(Text1.Text)
operator="/"
Text1.Text=""
End Sub


Private Sub Command17_Click()
Dim result As Double
operand2=Val(Text1.Text)
If operator="-" Then result=operand1-operand2
If operator="*" Then result=operand1*operand2
If operator="+" Then result=operand1+operand2
If operator="/" And operand2<>"0" Then result=operand1/operand2
Text1.Text=result
End Sub


Private Sub Command18_Click()
Text1.Text=Text1.Text*-1
End Sub


Private Sub Command2_Click()
Text1.Text=Text1.Text+"2"
End Sub


Private Sub Command3_Click()
Text1.Text=Text1.Text+"3"
End Sub


Private Sub Command4_Click()
Text1.Text=Text1.Text+"4"
End Sub


Private Sub Command5_Click()
Text1.Text=Text1.Text+"5"
End Sub


Private Sub Command6_Click()
Text1.Text=Text1.Text+"6"
End Sub


Private Sub Command7_Click()
Text1.Text=Text1.Text+"7"
End Sub


Private Sub Command8_Click()
Text1.Text=Text1.Text+"8"
End Sub


Private Sub Command9_Click()
Text1.Text=Text1.Text+"9"
End Sub
