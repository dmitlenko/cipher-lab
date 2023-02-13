using CipherLabs.Core;
using CipherLabs.Core.Algorithms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CipherLabs.Controls
{
    public partial class AffineCipherControl : UserControl
    {
        public AffineCipherControl(TextBox originalTextBox, TextBox resultTextBox)
        {
            InitializeComponent();

            OriginalTextBox = originalTextBox;
            ResultTextBox = resultTextBox;

            alphabetCombo.SelectedIndex = 0;
        }

        private AffineCipher affineCipher = new AffineCipher(Alphabets.English);
        public int ValA { get => Convert.ToInt32(a.Value); }
        public int ValB { get => Convert.ToInt32(b.Value); }
        public TextBox OriginalTextBox { get; private set; }
        public TextBox ResultTextBox { get; private set; }

        private void keyPhrase_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !
                ((affineCipher.Alphabet.Contains(char.ToUpper(e.KeyChar)) &&
                (!(sender as TextBox).Text.ToUpper().Contains(char.ToUpper(e.KeyChar)))) || char.IsControl(e.KeyChar));
        }

        private void alphabetCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (alphabetCombo.SelectedIndex)
            {
                case 0:
                    affineCipher.Alphabet = Alphabets.English;
                    break;

                case 1:
                    affineCipher.Alphabet = Alphabets.Ukrainian;
                    break;
            }

            a.Maximum = b.Maximum = affineCipher.Alphabet.Length;
        }

        private void decode_Click(object sender, EventArgs e)
        {
            try
            {
                ResultTextBox.Text = affineCipher.Decode(OriginalTextBox.Text, ValA, ValB);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void encode_Click(object sender, EventArgs e)
        {
            try
            {
                ResultTextBox.Text = affineCipher.Encode(OriginalTextBox.Text, ValA, ValB);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}