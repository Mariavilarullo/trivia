namespace JuegoTrivia
{
    partial class MenuInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInicial));
            this.Jugar = new System.Windows.Forms.Button();
            this.Highscores = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Jugar
            // 
            this.Jugar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Jugar.Font = new System.Drawing.Font("HelvLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jugar.Location = new System.Drawing.Point(171, 209);
            this.Jugar.Name = "Jugar";
            this.Jugar.Size = new System.Drawing.Size(238, 68);
            this.Jugar.TabIndex = 0;
            this.Jugar.Text = "Nuevo juego";
            this.Jugar.UseVisualStyleBackColor = true;
            this.Jugar.Click += new System.EventHandler(this.Jugar_Click);
            // 
            // Highscores
            // 
            this.Highscores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Highscores.Font = new System.Drawing.Font("HelvLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Highscores.Location = new System.Drawing.Point(171, 297);
            this.Highscores.Name = "Highscores";
            this.Highscores.Size = new System.Drawing.Size(238, 68);
            this.Highscores.TabIndex = 1;
            this.Highscores.Text = "Highscores";
            this.Highscores.UseVisualStyleBackColor = true;
            this.Highscores.Click += new System.EventHandler(this.Highscores_Click);
            // 
            // Salir
            // 
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Salir.Font = new System.Drawing.Font("HelvLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Location = new System.Drawing.Point(385, 423);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(191, 68);
            this.Salir.TabIndex = 2;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("The Led Display St", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(44, 25);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(503, 155);
            this.Titulo.TabIndex = 3;
            this.Titulo.Text = "Trivia";
            // 
            // MenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(588, 503);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Highscores);
            this.Controls.Add(this.Jugar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trivia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuInicial_FormClosing);
            this.Load += new System.EventHandler(this.MenuInicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Jugar;
        private System.Windows.Forms.Button Highscores;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Label Titulo;
    }
}

