﻿namespace ManipulacaoArquivos
{
    partial class Backup
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbOrigem = new System.Windows.Forms.TextBox();
            this.btnSelecionar01 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDestino = new System.Windows.Forms.TextBox();
            this.btnSelecionar02 = new System.Windows.Forms.Button();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Backup de Arquivos";
            // 
            // tbOrigem
            // 
            this.tbOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrigem.Location = new System.Drawing.Point(151, 94);
            this.tbOrigem.Name = "tbOrigem";
            this.tbOrigem.Size = new System.Drawing.Size(315, 26);
            this.tbOrigem.TabIndex = 1;
            // 
            // btnSelecionar01
            // 
            this.btnSelecionar01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar01.Location = new System.Drawing.Point(487, 91);
            this.btnSelecionar01.Name = "btnSelecionar01";
            this.btnSelecionar01.Size = new System.Drawing.Size(95, 29);
            this.btnSelecionar01.TabIndex = 2;
            this.btnSelecionar01.Text = "selecionar";
            this.btnSelecionar01.UseVisualStyleBackColor = true;
            this.btnSelecionar01.Click += new System.EventHandler(this.btnSelecionar01_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "origem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "destino";
            // 
            // tbDestino
            // 
            this.tbDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDestino.Location = new System.Drawing.Point(151, 165);
            this.tbDestino.Name = "tbDestino";
            this.tbDestino.Size = new System.Drawing.Size(315, 26);
            this.tbDestino.TabIndex = 5;
            // 
            // btnSelecionar02
            // 
            this.btnSelecionar02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar02.Location = new System.Drawing.Point(487, 165);
            this.btnSelecionar02.Name = "btnSelecionar02";
            this.btnSelecionar02.Size = new System.Drawing.Size(95, 26);
            this.btnSelecionar02.TabIndex = 6;
            this.btnSelecionar02.Text = "selecionar";
            this.btnSelecionar02.UseVisualStyleBackColor = true;
            this.btnSelecionar02.Click += new System.EventHandler(this.btnSelecionar02_Click);
            // 
            // btnExecutar
            // 
            this.btnExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.Location = new System.Drawing.Point(279, 266);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(94, 27);
            this.btnExecutar.TabIndex = 7;
            this.btnExecutar.Text = "executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 335);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.btnSelecionar02);
            this.Controls.Add(this.tbDestino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelecionar01);
            this.Controls.Add(this.tbOrigem);
            this.Controls.Add(this.label1);
            this.Name = "Backup";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOrigem;
        private System.Windows.Forms.Button btnSelecionar01;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDestino;
        private System.Windows.Forms.Button btnSelecionar02;
        private System.Windows.Forms.Button btnExecutar;
    }
}

