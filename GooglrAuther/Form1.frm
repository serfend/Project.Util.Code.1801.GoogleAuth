VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   5760
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   8130
   LinkTopic       =   "Form1"
   ScaleHeight     =   5760
   ScaleWidth      =   8130
   StartUpPosition =   3  '´°¿ÚÈ±Ê¡
   Begin VB.CommandButton Command1 
      Caption         =   "Command1"
      Height          =   1335
      Left            =   2160
      TabIndex        =   0
      Top             =   2160
      Width           =   3135
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()
    Dim googleAuth As New googleAuth.Auth
    With googleAuth
        .SetIdentity "serfend"
        .SetSecretBase32 "ffddggoogleauthtest"
        MsgBox "Url:" & .QRCodeUrl & vbCrLf & .OneTimePassword
    End With
End Sub

