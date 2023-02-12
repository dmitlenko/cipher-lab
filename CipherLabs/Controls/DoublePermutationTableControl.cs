using CipherLabs.Core;
using CipherLabs.Core.Algorithms;
using System;
using System.Windows.Forms;

namespace CipherLabs.Controls
{
    public partial class DoublePermutationTableControl : UserControl
    {
        public TextBox OriginalTextBox { get; private set; }
        public TextBox ResultTextBox { get; private set; }
        private DoublePermutationTable doublePermutationTable = new DoublePermutationTable();

        public DoublePermutationTableControl(TextBox originalTextBox, TextBox resultTextBox)
        {
            InitializeComponent();

            OriginalTextBox = originalTextBox;
            ResultTextBox = resultTextBox;
        }

        private void encode_Click(object sender, EventArgs e)
        {
            try
            {
                ResultTextBox.Text = doublePermutationTable.Encode(OriginalTextBox.Text, keyX.Text, keyY.Text);
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
                ResultTextBox.Text = doublePermutationTable.Decode(OriginalTextBox.Text, keyX.Text, keyY.Text);
            }
            catch (CipherException ex)
            {
                MessageBox.Show(ex.Message, "Помилка!");
            }
        }
    }
}