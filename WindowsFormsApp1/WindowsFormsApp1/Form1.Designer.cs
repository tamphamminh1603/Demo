namespace WindowsFormsApp1
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
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.lbTK = new System.Windows.Forms.Label();
            this.lbMK = new System.Windows.Forms.Label();
            this.btDK = new System.Windows.Forms.Button();
            this.btDN = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(161, 52);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(182, 20);
            this.txtTK.TabIndex = 0;
            this.txtTK.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(161, 99);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(182, 20);
            this.txtMK.TabIndex = 0;
            this.txtMK.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbTK
            // 
            this.lbTK.AutoSize = true;
            this.lbTK.Location = new System.Drawing.Point(60, 55);
            this.lbTK.Name = "lbTK";
            this.lbTK.Size = new System.Drawing.Size(60, 13);
            this.lbTK.TabIndex = 1;
            this.lbTK.Text = "User Name";
            // 
            // lbMK
            // 
            this.lbMK.AutoSize = true;
            this.lbMK.Location = new System.Drawing.Point(60, 99);
            this.lbMK.Name = "lbMK";
            this.lbMK.Size = new System.Drawing.Size(53, 13);
            this.lbMK.TabIndex = 1;
            this.lbMK.Text = "Password";
            // 
            // btDK
            // 
            this.btDK.Location = new System.Drawing.Point(75, 173);
            this.btDK.Name = "btDK";
            this.btDK.Size = new System.Drawing.Size(75, 23);
            this.btDK.TabIndex = 2;
            this.btDK.Text = "Sign Up";
            this.btDK.UseVisualStyleBackColor = true;
            // 
            // btDN
            // 
            this.btDN.Location = new System.Drawing.Point(224, 173);
            this.btDN.Name = "btDN";
            this.btDN.Size = new System.Drawing.Size(75, 23);
            this.btDN.TabIndex = 2;
            this.btDN.Text = "Sign In";
            this.btDN.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(378, 173);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 309);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btDN);
            this.Controls.Add(this.btDK);
            this.Controls.Add(this.lbMK);
            this.Controls.Add(this.lbTK);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTK);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label lbTK;
        private System.Windows.Forms.Label lbMK;
        private System.Windows.Forms.Button btDK;
        private System.Windows.Forms.Button btDN;
        private System.Windows.Forms.Button btExit;
    }
}

