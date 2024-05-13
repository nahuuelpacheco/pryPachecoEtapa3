
namespace pryPachecoEtapa3
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
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnBarco = new System.Windows.Forms.Button();
            this.btnAvion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehiculo.Location = new System.Drawing.Point(256, 291);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(179, 73);
            this.lblVehiculo.TabIndex = 4;
            this.lblVehiculo.Text = "Nombre del vehiculo";
            this.lblVehiculo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(12, 25);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(120, 53);
            this.btnAuto.TabIndex = 5;
            this.btnAuto.Text = "AUTO";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnBarco
            // 
            this.btnBarco.Location = new System.Drawing.Point(12, 166);
            this.btnBarco.Name = "btnBarco";
            this.btnBarco.Size = new System.Drawing.Size(120, 53);
            this.btnBarco.TabIndex = 6;
            this.btnBarco.Text = "BARCO";
            this.btnBarco.UseVisualStyleBackColor = true;
            this.btnBarco.Click += new System.EventHandler(this.btnBarco_Click);
            // 
            // btnAvion
            // 
            this.btnAvion.Location = new System.Drawing.Point(12, 311);
            this.btnAvion.Name = "btnAvion";
            this.btnAvion.Size = new System.Drawing.Size(120, 53);
            this.btnAvion.TabIndex = 7;
            this.btnAvion.Text = "AVION";
            this.btnAvion.UseVisualStyleBackColor = true;
            this.btnAvion.Click += new System.EventHandler(this.btnAvion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.btnAvion);
            this.Controls.Add(this.btnBarco);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.lblVehiculo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AUTO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnBarco;
        private System.Windows.Forms.Button btnAvion;
    }
}

