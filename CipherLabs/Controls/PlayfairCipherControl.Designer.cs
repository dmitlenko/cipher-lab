namespace CipherLabs.Controls
{
    partial class PlayfairCipherControl
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
            this.encode = new System.Windows.Forms.Button();
            this.decode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.alphabetCombo = new System.Windows.Forms.ComboBox();
            this.keyPhrase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // encode
            // 
            this.encode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encode.Location = new System.Drawing.Point(256, 0);
            this.encode.Name = "encode";
            this.encode.Size = new System.Drawing.Size(248, 24);
            this.encode.TabIndex = 27;
            this.encode.Text = "Зашифрувати";
            this.encode.UseVisualStyleBackColor = true;
            this.encode.Click += new System.EventHandler(this.encode_Click);
            // 
            // decode
            // 
            this.decode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decode.Location = new System.Drawing.Point(256, 32);
            this.decode.Name = "decode";
            this.decode.Size = new System.Drawing.Size(248, 24);
            this.decode.TabIndex = 26;
            this.decode.Text = "Розшифрувати";
            this.decode.UseVisualStyleBackColor = true;
            this.decode.Click += new System.EventHandler(this.decode_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Алфавіт:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // alphabetCombo
            // 
            this.alphabetCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alphabetCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alphabetCombo.FormattingEnabled = true;
            this.alphabetCombo.Items.AddRange(new object[] {
            "Aa-Zz+",
            "Аа-Яя+"});
            this.alphabetCombo.Location = new System.Drawing.Point(112, 0);
            this.alphabetCombo.Name = "alphabetCombo";
            this.alphabetCombo.Size = new System.Drawing.Size(136, 24);
            this.alphabetCombo.TabIndex = 24;
            this.alphabetCombo.SelectedIndexChanged += new System.EventHandler(this.alphabetCombo_SelectedIndexChanged);
            // 
            // keyPhrase
            // 
            this.keyPhrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.keyPhrase.Location = new System.Drawing.Point(112, 32);
            this.keyPhrase.Name = "keyPhrase";
            this.keyPhrase.Size = new System.Drawing.Size(136, 24);
            this.keyPhrase.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ключове слово:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlayfairCipherControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.encode);
            this.Controls.Add(this.decode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.alphabetCombo);
            this.Controls.Add(this.keyPhrase);
            this.Controls.Add(this.label2);
            this.Name = "PlayfairCipherControl";
            this.Size = new System.Drawing.Size(504, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encode;
        private System.Windows.Forms.Button decode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox alphabetCombo;
        private System.Windows.Forms.TextBox keyPhrase;
        private System.Windows.Forms.Label label2;
    }
}
