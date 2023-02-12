namespace CipherLabs.Controls
{
    partial class AffineCipherControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.NumericUpDown();
            this.b = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).BeginInit();
            this.SuspendLayout();
            // 
            // encode
            // 
            this.encode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encode.Location = new System.Drawing.Point(256, 32);
            this.encode.Name = "encode";
            this.encode.Size = new System.Drawing.Size(120, 24);
            this.encode.TabIndex = 27;
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
            this.decode.TabIndex = 26;
            this.decode.Text = "Розшифрувати";
            this.decode.UseVisualStyleBackColor = true;
            this.decode.Click += new System.EventHandler(this.decode_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(256, 0);
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
            "Aa-Zz",
            "Аа-Яя"});
            this.alphabetCombo.Location = new System.Drawing.Point(368, 0);
            this.alphabetCombo.Name = "alphabetCombo";
            this.alphabetCombo.Size = new System.Drawing.Size(136, 24);
            this.alphabetCombo.TabIndex = 24;
            this.alphabetCombo.SelectedIndexChanged += new System.EventHandler(this.alphabetCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Доданок:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Множник:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // a
            // 
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a.Location = new System.Drawing.Point(112, 0);
            this.a.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(136, 24);
            this.a.TabIndex = 20;
            this.a.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // b
            // 
            this.b.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b.Location = new System.Drawing.Point(112, 32);
            this.b.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(136, 24);
            this.b.TabIndex = 28;
            this.b.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AffineCipherControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.b);
            this.Controls.Add(this.encode);
            this.Controls.Add(this.decode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.alphabetCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.a);
            this.Name = "AffineCipherControl";
            this.Size = new System.Drawing.Size(504, 56);
            ((System.ComponentModel.ISupportInitialize)(this.a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button encode;
        private System.Windows.Forms.Button decode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox alphabetCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown a;
        private System.Windows.Forms.NumericUpDown b;
    }
}
