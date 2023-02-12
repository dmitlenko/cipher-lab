namespace CipherLabs.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textOriginal = new System.Windows.Forms.TextBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToOriginal = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceOriginal = new System.Windows.Forms.ToolStripMenuItem();
            this.resultTitle = new System.Windows.Forms.Label();
            this.cipherPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.algorithms = new System.Windows.Forms.ComboBox();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // textOriginal
            // 
            this.textOriginal.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textOriginal.Location = new System.Drawing.Point(8, 128);
            this.textOriginal.Multiline = true;
            this.textOriginal.Name = "textOriginal";
            this.textOriginal.Size = new System.Drawing.Size(248, 216);
            this.textOriginal.TabIndex = 1;
            // 
            // textResult
            // 
            this.textResult.ContextMenuStrip = this.contextMenu;
            this.textResult.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textResult.ForeColor = System.Drawing.Color.Black;
            this.textResult.Location = new System.Drawing.Point(264, 128);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.ReadOnly = true;
            this.textResult.Size = new System.Drawing.Size(248, 216);
            this.textResult.TabIndex = 6;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToOriginal,
            this.replaceOriginal});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(207, 48);
            // 
            // copyToOriginal
            // 
            this.copyToOriginal.Name = "copyToOriginal";
            this.copyToOriginal.Size = new System.Drawing.Size(206, 22);
            this.copyToOriginal.Text = "Копіювати до оригіналу";
            this.copyToOriginal.Click += new System.EventHandler(this.copyToOriginal_Click);
            // 
            // replaceOriginal
            // 
            this.replaceOriginal.Name = "replaceOriginal";
            this.replaceOriginal.Size = new System.Drawing.Size(206, 22);
            this.replaceOriginal.Text = "Замінити оргінал";
            this.replaceOriginal.Click += new System.EventHandler(this.replaceOriginal_Click);
            // 
            // resultTitle
            // 
            this.resultTitle.Font = new System.Drawing.Font("AA Pussycat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultTitle.Location = new System.Drawing.Point(264, 104);
            this.resultTitle.Name = "resultTitle";
            this.resultTitle.Size = new System.Drawing.Size(248, 24);
            this.resultTitle.TabIndex = 8;
            this.resultTitle.Text = "РЕЗУЛЬТАТ:";
            // 
            // cipherPanel
            // 
            this.cipherPanel.Location = new System.Drawing.Point(8, 40);
            this.cipherPanel.Name = "cipherPanel";
            this.cipherPanel.Size = new System.Drawing.Size(504, 56);
            this.cipherPanel.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("AA Pussycat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "ОРИГІНАЛ:";
            // 
            // algorithms
            // 
            this.algorithms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algorithms.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.algorithms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.algorithms.FormattingEnabled = true;
            this.algorithms.Items.AddRange(new object[] {
            "Шифр Цезаря",
            "Шифр Цезаря з ключовим словом",
            "Афінна система підстановки Цезаря",
            "Шифрувальні таблиці"});
            this.algorithms.Location = new System.Drawing.Point(8, 8);
            this.algorithms.Name = "algorithms";
            this.algorithms.Size = new System.Drawing.Size(505, 24);
            this.algorithms.TabIndex = 12;
            this.algorithms.SelectedIndexChanged += new System.EventHandler(this.algoDropDown_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 352);
            this.Controls.Add(this.algorithms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultTitle);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.textOriginal);
            this.Controls.Add(this.cipherPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cipher Lab";
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textOriginal;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Label resultTitle;
        private System.Windows.Forms.Panel cipherPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox algorithms;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToOriginal;
        private System.Windows.Forms.ToolStripMenuItem replaceOriginal;
    }
}

