
namespace PracticaFosagroTask1.Views
{
    partial class CircleWindow
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
            this.material = new System.Windows.Forms.ComboBox();
            this.CirR = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // material
            // 
            this.material.FormattingEnabled = true;
            this.material.Location = new System.Drawing.Point(89, 119);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(121, 21);
            this.material.TabIndex = 0;
            // 
            // CirR
            // 
            this.CirR.Location = new System.Drawing.Point(89, 51);
            this.CirR.Name = "CirR";
            this.CirR.Size = new System.Drawing.Size(121, 20);
            this.CirR.TabIndex = 1;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(89, 157);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(121, 69);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // CircleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 256);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.CirR);
            this.Controls.Add(this.material);
            this.Name = "CircleWindow";
            this.Text = "CircleWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox material;
        private System.Windows.Forms.TextBox CirR;
        private System.Windows.Forms.Button OK;
    }
}