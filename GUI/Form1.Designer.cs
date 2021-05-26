namespace GUI
{
    partial class Form1
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
            this.textInput = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textResult = new System.Windows.Forms.TextBox();
            this.buttonCipher = new System.Windows.Forms.Button();
            this.buttonDecipher = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericP = new System.Windows.Forms.NumericUpDown();
            this.numericG = new System.Windows.Forms.NumericUpDown();
            this.numericSecureKey = new System.Windows.Forms.NumericUpDown();
            this.numericY = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSecureKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).BeginInit();
            this.SuspendLayout();
            // 
            // textInput
            // 
            this.textInput.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textInput.Location = new System.Drawing.Point(103, 88);
            this.textInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(284, 29);
            this.textInput.TabIndex = 0;
            // 
            // labelInput
            // 
            this.labelInput.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInput.Location = new System.Drawing.Point(28, 84);
            this.labelInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(70, 31);
            this.labelInput.TabIndex = 1;
            this.labelInput.Text = "Input";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Result";
            // 
            // textResult
            // 
            this.textResult.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textResult.Location = new System.Drawing.Point(103, 148);
            this.textResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(284, 29);
            this.textResult.TabIndex = 2;
            // 
            // buttonCipher
            // 
            this.buttonCipher.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCipher.Location = new System.Drawing.Point(36, 361);
            this.buttonCipher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCipher.Name = "buttonCipher";
            this.buttonCipher.Size = new System.Drawing.Size(199, 37);
            this.buttonCipher.TabIndex = 4;
            this.buttonCipher.Text = "Cipher";
            this.buttonCipher.UseVisualStyleBackColor = true;
            this.buttonCipher.Click += new System.EventHandler(this.buttonCipher_Click);
            // 
            // buttonDecipher
            // 
            this.buttonDecipher.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDecipher.Location = new System.Drawing.Point(296, 361);
            this.buttonDecipher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDecipher.Name = "buttonDecipher";
            this.buttonDecipher.Size = new System.Drawing.Size(207, 37);
            this.buttonDecipher.TabIndex = 5;
            this.buttonDecipher.Text = "Decipher";
            this.buttonDecipher.UseVisualStyleBackColor = true;
            this.buttonDecipher.Click += new System.EventHandler(this.buttonDecipher_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGenerate.Location = new System.Drawing.Point(565, 361);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(184, 37);
            this.buttonGenerate.TabIndex = 6;
            this.buttonGenerate.Text = "Generate key";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(500, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Input pime number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(558, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 33);
            this.label3.TabIndex = 12;
            this.label3.Text = "Input root g";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(558, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 34);
            this.label4.TabIndex = 13;
            this.label4.Text = "y (g^x % p)";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(447, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "Input secure key[2, p - 2]";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // numericP
            // 
            this.numericP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericP.Location = new System.Drawing.Point(695, 54);
            this.numericP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericP.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericP.Name = "numericP";
            this.numericP.Size = new System.Drawing.Size(85, 29);
            this.numericP.TabIndex = 15;
            // 
            // numericG
            // 
            this.numericG.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericG.Location = new System.Drawing.Point(695, 98);
            this.numericG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericG.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericG.Name = "numericG";
            this.numericG.Size = new System.Drawing.Size(85, 29);
            this.numericG.TabIndex = 16;
            this.numericG.ValueChanged += new System.EventHandler(this.numericG_ValueChanged);
            // 
            // numericSecureKey
            // 
            this.numericSecureKey.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericSecureKey.Location = new System.Drawing.Point(700, 199);
            this.numericSecureKey.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericSecureKey.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericSecureKey.Name = "numericSecureKey";
            this.numericSecureKey.Size = new System.Drawing.Size(80, 29);
            this.numericSecureKey.TabIndex = 17;
            // 
            // numericY
            // 
            this.numericY.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericY.Location = new System.Drawing.Point(700, 148);
            this.numericY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericY.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericY.Name = "numericY";
            this.numericY.Size = new System.Drawing.Size(80, 29);
            this.numericY.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 466);
            this.Controls.Add(this.numericY);
            this.Controls.Add(this.numericSecureKey);
            this.Controls.Add(this.numericG);
            this.Controls.Add(this.numericP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.buttonDecipher);
            this.Controls.Add(this.buttonCipher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.textInput);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSecureKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.NumericUpDown numericY;

        private System.Windows.Forms.NumericUpDown numericG;
        private System.Windows.Forms.NumericUpDown numericSecureKey;

        private System.Windows.Forms.NumericUpDown numericP;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button buttonGenerate;

        private System.Windows.Forms.Button buttonDecipher;

        private System.Windows.Forms.Button buttonCipher;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textResult;

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textInput;

        #endregion
    }
}