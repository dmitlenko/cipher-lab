using CipherLabs.Core;
using CipherLabs.Core.Algorithms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CipherLabs.Controls
{
    public partial class PlayfairCipherControl : UserControl
    {
        private PlayfairCipher playfairCipher = new PlayfairCipher();
        public TextBox OriginalTextBox { get; private set; }
        public TextBox ResultTextBox { get; private set; }
        public PlayfairCipherControl(TextBox originalTextBox, TextBox resultTextBox)
        {
            InitializeComponent();

            OriginalTextBox = originalTextBox;
            ResultTextBox = resultTextBox;

            alphabetCombo.SelectedIndex = 0;
            playfairCipher.Alphabet = Alphabets.English;
        }

        private void alphabetCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (alphabetCombo.SelectedIndex)
            {
                case 0:
                    playfairCipher.Alphabet = Alphabets.English;
                    break;
                case 1:
                    playfairCipher.Alphabet = Alphabets.Ukrainian;
                    break;
            }
        }

        private void encode_Click(object sender, EventArgs e)
        {
            try
            {
                ResultTextBox.Text = playfairCipher.Encode(OriginalTextBox.Text, keyPhrase.Text);
            }
            catch (CipherException ex)
            {
                MessageBox.Show(ex.Message, "Помилка!");
            }
        }

        private void decode_Click(object sender, EventArgs e)
        {
            try
            {
                ResultTextBox.Text = playfairCipher.Decode(OriginalTextBox.Text, keyPhrase.Text);
            }
            catch (CipherException ex)
            {
                MessageBox.Show(ex.Message, "Помилка!");
            }
        }
    }
}
