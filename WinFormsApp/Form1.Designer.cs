
namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownFirstNumber = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSecondNumber = new System.Windows.Forms.NumericUpDown();
            this.comboBoxSigner = new System.Windows.Forms.ComboBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirstNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecondNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownFirstNumber
            // 
            this.numericUpDownFirstNumber.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownFirstNumber.Location = new System.Drawing.Point(12, 14);
            this.numericUpDownFirstNumber.Name = "numericUpDownFirstNumber";
            this.numericUpDownFirstNumber.Size = new System.Drawing.Size(150, 38);
            this.numericUpDownFirstNumber.TabIndex = 0;
            // 
            // numericUpDownSecondNumber
            // 
            this.numericUpDownSecondNumber.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownSecondNumber.Location = new System.Drawing.Point(415, 14);
            this.numericUpDownSecondNumber.Name = "numericUpDownSecondNumber";
            this.numericUpDownSecondNumber.Size = new System.Drawing.Size(150, 38);
            this.numericUpDownSecondNumber.TabIndex = 1;
            // 
            // comboBoxSigner
            // 
            this.comboBoxSigner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSigner.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSigner.FormattingEnabled = true;
            this.comboBoxSigner.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.comboBoxSigner.Location = new System.Drawing.Point(212, 13);
            this.comboBoxSigner.Name = "comboBoxSigner";
            this.comboBoxSigner.Size = new System.Drawing.Size(151, 39);
            this.comboBoxSigner.TabIndex = 2;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Enabled = false;
            this.textBoxResult.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxResult.Location = new System.Drawing.Point(12, 77);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(553, 38);
            this.textBoxResult.TabIndex = 3;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCalculate.Location = new System.Drawing.Point(12, 133);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(553, 96);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 240);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.comboBoxSigner);
            this.Controls.Add(this.numericUpDownSecondNumber);
            this.Controls.Add(this.numericUpDownFirstNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirstNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecondNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownFirstNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownSecondNumber;
        private System.Windows.Forms.ComboBox comboBoxSigner;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonCalculate;
    }
}

