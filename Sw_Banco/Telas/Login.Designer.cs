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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.id_tx = new System.Windows.Forms.TextBox();
            this.pass_mask = new System.Windows.Forms.MaskedTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Erro_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 109);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(745, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 109);
            this.button2.TabIndex = 1;
            this.button2.Text = "Logar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // id_tx
            // 
            this.id_tx.Location = new System.Drawing.Point(443, 157);
            this.id_tx.Name = "id_tx";
            this.id_tx.Size = new System.Drawing.Size(274, 22);
            this.id_tx.TabIndex = 2;
            // 
            // pass_mask
            // 
            this.pass_mask.Location = new System.Drawing.Point(443, 288);
            this.pass_mask.Name = "pass_mask";
            this.pass_mask.PasswordChar = '*';
            this.pass_mask.Size = new System.Drawing.Size(274, 22);
            this.pass_mask.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(443, 317);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 20);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Mostrar Senha";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Erro_lb
            // 
            this.Erro_lb.AutoSize = true;
            this.Erro_lb.Location = new System.Drawing.Point(615, 347);
            this.Erro_lb.Name = "Erro_lb";
            this.Erro_lb.Size = new System.Drawing.Size(44, 16);
            this.Erro_lb.TabIndex = 5;
            this.Erro_lb.Text = "label1";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.Erro_lb);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pass_mask);
            this.Controls.Add(this.id_tx);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(1200, 750);
            this.MinimumSize = new System.Drawing.Size(1200, 750);
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox id_tx;
        private System.Windows.Forms.MaskedTextBox pass_mask;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label Erro_lb;
    }
}

