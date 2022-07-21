
namespace example
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
            this.rButtonConvertHex = new System.Windows.Forms.RadioButton();
            this.rBoxConvertAscii = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBoxDataIn = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rButtonConvertHex
            // 
            this.rButtonConvertHex.AutoSize = true;
            this.rButtonConvertHex.Location = new System.Drawing.Point(28, 19);
            this.rButtonConvertHex.Name = "rButtonConvertHex";
            this.rButtonConvertHex.Size = new System.Drawing.Size(44, 17);
            this.rButtonConvertHex.TabIndex = 0;
            this.rButtonConvertHex.TabStop = true;
            this.rButtonConvertHex.Text = "Hex";
            this.rButtonConvertHex.UseVisualStyleBackColor = true;
            this.rButtonConvertHex.CheckedChanged += new System.EventHandler(this.rButtonConvertHex_CheckedChanged);
            // 
            // rBoxConvertAscii
            // 
            this.rBoxConvertAscii.AutoSize = true;
            this.rBoxConvertAscii.Location = new System.Drawing.Point(28, 65);
            this.rBoxConvertAscii.Name = "rBoxConvertAscii";
            this.rBoxConvertAscii.Size = new System.Drawing.Size(52, 17);
            this.rBoxConvertAscii.TabIndex = 1;
            this.rBoxConvertAscii.TabStop = true;
            this.rBoxConvertAscii.Text = "ASCII";
            this.rBoxConvertAscii.UseVisualStyleBackColor = true;
            this.rBoxConvertAscii.CheckedChanged += new System.EventHandler(this.rBoxConvertAscii_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rButtonConvertHex);
            this.groupBox1.Controls.Add(this.rBoxConvertAscii);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tBoxDataIn
            // 
            this.tBoxDataIn.Location = new System.Drawing.Point(12, 118);
            this.tBoxDataIn.Multiline = true;
            this.tBoxDataIn.Name = "tBoxDataIn";
            this.tBoxDataIn.Size = new System.Drawing.Size(200, 130);
            this.tBoxDataIn.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 260);
            this.Controls.Add(this.tBoxDataIn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rButtonConvertHex;
        private System.Windows.Forms.RadioButton rBoxConvertAscii;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tBoxDataIn;
    }
}

