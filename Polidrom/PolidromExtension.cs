using System;
namespace Polidrom
{
    public static class PolidromExtension
    {
        public static bool IsPolidrom(this string IsPolidrom)
        {
            string conversely = "";
            string outputText = "";

            for (int i = 0; i < IsPolidrom.Length; i++)
            {
                if (Char.IsLetter(IsPolidrom, i))
                    outputText += IsPolidrom[i];
            }
            outputText = outputText.ToLower();

            for (int i = outputText.Length - 1; i >= 0; i--)
            {
                conversely += outputText[i];
            }
            if (outputText == conversely)
                return true;
            return false;
        }
    }
}
