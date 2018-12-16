namespace Be.Vlaanderen.Basisregisters.Utilities.HexByteConvertor
{
    using System;

    // https://stackoverflow.com/questions/311165/how-do-you-convert-a-byte-array-to-a-hexadecimal-string-and-vice-versa
    public static class ByteArrayExtensions
    {
        public static string ToHexString(this byte[] bytes)
        {
            if (bytes == null)
                return null;

            var c = new char[bytes.Length * 2];

            for (int i = 0, b; i < bytes.Length; i++)
            {
                b = bytes[i] >> 4;
                c[i * 2] = (char)(55 + b + (((b - 10) >> 31) & -7));
                b = bytes[i] & 0xF;
                c[i * 2 + 1] = (char)(55 + b + (((b - 10) >> 31) & -7));
            }

            return new string(c);
        }

        public static byte[] ToByteArray(this string hex)
        {
            if (hex == null)
                return null;

            if (string.IsNullOrEmpty(hex))
                return new byte[0];

            var numberChars = hex.Length;
            var bytes = new byte[numberChars / 2];
            for (var i = 0; i < numberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);

            return bytes;
        }
    }
}
