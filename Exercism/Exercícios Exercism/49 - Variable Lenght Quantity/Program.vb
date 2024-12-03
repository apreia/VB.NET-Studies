Imports System

Module Program
    Sub Main()
        Dim encoded As UInteger() = VariableLengthQuantity.Encode({127UI, 128UI, 8192UI, &HFFFFFFFUI})
        Console.WriteLine("Encoded: " & String.Join(" ", encoded.Select(Function(b) b.ToString("X2"))))

        Dim decoded As UInteger() = VariableLengthQuantity.Decode(encoded)
        Console.WriteLine("Decoded: " & String.Join(", ", decoded))
    End Sub
End Module