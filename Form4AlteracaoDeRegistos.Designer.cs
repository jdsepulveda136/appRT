namespace appRT
{
    partial class Form4AlteracaoDeRegistos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_search_cli = new System.Windows.Forms.TextBox();
            this.txt_search_func = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_clientes = new System.Windows.Forms.Label();
            this.lbl_func = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes (digitar todo ou parte)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Funcionários (digitar todo ou parte)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(567, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ano (YYYY)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(571, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mês (MM)";
            // 
            // txt_search_cli
            // 
            this.txt_search_cli.Location = new System.Drawing.Point(21, 37);
            this.txt_search_cli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_search_cli.Name = "txt_search_cli";
            this.txt_search_cli.Size = new System.Drawing.Size(199, 22);
            this.txt_search_cli.TabIndex = 4;
            this.txt_search_cli.TextChanged += new System.EventHandler(this.Txt_search_cli_TextChanged);
            // 
            // txt_search_func
            // 
            this.txt_search_func.Location = new System.Drawing.Point(268, 36);
            this.txt_search_func.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_search_func.Name = "txt_search_func";
            this.txt_search_func.Size = new System.Drawing.Size(199, 22);
            this.txt_search_func.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(571, 36);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 6;
            // 
            // lbl_clientes
            // 
            this.lbl_clientes.AutoSize = true;
            this.lbl_clientes.Location = new System.Drawing.Point(21, 67);
            this.lbl_clientes.Name = "lbl_clientes";
            this.lbl_clientes.Size = new System.Drawing.Size(16, 17);
            this.lbl_clientes.TabIndex = 7;
            this.lbl_clientes.Text = "_";
            // 
            // lbl_func
            // 
            this.lbl_func.AutoSize = true;
            this.lbl_func.Location = new System.Drawing.Point(264, 67);
            this.lbl_func.Name = "lbl_func";
            this.lbl_func.Size = new System.Drawing.Size(16, 17);
            this.lbl_func.TabIndex = 8;
            this.lbl_func.Text = "_";
            // 
            // Form4AlteracaoDeRegistos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lbl_func);
            this.Controls.Add(this.lbl_clientes);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_search_func);
            this.Controls.Add(this.txt_search_cli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form4AlteracaoDeRegistos";
            this.Text = "Form4AlteracaoDeRegistos";
            this.Load += new System.EventHandler(this.Form4AlteracaoDeRegistos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_search_cli;
        private System.Windows.Forms.TextBox txt_search_func;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_clientes;
        private System.Windows.Forms.Label lbl_func;
    }
}