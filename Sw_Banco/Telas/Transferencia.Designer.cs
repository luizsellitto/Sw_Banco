namespace Sw_Banco.Telas
{
    partial class Transferencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transferencia));
            this.bt_Confirmar = new System.Windows.Forms.Button();
            this.bt_Cancelar = new System.Windows.Forms.Button();
            this.tx_chave = new System.Windows.Forms.TextBox();
            this.tx_valor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_Confirmar
            // 
            this.bt_Confirmar.BackColor = System.Drawing.Color.Transparent;
            this.bt_Confirmar.FlatAppearance.BorderSize = 0;
            this.bt_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Confirmar.Location = new System.Drawing.Point(429, 375);
            this.bt_Confirmar.Name = "bt_Confirmar";
            this.bt_Confirmar.Size = new System.Drawing.Size(109, 27);
            this.bt_Confirmar.TabIndex = 0;
            this.bt_Confirmar.UseVisualStyleBackColor = false;
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.BackColor = System.Drawing.Color.Transparent;
            this.bt_Cancelar.FlatAppearance.BorderSize = 0;
            this.bt_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Cancelar.Location = new System.Drawing.Point(242, 375);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(109, 27);
            this.bt_Cancelar.TabIndex = 1;
            this.bt_Cancelar.UseVisualStyleBackColor = false;
            // 
            // tx_chave
            // 
            this.tx_chave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_chave.Location = new System.Drawing.Point(327, 189);
            this.tx_chave.Multiline = true;
            this.tx_chave.Name = "tx_chave";
            this.tx_chave.Size = new System.Drawing.Size(133, 25);
            this.tx_chave.TabIndex = 2;
            // 
            // tx_valor
            // 
            this.tx_valor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_valor.Location = new System.Drawing.Point(327, 288);
            this.tx_valor.Multiline = true;
            this.tx_valor.Name = "tx_valor";
            this.tx_valor.Size = new System.Drawing.Size(133, 25);
            this.tx_valor.TabIndex = 3;
            // 
            // Transferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tx_valor);
            this.Controls.Add(this.tx_chave);
            this.Controls.Add(this.bt_Cancelar);
            this.Controls.Add(this.bt_Confirmar);
            this.Name = "Transferencia";
            this.Text = "Transferencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Confirmar;
        private System.Windows.Forms.Button bt_Cancelar;
        private System.Windows.Forms.TextBox tx_chave;
        private System.Windows.Forms.TextBox tx_valor;
    }
}