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
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.pass_mask = new System.Windows.Forms.MaskedTextBox();
            this.id_tx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.Color.Transparent;
            this.bt_login.FlatAppearance.BorderSize = 0;
            this.bt_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_login.Location = new System.Drawing.Point(652, 572);
            this.bt_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(185, 71);
            this.bt_login.TabIndex = 1;
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.bt_cancelar.FlatAppearance.BorderSize = 0;
            this.bt_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Location = new System.Drawing.Point(339, 572);
            this.bt_cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(187, 71);
            this.bt_cancelar.TabIndex = 0;
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pass_mask
            // 
            this.pass_mask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass_mask.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_mask.Location = new System.Drawing.Point(471, 462);
            this.pass_mask.Margin = new System.Windows.Forms.Padding(4);
            this.pass_mask.Name = "pass_mask";
            this.pass_mask.PasswordChar = '*';
            this.pass_mask.Size = new System.Drawing.Size(247, 23);
            this.pass_mask.TabIndex = 3;
            // 
            // id_tx
            // 
            this.id_tx.BackColor = System.Drawing.Color.White;
            this.id_tx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id_tx.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_tx.Location = new System.Drawing.Point(471, 314);
            this.id_tx.Margin = new System.Windows.Forms.Padding(4);
            this.id_tx.Multiline = true;
            this.id_tx.Name = "id_tx";
            this.id_tx.Size = new System.Drawing.Size(223, 31);
            this.id_tx.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1181, 702);
            this.Controls.Add(this.pass_mask);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.id_tx);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1199, 749);
            this.MinimumSize = new System.Drawing.Size(1199, 724);
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.MaskedTextBox pass_mask;
        private System.Windows.Forms.TextBox id_tx;
    }
}

