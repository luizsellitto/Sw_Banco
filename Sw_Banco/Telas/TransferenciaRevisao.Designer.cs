namespace Sw_Banco.Telas
{
    partial class TransferenciaRevisao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferenciaRevisao));
            this.tx_valor = new System.Windows.Forms.TextBox();
            this.tx_chave = new System.Windows.Forms.TextBox();
            this.tx_instituicao = new System.Windows.Forms.TextBox();
            this.tx_id = new System.Windows.Forms.TextBox();
            this.bt_Cancelar = new System.Windows.Forms.Button();
            this.bt_Confirmar = new System.Windows.Forms.Button();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tx_valor
            // 
            this.tx_valor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_valor.Location = new System.Drawing.Point(360, 134);
            this.tx_valor.Name = "tx_valor";
            this.tx_valor.Size = new System.Drawing.Size(100, 13);
            this.tx_valor.TabIndex = 9;
            // 
            // tx_chave
            // 
            this.tx_chave.BackColor = System.Drawing.SystemColors.Window;
            this.tx_chave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_chave.Location = new System.Drawing.Point(76, 379);
            this.tx_chave.Multiline = true;
            this.tx_chave.Name = "tx_chave";
            this.tx_chave.Size = new System.Drawing.Size(426, 24);
            this.tx_chave.TabIndex = 8;
            // 
            // tx_instituicao
            // 
            this.tx_instituicao.BackColor = System.Drawing.SystemColors.Window;
            this.tx_instituicao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_instituicao.Location = new System.Drawing.Point(94, 329);
            this.tx_instituicao.Multiline = true;
            this.tx_instituicao.Name = "tx_instituicao";
            this.tx_instituicao.Size = new System.Drawing.Size(408, 24);
            this.tx_instituicao.TabIndex = 7;
            // 
            // tx_id
            // 
            this.tx_id.BackColor = System.Drawing.SystemColors.Window;
            this.tx_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_id.Location = new System.Drawing.Point(56, 284);
            this.tx_id.Multiline = true;
            this.tx_id.Name = "tx_id";
            this.tx_id.Size = new System.Drawing.Size(426, 24);
            this.tx_id.TabIndex = 6;
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.BackColor = System.Drawing.Color.Transparent;
            this.bt_Cancelar.FlatAppearance.BorderSize = 0;
            this.bt_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Cancelar.Location = new System.Drawing.Point(536, 407);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(110, 26);
            this.bt_Cancelar.TabIndex = 10;
            this.bt_Cancelar.UseVisualStyleBackColor = false;
            // 
            // bt_Confirmar
            // 
            this.bt_Confirmar.BackColor = System.Drawing.Color.Transparent;
            this.bt_Confirmar.FlatAppearance.BorderSize = 0;
            this.bt_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Confirmar.Location = new System.Drawing.Point(675, 407);
            this.bt_Confirmar.Name = "bt_Confirmar";
            this.bt_Confirmar.Size = new System.Drawing.Size(110, 26);
            this.bt_Confirmar.TabIndex = 11;
            this.bt_Confirmar.UseVisualStyleBackColor = false;
            // 
            // tx_nome
            // 
            this.tx_nome.BackColor = System.Drawing.SystemColors.Window;
            this.tx_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_nome.Location = new System.Drawing.Point(76, 232);
            this.tx_nome.Multiline = true;
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(426, 24);
            this.tx_nome.TabIndex = 5;
            // 
            // TransferenciaRevisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Confirmar);
            this.Controls.Add(this.bt_Cancelar);
            this.Controls.Add(this.tx_valor);
            this.Controls.Add(this.tx_chave);
            this.Controls.Add(this.tx_instituicao);
            this.Controls.Add(this.tx_id);
            this.Controls.Add(this.tx_nome);
            this.Name = "TransferenciaRevisao";
            this.Text = "TransferenciaRevisao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_valor;
        private System.Windows.Forms.TextBox tx_chave;
        private System.Windows.Forms.TextBox tx_instituicao;
        private System.Windows.Forms.TextBox tx_id;
        private System.Windows.Forms.Button bt_Cancelar;
        private System.Windows.Forms.Button bt_Confirmar;
        private System.Windows.Forms.TextBox tx_nome;
    }
}