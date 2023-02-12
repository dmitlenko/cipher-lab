using CipherLabs.Core.Algorithms;
using CipherLabs.Core;
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
    public partial class EncryptionTablesControl : UserControl
    {
        private EncryptionTables encryptionTables = new EncryptionTables();
        public string Alphabet { get; set; }
        public TextBox OriginalTextBox { get; private set; }
        public TextBox ResultTextBox { get; private set; }
        public EncryptionTablesControl(TextBox originalTextBox, TextBox resultTextBox)
        {
            InitializeComponent();

            OriginalTextBox = originalTextBox;
            ResultTextBox = resultTextBox;
        }

        private void decode_Click(object sender, EventArgs e)
        {
            try
            {
                ResultTextBox.Text = encryptionTables.Decode(OriginalTextBox.Text, keyPhrase.Text, Convert.ToInt32(rowsCount.Value));
            } catch (CipherException ex)
            {
                MessageBox.Show(ex.Message, "Помилка!");
            }            
        }

        private void encode_Click(object sender, EventArgs e)
        {
            try
            {
                ResultTextBox.Text = encryptionTables.Encode(OriginalTextBox.Text, keyPhrase.Text, Convert.ToInt32(rowsCount.Value));
            }
            catch (CipherException ex)
            {
                MessageBox.Show(ex.Message, "Помилка!");
            }
        }
    }
}
