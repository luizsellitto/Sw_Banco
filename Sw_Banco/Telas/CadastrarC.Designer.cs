namespace Sw_Banco.Telas
{
    partial class CadastrarC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarC));
            this.tx_senha = new System.Windows.Forms.TextBox();
            this.tx_endereco = new System.Windows.Forms.TextBox();
            this.tx_sexo = new System.Windows.Forms.TextBox();
            this.tx_email = new System.Windows.Forms.TextBox();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.Salvar_bt = new System.Windows.Forms.Button();
            this.tx_cpf = new System.Windows.Forms.MaskedTextBox();
            this.tx_celular = new System.Windows.Forms.MaskedTextBox();
            this.tx_dataNasc = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // tx_senha
            // 
            this.tx_senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_senha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_senha.Location = new System.Drawing.Point(707, 508);
            this.tx_senha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_senha.Name = "tx_senha";
            this.tx_senha.Size = new System.Drawing.Size(183, 23);
            this.tx_senha.TabIndex = 19;
            // 
            // tx_endereco
            // 
            this.tx_endereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_endereco.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_endereco.Location = new System.Drawing.Point(707, 415);
            this.tx_endereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_endereco.Name = "tx_endereco";
            this.tx_endereco.Size = new System.Drawing.Size(183, 23);
            this.tx_endereco.TabIndex = 17;
            // 
            // tx_sexo
            // 
            this.tx_sexo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_sexo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_sexo.Location = new System.Drawing.Point(707, 315);
            this.tx_sexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_sexo.Name = "tx_sexo";
            this.tx_sexo.Size = new System.Drawing.Size(183, 23);
            this.tx_sexo.TabIndex = 16;
            // 
            // tx_email
            // 
            this.tx_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_email.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_email.Location = new System.Drawing.Point(248, 415);
            this.tx_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(183, 23);
            this.tx_email.TabIndex = 14;
            // 
            // tx_nome
            // 
            this.tx_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_nome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_nome.Location = new System.Drawing.Point(248, 219);
            this.tx_nome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(183, 23);
            this.tx_nome.TabIndex = 12;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.bt_cancelar.FlatAppearance.BorderSize = 0;
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Location = new System.Drawing.Point(347, 585);
            this.bt_cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(164, 59);
            this.bt_cancelar.TabIndex = 11;
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Salvar_bt
            // 
            this.Salvar_bt.BackColor = System.Drawing.Color.Transparent;
            this.Salvar_bt.FlatAppearance.BorderSize = 0;
            this.Salvar_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salvar_bt.Location = new System.Drawing.Point(616, 587);
            this.Salvar_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Salvar_bt.Name = "Salvar_bt";
            this.Salvar_bt.Size = new System.Drawing.Size(160, 57);
            this.Salvar_bt.TabIndex = 10;
            this.Salvar_bt.UseVisualStyleBackColor = false;
            this.Salvar_bt.Click += new System.EventHandler(this.Salvar_bt_Click_1);
            // 
            // tx_cpf
            // 
            this.tx_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_cpf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tx_cpf.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_cpf.Location = new System.Drawing.Point(248, 315);
            this.tx_cpf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_cpf.Mask = "000.000.000-00";
            this.tx_cpf.Name = "tx_cpf";
            this.tx_cpf.Size = new System.Drawing.Size(133, 23);
            this.tx_cpf.TabIndex = 22;
            // 
            // tx_celular
            // 
            this.tx_celular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_celular.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tx_celular.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_celular.Location = new System.Drawing.Point(707, 219);
            this.tx_celular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_celular.Mask = "(00) 00000-0000";
            this.tx_celular.Name = "tx_celular";
            this.tx_celular.Size = new System.Drawing.Size(133, 23);
            this.tx_celular.TabIndex = 20;
            // 
            // tx_dataNasc
            // 
            this.tx_dataNasc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_dataNasc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tx_dataNasc.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_dataNasc.Location = new System.Drawing.Point(248, 508);
            this.tx_dataNasc.Margin = new System.Windows.Forms.Padding(4);
            this.tx_dataNasc.Mask = "00/00/0000";
            this.tx_dataNasc.Name = "tx_dataNasc";
            this.tx_dataNasc.Size = new System.Drawing.Size(133, 23);
            this.tx_dataNasc.TabIndex = 21;
            // 
            // CadastrarC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1133, 657);
            this.Controls.Add(this.tx_cpf);
            this.Controls.Add(this.tx_dataNasc);
            this.Controls.Add(this.tx_celular);
            this.Controls.Add(this.tx_senha);
            this.Controls.Add(this.tx_endereco);
            this.Controls.Add(this.tx_sexo);
            this.Controls.Add(this.tx_email);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.Salvar_bt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CadastrarC";
            this.Text = "CadastrarC";
            this.Load += new System.EventHandler(this.CadastrarC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_senha;
        private System.Windows.Forms.TextBox tx_endereco;
        private System.Windows.Forms.TextBox tx_sexo;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button Salvar_bt;
        private System.Windows.Forms.MaskedTextBox tx_cpf;
        private System.Windows.Forms.MaskedTextBox tx_celular;
        private System.Windows.Forms.MaskedTextBox tx_dataNasc;
    }
}