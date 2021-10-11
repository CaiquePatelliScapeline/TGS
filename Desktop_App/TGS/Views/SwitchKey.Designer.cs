
namespace TGS.Views {
    partial class SwitchKey {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SwitchKey));
            this.pnl_SwitchKey = new System.Windows.Forms.Panel();
            this.tb_SwitchKey = new System.Windows.Forms.TableLayoutPanel();
            this.lv_SwitchKey = new System.Windows.Forms.ListView();
            this.pnl_SwitchKey.SuspendLayout();
            this.tb_SwitchKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_SwitchKey
            // 
            this.pnl_SwitchKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(235)))), ((int)(((byte)(252)))));
            this.pnl_SwitchKey.Controls.Add(this.tb_SwitchKey);
            this.pnl_SwitchKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SwitchKey.Location = new System.Drawing.Point(0, 0);
            this.pnl_SwitchKey.Name = "pnl_SwitchKey";
            this.pnl_SwitchKey.Size = new System.Drawing.Size(563, 323);
            this.pnl_SwitchKey.TabIndex = 0;
            // 
            // tb_SwitchKey
            // 
            this.tb_SwitchKey.ColumnCount = 3;
            this.tb_SwitchKey.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tb_SwitchKey.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tb_SwitchKey.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tb_SwitchKey.Controls.Add(this.lv_SwitchKey, 1, 1);
            this.tb_SwitchKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_SwitchKey.Location = new System.Drawing.Point(0, 0);
            this.tb_SwitchKey.Name = "tb_SwitchKey";
            this.tb_SwitchKey.RowCount = 3;
            this.tb_SwitchKey.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tb_SwitchKey.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tb_SwitchKey.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tb_SwitchKey.Size = new System.Drawing.Size(563, 323);
            this.tb_SwitchKey.TabIndex = 0;
            // 
            // lv_SwitchKey
            // 
            this.lv_SwitchKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lv_SwitchKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_SwitchKey.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_SwitchKey.HideSelection = false;
            this.lv_SwitchKey.Location = new System.Drawing.Point(14, 9);
            this.lv_SwitchKey.Name = "lv_SwitchKey";
            this.lv_SwitchKey.Size = new System.Drawing.Size(534, 304);
            this.lv_SwitchKey.TabIndex = 0;
            this.lv_SwitchKey.UseCompatibleStateImageBehavior = false;
            // 
            // SwitchKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(563, 323);
            this.Controls.Add(this.pnl_SwitchKey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SwitchKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Title";
            this.pnl_SwitchKey.ResumeLayout(false);
            this.tb_SwitchKey.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_SwitchKey;
        private System.Windows.Forms.TableLayoutPanel tb_SwitchKey;
        private System.Windows.Forms.ListView lv_SwitchKey;
    }
}