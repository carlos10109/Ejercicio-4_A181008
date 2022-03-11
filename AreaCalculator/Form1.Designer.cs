namespace AreaCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lados = new System.Windows.Forms.TextBox();
            this.AreaCuadra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ResulCuadra = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bases = new System.Windows.Forms.TextBox();
            this.altura = new System.Windows.Forms.TextBox();
            this.ResulTrian = new System.Windows.Forms.Label();
            this.AreaTria = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Radio = new System.Windows.Forms.TextBox();
            this.ResulCir = new System.Windows.Forms.Label();
            this.AreaCir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area Cuadrado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Area Triangulo";
            // 
            // lados
            // 
            this.lados.Location = new System.Drawing.Point(105, 191);
            this.lados.Name = "lados";
            this.lados.Size = new System.Drawing.Size(67, 20);
            this.lados.TabIndex = 2;
            // 
            // AreaCuadra
            // 
            this.AreaCuadra.Location = new System.Drawing.Point(61, 273);
            this.AreaCuadra.Name = "AreaCuadra";
            this.AreaCuadra.Size = new System.Drawing.Size(111, 23);
            this.AreaCuadra.TabIndex = 3;
            this.AreaCuadra.Text = "Area";
            this.AreaCuadra.UseVisualStyleBackColor = true;
            this.AreaCuadra.Click += new System.EventHandler(this.AreaCuadra_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(622, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Area Circulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "L X L =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lados Iguales";
            // 
            // ResulCuadra
            // 
            this.ResulCuadra.AutoSize = true;
            this.ResulCuadra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResulCuadra.Location = new System.Drawing.Point(93, 238);
            this.ResulCuadra.Name = "ResulCuadra";
            this.ResulCuadra.Size = new System.Drawing.Size(18, 20);
            this.ResulCuadra.TabIndex = 7;
            this.ResulCuadra.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Base";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(318, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Altura";
            // 
            // bases
            // 
            this.bases.Location = new System.Drawing.Point(365, 165);
            this.bases.Name = "bases";
            this.bases.Size = new System.Drawing.Size(67, 20);
            this.bases.TabIndex = 10;
            // 
            // altura
            // 
            this.altura.Location = new System.Drawing.Point(365, 194);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(67, 20);
            this.altura.TabIndex = 11;
            // 
            // ResulTrian
            // 
            this.ResulTrian.AutoSize = true;
            this.ResulTrian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResulTrian.Location = new System.Drawing.Point(376, 238);
            this.ResulTrian.Name = "ResulTrian";
            this.ResulTrian.Size = new System.Drawing.Size(18, 20);
            this.ResulTrian.TabIndex = 12;
            this.ResulTrian.Text = "0";
            // 
            // AreaTria
            // 
            this.AreaTria.Location = new System.Drawing.Point(334, 273);
            this.AreaTria.Name = "AreaTria";
            this.AreaTria.Size = new System.Drawing.Size(110, 23);
            this.AreaTria.TabIndex = 13;
            this.AreaTria.Text = "Area";
            this.AreaTria.UseVisualStyleBackColor = true;
            this.AreaTria.Click += new System.EventHandler(this.AreaTria_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(623, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Radio";
            // 
            // Radio
            // 
            this.Radio.Location = new System.Drawing.Point(665, 165);
            this.Radio.Name = "Radio";
            this.Radio.Size = new System.Drawing.Size(67, 20);
            this.Radio.TabIndex = 15;
            // 
            // ResulCir
            // 
            this.ResulCir.AutoSize = true;
            this.ResulCir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResulCir.Location = new System.Drawing.Point(673, 238);
            this.ResulCir.Name = "ResulCir";
            this.ResulCir.Size = new System.Drawing.Size(18, 20);
            this.ResulCir.TabIndex = 16;
            this.ResulCir.Text = "0";
            // 
            // AreaCir
            // 
            this.AreaCir.Location = new System.Drawing.Point(626, 273);
            this.AreaCir.Name = "AreaCir";
            this.AreaCir.Size = new System.Drawing.Size(110, 23);
            this.AreaCir.TabIndex = 17;
            this.AreaCir.Text = "Area";
            this.AreaCir.UseVisualStyleBackColor = true;
            this.AreaCir.Click += new System.EventHandler(this.AreaCir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AreaCir);
            this.Controls.Add(this.ResulCir);
            this.Controls.Add(this.Radio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AreaTria);
            this.Controls.Add(this.ResulTrian);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.bases);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ResulCuadra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AreaCuadra);
            this.Controls.Add(this.lados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lados;
        private System.Windows.Forms.Button AreaCuadra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ResulCuadra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox bases;
        private System.Windows.Forms.TextBox altura;
        private System.Windows.Forms.Label ResulTrian;
        private System.Windows.Forms.Button AreaTria;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Radio;
        private System.Windows.Forms.Label ResulCir;
        private System.Windows.Forms.Button AreaCir;
    }
}

