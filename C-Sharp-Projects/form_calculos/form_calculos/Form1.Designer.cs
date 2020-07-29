namespace form_calculos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_soma = new System.Windows.Forms.Button();
            this.bt_sub = new System.Windows.Forms.Button();
            this.bt_div = new System.Windows.Forms.Button();
            this.bt_mult = new System.Windows.Forms.Button();
            this.bt_restodivisao = new System.Windows.Forms.Button();
            this.tb_v1 = new System.Windows.Forms.TextBox();
            this.tb_v2 = new System.Windows.Forms.TextBox();
            this.tb_resultado = new System.Windows.Forms.TextBox();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cálculos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor 2: ";
            // 
            // bt_soma
            // 
            this.bt_soma.Location = new System.Drawing.Point(38, 196);
            this.bt_soma.Name = "bt_soma";
            this.bt_soma.Size = new System.Drawing.Size(50, 23);
            this.bt_soma.TabIndex = 3;
            this.bt_soma.Text = "+";
            this.bt_soma.UseVisualStyleBackColor = true;
            this.bt_soma.Click += new System.EventHandler(this.bt_soma_Click);
            // 
            // bt_sub
            // 
            this.bt_sub.Location = new System.Drawing.Point(108, 195);
            this.bt_sub.Name = "bt_sub";
            this.bt_sub.Size = new System.Drawing.Size(52, 23);
            this.bt_sub.TabIndex = 4;
            this.bt_sub.Text = "-";
            this.bt_sub.UseVisualStyleBackColor = true;
            this.bt_sub.Click += new System.EventHandler(this.bt_sub_Click);
            // 
            // bt_div
            // 
            this.bt_div.Location = new System.Drawing.Point(179, 196);
            this.bt_div.Name = "bt_div";
            this.bt_div.Size = new System.Drawing.Size(50, 23);
            this.bt_div.TabIndex = 5;
            this.bt_div.Text = "/";
            this.bt_div.UseVisualStyleBackColor = true;
            this.bt_div.Click += new System.EventHandler(this.bt_div_Click);
            // 
            // bt_mult
            // 
            this.bt_mult.Location = new System.Drawing.Point(253, 196);
            this.bt_mult.Name = "bt_mult";
            this.bt_mult.Size = new System.Drawing.Size(46, 23);
            this.bt_mult.TabIndex = 6;
            this.bt_mult.Text = "*";
            this.bt_mult.UseVisualStyleBackColor = true;
            this.bt_mult.Click += new System.EventHandler(this.bt_mult_Click);
            // 
            // bt_restodivisao
            // 
            this.bt_restodivisao.Location = new System.Drawing.Point(319, 196);
            this.bt_restodivisao.Name = "bt_restodivisao";
            this.bt_restodivisao.Size = new System.Drawing.Size(136, 23);
            this.bt_restodivisao.TabIndex = 7;
            this.bt_restodivisao.Text = "Resto da Divisão";
            this.bt_restodivisao.UseVisualStyleBackColor = true;
            this.bt_restodivisao.Click += new System.EventHandler(this.bt_restodivisao_Click);
            // 
            // tb_v1
            // 
            this.tb_v1.Location = new System.Drawing.Point(135, 97);
            this.tb_v1.Name = "tb_v1";
            this.tb_v1.Size = new System.Drawing.Size(100, 22);
            this.tb_v1.TabIndex = 8;
            // 
            // tb_v2
            // 
            this.tb_v2.Location = new System.Drawing.Point(143, 143);
            this.tb_v2.Name = "tb_v2";
            this.tb_v2.Size = new System.Drawing.Size(100, 22);
            this.tb_v2.TabIndex = 9;
            // 
            // tb_resultado
            // 
            this.tb_resultado.Location = new System.Drawing.Point(135, 305);
            this.tb_resultado.Name = "tb_resultado";
            this.tb_resultado.Size = new System.Drawing.Size(100, 22);
            this.tb_resultado.TabIndex = 10;
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Location = new System.Drawing.Point(58, 305);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(76, 17);
            this.lb_resultado.TabIndex = 11;
            this.lb_resultado.Text = "Resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 401);
            this.Controls.Add(this.lb_resultado);
            this.Controls.Add(this.tb_resultado);
            this.Controls.Add(this.tb_v2);
            this.Controls.Add(this.tb_v1);
            this.Controls.Add(this.bt_restodivisao);
            this.Controls.Add(this.bt_mult);
            this.Controls.Add(this.bt_div);
            this.Controls.Add(this.bt_sub);
            this.Controls.Add(this.bt_soma);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_soma;
        private System.Windows.Forms.Button bt_sub;
        private System.Windows.Forms.Button bt_div;
        private System.Windows.Forms.Button bt_mult;
        private System.Windows.Forms.Button bt_restodivisao;
        private System.Windows.Forms.TextBox tb_v1;
        private System.Windows.Forms.TextBox tb_v2;
        private System.Windows.Forms.TextBox tb_resultado;
        private System.Windows.Forms.Label lb_resultado;
    }
}

