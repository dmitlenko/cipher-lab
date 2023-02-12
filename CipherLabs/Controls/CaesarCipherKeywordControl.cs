using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CipherLabs.Core;
using CipherLabs.Core.Algorithms;

namespace CipherLabs.Controls
{
    public partial class CaesarCipherKeywordControl : UserControl
    {
        private CaesarCipherKeyword caesarCipher = new CaesarCipherKeyword(Alphabets.English);
        public int Key { get => Convert.ToInt32(key.Value); }
        public string KeyWord { get => keyPhrase.Text; }
        public TextBox OriginalTextBox { get; private set; }
        public TextBox ResultTextBox { get; private set; }
        public CaesarCipherKeywordControl(TextBox originalTextBox, TextBox resultTextBox)
        {
            InitializeComponent();
            
            OriginalTextBox = originalTextBox;
            ResultTextBox = resultTextBox;

            alphabetCombo.SelectedIndex = 0;
        }
        private void keyPhrase_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !
                ((caesarCipher.Alphabet.Contains(char.ToUpper(e.KeyChar)) &&
                (!(sender as TextBox).Text.ToUpper().Contains(char.ToUpper(e.KeyChar)))) || char.IsControl(e.KeyChar));
        }

        private void alphabetCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (alphabetCombo.SelectedIndex)
            {
                case 0:
                    caesarCipher.Alphabet = Alphabets.English;
                    break;
                case 1:
                    caesarCipher.Alphabet = Alphabets.Ukrainian;
                    break;
            }

            key.Maximum = caesarCipher.Alphabet.Length;
            key.Minimum = 0;
        }

        private void decode_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = caesarCipher.Decode(OriginalTextBox.Text, Key, KeyWord);
        }

        private void encode_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = caesarCipher.Encode(OriginalTextBox.Text, Key, KeyWord);
        }

    }
}
