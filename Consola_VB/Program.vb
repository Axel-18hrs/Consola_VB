Imports System
Imports System.IO

Module Program
    Private nn As Integer = 0
    Private personas(999) As Contacto
    Private leerArchivo As StreamReader
    Private escribirArchivo As StreamWriter
    Private path As String
    Sub New()

    End Sub

    ' este programa se hizo para crear y leer un mismo archiv, este recopila los daatos del usuario para almacenarlos en un archivo txt
    Sub Main(args As String())
        Dim x As Boolean = False
        While x = False
            personas(nn) = New Contacto()
            Try
                ' ubicacion dentro de la misma carpeta del programa
                path = "C:\Users\axel1\source\Repos\Consola_VB\Consola_VB\dats12"
                Console.WriteLine("// ingresa los siguientes datos" & vbCrLf)
                Console.WriteLine("[1]- Ingresa tu nombre completo:")
                    personas(nn).Nombre = Console.ReadLine()

                    Console.WriteLine("[2]- Ingresa tu telefono:")
                    personas(nn).Telefono = Console.ReadLine()

                    Console.WriteLine("[3]- Ingresa tu correo:")
                    personas(nn).Correo = Console.ReadLine()

                    Console.WriteLine("[4]- Ingresa tu fecha de nacimiento (DD/MM/AAAA):")
                    personas(nn).FechaNacimiento = Console.ReadLine()


                Dim opc As Integer = 0
                While opc = 0
                    Try
                        Console.Clear()
                        Console.WriteLine("// escoge lo que quieres hacer")
                        Console.WriteLine("[1]- continuar agregando")
                        Console.WriteLine("[2]- leer archivo creado")
                        Console.WriteLine("[3]- salir")
                        opc = CInt(Console.ReadLine())
                        Select Case opc
                            Case 1
                                Console.Clear()
                            Case 2
                                Using escribirArchivo = New StreamWriter(path)
                                    For i As Integer = 0 To nn Step 1
                                        escribirArchivo.WriteLine(personas(i).Nombre & vbTab & personas(i).Telefono & vbTab & personas(i).Correo & vbTab & personas(i).Edad & vbTab)
                                    Next
                                    escribirArchivo.Close()
                                End Using
                                Using leerArchivo = New StreamReader(path)
                                    Dim linea As String = leerArchivo.ReadLine()
                                    While linea IsNot Nothing
                                        Console.WriteLine(linea)
                                        linea = leerArchivo.ReadLine()
                                    End While
                                End Using
                            Case 3
                                x = True
                                Console.WriteLine("// saliendo de la aplicacion...")
                        End Select
                    Catch ex As Exception
                        Console.Clear()
                        Console.WriteLine("// eso no es una opcion, vuelvelo a intentar")
                        Console.ReadKey()
                    End Try
                End While
                opc = 0
                nn += 1
                Console.ReadKey()
            Catch ex As Exception
                Console.Clear()
                Console.WriteLine("// llena los datos de la manera correcta la proxima vez")
                Console.ReadKey()
                Console.Clear()
            End Try
        End While
    End Sub

End Module
