namespace Sw_Banco.Telas
{
    partial class emprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emprestimo));
            this.tx_motivo = new System.Windows.Forms.TextBox();
            this.tx_valor = new System.Windows.Forms.TextBox();
            this.tx_totalJuros = new System.Windows.Forms.TextBox();
            this.bt_confirmar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_motivo
            // 
            this.tx_motivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_motivo.Location = new System.Drawing.Point(355, 178);
            this.tx_motivo.Multiline = true;
            this.tx_motivo.Name = "tx_motivo";
            this.tx_motivo.Size = new System.Drawing.Size(125, 24);
            this.tx_motivo.TabIndex = 0;
            // 
            // tx_valor
            // 
            this.tx_valor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_valor.Location = new System.Drawing.Point(355, 241);
            this.tx_valor.Multiline = true;
            this.tx_valor.Name = "tx_valor";
            this.tx_valor.Size = new System.Drawing.Size(125, 24);
            this.tx_valor.TabIndex = 1;
            // 
            // tx_totalJuros
            // 
            this.tx_totalJuros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_totalJuros.Location = new System.Drawing.Point(405, 309);
            this.tx_totalJuros.Multiline = true;
            this.tx_totalJuros.Name = "tx_totalJuros";
            this.tx_totalJuros.Size = new System.Drawing.Size(125, 24);
            this.tx_totalJuros.TabIndex = 2;
            // 
            // bt_confirmar
            // 
            this.bt_confirmar.BackColor = System.Drawing.Color.Transparent;
            this.bt_confirmar.FlatAppearance.BorderSize = 0;
            this.bt_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_confirmar.Location = new System.Drawing.Point(435, 378);
            this.bt_confirmar.Name = "bt_confirmar";
            this.bt_confirmar.Size = new System.Drawing.Size(113, 26);
            this.bt_confirmar.TabIndex = 3;
            this.bt_confirmar.UseVisualStyleBackColor = false;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.bt_cancelar.FlatAppearance.BorderSize = 0;
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Location = new System.Drawing.Point(255, 378);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(113, 26);
            this.bt_cancelar.TabIndex = 4;
            this.bt_cancelar.UseVisualStyleBackColor = false;
            // 
            // emprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_confirmar);
            this.Controls.Add(this.tx_totalJuros);
            this.Controls.Add(this.tx_valor);
            this.Controls.Add(this.tx_motivo);
            this.Name = "emprestimo";
            this.Text = "emprestimo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_motivo;
        private System.Windows.Forms.TextBox tx_valor;
        private System.Windows.Forms.TextBox tx_totalJuros;
        private System.Windows.Forms.Button bt_confirmar;
        private System.Windows.Forms.Button bt_cancelar;
    }
}