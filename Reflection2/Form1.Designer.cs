
namespace Reflection2
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
            this.btnGetClassNameWithSpeceficAttribute = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGetClassNameWithSpeceficAttribute
            // 
            this.btnGetClassNameWithSpeceficAttribute.Location = new System.Drawing.Point(12, 12);
            this.btnGetClassNameWithSpeceficAttribute.Name = "btnGetClassNameWithSpeceficAttribute";
            this.btnGetClassNameWithSpeceficAttribute.Size = new System.Drawing.Size(304, 23);
            this.btnGetClassNameWithSpeceficAttribute.TabIndex = 0;
            this.btnGetClassNameWithSpeceficAttribute.Text = "Get Classes";
            this.btnGetClassNameWithSpeceficAttribute.UseVisualStyleBackColor = true;
            this.btnGetClassNameWithSpeceficAttribute.Click += new System.EventHandler(this.btnGetClassNameWithSpeceficAttribute_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(304, 260);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 330);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnGetClassNameWithSpeceficAttribute);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetClassNameWithSpeceficAttribute;
        private System.Windows.Forms.ListBox listBox1;
    }
}

