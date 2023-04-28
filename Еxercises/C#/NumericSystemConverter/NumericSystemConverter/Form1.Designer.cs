
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
            this.txtDesetichna = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOsmichna = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDvoichna = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtShest = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDesetichna
            // 
            this.txtDesetichna.Location = new System.Drawing.Point(21, 54);
            this.txtDesetichna.Name = "txtDesetichna";
            this.txtDesetichna.Size = new System.Drawing.Size(196, 22);
            this.txtDesetichna.TabIndex = 0;
            this.txtDesetichna.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GetLastSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Десетична";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Осмична";
            // 
            // txtOsmichna
            // 
            this.txtOsmichna.Location = new System.Drawing.Point(21, 106);
            this.txtOsmichna.Name = "txtOsmichna";
            this.txtOsmichna.Size = new System.Drawing.Size(196, 22);
            this.txtOsmichna.TabIndex = 2;
            this.txtOsmichna.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GetLastSelected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Двойчна";
            // 
            // txtDvoichna
            // 
            this.txtDvoichna.Location = new System.Drawing.Point(21, 156);
            this.txtDvoichna.Name = "txtDvoichna";
            this.txtDvoichna.Size = new System.Drawing.Size(196, 22);
            this.txtDvoichna.TabIndex = 4;
            this.txtDvoichna.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GetLastSelected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Шестнадесетична";
            // 
            // txtShest
            // 
            this.txtShest.Location = new System.Drawing.Point(21, 210);
            this.txtShest.Name = "txtShest";
            this.txtShest.Size = new System.Drawing.Size(196, 22);
            this.txtShest.TabIndex = 6;
            this.txtShest.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GetLastSelected);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(263, 54);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(118, 23);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(263, 83);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(263, 135);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(136, 17);
            this.lblInfo.TabIndex = 10;
            this.lblInfo.Text = "От бройна система";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 320);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtShest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDvoichna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOsmichna);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDesetichna);
            this.Name = "Form1";
            this.Text = "Калкулатор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDesetichna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOsmichna;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDvoichna;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtShest;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblInfo;
    }
}

