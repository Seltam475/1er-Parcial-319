namespace Pregunta_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.descripcion = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Porcentaje = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.raiz = new System.Windows.Forms.Button();
            this.cuadrado = new System.Windows.Forms.Button();
            this.inversa = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.nueve = new System.Windows.Forms.Button();
            this.ocho = new System.Windows.Forms.Button();
            this.siete = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.cuatro = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.dos = new System.Windows.Forms.Button();
            this.uno = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.coma = new System.Windows.Forms.Button();
            this.cero = new System.Windows.Forms.Button();
            this.cambio_signo = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcion
            // 
            this.descripcion.AutoSize = true;
            this.descripcion.Location = new System.Drawing.Point(228, 23);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(13, 13);
            this.descripcion.TabIndex = 0;
            this.descripcion.Text = "_";
            this.descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(30, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(240, 55);
            this.textBox1.TabIndex = 52;
            this.textBox1.Text = "0";
            // 
            // Porcentaje
            // 
            this.Porcentaje.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Porcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Porcentaje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Porcentaje.Location = new System.Drawing.Point(12, 131);
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.Size = new System.Drawing.Size(60, 40);
            this.Porcentaje.TabIndex = 2;
            this.Porcentaje.Text = "%";
            this.Porcentaje.UseVisualStyleBackColor = false;
            this.Porcentaje.Click += new System.EventHandler(this.Porcentaje_Click);
            // 
            // CE
            // 
            this.CE.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CE.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CE.Location = new System.Drawing.Point(78, 131);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(60, 40);
            this.CE.TabIndex = 3;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = false;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.SystemColors.ControlDark;
            this.C.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.C.Location = new System.Drawing.Point(144, 131);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(60, 40);
            this.C.TabIndex = 4;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // borrar
            // 
            this.borrar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.borrar.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.borrar.Location = new System.Drawing.Point(210, 131);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(60, 40);
            this.borrar.TabIndex = 5;
            this.borrar.Text = "<—";
            this.borrar.UseVisualStyleBackColor = false;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.SystemColors.ControlDark;
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.div.Location = new System.Drawing.Point(210, 177);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(60, 40);
            this.div.TabIndex = 9;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // raiz
            // 
            this.raiz.BackColor = System.Drawing.SystemColors.ControlDark;
            this.raiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raiz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.raiz.Location = new System.Drawing.Point(144, 177);
            this.raiz.Name = "raiz";
            this.raiz.Size = new System.Drawing.Size(60, 40);
            this.raiz.TabIndex = 8;
            this.raiz.UseVisualStyleBackColor = false;
            this.raiz.Text = "√x";
            this.raiz.Click += new System.EventHandler(this.raiz_Click);
            // 
            // cuadrado
            // 
            this.cuadrado.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuadrado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cuadrado.Location = new System.Drawing.Point(78, 177);
            this.cuadrado.Name = "cuadrado";
            this.cuadrado.Size = new System.Drawing.Size(60, 40);
            this.cuadrado.TabIndex = 7;
            this.cuadrado.UseVisualStyleBackColor = false;
            this.cuadrado.Text = "x²";
            this.cuadrado.Click += new System.EventHandler(this.cuadrado_Click);
            // 
            // inversa
            // 
            this.inversa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.inversa.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inversa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inversa.Location = new System.Drawing.Point(12, 177);
            this.inversa.Name = "inversa";
            this.inversa.Size = new System.Drawing.Size(60, 40);
            this.inversa.TabIndex = 6;
            this.inversa.Text = "1/x";
            this.inversa.UseVisualStyleBackColor = false;
            this.inversa.Click += new System.EventHandler(this.inversa_Click);
            // 
            // multi
            // 
            this.multi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.multi.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.multi.Location = new System.Drawing.Point(210, 223);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(60, 40);
            this.multi.TabIndex = 13;
            this.multi.Text = "x";
            this.multi.UseVisualStyleBackColor = false;
            this.multi.Click += new System.EventHandler(this.multi_Click);
            // 
            // nueve
            // 
            this.nueve.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nueve.Location = new System.Drawing.Point(144, 223);
            this.nueve.Name = "nueve";
            this.nueve.Size = new System.Drawing.Size(60, 40);
            this.nueve.TabIndex = 12;
            this.nueve.Text = "9";
            this.nueve.UseVisualStyleBackColor = true;
            this.nueve.Click += new System.EventHandler(this.nueve_Click);
            // 
            // ocho
            // 
            this.ocho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocho.Location = new System.Drawing.Point(78, 223);
            this.ocho.Name = "ocho";
            this.ocho.Size = new System.Drawing.Size(60, 40);
            this.ocho.TabIndex = 11;
            this.ocho.Text = "8";
            this.ocho.UseVisualStyleBackColor = true;
            this.ocho.Click += new System.EventHandler(this.ocho_Click);
            // 
            // siete
            // 
            this.siete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.siete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siete.Location = new System.Drawing.Point(12, 223);
            this.siete.Name = "siete";
            this.siete.Size = new System.Drawing.Size(60, 40);
            this.siete.TabIndex = 10;
            this.siete.Text = "7";
            this.siete.UseVisualStyleBackColor = false;
            this.siete.Click += new System.EventHandler(this.siete_Click);
            // 
            // resta
            // 
            this.resta.BackColor = System.Drawing.SystemColors.ControlDark;
            this.resta.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resta.Location = new System.Drawing.Point(210, 269);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(60, 40);
            this.resta.TabIndex = 17;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = false;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // seis
            // 
            this.seis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seis.Location = new System.Drawing.Point(144, 269);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(60, 40);
            this.seis.TabIndex = 16;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = true;
            this.seis.Click += new System.EventHandler(this.seis_Click);
            // 
            // cinco
            // 
            this.cinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinco.Location = new System.Drawing.Point(78, 269);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(60, 40);
            this.cinco.TabIndex = 15;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = true;
            this.cinco.Click += new System.EventHandler(this.cinco_Click);
            // 
            // cuatro
            // 
            this.cuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuatro.Location = new System.Drawing.Point(12, 269);
            this.cuatro.Name = "cuatro";
            this.cuatro.Size = new System.Drawing.Size(60, 40);
            this.cuatro.TabIndex = 14;
            this.cuatro.Text = "4";
            this.cuatro.UseVisualStyleBackColor = true;
            this.cuatro.Click += new System.EventHandler(this.cuatro_Click);
            // 
            // suma
            // 
            this.suma.BackColor = System.Drawing.SystemColors.ControlDark;
            this.suma.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.suma.Location = new System.Drawing.Point(210, 315);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(60, 40);
            this.suma.TabIndex = 21;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = false;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // tres
            // 
            this.tres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tres.Location = new System.Drawing.Point(144, 315);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(60, 40);
            this.tres.TabIndex = 20;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = true;
            this.tres.Click += new System.EventHandler(this.tres_Click);
            // 
            // dos
            // 
            this.dos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dos.Location = new System.Drawing.Point(78, 315);
            this.dos.Name = "dos";
            this.dos.Size = new System.Drawing.Size(60, 40);
            this.dos.TabIndex = 19;
            this.dos.Text = "2";
            this.dos.UseVisualStyleBackColor = true;
            this.dos.Click += new System.EventHandler(this.dos_Click);
            // 
            // uno
            // 
            this.uno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uno.Location = new System.Drawing.Point(12, 315);
            this.uno.Name = "uno";
            this.uno.Size = new System.Drawing.Size(60, 40);
            this.uno.TabIndex = 18;
            this.uno.Text = "1";
            this.uno.UseVisualStyleBackColor = true;
            this.uno.Click += new System.EventHandler(this.uno_Click);
            // 
            // igual
            // 
            this.igual.BackColor = System.Drawing.SystemColors.ControlDark;
            this.igual.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.igual.Location = new System.Drawing.Point(210, 361);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(60, 40);
            this.igual.TabIndex = 25;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = false;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // coma
            // 
            this.coma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coma.Location = new System.Drawing.Point(144, 361);
            this.coma.Name = "coma";
            this.coma.Size = new System.Drawing.Size(60, 40);
            this.coma.TabIndex = 24;
            this.coma.Text = ",";
            this.coma.UseVisualStyleBackColor = true;
            this.coma.Click += new System.EventHandler(this.coma_Click);
            // 
            // cero
            // 
            this.cero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cero.Location = new System.Drawing.Point(78, 361);
            this.cero.Name = "cero";
            this.cero.Size = new System.Drawing.Size(60, 40);
            this.cero.TabIndex = 23;
            this.cero.Text = "0";
            this.cero.UseVisualStyleBackColor = true;
            this.cero.Click += new System.EventHandler(this.cero_Click);
            // 
            // cambio_signo
            // 
            this.cambio_signo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambio_signo.Location = new System.Drawing.Point(12, 361);
            this.cambio_signo.Name = "cambio_signo";
            this.cambio_signo.Size = new System.Drawing.Size(60, 40);
            this.cambio_signo.TabIndex = 22;
            this.cambio_signo.Text = "+/-";
            this.cambio_signo.UseVisualStyleBackColor = true;
            this.cambio_signo.Click += new System.EventHandler(this.cambio_signo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 422);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.coma);
            this.Controls.Add(this.cero);
            this.Controls.Add(this.cambio_signo);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.tres);
            this.Controls.Add(this.dos);
            this.Controls.Add(this.uno);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.seis);
            this.Controls.Add(this.cinco);
            this.Controls.Add(this.cuatro);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.nueve);
            this.Controls.Add(this.ocho);
            this.Controls.Add(this.siete);
            this.Controls.Add(this.div);
            this.Controls.Add(this.raiz);
            this.Controls.Add(this.cuadrado);
            this.Controls.Add(this.inversa);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.C);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.Porcentaje);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.descripcion);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descripcion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Porcentaje;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button raiz;
        private System.Windows.Forms.Button cuadrado;
        private System.Windows.Forms.Button inversa;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button nueve;
        private System.Windows.Forms.Button ocho;
        private System.Windows.Forms.Button siete;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button seis;
        private System.Windows.Forms.Button cinco;
        private System.Windows.Forms.Button cuatro;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button tres;
        private System.Windows.Forms.Button dos;
        private System.Windows.Forms.Button uno;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button coma;
        private System.Windows.Forms.Button cero;
        private System.Windows.Forms.Button cambio_signo;
        private System.Windows.Forms.BindingSource bindingSource1;



    }
}

