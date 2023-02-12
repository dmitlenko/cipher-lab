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
    public partial class CaesarCipherControl : UserControl
    {
        private CaesarCipher caesarCipher = new CaesarCipher(Alphabets.English);
        public int Key { get => Convert.ToInt32(key.Value); }
        public TextBox OriginalTextBox { get; private set; }
        public TextBox ResultTextBox { get; private set; }
        public CaesarCipherControl(TextBox originalTextBox, TextBox resultTextBox)
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
        }

        private void decode_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = caesarCipher.Decode(OriginalTextBox.Text, Key);
        }

        private void encode_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = caesarCipher.Encode(OriginalTextBox.Text, Key);
        }
    }
}
