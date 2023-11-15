namespace Sw_Banco.Telas
{
    partial class Menup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menup));
            this.bt_pix = new System.Windows.Forms.Button();
            this.bt_emprestimo = new System.Windows.Forms.Button();
            this.bt_transferencia = new System.Windows.Forms.Button();
            this.bt_extrato = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.tx_saldo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_pix
            // 
            this.bt_pix.BackColor = System.Drawing.Color.Transparent;
            this.bt_pix.FlatAppearance.BorderSize = 0;
            this.bt_pix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_pix.Location = new System.Drawing.Point(291, 282);
            this.bt_pix.Margin = new System.Windows.Forms.Padding(4);
            this.bt_pix.Name = "bt_pix";
            this.bt_pix.Size = new System.Drawing.Size(127, 132);
            this.bt_pix.TabIndex = 0;
            this.bt_pix.UseVisualStyleBackColor = false;
            this.bt_pix.Click += new System.EventHandler(this.bt_pix_Click);
            // 
            // bt_emprestimo
            // 
            this.bt_emprestimo.BackColor = System.Drawing.Color.Transparent;
            this.bt_emprestimo.FlatAppearance.BorderSize = 0;
            this.bt_emprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_emprestimo.Location = new System.Drawing.Point(464, 282);
            this.bt_emprestimo.Margin = new System.Windows.Forms.Padding(4);
            this.bt_emprestimo.Name = "bt_emprestimo";
            this.bt_emprestimo.Size = new System.Drawing.Size(127, 132);
            this.bt_emprestimo.TabIndex = 1;
            this.bt_emprestimo.UseVisualStyleBackColor = false;
            this.bt_emprestimo.Click += new System.EventHandler(this.bt_emprestimo_Click);
            // 
            // bt_transferencia
            // 
            this.bt_transferencia.BackColor = System.Drawing.Color.Transparent;
            this.bt_transferencia.FlatAppearance.BorderSize = 0;
            this.bt_transferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_transferencia.Location = new System.Drawing.Point(637, 282);
            this.bt_transferencia.Margin = new System.Windows.Forms.Padding(4);
            this.bt_transferencia.Name = "bt_transferencia";
            this.bt_transferencia.Size = new System.Drawing.Size(127, 132);
            this.bt_transferencia.TabIndex = 2;
            this.bt_transferencia.UseVisualStyleBackColor = false;
            this.bt_transferencia.Click += new System.EventHandler(this.bt_transferencia_Click);
            // 
            // bt_extrato
            // 
            this.bt_extrato.BackColor = System.Drawing.Color.Transparent;
            this.bt_extrato.FlatAppearance.BorderSize = 0;
            this.bt_extrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_extrato.Location = new System.Drawing.Point(291, 450);
            this.bt_extrato.Margin = new System.Windows.Forms.Padding(4);
            this.bt_extrato.Name = "bt_extrato";
            this.bt_extrato.Size = new System.Drawing.Size(127, 132);
            this.bt_extrato.TabIndex = 3;
            this.bt_extrato.UseVisualStyleBackColor = false;
            this.bt_extrato.Click += new System.EventHandler(this.bt_extrato_Click);
            // 
            // bt_sair
            // 
            this.bt_sair.BackColor = System.Drawing.Color.Transparent;
            this.bt_sair.FlatAppearance.BorderSize = 0;
            this.bt_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sair.Location = new System.Drawing.Point(464, 450);
            this.bt_sair.Margin = new System.Windows.Forms.Padding(4);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(127, 132);
            this.bt_sair.TabIndex = 4;
            this.bt_sair.UseVisualStyleBackColor = false;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click_1);
            // 
            // tx_saldo
            // 
            this.tx_saldo.Enabled = false;
            this.tx_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_saldo.Location = new System.Drawing.Point(475, 190);
            this.tx_saldo.Margin = new System.Windows.Forms.Padding(4);
            this.tx_saldo.Multiline = true;
            this.tx_saldo.Name = "tx_saldo";
            this.tx_saldo.Size = new System.Drawing.Size(102, 31);
            this.tx_saldo.TabIndex = 5;
            // 
            // Menup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1037, 657);
            this.Controls.Add(this.tx_saldo);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.bt_extrato);
            this.Controls.Add(this.bt_transferencia);
            this.Controls.Add(this.bt_emprestimo);
            this.Controls.Add(this.bt_pix);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menup";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_pix;
        private System.Windows.Forms.Button bt_emprestimo;
        private System.Windows.Forms.Button bt_transferencia;
        private System.Windows.Forms.Button bt_extrato;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.TextBox tx_saldo;
    }
}