namespace form_menuprincipal
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lb_data_hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formuláriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataEHoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxRadioButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.máscarasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_data_hora
            // 
            this.lb_data_hora.AutoSize = true;
            this.lb_data_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data_hora.Location = new System.Drawing.Point(26, 324);
            this.lb_data_hora.Name = "lb_data_hora";
            this.lb_data_hora.Size = new System.Drawing.Size(0, 29);
            this.lb_data_hora.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "chama form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formuláriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(615, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formuláriosToolStripMenuItem
            // 
            this.formuláriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataEHoraToolStripMenuItem,
            this.checkBoxRadioButtonToolStripMenuItem,
            this.máscarasToolStripMenuItem,
            this.stringsToolStripMenuItem});
            this.formuláriosToolStripMenuItem.Name = "formuláriosToolStripMenuItem";
            this.formuláriosToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.formuláriosToolStripMenuItem.Text = "Formulários";
            // 
            // dataEHoraToolStripMenuItem
            // 
            this.dataEHoraToolStripMenuItem.Name = "dataEHoraToolStripMenuItem";
            this.dataEHoraToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.dataEHoraToolStripMenuItem.Text = "Data e Hora";
            this.dataEHoraToolStripMenuItem.Click += new System.EventHandler(this.dataEHoraToolStripMenuItem_Click);
            // 
            // checkBoxRadioButtonToolStripMenuItem
            // 
            this.checkBoxRadioButtonToolStripMenuItem.Name = "checkBoxRadioButtonToolStripMenuItem";
            this.checkBoxRadioButtonToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.checkBoxRadioButtonToolStripMenuItem.Text = "CheckBox RadioButton";
            this.checkBoxRadioButtonToolStripMenuItem.Click += new System.EventHandler(this.checkBoxRadioButtonToolStripMenuItem_Click);
            // 
            // máscarasToolStripMenuItem
            // 
            this.máscarasToolStripMenuItem.Name = "máscarasToolStripMenuItem";
            this.máscarasToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.máscarasToolStripMenuItem.Text = "Máscaras";
            this.máscarasToolStripMenuItem.Click += new System.EventHandler(this.máscarasToolStripMenuItem_Click);
            // 
            // stringsToolStripMenuItem
            // 
            this.stringsToolStripMenuItem.Name = "stringsToolStripMenuItem";
            this.stringsToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.stringsToolStripMenuItem.Text = "Strings";
            this.stringsToolStripMenuItem.Click += new System.EventHandler(this.stringsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 369);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_data_hora);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_data_hora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formuláriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataEHoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBoxRadioButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem máscarasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stringsToolStripMenuItem;
    }
}

