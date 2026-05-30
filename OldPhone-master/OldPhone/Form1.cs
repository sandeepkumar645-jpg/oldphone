using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OldPhone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            lblOutput.Text = OldPhonePad(txtInput.Text);
        }

        public static string OldPhonePad(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return string.Empty;

            var keyMap = new Dictionary<char, string>()
            {
                {'2', "ABC"},
                {'3', "DEF"},
                {'4', "GHI"},
                {'5', "JKL"},
                {'6', "MNO"},
                {'7', "PQRS"},
                {'8', "TUV"},
                {'9', "WXYZ"},
                {'0', " "}
            };

            StringBuilder result = new StringBuilder();
            char lastKey = '\0';
            int count = 0;

            foreach (char c in input)
            {
                if (c == '#')
                {
                    if (lastKey != '\0')
                        result.Append(GetCharFromKey(keyMap, lastKey, count));
                    break;
                }
                else if (c == '*')
                {
                    if (result.Length > 0)
                        result.Remove(result.Length - 1, 1);
                    lastKey = '\0';
                    count = 0;
                }
                else if (c == ' ')
                {
                    if (lastKey != '\0')
                        result.Append(GetCharFromKey(keyMap, lastKey, count));
                    lastKey = '\0';
                    count = 0;
                }
                else if (char.IsDigit(c))
                {
                    if (c == lastKey)
                    {
                        count++;
                    }
                    else
                    {
                        if (lastKey != '\0')
                            result.Append(GetCharFromKey(keyMap, lastKey, count));
                        lastKey = c;
                        count = 1;
                    }
                }
            }

            if (lastKey != '\0')
                result.Append(GetCharFromKey(keyMap, lastKey, count));

            return result.ToString();
        }

        private static char GetCharFromKey(Dictionary<char, string> keyMap, char key, int count)
        {
            if (!keyMap.ContainsKey(key))
                return '\0';
            string letters = keyMap[key];
            int index = (count - 1) % letters.Length;
            return letters[index];
        }
    }
}
