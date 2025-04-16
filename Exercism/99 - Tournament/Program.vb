Imports System
Imports System.IO

Module Program
    Sub Main()
        Dim input As String = "Allegoric Alaskans;Blithering Badgers;win" & vbLf &
                              "Devastating Donkeys;Courageous Californians;draw" & vbLf &
                              "Devastating Donkeys;Allegoric Alaskans;win" & vbLf &
                              "Courageous Californians;Blithering Badgers;loss" & vbLf &
                              "Blithering Badgers;Devastating Donkeys;loss" & vbLf &
                              "Allegoric Alaskans;Courageous Californians;win"

        Using inStream As New MemoryStream(System.Text.Encoding.UTF8.GetBytes(input)),
              outStream As New MemoryStream()

            Tournament.Tally(inStream, outStream)

            outStream.Seek(0, SeekOrigin.Begin)
            Using reader As New StreamReader(outStream)
                Console.WriteLine(reader.ReadToEnd())
            End Using
        End Using
    End Sub
End Module