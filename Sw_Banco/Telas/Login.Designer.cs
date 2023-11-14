namespace Sw_Banco
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bt_login = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Erro_lb = new System.Windows.Forms.Label();
            this.pass_mask = new System.Windows.Forms.MaskedTextBox();
            this.id_tx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.Color.Transparent;
            this.bt_login.FlatAppearance.BorderSize = 0;
            this.bt_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_login.Location = new System.Drawing.Point(489, 465);
            this.bt_login.Margin = new System.Windows.Forms.Padding(2);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(139, 58);
            this.bt_login.TabIndex = 1;
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(391, 410);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Mostrar Senha";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(254, 465);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 58);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Erro_lb
            // 
            this.Erro_lb.AutoSize = true;
            this.Erro_lb.BackColor = System.Drawing.Color.Transparent;
            this.Erro_lb.Location = new System.Drawing.Point(423, 429);
            this.Erro_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Erro_lb.Name = "Erro_lb";
            this.Erro_lb.Size = new System.Drawing.Size(35, 13);
            this.Erro_lb.TabIndex = 5;
            this.Erro_lb.Text = "label1";
            // 
            // pass_mask
            // 
            this.pass_mask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass_mask.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_mask.Location = new System.Drawing.Point(353, 375);
            this.pass_mask.Name = "pass_mask";
            this.pass_mask.PasswordChar = '*';
            this.pass_mask.Size = new System.Drawing.Size(185, 19);
            this.pass_mask.TabIndex = 3;
            this.pass_mask.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.pass_mask_MaskInputRejected);
            // 
            // id_tx
            // 
            this.id_tx.BackColor = System.Drawing.Color.White;
            this.id_tx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id_tx.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_tx.Location = new System.Drawing.Point(353, 255);
            this.id_tx.Multiline = true;
            this.id_tx.Name = "id_tx";
            this.id_tx.Size = new System.Drawing.Size(167, 25);
            this.id_tx.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(888, 571);
            this.Controls.Add(this.Erro_lb);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pass_mask);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.id_tx);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(904, 617);
            this.MinimumSize = new System.Drawing.Size(904, 597);
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Erro_lb;
        private System.Windows.Forms.MaskedTextBox pass_mask;
        private System.Windows.Forms.TextBox id_tx;
    }
}

