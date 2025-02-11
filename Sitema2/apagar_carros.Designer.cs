namespace Sitema2
{
    partial class apagar_carros
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
            this.dgvCarros = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonRemoverCarros = new System.Windows.Forms.Button();
            this.buttonPesquisarcarros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCarros
            // 
            this.dgvCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarros.Location = new System.Drawing.Point(29, 51);
            this.dgvCarros.Name = "dgvCarros";
            this.dgvCarros.Size = new System.Drawing.Size(541, 319);
            this.dgvCarros.TabIndex = 1;
            this.dgvCarros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarros_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "apagar carros";
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Location = new System.Drawing.Point(619, 252);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(147, 26);
            this.buttonFechar.TabIndex = 6;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click_1);
            // 
            // buttonRemoverCarros
            // 
            this.buttonRemoverCarros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoverCarros.Location = new System.Drawing.Point(619, 189);
            this.buttonRemoverCarros.Name = "buttonRemoverCarros";
            this.buttonRemoverCarros.Size = new System.Drawing.Size(147, 26);
            this.buttonRemoverCarros.TabIndex = 5;
            this.buttonRemoverCarros.Text = "Remover carros";
            this.buttonRemoverCarros.UseVisualStyleBackColor = true;
            this.buttonRemoverCarros.Click += new System.EventHandler(this.buttonRemoverCarros_Click);
            // 
            // buttonPesquisarcarros
            // 
            this.buttonPesquisarcarros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisarcarros.Location = new System.Drawing.Point(619, 117);
            this.buttonPesquisarcarros.Name = "buttonPesquisarcarros";
            this.buttonPesquisarcarros.Size = new System.Drawing.Size(147, 32);
            this.buttonPesquisarcarros.TabIndex = 4;
            this.buttonPesquisarcarros.Text = "Pesquisar carros";
            this.buttonPesquisarcarros.UseVisualStyleBackColor = true;
            this.buttonPesquisarcarros.Click += new System.EventHandler(this.buttonPesquisarcarros_Click);
            // 
            // apagar_carros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonRemoverCarros);
            this.Controls.Add(this.buttonPesquisarcarros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCarros);
            this.Name = "apagar_carros";
            this.Text = "apagar_carros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonRemoverCarros;
        private System.Windows.Forms.Button buttonPesquisarcarros;
    }
}