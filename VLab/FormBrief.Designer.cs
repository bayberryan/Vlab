namespace VLab
{
    partial class FormBrief
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSteps = new System.Windows.Forms.Button();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.btnPurpose = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rtbBrief = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(521, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(160, 53);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "开始实验";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // btnSteps
            // 
            this.btnSteps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.btnSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSteps.FlatAppearance.BorderSize = 0;
            this.btnSteps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSteps.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSteps.ForeColor = System.Drawing.Color.White;
            this.btnSteps.Location = new System.Drawing.Point(355, 3);
            this.btnSteps.Name = "btnSteps";
            this.btnSteps.Size = new System.Drawing.Size(160, 53);
            this.btnSteps.TabIndex = 2;
            this.btnSteps.Text = "实验步骤";
            this.btnSteps.UseVisualStyleBackColor = false;
            // 
            // btnMaterial
            // 
            this.btnMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.btnMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMaterial.FlatAppearance.BorderSize = 0;
            this.btnMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterial.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterial.ForeColor = System.Drawing.Color.White;
            this.btnMaterial.Location = new System.Drawing.Point(189, 3);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(160, 53);
            this.btnMaterial.TabIndex = 1;
            this.btnMaterial.Text = "实验用品";
            this.btnMaterial.UseVisualStyleBackColor = false;
            // 
            // btnPurpose
            // 
            this.btnPurpose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.btnPurpose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPurpose.FlatAppearance.BorderSize = 0;
            this.btnPurpose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurpose.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurpose.ForeColor = System.Drawing.Color.White;
            this.btnPurpose.Location = new System.Drawing.Point(23, 3);
            this.btnPurpose.Name = "btnPurpose";
            this.btnPurpose.Size = new System.Drawing.Size(160, 53);
            this.btnPurpose.TabIndex = 0;
            this.btnPurpose.Text = "实验目的";
            this.btnPurpose.UseVisualStyleBackColor = false;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(113, 35);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(478, 29);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "MFK1-FA型卡帕桥磁化率仪操作实验";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(71)))), ((int)(((byte)(166)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.labelTitle, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(704, 100);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btnStart, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnPurpose, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSteps, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnMaterial, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 414);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(704, 59);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // rtbBrief
            // 
            this.rtbBrief.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbBrief.Location = new System.Drawing.Point(0, 100);
            this.rtbBrief.Name = "rtbBrief";
            this.rtbBrief.Size = new System.Drawing.Size(704, 314);
            this.rtbBrief.TabIndex = 3;
            this.rtbBrief.Text = "";
            // 
            // FormBrief
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 473);
            this.Controls.Add(this.rtbBrief);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MinimumSize = new System.Drawing.Size(720, 512);
            this.Name = "FormBrief";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSteps;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Button btnPurpose;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RichTextBox rtbBrief;
    }
}