﻿namespace Sw_Banco.Telas
{
    partial class EmprestimoRevisao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmprestimoRevisao));
            this.tx_valor = new System.Windows.Forms.TextBox();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.tx_id = new System.Windows.Forms.TextBox();
            this.tx_cpf = new System.Windows.Forms.TextBox();
            this.bt_confirmar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.tx_juros = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tx_valor
            // 
            this.tx_valor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_valor.Enabled = false;
            this.tx_valor.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_valor.Location = new System.Drawing.Point(347, 110);
            this.tx_valor.Name = "tx_valor";
            this.tx_valor.Size = new System.Drawing.Size(97, 22);
            this.tx_valor.TabIndex = 10;
            // 
            // tx_nome
            // 
            this.tx_nome.BackColor = System.Drawing.SystemColors.Window;
            this.tx_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_nome.Enabled = false;
            this.tx_nome.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_nome.Location = new System.Drawing.Point(71, 234);
            this.tx_nome.Multiline = true;
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(426, 24);
            this.tx_nome.TabIndex = 11;
            // 
            // tx_id
            // 
            this.tx_id.BackColor = System.Drawing.SystemColors.Window;
            this.tx_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_id.Enabled = false;
            this.tx_id.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_id.Location = new System.Drawing.Point(59, 315);
            this.tx_id.Multiline = true;
            this.tx_id.Name = "tx_id";
            this.tx_id.Size = new System.Drawing.Size(438, 24);
            this.tx_id.TabIndex = 12;
            // 
            // tx_cpf
            // 
            this.tx_cpf.BackColor = System.Drawing.SystemColors.Window;
            this.tx_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_cpf.Enabled = false;
            this.tx_cpf.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_cpf.Location = new System.Drawing.Point(71, 384);
            this.tx_cpf.Multiline = true;
            this.tx_cpf.Name = "tx_cpf";
            this.tx_cpf.Size = new System.Drawing.Size(426, 24);
            this.tx_cpf.TabIndex = 13;
            // 
            // bt_confirmar
            // 
            this.bt_confirmar.BackColor = System.Drawing.Color.Transparent;
            this.bt_confirmar.FlatAppearance.BorderSize = 0;
            this.bt_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_confirmar.Location = new System.Drawing.Point(678, 407);
            this.bt_confirmar.Name = "bt_confirmar";
            this.bt_confirmar.Size = new System.Drawing.Size(110, 26);
            this.bt_confirmar.TabIndex = 14;
            this.bt_confirmar.UseVisualStyleBackColor = false;
            this.bt_confirmar.Click += new System.EventHandler(this.bt_confirmar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.bt_cancelar.FlatAppearance.BorderSize = 0;
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Location = new System.Drawing.Point(540, 407);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(110, 26);
            this.bt_cancelar.TabIndex = 15;
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // tx_juros
            // 
            this.tx_juros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_juros.Enabled = false;
            this.tx_juros.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_juros.Location = new System.Drawing.Point(347, 161);
            this.tx_juros.Name = "tx_juros";
            this.tx_juros.Size = new System.Drawing.Size(97, 22);
            this.tx_juros.TabIndex = 16;
            // 
            // EmprestimoRevisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 452);
            this.Controls.Add(this.tx_juros);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_confirmar);
            this.Controls.Add(this.tx_cpf);
            this.Controls.Add(this.tx_id);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.tx_valor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EmprestimoRevisao";
            this.Text = "EmprestimoRevisao";
            this.Load += new System.EventHandler(this.EmprestimoRevisao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_valor;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.TextBox tx_id;
        private System.Windows.Forms.TextBox tx_cpf;
        private System.Windows.Forms.Button bt_confirmar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.TextBox tx_juros;
    }
}