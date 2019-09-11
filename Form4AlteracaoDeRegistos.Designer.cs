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
            this.lbox_clientes = new System.Windows.Forms.ListBox();
            this.lbox_func = new System.Windows.Forms.ListBox();
            this.data_registos = new System.Windows.Forms.DataGridView();
            this.bt_remove = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.txt_ano = new System.Windows.Forms.TextBox();
            this.txt_mes = new System.Windows.Forms.TextBox();
            this.lista_meses = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.data_registos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes (digitar todo ou parte)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Funcionários (digitar todo ou parte)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ano (YYYY)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mês (MM)";
            // 
            // txt_search_cli
            // 
            this.txt_search_cli.Location = new System.Drawing.Point(16, 30);
            this.txt_search_cli.Name = "txt_search_cli";
            this.txt_search_cli.Size = new System.Drawing.Size(150, 20);
            this.txt_search_cli.TabIndex = 4;
            this.txt_search_cli.TextChanged += new System.EventHandler(this.Txt_search_cli_TextChanged);
            // 
            // txt_search_func
            // 
            this.txt_search_func.Location = new System.Drawing.Point(201, 29);
            this.txt_search_func.Name = "txt_search_func";
            this.txt_search_func.Size = new System.Drawing.Size(150, 20);
            this.txt_search_func.TabIndex = 5;
            this.txt_search_func.TextChanged += new System.EventHandler(this.Txt_search_func_TextChanged);
            // 
            // lbox_clientes
            // 
            this.lbox_clientes.FormattingEnabled = true;
            this.lbox_clientes.Location = new System.Drawing.Point(16, 59);
            this.lbox_clientes.Name = "lbox_clientes";
            this.lbox_clientes.Size = new System.Drawing.Size(150, 95);
            this.lbox_clientes.TabIndex = 7;
            this.lbox_clientes.SelectedIndexChanged += new System.EventHandler(this.Lbox_clientes_SelectedIndexChanged);
            // 
            // lbox_func
            // 
            this.lbox_func.FormattingEnabled = true;
            this.lbox_func.Location = new System.Drawing.Point(201, 59);
            this.lbox_func.Name = "lbox_func";
            this.lbox_func.Size = new System.Drawing.Size(150, 95);
            this.lbox_func.TabIndex = 8;
            this.lbox_func.SelectedIndexChanged += new System.EventHandler(this.Lbox_func_SelectedIndexChanged);
            // 
            // data_registos
            // 
            this.data_registos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_registos.Location = new System.Drawing.Point(16, 175);
            this.data_registos.Name = "data_registos";
            this.data_registos.Size = new System.Drawing.Size(772, 263);
            this.data_registos.TabIndex = 9;
            // 
            // bt_remove
            // 
            this.bt_remove.Location = new System.Drawing.Point(16, 458);
            this.bt_remove.Name = "bt_remove";
            this.bt_remove.Size = new System.Drawing.Size(194, 23);
            this.bt_remove.TabIndex = 10;
            this.bt_remove.Text = "Remover Registo";
            this.bt_remove.UseVisualStyleBackColor = true;
            this.bt_remove.Click += new System.EventHandler(this.Bt_remove_Click);
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(16, 487);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(194, 23);
            this.bt_update.TabIndex = 11;
            this.bt_update.Text = "Actualizar registo na Base de dados";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.Bt_update_Click);
            // 
            // bt_sair
            // 
            this.bt_sair.Location = new System.Drawing.Point(712, 527);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(75, 23);
            this.bt_sair.TabIndex = 12;
            this.bt_sair.Text = "Fechar";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.Bt_sair_Click);
            // 
            // txt_ano
            // 
            this.txt_ano.Location = new System.Drawing.Point(428, 30);
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(100, 20);
            this.txt_ano.TabIndex = 13;
            // 
            // txt_mes
            // 
            this.txt_mes.Location = new System.Drawing.Point(431, 76);
            this.txt_mes.Name = "txt_mes";
            this.txt_mes.Size = new System.Drawing.Size(100, 20);
            this.txt_mes.TabIndex = 14;
            // 
            // lista_meses
            // 
            this.lista_meses.Location = new System.Drawing.Point(566, 30);
            this.lista_meses.Name = "lista_meses";
            this.lista_meses.Size = new System.Drawing.Size(48, 124);
            this.lista_meses.TabIndex = 15;
            this.lista_meses.UseCompatibleStateImageBehavior = false;
            this.lista_meses.View = System.Windows.Forms.View.List;
            // 
            // Form4AlteracaoDeRegistos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.lista_meses);
            this.Controls.Add(this.txt_mes);
            this.Controls.Add(this.txt_ano);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_remove);
            this.Controls.Add(this.data_registos);
            this.Controls.Add(this.lbox_func);
            this.Controls.Add(this.lbox_clientes);
            this.Controls.Add(this.txt_search_func);
            this.Controls.Add(this.txt_search_cli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4AlteracaoDeRegistos";
            this.Text = "Form4AlteracaoDeRegistos";
            this.Load += new System.EventHandler(this.Form4AlteracaoDeRegistos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_registos)).EndInit();
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
        private System.Windows.Forms.ListBox lbox_clientes;
        private System.Windows.Forms.ListBox lbox_func;
        private System.Windows.Forms.DataGridView data_registos;
        private System.Windows.Forms.Button bt_remove;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.TextBox txt_ano;
        private System.Windows.Forms.TextBox txt_mes;
        private System.Windows.Forms.ListView lista_meses;
    }
}