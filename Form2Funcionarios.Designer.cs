namespace appRT
{
    partial class Form2Funcionarios
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
            this.grid_funcionarios = new System.Windows.Forms.DataGridView();
            this.bt_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_funcionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_funcionarios
            // 
            this.grid_funcionarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_funcionarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grid_funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_funcionarios.Location = new System.Drawing.Point(13, 13);
            this.grid_funcionarios.Name = "grid_funcionarios";
            this.grid_funcionarios.Size = new System.Drawing.Size(384, 252);
            this.grid_funcionarios.TabIndex = 0;
            // 
            // bt_ok
            // 
            this.bt_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_ok.Location = new System.Drawing.Point(321, 291);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 1;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.Bt_ok_Click);
            // 
            // Form2Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 326);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.grid_funcionarios);
            this.Name = "Form2Funcionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2Funcionarios";
            this.Load += new System.EventHandler(this.Form2Funcionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_funcionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_funcionarios;
        private System.Windows.Forms.Button bt_ok;
    }
}