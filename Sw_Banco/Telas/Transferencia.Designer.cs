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
            this.tx_valor = new System.Windows.Forms.TextBox();
            this.tx_chave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_Confirmar
            // 
            this.bt_Confirmar.BackColor = System.Drawing.Color.Transparent;
            this.bt_Confirmar.FlatAppearance.BorderSize = 0;
            this.bt_Confirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_Confirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Confirmar.Location = new System.Drawing.Point(572, 462);
            this.bt_Confirmar.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Confirmar.Name = "bt_Confirmar";
            this.bt_Confirmar.Size = new System.Drawing.Size(145, 33);
            this.bt_Confirmar.TabIndex = 0;
            this.bt_Confirmar.UseVisualStyleBackColor = false;
            this.bt_Confirmar.Click += new System.EventHandler(this.bt_Confirmar_Click);
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.BackColor = System.Drawing.Color.Transparent;
            this.bt_Cancelar.FlatAppearance.BorderSize = 0;
            this.bt_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Cancelar.Location = new System.Drawing.Point(323, 462);
            this.bt_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(145, 33);
            this.bt_Cancelar.TabIndex = 1;
            this.bt_Cancelar.UseVisualStyleBackColor = false;
            this.bt_Cancelar.Click += new System.EventHandler(this.bt_Cancelar_Click);
            // 
            // tx_valor
            // 
            this.tx_valor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_valor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_valor.Location = new System.Drawing.Point(436, 359);
            this.tx_valor.Margin = new System.Windows.Forms.Padding(4);
            this.tx_valor.Multiline = true;
            this.tx_valor.Name = "tx_valor";
            this.tx_valor.Size = new System.Drawing.Size(177, 21);
            this.tx_valor.TabIndex = 3;
            // 
            // tx_chave
            // 
            this.tx_chave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_chave.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_chave.Location = new System.Drawing.Point(436, 234);
            this.tx_chave.Margin = new System.Windows.Forms.Padding(4);
            this.tx_chave.Multiline = true;
            this.tx_chave.Name = "tx_chave";
            this.tx_chave.Size = new System.Drawing.Size(177, 23);
            this.tx_chave.TabIndex = 24;
            // 
            // Transferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tx_chave);
            this.Controls.Add(this.tx_valor);
            this.Controls.Add(this.bt_Cancelar);
            this.Controls.Add(this.bt_Confirmar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Transferencia";
            this.Text = "Transferencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Confirmar;
        private System.Windows.Forms.Button bt_Cancelar;
        private System.Windows.Forms.TextBox tx_valor;
        private System.Windows.Forms.TextBox tx_chave;
    }
}