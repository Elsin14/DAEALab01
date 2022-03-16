namespace WindowsFormsApp2
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
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.operacion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.calcular1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.numeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.combo2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.calcular2 = new System.Windows.Forms.Button();
            this.convertir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabcontrol.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tabPage1);
            this.tabcontrol.Controls.Add(this.tabPage3);
            this.tabcontrol.Controls.Add(this.tabPage2);
            this.tabcontrol.Location = new System.Drawing.Point(12, 12);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(731, 389);
            this.tabcontrol.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.operacion);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.calcular1);
            this.tabPage1.Controls.Add(this.n2);
            this.tabPage1.Controls.Add(this.n1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(723, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Calculadora";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // operacion
            // 
            this.operacion.FormattingEnabled = true;
            this.operacion.Location = new System.Drawing.Point(99, 98);
            this.operacion.Name = "operacion";
            this.operacion.Size = new System.Drawing.Size(121, 21);
            this.operacion.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Operación";
            // 
            // calcular1
            // 
            this.calcular1.Location = new System.Drawing.Point(99, 131);
            this.calcular1.Name = "calcular1";
            this.calcular1.Size = new System.Drawing.Size(75, 23);
            this.calcular1.TabIndex = 4;
            this.calcular1.Text = "Calcular";
            this.calcular1.UseVisualStyleBackColor = true;
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(99, 64);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(100, 20);
            this.n2.TabIndex = 3;
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(99, 35);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(100, 20);
            this.n1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabla);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(723, 363);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Numeros primos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabla
            // 
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeros});
            this.tabla.Location = new System.Drawing.Point(20, 30);
            this.tabla.Name = "tabla";
            this.tabla.Size = new System.Drawing.Size(381, 311);
            this.tabla.TabIndex = 0;
            // 
            // numeros
            // 
            this.numeros.HeaderText = "numero";
            this.numeros.Name = "numeros";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.combo2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.calcular2);
            this.tabPage2.Controls.Add(this.convertir);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(723, 363);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Conversion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // combo2
            // 
            this.combo2.FormattingEnabled = true;
            this.combo2.Location = new System.Drawing.Point(123, 85);
            this.combo2.Name = "combo2";
            this.combo2.Size = new System.Drawing.Size(121, 21);
            this.combo2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Operación";
            // 
            // calcular2
            // 
            this.calcular2.Location = new System.Drawing.Point(123, 127);
            this.calcular2.Name = "calcular2";
            this.calcular2.Size = new System.Drawing.Size(75, 23);
            this.calcular2.TabIndex = 9;
            this.calcular2.Text = "Calcular";
            this.calcular2.UseVisualStyleBackColor = true;
            // 
            // convertir
            // 
            this.convertir.Location = new System.Drawing.Point(123, 41);
            this.convertir.Name = "convertir";
            this.convertir.Size = new System.Drawing.Size(100, 20);
            this.convertir.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Numero";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabcontrol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabcontrol.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox operacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calcular1;
        private System.Windows.Forms.TextBox n2;
        private System.Windows.Forms.TextBox n1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeros;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox combo2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calcular2;
        private System.Windows.Forms.TextBox convertir;
        private System.Windows.Forms.Label label5;
    }
}

