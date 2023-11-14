namespace Sw_Banco.Telas
{
    partial class CadastrarF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarF));
            this.Salvar_bt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.tx_email = new System.Windows.Forms.TextBox();
            this.tx_sexo = new System.Windows.Forms.TextBox();
            this.tx_endereco = new System.Windows.Forms.TextBox();
            this.tx_senha = new System.Windows.Forms.TextBox();
            this.tx_celular = new System.Windows.Forms.MaskedTextBox();
            this.tx_dataNasc = new System.Windows.Forms.MaskedTextBox();
            this.tx_cpf = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Salvar_bt
            // 
            this.Salvar_bt.BackColor = System.Drawing.Color.Transparent;
            this.Salvar_bt.FlatAppearance.BorderSize = 0;
            this.Salvar_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salvar_bt.Location = new System.Drawing.Point(406, 403);
            this.Salvar_bt.Margin = new System.Windows.Forms.Padding(2);
            this.Salvar_bt.Name = "Salvar_bt";
            this.Salvar_bt.Size = new System.Drawing.Size(105, 39);
            this.Salvar_bt.TabIndex = 0;
            this.Salvar_bt.UseVisualStyleBackColor = false;
            this.Salvar_bt.Click += new System.EventHandler(this.Salvar_bt_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(232, 403);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 39);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tx_nome
            // 
            this.tx_nome.BackColor = System.Drawing.Color.White;
            this.tx_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_nome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_nome.Location = new System.Drawing.Point(124, 146);
            this.tx_nome.Margin = new System.Windows.Forms.Padding(2);
            this.tx_nome.Multiline = true;
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(137, 22);
            this.tx_nome.TabIndex = 2;
            // 
            // tx_email
            // 
            this.tx_email.BackColor = System.Drawing.Color.White;
            this.tx_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_email.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_email.Location = new System.Drawing.Point(124, 287);
            this.tx_email.Margin = new System.Windows.Forms.Padding(2);
            this.tx_email.Multiline = true;
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(137, 22);
            this.tx_email.TabIndex = 11;
            // 
            // tx_sexo
            // 
            this.tx_sexo.BackColor = System.Drawing.Color.White;
            this.tx_sexo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_sexo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_sexo.Location = new System.Drawing.Point(473, 217);
            this.tx_sexo.Margin = new System.Windows.Forms.Padding(2);
            this.tx_sexo.Multiline = true;
            this.tx_sexo.Name = "tx_sexo";
            this.tx_sexo.Size = new System.Drawing.Size(137, 22);
            this.tx_sexo.TabIndex = 14;
            // 
            // tx_endereco
            // 
            this.tx_endereco.BackColor = System.Drawing.Color.White;
            this.tx_endereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_endereco.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_endereco.Location = new System.Drawing.Point(473, 287);
            this.tx_endereco.Margin = new System.Windows.Forms.Padding(2);
            this.tx_endereco.Multiline = true;
            this.tx_endereco.Name = "tx_endereco";
            this.tx_endereco.Size = new System.Drawing.Size(137, 22);
            this.tx_endereco.TabIndex = 15;
            // 
            // tx_senha
            // 
            this.tx_senha.BackColor = System.Drawing.Color.White;
            this.tx_senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_senha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_senha.Location = new System.Drawing.Point(473, 353);
            this.tx_senha.Margin = new System.Windows.Forms.Padding(2);
            this.tx_senha.Multiline = true;
            this.tx_senha.Name = "tx_senha";
            this.tx_senha.Size = new System.Drawing.Size(137, 22);
            this.tx_senha.TabIndex = 16;
            // 
            // tx_celular
            // 
            this.tx_celular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_celular.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tx_celular.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_celular.Location = new System.Drawing.Point(484, 149);
            this.tx_celular.Mask = "(00) 00000-0000";
            this.tx_celular.Name = "tx_celular";
            this.tx_celular.Size = new System.Drawing.Size(100, 19);
            this.tx_celular.TabIndex = 17;
            // 
            // tx_dataNasc
            // 
            this.tx_dataNasc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_dataNasc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tx_dataNasc.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_dataNasc.Location = new System.Drawing.Point(134, 356);
            this.tx_dataNasc.Mask = "00/00/0000";
            this.tx_dataNasc.Name = "tx_dataNasc";
            this.tx_dataNasc.Size = new System.Drawing.Size(100, 19);
            this.tx_dataNasc.TabIndex = 18;
            // 
            // tx_cpf
            // 
            this.tx_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_cpf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tx_cpf.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_cpf.Location = new System.Drawing.Point(134, 220);
            this.tx_cpf.Mask = "000.000.000-00";
            this.tx_cpf.Name = "tx_cpf";
            this.tx_cpf.Size = new System.Drawing.Size(100, 19);
            this.tx_cpf.TabIndex = 19;
            // 
            // CadastrarF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 453);
            this.Controls.Add(this.tx_cpf);
            this.Controls.Add(this.tx_dataNasc);
            this.Controls.Add(this.tx_celular);
            this.Controls.Add(this.tx_senha);
            this.Controls.Add(this.tx_endereco);
            this.Controls.Add(this.tx_sexo);
            this.Controls.Add(this.tx_email);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Salvar_bt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CadastrarF";
            this.Text = "CadastrarF";
            this.Load += new System.EventHandler(this.CadastrarF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Salvar_bt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.TextBox tx_sexo;
        private System.Windows.Forms.TextBox tx_endereco;
        private System.Windows.Forms.TextBox tx_senha;
        private System.Windows.Forms.MaskedTextBox tx_celular;
        private System.Windows.Forms.MaskedTextBox tx_dataNasc;
        private System.Windows.Forms.MaskedTextBox tx_cpf;
    }
}