namespace Sw_Banco.Telas
{
    partial class Pix
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pix));
            this.tx_valor = new System.Windows.Forms.TextBox();
            this.bt_confirmar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.tx_chave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tx_valor
            // 
            this.tx_valor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_valor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_valor.Location = new System.Drawing.Point(459, 352);
            this.tx_valor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_valor.Multiline = true;
            this.tx_valor.Name = "tx_valor";
            this.tx_valor.Size = new System.Drawing.Size(155, 32);
            this.tx_valor.TabIndex = 1;
            // 
            // bt_confirmar
            // 
            this.bt_confirmar.BackColor = System.Drawing.Color.Transparent;
            this.bt_confirmar.FlatAppearance.BorderSize = 0;
            this.bt_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_confirmar.Location = new System.Drawing.Point(589, 470);
            this.bt_confirmar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_confirmar.Name = "bt_confirmar";
            this.bt_confirmar.Size = new System.Drawing.Size(141, 28);
            this.bt_confirmar.TabIndex = 2;
            this.bt_confirmar.UseVisualStyleBackColor = false;
            this.bt_confirmar.Click += new System.EventHandler(this.bt_confirmar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.bt_cancelar.FlatAppearance.BorderSize = 0;
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Location = new System.Drawing.Point(337, 470);
            this.bt_cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(141, 28);
            this.bt_cancelar.TabIndex = 3;
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // tx_chave
            // 
            this.tx_chave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_chave.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_chave.Location = new System.Drawing.Point(459, 220);
            this.tx_chave.Margin = new System.Windows.Forms.Padding(4);
            this.tx_chave.Multiline = true;
            this.tx_chave.Name = "tx_chave";
            this.tx_chave.Size = new System.Drawing.Size(155, 32);
            this.tx_chave.TabIndex = 4;
            // 
            // pix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tx_chave);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_confirmar);
            this.Controls.Add(this.tx_valor);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "pix";
            this.Text = "pix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tx_valor;
        private System.Windows.Forms.Button bt_confirmar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.TextBox tx_chave;
    }
}