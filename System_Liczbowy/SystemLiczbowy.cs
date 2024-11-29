using System;

namespace System_Liczbowy
{
    internal class SystemLiczbowy
    {
        string dziesietna;
        string binarna;
        string osemkowa;
        string szesnastkowa;

        public string Dziesietna
        {
            get { return dziesietna; }
            set
            {
                dziesietna = value;
                int number = int.Parse(dziesietna);
                binarna = ToBinary(number);
                osemkowa = DecimalToOctal(number);
                szesnastkowa = DecimalToHex(number);
            }
        }

        public string Binarna
        {
            get { return binarna; }
            set
            {
                binarna = value;
                int number = BinaryToDecimal(binarna);
                dziesietna = number.ToString();
                osemkowa = DecimalToOctal(number);
                szesnastkowa = DecimalToHex(number);
            }
        }

        public string Osemkowa
        {
            get { return osemkowa; }
            set
            {
                osemkowa = value;
                int number = OctalToDecimal(osemkowa);
                dziesietna = number.ToString();
                binarna = ToBinary(number);
                szesnastkowa = DecimalToHex(number);
            }
        }

        public string Szesnastkowa
        {
            get { return szesnastkowa; }
            set
            {
                szesnastkowa = value;
                int number = HexToDecimal(szesnastkowa);
                dziesietna = number.ToString();
                binarna = ToBinary(number);
                osemkowa = DecimalToOctal(number);
            }
        }

        public SystemLiczbowy()
        {
            dziesietna = "";
            binarna = "";
            osemkowa = "";
            szesnastkowa = "";
        }

        private string ToBinary(int number)
        {
            if (number == 0) return "0";
            string binary = "";
            while (number > 0)
            {
                binary = (number % 2) + binary;
                number /= 2;
            }

            return binary;
        }

        private string DecimalToOctal(int number)
        {
            
            if (number == 0) return "0";
            string octal = "";
            while (number > 0)
            {
                octal = (number % 8) + octal;
                number /= 8;
            }
            return octal;
        }

        private string DecimalToHex(int number)
        {
            if (number == 0) return "0";
            string hex = "";
            while (number > 0)
            {
                int remainder = number % 16;
                
                hex = (remainder < 10 ? remainder.ToString() : ((char)(remainder - 10 + 'A')).ToString()) + hex;
                number /= 16;
            }
            return hex;
        }

        private int BinaryToDecimal(string binary)
        {
            int decimalValue = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[binary.Length - 1 - i] == '1')
                {
                    decimalValue += (1 << i); 
                }
            }
            return decimalValue;
        }

        private int OctalToDecimal(string octal)
        {
            int decimalValue = 0;
            for (int i = 0; i < octal.Length; i++)
            {
                decimalValue = decimalValue * 8 + (octal[i] - '0');
            }
            return decimalValue;
        }

        private int HexToDecimal(string hex)
        {
            int decimalValue = 0;
            for (int i = 0; i < hex.Length; i++)
            {
                decimalValue = decimalValue * 16 + (hex[i] >= 'A' ? hex[i] - 'A' + 10 : hex[i] - '0');
            }
            return decimalValue;
        }

        public override string ToString()
        {
            int temp = binarna.Length % 4;
            string missingzero = "";
            if (temp > 0)
            {


                for (int i = 0; i < temp; i++)
                {
                    missingzero += "0";
                }
            }



                return $"Liczba dziesiętna: {dziesietna}\n" +
                   $"Liczba binarna: {missingzero}{binarna}\n" +
                   $"Liczba ósemkowa: {osemkowa}\n" +
                   $"Liczba szesnastkowa: {szesnastkowa}";
    }
    }
}