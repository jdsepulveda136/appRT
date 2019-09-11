namespace appRT
{
    partial class Form1
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
            this.bt_sair = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listagensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.data_tempos = new System.Windows.Forms.DataGridView();
            this.cmb_clientes = new System.Windows.Forms.ComboBox();
            this.txt_filtrar_clientes = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.cmb_funcionarios = new System.Windows.Forms.ComboBox();
            this.txt_funcionarios = new System.Windows.Forms.TextBox();
            this.txt_total_minutos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_tot_min_mensal = new System.Windows.Forms.Button();
            this.txt_min_mensal = new System.Windows.Forms.TextBox();
            this.data_stats = new System.Windows.Forms.DataGridView();
            this.estatistica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_stats = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pick_data = new System.Windows.Forms.DateTimePicker();
            this.Duração = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_inserir = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.updown_duracao = new System.Windows.Forms.NumericUpDown();
            this.list_clientes = new System.Windows.Forms.ListBox();
            this.list_funcionarios = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.adicionarAlterarRegistosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_tempos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_stats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updown_duracao)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_sair
            // 
            this.bt_sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_sair.Location = new System.Drawing.Point(892, 511);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(75, 23);
            this.bt_sair.TabIndex = 4;
            this.bt_sair.Text = "Sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.Bt_sair_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listagensToolStripMenuItem,
            this.estatisticasToolStripMenuItem,
            this.adicionarAlterarRegistosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(979, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // listagensToolStripMenuItem
            // 
            this.listagensToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.funcionáriosToolStripMenuItem});
            this.listagensToolStripMenuItem.Name = "listagensToolStripMenuItem";
            this.listagensToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.listagensToolStripMenuItem.Text = "Listagens";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.ClientesToolStripMenuItem_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.FuncionáriosToolStripMenuItem_Click);
            // 
            // estatisticasToolStripMenuItem
            // 
            this.estatisticasToolStripMenuItem.Name = "estatisticasToolStripMenuItem";
            this.estatisticasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.estatisticasToolStripMenuItem.Text = "Estatisticas";
            this.estatisticasToolStripMenuItem.Click += new System.EventHandler(this.EstatisticasToolStripMenuItem_Click);
            // 
            // data_tempos
            // 
            this.data_tempos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.data_tempos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_tempos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_tempos.Location = new System.Drawing.Point(133, 92);
            this.data_tempos.Name = "data_tempos";
            this.data_tempos.RowHeadersVisible = false;
            this.data_tempos.RowHeadersWidth = 51;
            this.data_tempos.Size = new System.Drawing.Size(497, 265);
            this.data_tempos.TabIndex = 6;
            // 
            // cmb_clientes
            // 
            this.cmb_clientes.FormattingEnabled = true;
            this.cmb_clientes.Location = new System.Drawing.Point(178, 64);
            this.cmb_clientes.Name = "cmb_clientes";
            this.cmb_clientes.Size = new System.Drawing.Size(121, 21);
            this.cmb_clientes.TabIndex = 7;
            this.cmb_clientes.SelectedIndexChanged += new System.EventHandler(this.Cmb_clientes_SelectedIndexChanged);
            // 
            // txt_filtrar_clientes
            // 
            this.txt_filtrar_clientes.Location = new System.Drawing.Point(178, 38);
            this.txt_filtrar_clientes.Name = "txt_filtrar_clientes";
            this.txt_filtrar_clientes.Size = new System.Drawing.Size(121, 20);
            this.txt_filtrar_clientes.TabIndex = 1;
            this.txt_filtrar_clientes.TextChanged += new System.EventHandler(this.Txt_filtrar_clientes_TextChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(234, 77);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 9;
            // 
            // cmb_funcionarios
            // 
            this.cmb_funcionarios.FormattingEnabled = true;
            this.cmb_funcionarios.Location = new System.Drawing.Point(432, 64);
            this.cmb_funcionarios.Name = "cmb_funcionarios";
            this.cmb_funcionarios.Size = new System.Drawing.Size(121, 21);
            this.cmb_funcionarios.TabIndex = 10;
            this.cmb_funcionarios.SelectedIndexChanged += new System.EventHandler(this.Cmb_funcionarios_SelectedIndexChanged);
            // 
            // txt_funcionarios
            // 
            this.txt_funcionarios.Location = new System.Drawing.Point(432, 38);
            this.txt_funcionarios.Name = "txt_funcionarios";
            this.txt_funcionarios.Size = new System.Drawing.Size(121, 20);
            this.txt_funcionarios.TabIndex = 2;
            this.txt_funcionarios.TextChanged += new System.EventHandler(this.Txt_funcionarios_TextChanged_1);
            // 
            // txt_total_minutos
            // 
            this.txt_total_minutos.Location = new System.Drawing.Point(133, 363);
            this.txt_total_minutos.Name = "txt_total_minutos";
            this.txt_total_minutos.Size = new System.Drawing.Size(100, 20);
            this.txt_total_minutos.TabIndex = 13;
            this.txt_total_minutos.TextChanged += new System.EventHandler(this.Txt_total_minutos_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Total de minutos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bt_tot_min_mensal
            // 
            this.bt_tot_min_mensal.Location = new System.Drawing.Point(251, 363);
            this.bt_tot_min_mensal.Name = "bt_tot_min_mensal";
            this.bt_tot_min_mensal.Size = new System.Drawing.Size(134, 23);
            this.bt_tot_min_mensal.TabIndex = 15;
            this.bt_tot_min_mensal.Text = "Total de minutos mensal";
            this.bt_tot_min_mensal.UseVisualStyleBackColor = true;
            this.bt_tot_min_mensal.Click += new System.EventHandler(this.Bt_tot_min_mensal_Click);
            // 
            // txt_min_mensal
            // 
            this.txt_min_mensal.Location = new System.Drawing.Point(392, 363);
            this.txt_min_mensal.Name = "txt_min_mensal";
            this.txt_min_mensal.Size = new System.Drawing.Size(100, 20);
            this.txt_min_mensal.TabIndex = 16;
            // 
            // data_stats
            // 
            this.data_stats.AllowUserToAddRows = false;
            this.data_stats.AllowUserToDeleteRows = false;
            this.data_stats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_stats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_stats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.estatistica,
            this.valor});
            this.data_stats.Location = new System.Drawing.Point(770, 92);
            this.data_stats.Name = "data_stats";
            this.data_stats.ReadOnly = true;
            this.data_stats.RowHeadersVisible = false;
            this.data_stats.RowHeadersWidth = 51;
            this.data_stats.Size = new System.Drawing.Size(197, 265);
            this.data_stats.TabIndex = 17;
            this.data_stats.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_stats_CellContentClick);
            // 
            // estatistica
            // 
            this.estatistica.HeaderText = "Estatística";
            this.estatistica.MinimumWidth = 6;
            this.estatistica.Name = "estatistica";
            this.estatistica.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.MinimumWidth = 6;
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // bt_stats
            // 
            this.bt_stats.Location = new System.Drawing.Point(770, 60);
            this.bt_stats.Name = "bt_stats";
            this.bt_stats.Size = new System.Drawing.Size(197, 23);
            this.bt_stats.TabIndex = 18;
            this.bt_stats.Text = "Mostra Estatísticas";
            this.bt_stats.UseVisualStyleBackColor = true;
            this.bt_stats.Click += new System.EventHandler(this.Bt_stats_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Data";
            // 
            // pick_data
            // 
            this.pick_data.Location = new System.Drawing.Point(16, 448);
            this.pick_data.Name = "pick_data";
            this.pick_data.Size = new System.Drawing.Size(200, 20);
            this.pick_data.TabIndex = 3;
            // 
            // Duração
            // 
            this.Duração.AutoSize = true;
            this.Duração.Location = new System.Drawing.Point(222, 432);
            this.Duração.Name = "Duração";
            this.Duração.Size = new System.Drawing.Size(48, 13);
            this.Duração.TabIndex = 24;
            this.Duração.Text = "Duração";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(328, 449);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(433, 20);
            this.txt_descricao.TabIndex = 5;
            this.txt_descricao.TextChanged += new System.EventHandler(this.Txt_descricao_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Descrição";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // bt_inserir
            // 
            this.bt_inserir.Location = new System.Drawing.Point(770, 447);
            this.bt_inserir.Name = "bt_inserir";
            this.bt_inserir.Size = new System.Drawing.Size(96, 21);
            this.bt_inserir.TabIndex = 6;
            this.bt_inserir.Text = "Inserir";
            this.bt_inserir.UseVisualStyleBackColor = true;
            this.bt_inserir.Click += new System.EventHandler(this.Bt_inserir_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(664, 922);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 30;
            // 
            // updown_duracao
            // 
            this.updown_duracao.Location = new System.Drawing.Point(222, 449);
            this.updown_duracao.Name = "updown_duracao";
            this.updown_duracao.Size = new System.Drawing.Size(100, 20);
            this.updown_duracao.TabIndex = 4;
            // 
            // list_clientes
            // 
            this.list_clientes.FormattingEnabled = true;
            this.list_clientes.Location = new System.Drawing.Point(13, 92);
            this.list_clientes.Name = "list_clientes";
            this.list_clientes.Size = new System.Drawing.Size(114, 264);
            this.list_clientes.TabIndex = 32;
            // 
            // list_funcionarios
            // 
            this.list_funcionarios.FormattingEnabled = true;
            this.list_funcionarios.Location = new System.Drawing.Point(637, 92);
            this.list_funcionarios.Name = "list_funcionarios";
            this.list_funcionarios.Size = new System.Drawing.Size(120, 264);
            this.list_funcionarios.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Funcionário";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Inserção de registo";
            // 
            // adicionarAlterarRegistosToolStripMenuItem
            // 
            this.adicionarAlterarRegistosToolStripMenuItem.Name = "adicionarAlterarRegistosToolStripMenuItem";
            this.adicionarAlterarRegistosToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            this.adicionarAlterarRegistosToolStripMenuItem.Text = "Adicionar/Alterar Registos";
            this.adicionarAlterarRegistosToolStripMenuItem.Click += new System.EventHandler(this.AdicionarAlterarRegistosToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 546);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.list_funcionarios);
            this.Controls.Add(this.list_clientes);
            this.Controls.Add(this.updown_duracao);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.bt_inserir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.Duração);
            this.Controls.Add(this.pick_data);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_stats);
            this.Controls.Add(this.data_stats);
            this.Controls.Add(this.txt_min_mensal);
            this.Controls.Add(this.bt_tot_min_mensal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_total_minutos);
            this.Controls.Add(this.txt_funcionarios);
            this.Controls.Add(this.cmb_funcionarios);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.txt_filtrar_clientes);
            this.Controls.Add(this.cmb_clientes);
            this.Controls.Add(this.data_tempos);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "App Registos de Tempo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_tempos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_stats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updown_duracao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listagensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.DataGridView data_tempos;
        private System.Windows.Forms.ComboBox cmb_clientes;
        private System.Windows.Forms.TextBox txt_filtrar_clientes;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox cmb_funcionarios;
        private System.Windows.Forms.TextBox txt_funcionarios;
        private System.Windows.Forms.TextBox txt_total_minutos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_tot_min_mensal;
        private System.Windows.Forms.TextBox txt_min_mensal;
        private System.Windows.Forms.DataGridView data_stats;
        private System.Windows.Forms.Button bt_stats;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatistica;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker pick_data;
        private System.Windows.Forms.Label Duração;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_inserir;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown updown_duracao;
        private System.Windows.Forms.ListBox list_clientes;
        private System.Windows.Forms.ListBox list_funcionarios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem estatisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarAlterarRegistosToolStripMenuItem;
    }
}

