namespace CipherLabs.Controls
{
    partial class CaesarCipherKeywordControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.keyPhrase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.key = new System.Windows.Forms.NumericUpDown();
            this.alphabetCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.encode = new System.Windows.Forms.Button();
            this.decode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.key)).BeginInit();
            this.SuspendLayout();
            // 
            // keyPhrase
            // 
            this.keyPhrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.keyPhrase.Location = new System.Drawing.Point(112, 32);
            this.keyPhrase.Name = "keyPhrase";
            this.keyPhrase.Size = new System.Drawing.Size(136, 24);
            this.keyPhrase.TabIndex = 15;
            this.keyPhrase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPhrase_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ключове слово:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ключ:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // key
            // 
            this.key.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.key.Location = new System.Drawing.Point(112, 0);
            this.key.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(136, 24);
            this.key.TabIndex = 12;
            // 
            // alphabetCombo
            // 
            this.alphabetCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alphabetCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alphabetCombo.FormattingEnabled = true;
            this.alphabetCombo.Items.AddRange(new object[] {
            "Aa-Zz",
            "Аа-Яя"});
            this.alphabetCombo.Location = new System.Drawing.Point(368, 0);
            this.alphabetCombo.Name = "alphabetCombo";
            this.alphabetCombo.Size = new System.Drawing.Size(136, 24);
            this.alphabetCombo.TabIndex = 16;
            this.alphabetCombo.SelectedIndexChanged += new System.EventHandler(this.alphabetCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(256, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Алфавіт:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // encode
            // 
            this.encode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encode.Location = new System.Drawing.Point(256, 32);
            this.encode.Name = "encode";
            this.encode.Size = new System.Drawing.Size(120, 24);
            this.encode.TabIndex = 19;
            this.encode.Text = "Зашифрувати";
            this.encode.UseVisualStyleBackColor = true;
            this.encode.Click += new System.EventHandler(this.encode_Click);
            // 
            // decode
            // 
            this.decode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decode.Location = new System.Drawing.Point(384, 32);
            this.decode.Name = "decode";
            this.decode.Size = new System.Drawing.Size(120, 24);
            this.decode.TabIndex = 18;
            this.decode.Text = "Розшифрувати";
            this.decode.UseVisualStyleBackColor = true;
            this.decode.Click += new System.EventHandler(this.decode_Click);
            // 
            // CaesarCipherKeywordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.encode);
            this.Controls.Add(this.decode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.alphabetCombo);
            this.Controls.Add(this.keyPhrase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.key);
            this.Name = "CaesarCipherKeywordControl";
            this.Size = new System.Drawing.Size(504, 56);
            ((System.ComponentModel.ISupportInitialize)(this.key)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox keyPhrase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown key;
        private System.Windows.Forms.ComboBox alphabetCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button encode;
        private System.Windows.Forms.Button decode;
    }
}
