using System;
using System.Windows.Forms;
using System.IO;

namespace Folder_hierarchy_copy
{
    partial class select_pass_form
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// コピー完了メッセージ
        /// </summary>
        private const string completionMessage = "コピーを完了しました";

        /// <summary>
        /// コピー完了メッセージタイトル
        /// </summary>
        private const string completionInfoMessage = "information";

        /// <summary>
        /// ディレクトリ未選択メッセージ
        /// </summary>
        private const string unselectedMessage = "ディレクトリを選択して下さい";

        /// <summary>
        /// コピー元ディレクトリ存在なしメッセージ
        /// </summary>
        private const string originalNotExistMessage = "コピー元ディレクトリが存在しません";

        /// <summary>
        /// コピー先ディレクトリ存在なしメッセージ
        /// </summary>
        private const string copytoNotExistMessage = "コピー先ディレクトリが存在しません";

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
            this.folderBrowserDialogOriginal = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogCopyTo = new System.Windows.Forms.FolderBrowserDialog();
            this.original_button = new System.Windows.Forms.Button();
            this.copyto_button = new System.Windows.Forms.Button();
            this.original_pass = new System.Windows.Forms.TextBox();
            this.copyto_pass = new System.Windows.Forms.TextBox();
            this.run_button = new System.Windows.Forms.Button();
            this.selectFileCheckBox = new System.Windows.Forms.CheckBox();
            this.description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // original_button
            // 
            this.original_button.Location = new System.Drawing.Point(41, 86);
            this.original_button.Name = "original_button";
            this.original_button.Size = new System.Drawing.Size(103, 41);
            this.original_button.TabIndex = 0;
            this.original_button.Text = "コピー元選択";
            this.original_button.UseVisualStyleBackColor = true;
            this.original_button.Click += new System.EventHandler(this.original_button_Click);
            // 
            // copyto_button
            // 
            this.copyto_button.Location = new System.Drawing.Point(38, 227);
            this.copyto_button.Name = "copyto_button";
            this.copyto_button.Size = new System.Drawing.Size(103, 41);
            this.copyto_button.TabIndex = 1;
            this.copyto_button.Text = "コピー先選択";
            this.copyto_button.UseVisualStyleBackColor = true;
            this.copyto_button.Click += new System.EventHandler(this.copyto_button_Click);
            // 
            // original_pass
            // 
            this.original_pass.Location = new System.Drawing.Point(38, 149);
            this.original_pass.Name = "original_pass";
            this.original_pass.Size = new System.Drawing.Size(710, 22);
            this.original_pass.TabIndex = 2;
            // 
            // copyto_pass
            // 
            this.copyto_pass.Location = new System.Drawing.Point(41, 292);
            this.copyto_pass.Name = "copyto_pass";
            this.copyto_pass.Size = new System.Drawing.Size(710, 22);
            this.copyto_pass.TabIndex = 3;
            // 
            // run_button
            // 
            this.run_button.Location = new System.Drawing.Point(627, 347);
            this.run_button.Name = "run_button";
            this.run_button.Size = new System.Drawing.Size(121, 57);
            this.run_button.TabIndex = 4;
            this.run_button.Text = "コピー開始";
            this.run_button.UseVisualStyleBackColor = true;
            this.run_button.Click += new System.EventHandler(this.run_button_Click);
            // 
            // selectFileCheckBox
            // 
            this.selectFileCheckBox.AutoSize = true;
            this.selectFileCheckBox.Location = new System.Drawing.Point(468, 367);
            this.selectFileCheckBox.Name = "selectFileCheckBox";
            this.selectFileCheckBox.Size = new System.Drawing.Size(120, 19);
            this.selectFileCheckBox.TabIndex = 5;
            this.selectFileCheckBox.Text = "ファイルを含める";
            this.selectFileCheckBox.UseVisualStyleBackColor = true;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(38, 25);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(294, 15);
            this.description.TabIndex = 6;
            this.description.Text = "※選択したディレクトリ階層をコピーするツールです";
            // 
            // select_pass_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.description);
            this.Controls.Add(this.selectFileCheckBox);
            this.Controls.Add(this.run_button);
            this.Controls.Add(this.copyto_pass);
            this.Controls.Add(this.original_pass);
            this.Controls.Add(this.copyto_button);
            this.Controls.Add(this.original_button);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "select_pass_form";
            this.Text = "ディレクトリを選択して下さい";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // コピー元
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogOriginal;
        private Button original_button;
        private Button copyto_button;
        private TextBox original_pass;
        private TextBox copyto_pass;
        private Button run_button;
        private CheckBox selectFileCheckBox;
        private Label description;

        // コピー先
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogCopyTo;

        // コピー元フォルダ選択
        private void original_button_Click(object sender, EventArgs e)
        {
            folderBrowserDialogOriginal.Description = "コピー元フォルダを指定してください。";
            folderBrowserDialogOriginal.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialogOriginal.SelectedPath = @"C:\Windows";
            folderBrowserDialogOriginal.ShowNewFolderButton = false;

            //ダイアログを表示する
            if (folderBrowserDialogOriginal.ShowDialog(this) == DialogResult.OK)
            {
                //選択されたフォルダをテキストボックスへ表示
                original_pass.Text = folderBrowserDialogOriginal.SelectedPath;
            }
        }

        // コピー先フォルダ選択
        private void copyto_button_Click(object sender, EventArgs e)
        {
            folderBrowserDialogCopyTo.Description = "コピー先フォルダを指定してください。";
            folderBrowserDialogCopyTo.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialogCopyTo.SelectedPath = @"C:\folder_copyto_default_env";

            folderBrowserDialogCopyTo.ShowNewFolderButton = false;

            //ダイアログを表示する
            if (folderBrowserDialogCopyTo.ShowDialog(this) == DialogResult.OK)
            {
                //選択されたフォルダをテキストボックスへ表示
                copyto_pass.Text = folderBrowserDialogCopyTo.SelectedPath;
            }
        }

        private void run_button_Click(object sender, EventArgs e)
        {
            if(original_pass.Text.Length == 0 || copyto_pass.Text.Length == 0)
            {
                // ディレクトリ未選択
                MessageBox.Show(unselectedMessage);
            }
            else if (!Directory.Exists(original_pass.Text))
            {
                // コピー元フォルダの存在チェック
                MessageBox.Show(originalNotExistMessage);
            }
            else if (!Directory.Exists(copyto_pass.Text))
            {
                // コピー先フォルダの存在チェック
                MessageBox.Show(copytoNotExistMessage);
            }
            else
            {
                // コピー
                Common.Set_CopyDirectory(original_pass.Text, copyto_pass.Text, this.selectFileCheckBox.Checked);

                MessageBox.Show(completionMessage, completionInfoMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }
    }
}

