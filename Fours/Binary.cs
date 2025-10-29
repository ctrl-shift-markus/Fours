using System;

namespace Fours;
public class Binary
{

    // Converts a binary number (as a string) to its decimal equivalent
    public static int ToDecimal(string binaryNumber)
    {
        int decimalValue = 0;
        int length = binaryNumber.Length;
        for (int i = 0; i < length; i++)
        {
            if (binaryNumber[length - 1 - i] == '1')
            {
                decimalValue += (1 << i);
            }
        }
        return decimalValue;
    }

    // Converts a decimal number to its binary equivalent (as a string)
    public static string ToBinary(int decimalNumber)
    {
        if (decimalNumber == 0) return "0";
        string binary = string.Empty;
        while (decimalNumber > 0)
        {
            binary = (decimalNumber % 2).ToString() + binary;
            decimalNumber /= 2;
        }
        return binary;
    }

    // Checks if a string represents a valid binary number
    public static bool IsBinary(string input)
    {
        foreach (char c in input)
        {
            if (c != '0' && c != '1')
            {
                return false;
            }
        }
        return true;
    }

    // Checks if a string represents a valid decimal number
    public static bool IsDecimal(string input)
    {
        foreach (char c in input)
        {
            if (c < '0' || c > '9')
            {
                return false;
            }
        }
        return true;
    }
}