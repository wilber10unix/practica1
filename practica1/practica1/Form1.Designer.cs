﻿namespace practica1
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
            this.ctNombre = new System.Windows.Forms.TextBox();
            this.ctEdad = new System.Windows.Forms.TextBox();
            this.ctSexo = new System.Windows.Forms.TextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctNombre
            // 
            this.ctNombre.Location = new System.Drawing.Point(350, 101);
            this.ctNombre.Name = "ctNombre";
            this.ctNombre.Size = new System.Drawing.Size(100, 20);
            this.ctNombre.TabIndex = 0;
            // 
            // ctEdad
            // 
            this.ctEdad.Location = new System.Drawing.Point(350, 158);
            this.ctEdad.Name = "ctEdad";
            this.ctEdad.Size = new System.Drawing.Size(100, 20);
            this.ctEdad.TabIndex = 1;
            this.ctEdad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ctSexo
            // 
            this.ctSexo.Location = new System.Drawing.Point(350, 215);
            this.ctSexo.Name = "ctSexo";
            this.ctSexo.Size = new System.Drawing.Size(100, 20);
            this.ctSexo.TabIndex = 2;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(371, 317);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 3;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sexo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.ctSexo);
            this.Controls.Add(this.ctEdad);
            this.Controls.Add(this.ctNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctNombre;
        private System.Windows.Forms.TextBox ctEdad;
        private System.Windows.Forms.TextBox ctSexo;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

