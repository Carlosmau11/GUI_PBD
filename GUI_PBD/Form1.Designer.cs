
namespace GUI_PBD
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.lblText = new System.Windows.Forms.Label();
			this.btnAlumnoEmpresa = new System.Windows.Forms.Button();
			this.btnAlumno = new System.Windows.Forms.Button();
			this.btnEmpresa = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblText
			// 
			this.lblText.AutoSize = true;
			this.lblText.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblText.ForeColor = System.Drawing.SystemColors.Control;
			this.lblText.Location = new System.Drawing.Point(95, 84);
			this.lblText.Name = "lblText";
			this.lblText.Size = new System.Drawing.Size(605, 25);
			this.lblText.TabIndex = 0;
			this.lblText.Text = "BIENVENIDOS AL SISTEMA DE CONTROL DE ALUMNOS Y EMPRESAS";
			this.lblText.Click += new System.EventHandler(this.label1_Click);
			// 
			// btnAlumnoEmpresa
			// 
			this.btnAlumnoEmpresa.Image = global::GUI_PBD.Properties.Resources.AlumnoEmpresa;
			this.btnAlumnoEmpresa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnAlumnoEmpresa.Location = new System.Drawing.Point(586, 223);
			this.btnAlumnoEmpresa.Name = "btnAlumnoEmpresa";
			this.btnAlumnoEmpresa.Size = new System.Drawing.Size(95, 88);
			this.btnAlumnoEmpresa.TabIndex = 3;
			this.btnAlumnoEmpresa.Text = "AlumnoEmpresa";
			this.btnAlumnoEmpresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAlumnoEmpresa.UseVisualStyleBackColor = true;
			// 
			// btnAlumno
			// 
			this.btnAlumno.Image = global::GUI_PBD.Properties.Resources.Alumno;
			this.btnAlumno.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnAlumno.Location = new System.Drawing.Point(348, 223);
			this.btnAlumno.Name = "btnAlumno";
			this.btnAlumno.Size = new System.Drawing.Size(95, 88);
			this.btnAlumno.TabIndex = 2;
			this.btnAlumno.Text = "Alumno";
			this.btnAlumno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAlumno.UseVisualStyleBackColor = true;
			// 
			// btnEmpresa
			// 
			this.btnEmpresa.Image = global::GUI_PBD.Properties.Resources.Empresa;
			this.btnEmpresa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnEmpresa.Location = new System.Drawing.Point(124, 223);
			this.btnEmpresa.Name = "btnEmpresa";
			this.btnEmpresa.Size = new System.Drawing.Size(95, 88);
			this.btnEmpresa.TabIndex = 1;
			this.btnEmpresa.Text = "Empresa";
			this.btnEmpresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnEmpresa.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnAlumnoEmpresa);
			this.Controls.Add(this.btnAlumno);
			this.Controls.Add(this.btnEmpresa);
			this.Controls.Add(this.lblText);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sistema PBD";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblText;
		private System.Windows.Forms.Button btnEmpresa;
		private System.Windows.Forms.Button btnAlumno;
		private System.Windows.Forms.Button btnAlumnoEmpresa;
	}
}

