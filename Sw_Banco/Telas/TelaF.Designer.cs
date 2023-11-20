namespace Sw_Banco.Telas
{
    partial class TelaF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaF));
            this.CC_button = new System.Windows.Forms.Button();
            this.CF_button = new System.Windows.Forms.Button();
            this.Sair_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CC_button
            // 
            this.CC_button.BackColor = System.Drawing.Color.Transparent;
            this.CC_button.FlatAppearance.BorderSize = 0;
            this.CC_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CC_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CC_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CC_button.Location = new System.Drawing.Point(364, 251);
            this.CC_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CC_button.Name = "CC_button";
            this.CC_button.Size = new System.Drawing.Size(300, 49);
            this.CC_button.TabIndex = 0;
            this.CC_button.UseVisualStyleBackColor = false;
            this.CC_button.Click += new System.EventHandler(this.CC_button_Click);
            // 
            // CF_button
            // 
            this.CF_button.BackColor = System.Drawing.Color.Transparent;
            this.CF_button.FlatAppearance.BorderSize = 0;
            this.CF_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CF_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CF_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CF_button.Location = new System.Drawing.Point(364, 335);
            this.CF_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CF_button.Name = "CF_button";
            this.CF_button.Size = new System.Drawing.Size(300, 49);
            this.CF_button.TabIndex = 1;
            this.CF_button.UseVisualStyleBackColor = false;
            this.CF_button.Click += new System.EventHandler(this.CF_button_Click);
            // 
            // Sair_button
            // 
            this.Sair_button.BackColor = System.Drawing.Color.Transparent;
            this.Sair_button.FlatAppearance.BorderSize = 0;
            this.Sair_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Sair_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Sair_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sair_button.Location = new System.Drawing.Point(364, 417);
            this.Sair_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sair_button.Name = "Sair_button";
            this.Sair_button.Size = new System.Drawing.Size(300, 52);
            this.Sair_button.TabIndex = 2;
            this.Sair_button.UseVisualStyleBackColor = false;
            this.Sair_button.Click += new System.EventHandler(this.Sair_button_Click);
            // 
            // TelaF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 561);
            this.Controls.Add(this.Sair_button);
            this.Controls.Add(this.CF_button);
            this.Controls.Add(this.CC_button);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TelaF";
            this.Text = "TelaF";
            this.Load += new System.EventHandler(this.TelaF_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CC_button;
        private System.Windows.Forms.Button CF_button;
        private System.Windows.Forms.Button Sair_button;
    }
}