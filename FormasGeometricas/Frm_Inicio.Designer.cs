
namespace FormasGeometricas
{
    partial class Frm_Inicio
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
            this.cmd_Resultados = new System.Windows.Forms.Button();
            this.cmd_Iniciar = new System.Windows.Forms.Button();
            this.cmd_Creditos = new System.Windows.Forms.Button();
            this.cmd_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_Resultados
            // 
            this.cmd_Resultados.BackColor = System.Drawing.Color.Blue;
            this.cmd_Resultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Resultados.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_Resultados.ForeColor = System.Drawing.Color.Transparent;
            this.cmd_Resultados.Location = new System.Drawing.Point(445, 619);
            this.cmd_Resultados.Name = "cmd_Resultados";
            this.cmd_Resultados.Size = new System.Drawing.Size(169, 58);
            this.cmd_Resultados.TabIndex = 3;
            this.cmd_Resultados.Text = "Resultados";
            this.cmd_Resultados.UseVisualStyleBackColor = false;
            this.cmd_Resultados.Click += new System.EventHandler(this.cmd_Resultados_Click);
            // 
            // cmd_Iniciar
            // 
            this.cmd_Iniciar.BackColor = System.Drawing.Color.Green;
            this.cmd_Iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Iniciar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_Iniciar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmd_Iniciar.Location = new System.Drawing.Point(627, 543);
            this.cmd_Iniciar.Name = "cmd_Iniciar";
            this.cmd_Iniciar.Size = new System.Drawing.Size(169, 58);
            this.cmd_Iniciar.TabIndex = 2;
            this.cmd_Iniciar.Text = "Iniciar";
            this.cmd_Iniciar.UseVisualStyleBackColor = false;
            this.cmd_Iniciar.Click += new System.EventHandler(this.cmd_Iniciar_Click);
            // 
            // cmd_Creditos
            // 
            this.cmd_Creditos.BackColor = System.Drawing.Color.Yellow;
            this.cmd_Creditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Creditos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_Creditos.ForeColor = System.Drawing.Color.White;
            this.cmd_Creditos.Location = new System.Drawing.Point(812, 619);
            this.cmd_Creditos.Name = "cmd_Creditos";
            this.cmd_Creditos.Size = new System.Drawing.Size(169, 58);
            this.cmd_Creditos.TabIndex = 4;
            this.cmd_Creditos.Text = "Créditos";
            this.cmd_Creditos.UseVisualStyleBackColor = false;
            this.cmd_Creditos.Click += new System.EventHandler(this.cmd_Creditos_Click);
            // 
            // cmd_Sair
            // 
            this.cmd_Sair.BackColor = System.Drawing.Color.Red;
            this.cmd_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Sair.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_Sair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmd_Sair.Location = new System.Drawing.Point(627, 696);
            this.cmd_Sair.Name = "cmd_Sair";
            this.cmd_Sair.Size = new System.Drawing.Size(169, 58);
            this.cmd_Sair.TabIndex = 5;
            this.cmd_Sair.Text = "Sair";
            this.cmd_Sair.UseVisualStyleBackColor = false;
            this.cmd_Sair.Click += new System.EventHandler(this.cmd_Sair_Click);
            // 
            // Frm_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::FormasGeometricas.Properties.Resources.Inicio;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.cmd_Sair);
            this.Controls.Add(this.cmd_Creditos);
            this.Controls.Add(this.cmd_Resultados);
            this.Controls.Add(this.cmd_Iniciar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Inicio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_Resultados;
        private System.Windows.Forms.Button cmd_Iniciar;
        private System.Windows.Forms.Button cmd_Creditos;
        private System.Windows.Forms.Button cmd_Sair;
    }
}