namespace appRT
{
    partial class Form3Clientes
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
            this.grid_clientes = new System.Windows.Forms.DataGridView();
            this.bt_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_clientes
            // 
            this.grid_clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_clientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grid_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_clientes.Location = new System.Drawing.Point(13, 13);
            this.grid_clientes.Name = "grid_clientes";
            this.grid_clientes.Size = new System.Drawing.Size(377, 276);
            this.grid_clientes.TabIndex = 0;
            // 
            // bt_ok
            // 
            this.bt_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_ok.Location = new System.Drawing.Point(313, 313);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 1;
            this.bt_ok.Text = "Ok";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.Bt_ok_Click);
            // 
            // Form3Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 348);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.grid_clientes);
            this.Name = "Form3Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3Clientes";
            this.Load += new System.EventHandler(this.Form3Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_clientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_clientes;
        private System.Windows.Forms.Button bt_ok;
    }
}