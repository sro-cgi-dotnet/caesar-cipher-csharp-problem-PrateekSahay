using System;
using System.Linq;
using System.Text;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        
        public static string Rotate(string text, int shiftKey)
        {
            // ASCII code for a -> 97 z -> 122 && A -> 65 Z -> 90
            int upperAlphabet = 65;
            int lowerAlphabet = 97;
            
            StringBuilder cipher = new StringBuilder();
            int charInAscii = 0;
            foreach(char c in text){
                charInAscii = c;
                if(charInAscii >= 'A' && charInAscii <= 'Z'){
                    charInAscii = CaesarCipherHelper(charInAscii, upperAlphabet, shiftKey);
                }
                else if(charInAscii >= 'a' && charInAscii <= 'z'){
                    charInAscii = CaesarCipherHelper(charInAscii, lowerAlphabet, shiftKey);
                }
                
                char cipherChar = (char)charInAscii;
                
                cipher.Append(cipherChar);
            }
            return cipher.ToString();
        }
      
        private static int CaesarCipherHelper(int charInAscii, int alphabetStart, int shiftKey){
            charInAscii = charInAscii - alphabetStart + shiftKey;
            charInAscii %= 26;
            charInAscii += alphabetStart;
            return charInAscii;
        }
    }
}
