namespace JuegoTrivia
{
    partial class Highscores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Highscores));
            this.listView1 = new System.Windows.Forms.ListView();
            this.Volver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listView1.Font = new System.Drawing.Font("HelvLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(29, 87);
            this.listView1.MinimumSize = new System.Drawing.Size(20, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(534, 321);
            this.listView1.TabIndex = 0;
            this.listView1.TileSize = new System.Drawing.Size(20, 20);
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Volver
            // 
            this.Volver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Volver.Font = new System.Drawing.Font("HelvLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volver.Location = new System.Drawing.Point(199, 431);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(189, 47);
            this.Volver.TabIndex = 1;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("The Led Display St", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "HIGHSCORES";
            // 
            // Highscores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(588, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Highscores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Highscores";
            this.Load += new System.EventHandler(this.Highscores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Label label1;

    }
}