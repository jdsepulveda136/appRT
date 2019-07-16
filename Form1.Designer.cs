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
            this.bt_stats = new System.Windows.Forms.Button();
            this.estatistica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_tempos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_stats)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_sair
            // 
            this.bt_sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_sair.Location = new System.Drawing.Point(887, 503);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(75, 23);
            this.bt_sair.TabIndex = 4;
            this.bt_sair.Text = "Sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.Bt_sair_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listagensToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 24);
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
            // data_tempos
            // 
            this.data_tempos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_tempos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_tempos.Location = new System.Drawing.Point(13, 94);
            this.data_tempos.Name = "data_tempos";
            this.data_tempos.Size = new System.Drawing.Size(729, 265);
            this.data_tempos.TabIndex = 6;
            // 
            // cmb_clientes
            // 
            this.cmb_clientes.FormattingEnabled = true;
            this.cmb_clientes.Location = new System.Drawing.Point(13, 62);
            this.cmb_clientes.Name = "cmb_clientes";
            this.cmb_clientes.Size = new System.Drawing.Size(121, 21);
            this.cmb_clientes.TabIndex = 7;
            this.cmb_clientes.SelectedIndexChanged += new System.EventHandler(this.Cmb_clientes_SelectedIndexChanged);
            // 
            // txt_filtrar_clientes
            // 
            this.txt_filtrar_clientes.Location = new System.Drawing.Point(13, 36);
            this.txt_filtrar_clientes.Name = "txt_filtrar_clientes";
            this.txt_filtrar_clientes.Size = new System.Drawing.Size(121, 20);
            this.txt_filtrar_clientes.TabIndex = 8;
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
            this.cmb_funcionarios.Location = new System.Drawing.Point(197, 62);
            this.cmb_funcionarios.Name = "cmb_funcionarios";
            this.cmb_funcionarios.Size = new System.Drawing.Size(121, 21);
            this.cmb_funcionarios.TabIndex = 10;
            this.cmb_funcionarios.SelectedIndexChanged += new System.EventHandler(this.Cmb_funcionarios_SelectedIndexChanged);
            // 
            // txt_funcionarios
            // 
            this.txt_funcionarios.Location = new System.Drawing.Point(197, 36);
            this.txt_funcionarios.Name = "txt_funcionarios";
            this.txt_funcionarios.Size = new System.Drawing.Size(121, 20);
            this.txt_funcionarios.TabIndex = 0;
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
            this.bt_tot_min_mensal.Location = new System.Drawing.Point(16, 393);
            this.bt_tot_min_mensal.Name = "bt_tot_min_mensal";
            this.bt_tot_min_mensal.Size = new System.Drawing.Size(134, 23);
            this.bt_tot_min_mensal.TabIndex = 15;
            this.bt_tot_min_mensal.Text = "Total de minutos mensal";
            this.bt_tot_min_mensal.UseVisualStyleBackColor = true;
            this.bt_tot_min_mensal.Click += new System.EventHandler(this.Bt_tot_min_mensal_Click);
            // 
            // txt_min_mensal
            // 
            this.txt_min_mensal.Location = new System.Drawing.Point(157, 393);
            this.txt_min_mensal.Name = "txt_min_mensal";
            this.txt_min_mensal.Size = new System.Drawing.Size(100, 20);
            this.txt_min_mensal.TabIndex = 16;
            // 
            // data_stats
            // 
            this.data_stats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_stats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.estatistica,
            this.valor});
            this.data_stats.Location = new System.Drawing.Point(765, 94);
            this.data_stats.Name = "data_stats";
            this.data_stats.Size = new System.Drawing.Size(197, 265);
            this.data_stats.TabIndex = 17;
            // 
            // bt_stats
            // 
            this.bt_stats.Location = new System.Drawing.Point(765, 65);
            this.bt_stats.Name = "bt_stats";
            this.bt_stats.Size = new System.Drawing.Size(197, 23);
            this.bt_stats.TabIndex = 18;
            this.bt_stats.Text = "Mostra Estatísticas";
            this.bt_stats.UseVisualStyleBackColor = true;
            this.bt_stats.Click += new System.EventHandler(this.Bt_stats_Click);
            // 
            // estatistica
            // 
            this.estatistica.HeaderText = "Estatística";
            this.estatistica.Name = "estatistica";
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 538);
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
    }
}

