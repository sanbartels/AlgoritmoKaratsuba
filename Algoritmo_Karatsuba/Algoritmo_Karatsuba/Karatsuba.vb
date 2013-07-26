Imports System.Numerics
Public Class Karatsuba

    Public Function multiplicarKaratsuba(ByVal numero1 As BigInteger, ByVal numero2 As BigInteger) As BigInteger
        Dim numDigitos As BigInteger = Math.Max(numero1.ToString.Length, numero2.ToString.Length)
        If numDigitos <= 1000 Then
            Return BigInteger.Multiply(numero1, numero2)
        End If
        numDigitos /= 2
        Dim num1_dvd1 As BigInteger = numero1 >> numDigitos
        Dim num1_dvd2 As BigInteger = numero1 - (num1_dvd1 << numDigitos)
        Dim num2_dvd1 As BigInteger = numero2 >> numDigitos
        Dim num2_dvd2 As BigInteger = numero2 - (num2_dvd1 << numDigitos)
        'multiplicaciones
        Dim z2 As BigInteger = multiplicarKaratsuba(num1_dvd1, num2_dvd1)
        Dim z0 As BigInteger = multiplicarKaratsuba(num1_dvd2, num2_dvd2)
        Dim z1 As BigInteger = multiplicarKaratsuba((num1_dvd1 + num1_dvd2), (num2_dvd1 + num2_dvd2))
        Return (z2 + ((z1 - z2 - z0) << numDigitos) + (z0 << (2 * numDigitos)))
    End Function

End Class
