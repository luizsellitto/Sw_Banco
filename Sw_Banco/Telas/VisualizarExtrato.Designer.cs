﻿namespace Sw_Banco.Telas
{
    partial class VisualizarExtrato
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sair_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 328);
            this.dataGridView1.TabIndex = 0;
            // 
            // sair_button
            // 
            this.sair_button.Location = new System.Drawing.Point(417, 382);
            this.sair_button.Name = "sair_button";
            this.sair_button.Size = new System.Drawing.Size(75, 23);
            this.sair_button.TabIndex = 1;
            this.sair_button.Text = "sair";
            this.sair_button.UseVisualStyleBackColor = true;
            this.sair_button.Click += new System.EventHandler(this.sair_button_Click);
            // 
            // VisualizarExtrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sair_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VisualizarExtrato";
            this.Text = "VisualizarExtrato";
            this.Load += new System.EventHandler(this.VisualizarExtrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button sair_button;
    }
}