﻿namespace PowerString
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.NewAccountCreateLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DuplicateConfirmationBtn = new System.Windows.Forms.Button();
            this.PswInputAgainBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PswInputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdInputBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NewAccountCreateBtn = new System.Windows.Forms.Button();
            this.NewAcountBackBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewAccountCreateLabel
            // 
            this.NewAccountCreateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NewAccountCreateLabel.AutoSize = true;
            this.NewAccountCreateLabel.Font = new System.Drawing.Font("Gulim", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NewAccountCreateLabel.Location = new System.Drawing.Point(207, 54);
            this.NewAccountCreateLabel.Name = "NewAccountCreateLabel";
            this.NewAccountCreateLabel.Size = new System.Drawing.Size(436, 48);
            this.NewAccountCreateLabel.TabIndex = 2;
            this.NewAccountCreateLabel.Text = "새로운 사용자 등록\r\n";
            this.NewAccountCreateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.DuplicateConfirmationBtn);
            this.groupBox1.Controls.Add(this.PswInputAgainBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PswInputBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IdInputBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(152, 137);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(546, 203);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // DuplicateConfirmationBtn
            // 
            this.DuplicateConfirmationBtn.Location = new System.Drawing.Point(445, 51);
            this.DuplicateConfirmationBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DuplicateConfirmationBtn.Name = "DuplicateConfirmationBtn";
            this.DuplicateConfirmationBtn.Size = new System.Drawing.Size(86, 32);
            this.DuplicateConfirmationBtn.TabIndex = 7;
            this.DuplicateConfirmationBtn.Text = "중복확인";
            this.DuplicateConfirmationBtn.UseVisualStyleBackColor = true;
            this.DuplicateConfirmationBtn.Click += new System.EventHandler(this.DuplicateConfirmationBtn_Click);
            // 
            // PswInputAgainBox
            // 
            this.PswInputAgainBox.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PswInputAgainBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.PswInputAgainBox.Location = new System.Drawing.Point(215, 137);
            this.PswInputAgainBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PswInputAgainBox.Name = "PswInputAgainBox";
            this.PswInputAgainBox.Size = new System.Drawing.Size(215, 30);
            this.PswInputAgainBox.TabIndex = 6;
            this.PswInputAgainBox.Text = "비밀번호를 입력하세요";
            this.PswInputAgainBox.TextChanged += new System.EventHandler(this.PswInputAgainBox_TextChanged);
            this.PswInputAgainBox.Enter += new System.EventHandler(this.PswInputAgainBox_Enter_1);
            this.PswInputAgainBox.Leave += new System.EventHandler(this.PswInputAgainBox_Leave_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "비밀번호 재확인";
            // 
            // PswInputBox
            // 
            this.PswInputBox.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PswInputBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.PswInputBox.Location = new System.Drawing.Point(215, 94);
            this.PswInputBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PswInputBox.Name = "PswInputBox";
            this.PswInputBox.Size = new System.Drawing.Size(215, 30);
            this.PswInputBox.TabIndex = 5;
            this.PswInputBox.Text = "비밀번호는 4자까지";
            this.PswInputBox.TextChanged += new System.EventHandler(this.PswInputBox_TextChanged);
            this.PswInputBox.Enter += new System.EventHandler(this.PswInputBox_Enter_1);
            this.PswInputBox.Leave += new System.EventHandler(this.PswInputBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "새로운 사용자명 입력";
            // 
            // IdInputBox
            // 
            this.IdInputBox.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdInputBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.IdInputBox.Location = new System.Drawing.Point(215, 51);
            this.IdInputBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IdInputBox.Name = "IdInputBox";
            this.IdInputBox.Size = new System.Drawing.Size(215, 30);
            this.IdInputBox.TabIndex = 4;
            this.IdInputBox.Text = "사용자명은 30자까지";
            this.IdInputBox.Enter += new System.EventHandler(this.IdInputBox_Enter_1);
            this.IdInputBox.Leave += new System.EventHandler(this.IdInputBox_Leave_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "비밀번호 입력";
            // 
            // NewAccountCreateBtn
            // 
            this.NewAccountCreateBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewAccountCreateBtn.Font = new System.Drawing.Font("Gulim", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewAccountCreateBtn.Location = new System.Drawing.Point(205, 363);
            this.NewAccountCreateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewAccountCreateBtn.Name = "NewAccountCreateBtn";
            this.NewAccountCreateBtn.Size = new System.Drawing.Size(440, 41);
            this.NewAccountCreateBtn.TabIndex = 4;
            this.NewAccountCreateBtn.Text = "새로운 사용자 계정 생성";
            this.NewAccountCreateBtn.UseVisualStyleBackColor = true;
            this.NewAccountCreateBtn.Click += new System.EventHandler(this.NewAccountCreateBtn_Click);
            // 
            // NewAcountBackBtn
            // 
            this.NewAcountBackBtn.Location = new System.Drawing.Point(733, 406);
            this.NewAcountBackBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewAcountBackBtn.Name = "NewAcountBackBtn";
            this.NewAcountBackBtn.Size = new System.Drawing.Size(86, 31);
            this.NewAcountBackBtn.TabIndex = 5;
            this.NewAcountBackBtn.Text = "취소(&c)";
            this.NewAcountBackBtn.UseVisualStyleBackColor = true;
            this.NewAcountBackBtn.Click += new System.EventHandler(this.NewAcountBackBtn_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.NewAcountBackBtn);
            this.Controls.Add(this.NewAccountCreateBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NewAccountCreateLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SignUpForm";
            this.Text = "PowerString";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewAccountCreateLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PswInputAgainBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PswInputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdInputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NewAccountCreateBtn;
        private System.Windows.Forms.Button NewAcountBackBtn;
        private System.Windows.Forms.Button DuplicateConfirmationBtn;
    }
}