namespace Chinook.UI.Desktop
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnResultado = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.dcCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFiltroPorNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(296, 8);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(75, 23);
            this.btnResultado.TabIndex = 0;
            this.btnResultado.Text = "Consultar";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dcCodigo,
            this.dcNombre});
            this.dgvListado.Location = new System.Drawing.Point(8, 40);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(784, 408);
            this.dgvListado.TabIndex = 1;
            // 
            // dcCodigo
            // 
            this.dcCodigo.DataPropertyName = "ArtistId";
            this.dcCodigo.HeaderText = "Codigo";
            this.dcCodigo.Name = "dcCodigo";
            // 
            // dcNombre
            // 
            this.dcNombre.DataPropertyName = "Name";
            this.dcNombre.HeaderText = "Nombre";
            this.dcNombre.Name = "dcNombre";
            // 
            // txtFiltroPorNombre
            // 
            this.txtFiltroPorNombre.Location = new System.Drawing.Point(8, 8);
            this.txtFiltroPorNombre.Name = "txtFiltroPorNombre";
            this.txtFiltroPorNombre.Size = new System.Drawing.Size(272, 20);
            this.txtFiltroPorNombre.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFiltroPorNombre);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.btnResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcNombre;
        private System.Windows.Forms.TextBox txtFiltroPorNombre;
    }
}

