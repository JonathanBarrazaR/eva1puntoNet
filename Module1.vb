Module Module1

    Sub Main()


        'eje1 calculadora de prod

        'Dim nota1 As Integer
        'Dim nota2 As Integer
        'Dim nota3 As Integer
        'Dim prod As Integer


        'nota1 = InputBox("Ingrese la Primera nota nro1")
        'nota2 = InputBox("Ingrese la Primera nota nro2")
        'nota3 = InputBox("Ingrese la Primera nota nro3")

        'prod = (nota1 + nota2 + nota3) / 3

        'MsgBox("el prodmedio final es: " & prod)

        'Console.ReadKey()

        'eje2 conversor de tempe

        'Dim K As Double
        'Dim C As Double
        'Dim F As Double
        'Dim selector As Integer
        ' Formula Celsius X 9/5 +32 para faren // Celsius + 273.15



        'selector = InputBox("Ingrese el selector de temperatura
        '          1- Celsius - Fahrenheit.
        '          2- Celsius - kelvin.
        '          3- Fahrenheit - Celsius.
        '          4- Fahrenheit - Kelvin. ")

        'Select Case selector
        '    Case 1 '------------------------
        '        C = InputBox("Ingrese la temperatura en Celsius para convertirla en Fahrenheit")

        '        F = (C * 9 / 5 + 32)

        '        MsgBox("La conversion de Celsius a Fahrenheit es: " & F & "F°")
        '    Case 2 '--------------------------
        '        C = InputBox("Ingrese la temperatura en Celsius para convertirla en Kelvin")

        '        K = (C + 273.15)

        '        MsgBox("La conversion de Celsius a Kelvin es: " & K & "K°")
        '    Case 3 '----------------------------
        '        F = InputBox("Ingrese la temperatura en Fahrenheit para convertirla en Celsius")

        '        C = (F - 32) * 5 / 9

        '        MsgBox("La conversion de Fahrenheit a Celsius es: " & C & "C°")
        '    Case 4 '----------------------------
        '        F = InputBox("Ingrese la temperatura en Fahrenheit para convertirla en Kelvin")

        '        K = (F + 459.67) * 5 / 9

        '        MsgBox("La conversion de Fahrenheit a Kelvin es: " & K & "K°")
        'End Select

        '        Console.ReadKey()

        'eje3 par o impar

        'Dim nro As Integer = InputBox("Ingrese un numero para detectar si es par o impar")

        'If nro Mod 2 = 0 Then
        '    MsgBox("El numero que as elegido " & nro & " es par")
        'Else
        '    MsgBox("El numero que as elegido " & nro & " es impar")
        'End If

        'Console.ReadKey()

        'eje4 calcu de descuanto
        '    Dim regular As Double = 0.05
        '    Dim premium As Double = 0.15
        '    Dim vip As Double = 0.3
        '    Dim finwi As Boolean = True
        '    Dim selector As Integer
        '    Dim precioprod As Integer
        '    Dim total As Integer
        '    Dim descu As Double

        '    While finwi
        '        precioprod = 0
        '        total = 0
        '        descu = 0

        '        precioprod = InputBox("Ingrese el precio de los productos")

        '        selector = InputBox("Ingrese el rango de membresia
        '1- Regular
        '2- Premium
        '3- VIP
        '4- Salir")

        '        Select Case selector
        '            Case 1
        '                descu = precioprod * regular
        '                total = precioprod - descu

        '                MsgBox("el total de los productos son: " & precioprod &
        '                       " y el descuento fue de: " & descu &
        '                       " el total de la compra fue: " & total)
        '            Case 2
        '                descu = precioprod * premium
        '                total = precioprod - descu

        '                MsgBox("el total de los productos son: " & precioprod &
        '                       " y el descuento fue de: " & descu &
        '                       " el total de la compra fue: " & total)
        '            Case 3
        '                descu = precioprod * vip
        '                total = precioprod - descu

        '                MsgBox("el total de los productos son: " & precioprod &
        '                       " y el descuento fue de: " & descu &
        '                       " el total de la compra fue: " & total)
        '            Case 4
        '                finwi = False
        '                MsgBox("Hasta luego")
        '        End Select

        '    End While

        'ejer 5 ano bisiesto

        'Dim finiw As Boolean = True
        'Dim ano As Integer = 0
        'Dim sino As String


        'While finiw
        '    ano = InputBox("Ingrese el año para saber si es bisiesto o no")

        '    If ano Mod 4 = 0 AndAlso (ano Mod 100 <> 0 OrElse ano Mod 400 = 0) Then
        '        MsgBox("el año es bisiesto")
        '    Else
        '        MsgBox("el año no es bisiesto")
        '    End If

        '    sino = InputBox("¿continuar? si/no")
        '    If sino.ToString.ToLower() = "si" Then

        '    Else
        '        finiw = False
        '        MsgBox("Adios")
        '    End If
        'End While

        'ejeci 6 - 0...3...6

        'Dim numero As Integer
        'Dim n As Integer

        'numero = CInt(InputBox("Ingrese un numero"))

        'For n = 0 To numero
        '    If n Mod 3 = 0 Then
        '        MsgBox("el numero " & n & " es multiplo de 3")
        '    End If
        'Next

        'ejer 7 valida contra

        'Dim contra As String
        'Dim tieneletra As Boolean
        'Dim tienenumero As Boolean
        'Dim n As Integer

        'contra = InputBox("ingrese una contraseña")

        'If Len(contra) < 8 Then
        '    MsgBox("La contraseña debe tener al menos 8 caracteres.")
        '    Exit Sub
        'End If

        'tieneletra = False
        'tienenumero = False

        'For n = 1 To Len(contra)
        '    If IsNumeric(Mid(contra, n, 1)) Then
        '        tienenumero = True
        '    End If
        '    If Mid(contra, n, 1) Like "[a-zA-Z]" Then
        '        tieneletra = True
        '    End If
        'Next n

        'If tieneletra And tienenumero Then
        '    MsgBox("La contraseña cumple con los criterios de seguridad.")
        'Else
        '    MsgBox("La contraseña no cumple con los criterios de seguridad.")
        'End If


        'ejer 8 - reverva hotel




    End Sub


End Module
