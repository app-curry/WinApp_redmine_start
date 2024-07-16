namespace WinApp_redmine_start
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_redmine_start = new System.Windows.Forms.Button();
            this.textBox_redmine_installpath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_selectDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_redmine_start
            // 
            this.button_redmine_start.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_redmine_start.Location = new System.Drawing.Point(12, 84);
            this.button_redmine_start.Name = "button_redmine_start";
            this.button_redmine_start.Size = new System.Drawing.Size(157, 64);
            this.button_redmine_start.TabIndex = 4;
            this.button_redmine_start.Text = "redmine start";
            this.button_redmine_start.UseVisualStyleBackColor = true;
            this.button_redmine_start.Click += new System.EventHandler(this.button_redmine_start_Click);
            // 
            // textBox_redmine_installpath
            // 
            this.textBox_redmine_installpath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_redmine_installpath.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_redmine_installpath.Location = new System.Drawing.Point(12, 33);
            this.textBox_redmine_installpath.Name = "textBox_redmine_installpath";
            this.textBox_redmine_installpath.Size = new System.Drawing.Size(648, 28);
            this.textBox_redmine_installpath.TabIndex = 5;
            this.textBox_redmine_installpath.Text = "redmine installpath";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "RedmineInstallPath";
            // 
            // button_selectDir
            // 
            this.button_selectDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_selectDir.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_selectDir.Location = new System.Drawing.Point(666, 33);
            this.button_selectDir.Name = "button_selectDir";
            this.button_selectDir.Size = new System.Drawing.Size(43, 28);
            this.button_selectDir.TabIndex = 7;
            this.button_selectDir.Text = "...";
            this.button_selectDir.UseVisualStyleBackColor = true;
            this.button_selectDir.Click += new System.EventHandler(this.button_selectDir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 160);
            this.Controls.Add(this.button_selectDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_redmine_installpath);
            this.Controls.Add(this.button_redmine_start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_redmine_start;
        private System.Windows.Forms.TextBox textBox_redmine_installpath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_selectDir;
    }
}

