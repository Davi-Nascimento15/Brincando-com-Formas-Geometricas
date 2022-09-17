
namespace FormasGeometricas
{
    partial class Frm_Insere
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
            this.cmd_Iniciar = new System.Windows.Forms.Button();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.pb_AvatarMenina = new System.Windows.Forms.PictureBox();
            this.pb_AvatarMenino = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AvatarMenina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AvatarMenino)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_Iniciar
            // 
            this.cmd_Iniciar.BackColor = System.Drawing.Color.Red;
            this.cmd_Iniciar.Enabled = false;
            this.cmd_Iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Iniciar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_Iniciar.ForeColor = System.Drawing.Color.White;
            this.cmd_Iniciar.Location = new System.Drawing.Point(621, 591);
            this.cmd_Iniciar.Name = "cmd_Iniciar";
            this.cmd_Iniciar.Size = new System.Drawing.Size(180, 69);
            this.cmd_Iniciar.TabIndex = 7;
            this.cmd_Iniciar.Text = "Iniciar";
            this.cmd_Iniciar.UseVisualStyleBackColor = false;
            this.cmd_Iniciar.Click += new System.EventHandler(this.cmd_Iniciar_Click);
            // 
            // txt_Nome
            // 
            this.txt_Nome.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(520, 207);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(373, 41);
            this.txt_Nome.TabIndex = 10;
            this.txt_Nome.Text = "Player 1";
            this.txt_Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pb_AvatarMenina
            // 
            this.pb_AvatarMenina.BackColor = System.Drawing.Color.Transparent;
            this.pb_AvatarMenina.Image = global::FormasGeometricas.Properties.Resources.Avatar_Menina;
            this.pb_AvatarMenina.Location = new System.Drawing.Point(736, 380);
            this.pb_AvatarMenina.Name = "pb_AvatarMenina";
            this.pb_AvatarMenina.Size = new System.Drawing.Size(157, 132);
            this.pb_AvatarMenina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_AvatarMenina.TabIndex = 13;
            this.pb_AvatarMenina.TabStop = false;
            this.pb_AvatarMenina.Click += new System.EventHandler(this.pb_AvatarMenina_Click);
            // 
            // pb_AvatarMenino
            // 
            this.pb_AvatarMenino.BackColor = System.Drawing.Color.Transparent;
            this.pb_AvatarMenino.Image = global::FormasGeometricas.Properties.Resources.male_boy_person_people_avatar_icon_159358;
            this.pb_AvatarMenino.Location = new System.Drawing.Point(543, 380);
            this.pb_AvatarMenino.Name = "pb_AvatarMenino";
            this.pb_AvatarMenino.Size = new System.Drawing.Size(140, 132);
            this.pb_AvatarMenino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_AvatarMenino.TabIndex = 12;
            this.pb_AvatarMenino.TabStop = false;
            this.pb_AvatarMenino.Click += new System.EventHandler(this.pb_AvatarMenino_Click);
            // 
            // Frm_Insere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::FormasGeometricas.Properties.Resources.Untitled_Diagram;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.ControlBox = false;
            this.Controls.Add(this.pb_AvatarMenina);
            this.Controls.Add(this.pb_AvatarMenino);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.cmd_Iniciar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Insere";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pb_AvatarMenina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AvatarMenino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmd_Iniciar;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.PictureBox pb_AvatarMenino;
        private System.Windows.Forms.PictureBox pb_AvatarMenina;
    }
}