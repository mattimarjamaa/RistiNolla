Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Module Module1
	
	Public Structure Kentt‰
		Dim X As Short
		Dim Y As Short
		Dim Arvo As Short
		Dim Ind As Short
	End Structure
	Public Vuorossa As Short
	Public I As Short
	Public J As Short
	Public K1 As Short
	Public X As Short
	Public Y As Short
	Public Siirto As Short
	Public GameOver As Boolean
	Public Aloittaja As Short
	Public K(2, 2) As Short
	Public PosX(8) As Short
	Public PosY(8) As Short
	'Samojen merkkien m‰‰r‰...
	'UPGRADE_WARNING: Lower bound of array A was changed from 1,0 to 0,0. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1033"'
	Public A(8, 1) As Short
	'UPGRADE_WARNING: Lower bound of array B was changed from 1,0 to 0,0. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1033"'
	Public B(8, 2) As Kentt‰
	'1 - 3 Vaakaan vas-oik
	'4 - 6 Pystyyn yla-ala
	'7 vinoon vas.yl‰ - oik.ala
	'8 vinoon oik.yl‰ - vas.ala
	Public Const Pelaaja As Short = 0
	Public Const Kone As Short = 1
	Public KonePeli As Boolean
	Public Linjat As Kentt‰
	
	Sub N‰yt‰Suora(ByRef I As Short)
		For J = 0 To 2
			PL.DefInstance.Merkki(B(I, J).Ind).Image = PL.DefInstance.Pic(Vuorossa + 2).Image
		Next J
	End Sub
	
	Sub UusiPeli()
		Lopputoimet()
		For I = 0 To 8
			PL.DefInstance.Merkki(I).Image = PL.DefInstance.T_Pic.Image
		Next I
		GameOver = False
		If Aloittaja = Pelaaja Then Aloittaja = Kone Else Aloittaja = Pelaaja
		Vuorossa = Aloittaja
		If Vuorossa = Kone Or KonePeli Then PL.DefInstance.Timer1.Enabled = True
		PL.DefInstance.Score.Text = IIf(Vuorossa, "X", "O")
	End Sub
	
	Sub UusiKonepeli()
		Lopputoimet()
		KonePeli = True
		For I = 0 To 8
			PL.DefInstance.Merkki(I).Image = PL.DefInstance.T_Pic.Image
		Next I
		GameOver = False
		If Aloittaja = Pelaaja Then Aloittaja = Kone Else Aloittaja = Pelaaja
		Vuorossa = Aloittaja
		PL.DefInstance.Timer1.Enabled = True
		PL.DefInstance.Score.Text = IIf(Vuorossa, "X", "O")
	End Sub
	
	Sub SeuraavaPelaaja()
		Vuorossa = IIf(Vuorossa, 0, 1)
		PL.DefInstance.Score.Text = IIf(Vuorossa, "X", "O")
		Siirto = Siirto + 1
		If Siirto = 9 Then PL.DefInstance.Score.Text = "-"
		If (Vuorossa = Kone Or KonePeli) And Siirto < 9 Then PL.DefInstance.Timer1.Enabled = True
		If Siirto = 9 And KonePeli Then UusiKonepeli()
		If Siirto = 9 And Not KonePeli Then UusiPeli()
	End Sub
	'Tarkistetaan kuinka monta riviss‰
	Sub TarkistaSiirto()
		For I = 1 To 8
			A(I, 0) = 0 : A(I, 1) = 0
			For J = 0 To 2
				X = B(I, J).X
				Y = B(I, J).Y
				K1 = K(X, Y)
				If K1 > -1 Then A(I, K1) = A(I, K1) + 1
			Next J
		Next I
	End Sub
	
	Sub KoneenSiirto()
		Dim V As Short
		Dim BB As Boolean
		
		If Siirto < 3 Then
			'Suojataan keskelle, tai kulmaan.
			'If Not KonePeli Then
			Randomize(VB.Timer())
			'Hieman satunnaisuutta
			If K(1, 1) = -1 Then X = 1 : Y = 1 : Aseta(X, Y, 4) : Exit Sub
			V = Int(Rnd(1) * 3) : If K(0, 0) = -1 And V = 1 Then X = 0 : Y = 0 : Aseta(X, Y, 0) : Exit Sub
			V = Int(Rnd(1) * 3) : If K(2, 0) = -1 And V = 1 Then X = 2 : Y = 0 : Aseta(X, Y, 2) : Exit Sub
			V = Int(Rnd(1) * 3) : If K(0, 2) = -1 And V = 1 Then X = 0 : Y = 2 : Aseta(X, Y, 6) : Exit Sub
			V = Int(Rnd(1) * 3) : If K(2, 2) = -1 And V = 1 Then X = 2 : Y = 2 : Aseta(X, Y, 8) : Exit Sub
			'End If
			If K(1, 1) = -1 Then X = 1 : Y = 1 : Aseta(X, Y, 4) : Exit Sub
			If K(0, 0) = -1 Then X = 0 : Y = 0 : Aseta(X, Y, 0) : Exit Sub
			If K(2, 0) = -1 Then X = 2 : Y = 0 : Aseta(X, Y, 2) : Exit Sub
			If K(0, 2) = -1 Then X = 0 : Y = 2 : Aseta(X, Y, 6) : Exit Sub
			If K(2, 2) = -1 Then X = 2 : Y = 2 : Aseta(X, Y, 8) : Exit Sub
		End If
		V = IIf(Vuorossa, 0, 1)
		BB = EtsiPaikka(2)
		If BB Then Exit Sub
		If Not BB Then
			TarkistaSiirto()
			For I = 1 To 8
				If A(I, V) = 2 Then If Est‰Suora(I) Then Exit Sub
			Next I
			If EtsiPaikka(1) Then Exit Sub
		End If
		ArvotaanJonnekkin()
	End Sub
	
	Sub ArvotaanJonnekkin()
		Randomize(VB.Timer())
		Do 
			X = Int(Rnd(1) * 3)
			Y = Int(Rnd(1) * 3)
		Loop Until K(X, Y) = -1
		
		Aseta(X, Y, Y * 3 + X)
	End Sub
	
	Sub Aseta(ByRef X As Short, ByRef Y As Short, ByRef I As Short)
		K(X, Y) = Vuorossa
		'PL!Merkki(I).Picture = PL!Pic(Vuorossa)
		Siirr‰Merkki(I, Vuorossa)
	End Sub
	
	Function EtsiPaikka(ByRef AA As Short) As Boolean
		Dim V, Lupa As Short
		'Onko jossakin "kaksi" per‰kk‰in?
		V = IIf(Vuorossa, 0, 1)
		For I = 8 To 1 Step -1
			If A(I, Vuorossa) = AA Then
				Lupa = True 'Onko vastustajan merkkej‰ linjalla?
				For J = 0 To 2
					X = B(I, J).X
					Y = B(I, J).Y
					If K(X, Y) = V Then
						Lupa = False : Exit For
					End If
				Next J
				If Lupa Then 'Ei ollut sijoitetaan sinne.
					For J = 0 To 2
						X = B(I, J).X
						Y = B(I, J).Y
						If K(X, Y) = -1 Then Aseta(X, Y, B(I, J).Ind) : EtsiPaikka = True : Exit Function
					Next J
				End If
			End If
		Next I
	End Function
	
	Function Est‰Suora(ByRef I As Short) As Boolean
		For J = 0 To 2
			X = B(I, J).X
			Y = B(I, J).Y
			If K(X, Y) = -1 Then Aseta(X, Y, B(I, J).Ind) : Est‰Suora = True : Exit For
		Next J
	End Function
	
	Sub Lopputoimet()
		GameOver = True
		KonePeli = False
		PL.DefInstance.BackColor = System.Drawing.ColorTranslator.FromOle(QBColor(0))
		PL.DefInstance.Score.Text = "-"
		Siirto = 0
		For Y = 0 To 2 : For X = 0 To 2
				K(X, Y) = -1
				'PL!Merkki(Y * 3 + X).Visible = False
			Next  : Next 
		
		'For I = 0 To 8
		'    J = IIf(J, 0, 1)
		'    Siirr‰Merkki I, J
		'Next
		
	End Sub
	
	
	Sub Siirr‰Merkki(ByRef S As Short, ByRef T As Short)
		Dim XI, YI As Short
		Dim X1, Y1 As Short
		Dim X2, Y2 As Short
		
		X2 = PosX(S) : Y2 = PosY(S) 'Minne
		X1 = VB6.PixelsToTwipsX(PL.DefInstance.Pic(T).Left) : Y1 = VB6.PixelsToTwipsY(PL.DefInstance.Pic(T).Top) 'Mist‰
		PL.DefInstance.Pic(T).Visible = False
		PL.DefInstance.Merkki(S).Visible = False
		PL.DefInstance.Merkki(S).Left = VB6.TwipsToPixelsX(X1)
		PL.DefInstance.Merkki(S).Top = VB6.TwipsToPixelsY(Y1)
		PL.DefInstance.Merkki(S).Image = PL.DefInstance.Pic(T).Image
		PL.DefInstance.Merkki(S).Visible = True
		Do 
			XI = (X2 - X1) / 60 ' Alskelten m‰‰r‰ m‰‰r‰np‰‰h‰n...
			If XI <> 0 Then
				X1 = X1 + XI * 3 ' = Nopeus
				If (X1 >= X2 And XI = 1) Or (X1 <= X2 And XI = -1) Then
					X1 = X2 : XI = 0
				End If
			End If
			YI = (Y2 - Y1) / 60 ' Alskelten m‰‰r‰ m‰‰r‰np‰‰h‰n...
			If YI <> 0 Then
				Y1 = Y1 + YI * 3 ' = Nopeus
				If (Y1 >= Y2 And YI = 1) Or (Y1 <= Y2 And YI = -1) Then
					Y1 = X2 : YI = 0
				End If
			End If
			PL.DefInstance.Merkki(S).Left = VB6.TwipsToPixelsX(X1)
			PL.DefInstance.Merkki(S).Top = VB6.TwipsToPixelsY(Y1)
			System.Windows.Forms.Application.DoEvents()
		Loop Until XI = 0 And YI = 0
		PL.DefInstance.Merkki(S).Left = VB6.TwipsToPixelsX(PosX(S))
		PL.DefInstance.Merkki(S).Top = VB6.TwipsToPixelsY(PosY(S))
		PL.DefInstance.Line1.Refresh()
		PL.DefInstance.Line2.Refresh()
		PL.DefInstance.Line3.Refresh()
		PL.DefInstance.Line4.Refresh()
		PL.DefInstance.Pic(T).Visible = True
	End Sub
	'Kutsutaan Form-Load aliohjelmasta
	Sub Alkuarvot()
		For I = 0 To 8
			PosX(I) = VB6.PixelsToTwipsX(PL.DefInstance.Merkki(I).Left)
			PosY(I) = VB6.PixelsToTwipsY(PL.DefInstance.Merkki(I).Top)
		Next I
		Lopputoimet()
		'Asetetaan koordinaatit valmiiksi
		'A = kahdeksan suuntaa johon suora voidaan saada
		For I = 1 To 8
			Select Case I
				Case 1, 2, 3
					For X = 0 To 2
						B(I, X).X = X
						B(I, X).Y = I - 1
						B(I, X).Ind = (I - 1) * 3 + X
					Next X
				Case 4, 5, 6
					For Y = 0 To 2
						B(I, Y).Y = Y
						B(I, Y).X = I - 4
						B(I, Y).Ind = Y * 3 + (I - 4)
					Next Y
				Case 7
					For J = 0 To 2
						B(I, J).X = J
						B(I, J).Y = J
						B(I, J).Ind = J * 3 + J
					Next J
				Case 8
					For J = 0 To 2
						B(I, J).X = 2 - J
						B(I, J).Y = J
						B(I, J).Ind = J * 3 + (2 - J)
					Next J
			End Select
		Next I
		
	End Sub
End Module