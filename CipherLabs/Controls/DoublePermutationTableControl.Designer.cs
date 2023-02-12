namespace CipherLabs.Controls
{
    partial class DoublePermutationTableControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.encode = new System.Windows.Forms.Button();
            this.decode = new System.Windows.Forms.Button();
            this.keyX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.keyY = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Ключ Y:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // encode
            // 
            this.encode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encode.Location = new System.Drawing.Point(256, 0);
            this.encode.Name = "encode";
            this.encode.Size = new System.Drawing.Size(248, 24);
            this.encode.TabIndex = 33;
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
            this.decode.TabIndex = 32;
            this.decode.Text = "Розшифрувати";
            this.decode.UseVisualStyleBackColor = true;
            this.decode.Click += new System.EventHandler(this.decode_Click);
            // 
            // keyX
            // 
            this.keyX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.keyX.Location = new System.Drawing.Point(112, 0);
            this.keyX.Name = "keyX";
            this.keyX.Size = new System.Drawing.Size(136, 24);
            this.keyX.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ключ X:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // keyY
            // 
            this.keyY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.keyY.Location = new System.Drawing.Point(112, 32);
            this.keyY.Name = "keyY";
            this.keyY.Size = new System.Drawing.Size(136, 24);
            this.keyY.TabIndex = 35;
            // 
            // DoublePermutationTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.keyY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encode);
            this.Controls.Add(this.decode);
            this.Controls.Add(this.keyX);
            this.Controls.Add(this.label2);
            this.Name = "DoublePermutationTableControl";
            this.Size = new System.Drawing.Size(504, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button encode;
        private System.Windows.Forms.Button decode;
        private System.Windows.Forms.TextBox keyX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keyY;
    }
}
