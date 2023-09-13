
namespace CargarMatriz
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
            this.txtbox = new System.Windows.Forms.TextBox();
            this.btcargar = new System.Windows.Forms.Button();
            this.btlistar = new System.Windows.Forms.Button();
            this.lbllista = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(34, 48);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(175, 20);
            this.txtbox.TabIndex = 0;
            // 
            // btcargar
            // 
            this.btcargar.Location = new System.Drawing.Point(216, 48);
            this.btcargar.Name = "btcargar";
            this.btcargar.Size = new System.Drawing.Size(75, 23);
            this.btcargar.TabIndex = 1;
            this.btcargar.Text = "Cargar";
            this.btcargar.UseVisualStyleBackColor = true;
            this.btcargar.Click += new System.EventHandler(this.btcargar_Click);
            // 
            // btlistar
            // 
            this.btlistar.Location = new System.Drawing.Point(34, 74);
            this.btlistar.Name = "btlistar";
            this.btlistar.Size = new System.Drawing.Size(75, 23);
            this.btlistar.TabIndex = 2;
            this.btlistar.Text = "Listar";
            this.btlistar.UseVisualStyleBackColor = true;
            this.btlistar.Click += new System.EventHandler(this.btlistar_Click);
            // 
            // lbllista
            // 
            this.lbllista.AutoSize = true;
            this.lbllista.Location = new System.Drawing.Point(34, 104);
            this.lbllista.Name = "lbllista";
            this.lbllista.Size = new System.Drawing.Size(0, 13);
            this.lbllista.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbllista);
            this.Controls.Add(this.btlistar);
            this.Controls.Add(this.btcargar);
            this.Controls.Add(this.txtbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.Button btcargar;
        private System.Windows.Forms.Button btlistar;
        private System.Windows.Forms.Label lbllista;
    }
}

