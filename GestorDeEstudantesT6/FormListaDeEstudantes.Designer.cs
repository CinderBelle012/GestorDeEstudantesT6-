namespace GestorDeEstudantesT6
{
    partial class FormListaDeEstudantes
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
            this.dataGridViewListaDeEstudantes = new System.Windows.Forms.DataGridView();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaDeEstudantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListaDeEstudantes
            // 
            this.dataGridViewListaDeEstudantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListaDeEstudantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaDeEstudantes.Location = new System.Drawing.Point(16, 15);
            this.dataGridViewListaDeEstudantes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewListaDeEstudantes.Name = "dataGridViewListaDeEstudantes";
            this.dataGridViewListaDeEstudantes.RowHeadersWidth = 51;
            this.dataGridViewListaDeEstudantes.Size = new System.Drawing.Size(923, 391);
            this.dataGridViewListaDeEstudantes.TabIndex = 0;
            this.dataGridViewListaDeEstudantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListaDeEstudantes_CellContentClick);
            this.dataGridViewListaDeEstudantes.DoubleClick += new System.EventHandler(this.dataGridViewListaDeEstudantes_DoubleClick);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtualizar.Location = new System.Drawing.Point(16, 414);
            this.buttonAtualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(923, 85);
            this.buttonAtualizar.TabIndex = 1;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // FormListaDeEstudantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 512);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.dataGridViewListaDeEstudantes);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormListaDeEstudantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGA - Lista de Alunos";
            this.Load += new System.EventHandler(this.FormListaDeEstudantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaDeEstudantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListaDeEstudantes;
        private System.Windows.Forms.Button buttonAtualizar;
    }
}