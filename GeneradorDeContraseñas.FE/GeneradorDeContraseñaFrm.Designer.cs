
namespace GeneradorDeContraseñas.FE
{
    partial class Formulario1
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
            this.chkMayusculas = new System.Windows.Forms.CheckBox();
            this.chkNumeros = new System.Windows.Forms.CheckBox();
            this.chkSimbolos = new System.Windows.Forms.CheckBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblLongitud = new System.Windows.Forms.Label();
            this.txtbxLongitud = new System.Windows.Forms.TextBox();
            this.btGenerar = new System.Windows.Forms.Button();
            this.txtbxResultado = new System.Windows.Forms.TextBox();
            this.lblAdv = new System.Windows.Forms.Label();
            this.lblAst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkMayusculas
            // 
            this.chkMayusculas.AutoSize = true;
            this.chkMayusculas.BackColor = System.Drawing.SystemColors.Control;
            this.chkMayusculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMayusculas.Location = new System.Drawing.Point(17, 88);
            this.chkMayusculas.Name = "chkMayusculas";
            this.chkMayusculas.Size = new System.Drawing.Size(182, 29);
            this.chkMayusculas.TabIndex = 0;
            this.chkMayusculas.Text = "Usar Mayúsculas";
            this.chkMayusculas.UseVisualStyleBackColor = false;
            this.chkMayusculas.CheckedChanged += new System.EventHandler(this.chkMayusculas_CheckedChanged);
            // 
            // chkNumeros
            // 
            this.chkNumeros.AutoSize = true;
            this.chkNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNumeros.Location = new System.Drawing.Point(369, 88);
            this.chkNumeros.Name = "chkNumeros";
            this.chkNumeros.Size = new System.Drawing.Size(156, 29);
            this.chkNumeros.TabIndex = 1;
            this.chkNumeros.Text = "Usar Números";
            this.chkNumeros.UseVisualStyleBackColor = true;
            this.chkNumeros.CheckedChanged += new System.EventHandler(this.chkNumeros_CheckedChanged);
            // 
            // chkSimbolos
            // 
            this.chkSimbolos.AutoSize = true;
            this.chkSimbolos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSimbolos.Location = new System.Drawing.Point(205, 88);
            this.chkSimbolos.Name = "chkSimbolos";
            this.chkSimbolos.Size = new System.Drawing.Size(158, 29);
            this.chkSimbolos.TabIndex = 2;
            this.chkSimbolos.Text = "Usar Símbolos";
            this.chkSimbolos.UseVisualStyleBackColor = true;
            this.chkSimbolos.CheckedChanged += new System.EventHandler(this.chkSimbolos_CheckedChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 15F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(121, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(462, 25);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Bienvenido al generador de contraseñas";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(12, 46);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(497, 25);
            this.lblSubtitulo.TabIndex = 4;
            this.lblSubtitulo.Text = "Seleccione sus preferencias y crearemos su contraseña";
            // 
            // lblLongitud
            // 
            this.lblLongitud.AutoSize = true;
            this.lblLongitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitud.Location = new System.Drawing.Point(12, 136);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(305, 25);
            this.lblLongitud.TabIndex = 5;
            this.lblLongitud.Text = "Ingrese la cantidad de caracteres:";
            // 
            // txtbxLongitud
            // 
            this.txtbxLongitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxLongitud.Location = new System.Drawing.Point(323, 135);
            this.txtbxLongitud.Name = "txtbxLongitud";
            this.txtbxLongitud.Size = new System.Drawing.Size(242, 26);
            this.txtbxLongitud.TabIndex = 6;
            this.txtbxLongitud.TextChanged += new System.EventHandler(this.txtbxLongitud_TextChanged);
            // 
            // btGenerar
            // 
            this.btGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGenerar.Location = new System.Drawing.Point(278, 191);
            this.btGenerar.Name = "btGenerar";
            this.btGenerar.Size = new System.Drawing.Size(157, 75);
            this.btGenerar.TabIndex = 7;
            this.btGenerar.Text = "Generar Contraseña";
            this.btGenerar.UseVisualStyleBackColor = true;
            this.btGenerar.Click += new System.EventHandler(this.btGenerar_Click);
            // 
            // txtbxResultado
            // 
            this.txtbxResultado.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxResultado.ForeColor = System.Drawing.Color.Gray;
            this.txtbxResultado.Location = new System.Drawing.Point(171, 283);
            this.txtbxResultado.Name = "txtbxResultado";
            this.txtbxResultado.ReadOnly = true;
            this.txtbxResultado.Size = new System.Drawing.Size(377, 30);
            this.txtbxResultado.TabIndex = 8;
            this.txtbxResultado.Text = "Su contraseña aparecerá aquí";
            // 
            // lblAdv
            // 
            this.lblAdv.AutoSize = true;
            this.lblAdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdv.ForeColor = System.Drawing.Color.Red;
            this.lblAdv.Location = new System.Drawing.Point(323, 164);
            this.lblAdv.Name = "lblAdv";
            this.lblAdv.Size = new System.Drawing.Size(0, 22);
            this.lblAdv.TabIndex = 9;
            // 
            // lblAst
            // 
            this.lblAst.AutoSize = true;
            this.lblAst.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAst.ForeColor = System.Drawing.Color.Red;
            this.lblAst.Location = new System.Drawing.Point(566, 124);
            this.lblAst.Name = "lblAst";
            this.lblAst.Size = new System.Drawing.Size(0, 22);
            this.lblAst.TabIndex = 10;
            // 
            // Formulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 385);
            this.Controls.Add(this.lblAst);
            this.Controls.Add(this.lblAdv);
            this.Controls.Add(this.txtbxResultado);
            this.Controls.Add(this.btGenerar);
            this.Controls.Add(this.txtbxLongitud);
            this.Controls.Add(this.lblLongitud);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.chkSimbolos);
            this.Controls.Add(this.chkNumeros);
            this.Controls.Add(this.chkMayusculas);
            this.Name = "Formulario1";
            this.Text = "Generador de Contraseñas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkMayusculas;
        private System.Windows.Forms.CheckBox chkNumeros;
        private System.Windows.Forms.CheckBox chkSimbolos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblLongitud;
        private System.Windows.Forms.TextBox txtbxLongitud;
        private System.Windows.Forms.Button btGenerar;
        private System.Windows.Forms.TextBox txtbxResultado;
        private System.Windows.Forms.Label lblAdv;
        private System.Windows.Forms.Label lblAst;
    }
}

