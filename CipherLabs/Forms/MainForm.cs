using System;
using System.Windows.Forms;
using CipherLabs.Controls;

namespace CipherLabs.Forms
{
    public partial class MainForm : Form
    {
        private UserControl cipherControl;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            algorithms.SelectedIndex = 0;
        }

        private void algoDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (algorithms.SelectedIndex) {
                case 0:
                    cipherControl = new CaesarCipherControl(textOriginal, textResult);
                    break;
                case 1:
                    cipherControl = new CaesarCipherKeywordControl(textOriginal, textResult);
                    break;
                case 2:
                    cipherControl = new AffineCipherControl(textOriginal, textResult);
                    break;
                case 3:
                    cipherControl = new EncryptionTablesControl(textOriginal, textResult);
                    break;
            }

            cipherPanel.Controls.Clear();
            cipherControl.Dock = DockStyle.Fill;
            cipherPanel.Controls.Add(cipherControl);
        }

        private void copyToOriginal_Click(object sender, EventArgs e)
        {
            textOriginal.AppendText(textResult.Text);
        }

        private void replaceOriginal_Click(object sender, EventArgs e)
        {
            textOriginal.Text = textResult.Text;
        }
    }
}
