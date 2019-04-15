namespace JuegoTrivia
{
    partial class Juego
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego));
            this.nombre = new System.Windows.Forms.Label();
            this.vidas = new System.Windows.Forms.Label();
            this.puntaje = new System.Windows.Forms.Label();
            this.reloj = new System.Windows.Forms.Label();
            this.pregunta = new System.Windows.Forms.Label();
            this.respuesta1 = new System.Windows.Forms.Label();
            this.respuesta2 = new System.Windows.Forms.Label();
            this.respuesta3 = new System.Windows.Forms.Label();
            this.respuesta4 = new System.Windows.Forms.Label();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("HelvLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(12, 8);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(111, 32);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "Nombre";
            // 
            // vidas
            // 
            this.vidas.AutoSize = true;
            this.vidas.Font = new System.Drawing.Font("HelvLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vidas.Location = new System.Drawing.Point(232, 8);
            this.vidas.Name = "vidas";
            this.vidas.Size = new System.Drawing.Size(81, 32);
            this.vidas.TabIndex = 1;
            this.vidas.Text = "Vidas";
            // 
            // puntaje
            // 
            this.puntaje.AutoSize = true;
            this.puntaje.Font = new System.Drawing.Font("HelvLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntaje.Location = new System.Drawing.Point(435, 8);
            this.puntaje.Name = "puntaje";
            this.puntaje.Size = new System.Drawing.Size(105, 32);
            this.puntaje.TabIndex = 2;
            this.puntaje.Text = "Puntaje";
            // 
            // reloj
            // 
            this.reloj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reloj.Font = new System.Drawing.Font("HelvLight", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloj.Location = new System.Drawing.Point(590, 9);
            this.reloj.Name = "reloj";
            this.reloj.Size = new System.Drawing.Size(92, 67);
            this.reloj.TabIndex = 3;
            this.reloj.Text = "30";
            this.reloj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pregunta
            // 
            this.pregunta.Font = new System.Drawing.Font("HelvLight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pregunta.Location = new System.Drawing.Point(17, 97);
            this.pregunta.Name = "pregunta";
            this.pregunta.Size = new System.Drawing.Size(665, 164);
            this.pregunta.TabIndex = 4;
            this.pregunta.Text = "label1";
            this.pregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // respuesta1
            // 
            this.respuesta1.Font = new System.Drawing.Font("HelvLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respuesta1.Location = new System.Drawing.Point(182, 261);
            this.respuesta1.Name = "respuesta1";
            this.respuesta1.Size = new System.Drawing.Size(500, 78);
            this.respuesta1.TabIndex = 5;
            this.respuesta1.Text = "label1";
            this.respuesta1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // respuesta2
            // 
            this.respuesta2.Font = new System.Drawing.Font("HelvLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respuesta2.Location = new System.Drawing.Point(182, 341);
            this.respuesta2.Name = "respuesta2";
            this.respuesta2.Size = new System.Drawing.Size(500, 78);
            this.respuesta2.TabIndex = 6;
            this.respuesta2.Text = "label2";
            this.respuesta2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // respuesta3
            // 
            this.respuesta3.Font = new System.Drawing.Font("HelvLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respuesta3.Location = new System.Drawing.Point(182, 421);
            this.respuesta3.Name = "respuesta3";
            this.respuesta3.Size = new System.Drawing.Size(500, 78);
            this.respuesta3.TabIndex = 7;
            this.respuesta3.Text = "label3";
            this.respuesta3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // respuesta4
            // 
            this.respuesta4.Font = new System.Drawing.Font("HelvLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respuesta4.Location = new System.Drawing.Point(182, 501);
            this.respuesta4.Name = "respuesta4";
            this.respuesta4.Size = new System.Drawing.Size(500, 78);
            this.respuesta4.TabIndex = 8;
            this.respuesta4.Text = "label5";
            this.respuesta4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // b2
            // 
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b2.Font = new System.Drawing.Font("HelvLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(115, 359);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(48, 42);
            this.b2.TabIndex = 10;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b1
            // 
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b1.Font = new System.Drawing.Font("HelvLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(115, 279);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(48, 42);
            this.b1.TabIndex = 11;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b3
            // 
            this.b3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b3.Font = new System.Drawing.Font("HelvLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(115, 439);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(48, 42);
            this.b3.TabIndex = 12;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b4
            // 
            this.b4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b4.Font = new System.Drawing.Font("HelvLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(115, 519);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(48, 42);
            this.b4.TabIndex = 13;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HelvLight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HelvLight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HelvLight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(694, 618);
            this.shapeContainer1.TabIndex = 17;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 708;
            this.lineShape1.Y1 = 86;
            this.lineShape1.Y2 = 86;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(694, 618);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.respuesta4);
            this.Controls.Add(this.respuesta3);
            this.Controls.Add(this.respuesta2);
            this.Controls.Add(this.respuesta1);
            this.Controls.Add(this.pregunta);
            this.Controls.Add(this.reloj);
            this.Controls.Add(this.puntaje);
            this.Controls.Add(this.vidas);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Juego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Juego_FormClosing);
            this.Load += new System.EventHandler(this.Juego_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label vidas;
        private System.Windows.Forms.Label puntaje;
        private System.Windows.Forms.Label reloj;
        private System.Windows.Forms.Label pregunta;
        private System.Windows.Forms.Label respuesta1;
        private System.Windows.Forms.Label respuesta2;
        private System.Windows.Forms.Label respuesta3;
        private System.Windows.Forms.Label respuesta4;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Timer timer1;
    }
}