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
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_tempos)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_sair
            // 
            this.bt_sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_sair.Location = new System.Drawing.Point(713, 415);
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            this.data_tempos.Size = new System.Drawing.Size(775, 275);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

