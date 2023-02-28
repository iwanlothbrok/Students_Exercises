
using System;

namespace NumericSystemConverter
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
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOctal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBinary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(16, 44);
            this.txtDecimal.Margin = new System.Windows.Forms.Padding(2);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(148, 20);
            this.txtDecimal.TabIndex = 0;
            this.txtDecimal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GetLastSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Десетична";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Осмична";
            // 
            // txtOctal
            // 
            this.txtOctal.Location = new System.Drawing.Point(16, 86);
            this.txtOctal.Margin = new System.Windows.Forms.Padding(2);
            this.txtOctal.Name = "txtOctal";
            this.txtOctal.Size = new System.Drawing.Size(148, 20);
            this.txtOctal.TabIndex = 2;
            this.txtOctal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GetLastSelected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Двойчна";
            // 
            // txtBinary
            // 
            this.txtBinary.Location = new System.Drawing.Point(16, 127);
            this.txtBinary.Margin = new System.Windows.Forms.Padding(2);
            this.txtBinary.Name = "txtBinary";
            this.txtBinary.Size = new System.Drawing.Size(148, 20);
            this.txtBinary.TabIndex = 4;
            this.txtBinary.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GetLastSelected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Шестнадесетична";
            // 
            // txtHex
            // 
            this.txtHex.Location = new System.Drawing.Point(16, 171);
            this.txtHex.Margin = new System.Windows.Forms.Padding(2);
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(148, 20);
            this.txtHex.TabIndex = 6;
            this.txtHex.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GetLastSelected);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(197, 44);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(88, 19);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(197, 67);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 19);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(197, 110);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(105, 13);
            this.lblInfo.TabIndex = 10;
            this.lblInfo.Text = "От бройна система";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 260);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBinary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOctal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDecimal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Калкулатор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOctal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBinary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblInfo;
    }
}

