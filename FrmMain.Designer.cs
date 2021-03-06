﻿
namespace DotCards
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbSelect = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.trvCardSet = new System.Windows.Forms.TreeView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblTotalQCountNum = new System.Windows.Forms.Label();
            this.lblTotalQCount = new System.Windows.Forms.Label();
            this.lblPathStr = new System.Windows.Forms.Label();
            this.lblQuestionCountNum = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblQestionCount = new System.Windows.Forms.Label();
            this.tbQuestions = new System.Windows.Forms.TabPage();
            this.htmlView = new TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowAnswer = new System.Windows.Forms.Button();
            this.btnPrevQ = new System.Windows.Forms.Button();
            this.btnNextQ = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbSelect.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.tbQuestions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbSelect);
            this.tabControl1.Controls.Add(this.tbQuestions);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(946, 622);
            this.tabControl1.TabIndex = 1;
            // 
            // tbSelect
            // 
            this.tbSelect.Controls.Add(this.btnClear);
            this.tbSelect.Controls.Add(this.txtSearchText);
            this.tbSelect.Controls.Add(this.trvCardSet);
            this.tbSelect.Controls.Add(this.btnUpdate);
            this.tbSelect.Controls.Add(this.grpInfo);
            this.tbSelect.Location = new System.Drawing.Point(4, 24);
            this.tbSelect.Name = "tbSelect";
            this.tbSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tbSelect.Size = new System.Drawing.Size(938, 594);
            this.tbSelect.TabIndex = 0;
            this.tbSelect.Text = "Select";
            this.tbSelect.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(438, 8);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSearchText
            // 
            this.txtSearchText.Location = new System.Drawing.Point(3, 8);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(429, 23);
            this.txtSearchText.TabIndex = 9;
            this.txtSearchText.TextChanged += new System.EventHandler(this.txtSearchText_TextChanged);
            // 
            // trvCardSet
            // 
            this.trvCardSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trvCardSet.Location = new System.Drawing.Point(3, 37);
            this.trvCardSet.Name = "trvCardSet";
            this.trvCardSet.Size = new System.Drawing.Size(510, 554);
            this.trvCardSet.TabIndex = 8;
            this.trvCardSet.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.Location = new System.Drawing.Point(524, 539);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 47);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblTotalQCountNum);
            this.grpInfo.Controls.Add(this.lblTotalQCount);
            this.grpInfo.Controls.Add(this.lblPathStr);
            this.grpInfo.Controls.Add(this.lblQuestionCountNum);
            this.grpInfo.Controls.Add(this.btnSelect);
            this.grpInfo.Controls.Add(this.lblPath);
            this.grpInfo.Controls.Add(this.lblQestionCount);
            this.grpInfo.Location = new System.Drawing.Point(524, 3);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(406, 241);
            this.grpInfo.TabIndex = 1;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Info";
            // 
            // lblTotalQCountNum
            // 
            this.lblTotalQCountNum.AutoSize = true;
            this.lblTotalQCountNum.Location = new System.Drawing.Point(127, 59);
            this.lblTotalQCountNum.Name = "lblTotalQCountNum";
            this.lblTotalQCountNum.Size = new System.Drawing.Size(89, 15);
            this.lblTotalQCountNum.TabIndex = 6;
            this.lblTotalQCountNum.Text = "Question count";
            // 
            // lblTotalQCount
            // 
            this.lblTotalQCount.AutoSize = true;
            this.lblTotalQCount.Location = new System.Drawing.Point(6, 59);
            this.lblTotalQCount.Name = "lblTotalQCount";
            this.lblTotalQCount.Size = new System.Drawing.Size(118, 15);
            this.lblTotalQCount.TabIndex = 5;
            this.lblTotalQCount.Text = "Total question count:";
            // 
            // lblPathStr
            // 
            this.lblPathStr.AutoSize = true;
            this.lblPathStr.Location = new System.Drawing.Point(127, 83);
            this.lblPathStr.Name = "lblPathStr";
            this.lblPathStr.Size = new System.Drawing.Size(45, 15);
            this.lblPathStr.TabIndex = 4;
            this.lblPathStr.Text = "PathStr";
            // 
            // lblQuestionCountNum
            // 
            this.lblQuestionCountNum.AutoSize = true;
            this.lblQuestionCountNum.Location = new System.Drawing.Point(127, 34);
            this.lblQuestionCountNum.Name = "lblQuestionCountNum";
            this.lblQuestionCountNum.Size = new System.Drawing.Size(89, 15);
            this.lblQuestionCountNum.TabIndex = 3;
            this.lblQuestionCountNum.Text = "Question count";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(276, 188);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(124, 47);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(90, 83);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(34, 15);
            this.lblPath.TabIndex = 1;
            this.lblPath.Text = "Path:";
            // 
            // lblQestionCount
            // 
            this.lblQestionCount.AutoSize = true;
            this.lblQestionCount.Location = new System.Drawing.Point(32, 34);
            this.lblQestionCount.Name = "lblQestionCount";
            this.lblQestionCount.Size = new System.Drawing.Size(92, 15);
            this.lblQestionCount.TabIndex = 0;
            this.lblQestionCount.Text = "Question count:";
            // 
            // tbQuestions
            // 
            this.tbQuestions.Controls.Add(this.htmlView);
            this.tbQuestions.Controls.Add(this.panel1);
            this.tbQuestions.Location = new System.Drawing.Point(4, 24);
            this.tbQuestions.Name = "tbQuestions";
            this.tbQuestions.Padding = new System.Windows.Forms.Padding(3);
            this.tbQuestions.Size = new System.Drawing.Size(938, 594);
            this.tbQuestions.TabIndex = 1;
            this.tbQuestions.Text = "Questions";
            this.tbQuestions.UseVisualStyleBackColor = true;
            // 
            // htmlView
            // 
            this.htmlView.AutoScroll = true;
            this.htmlView.AutoScrollMinSize = new System.Drawing.Size(932, 20);
            this.htmlView.BackColor = System.Drawing.Color.White;
            this.htmlView.BaseStylesheet = null;
            this.htmlView.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.htmlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlView.Location = new System.Drawing.Point(3, 3);
            this.htmlView.Name = "htmlView";
            this.htmlView.Size = new System.Drawing.Size(932, 532);
            this.htmlView.TabIndex = 5;
            this.htmlView.Text = "htmlPanel1";
            this.htmlView.UseGdiPlusTextRendering = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.btnShowAnswer);
            this.panel1.Controls.Add(this.btnPrevQ);
            this.panel1.Controls.Add(this.btnNextQ);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 535);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 56);
            this.panel1.TabIndex = 8;
            // 
            // btnShowAnswer
            // 
            this.btnShowAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAnswer.Location = new System.Drawing.Point(366, 3);
            this.btnShowAnswer.Name = "btnShowAnswer";
            this.btnShowAnswer.Size = new System.Drawing.Size(214, 51);
            this.btnShowAnswer.TabIndex = 9;
            this.btnShowAnswer.Text = "Show";
            this.btnShowAnswer.UseVisualStyleBackColor = true;
            // 
            // btnPrevQ
            // 
            this.btnPrevQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevQ.Location = new System.Drawing.Point(5, 3);
            this.btnPrevQ.Name = "btnPrevQ";
            this.btnPrevQ.Size = new System.Drawing.Size(75, 51);
            this.btnPrevQ.TabIndex = 8;
            this.btnPrevQ.Text = "Prev";
            this.btnPrevQ.UseVisualStyleBackColor = true;
            // 
            // btnNextQ
            // 
            this.btnNextQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextQ.Location = new System.Drawing.Point(852, 3);
            this.btnNextQ.Name = "btnNextQ";
            this.btnNextQ.Size = new System.Drawing.Size(75, 51);
            this.btnNextQ.TabIndex = 7;
            this.btnNextQ.Text = "Next";
            this.btnNextQ.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 622);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmMain";
            this.Text = "DotCards";
            this.tabControl1.ResumeLayout(false);
            this.tbSelect.ResumeLayout(false);
            this.tbSelect.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.tbQuestions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbSelect;
        private System.Windows.Forms.TabPage tbQuestions;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblQestionCount;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblPathStr;
        private System.Windows.Forms.Label lblQuestionCountNum;
        private TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel htmlView;
        private System.Windows.Forms.Label lblTotalQCountNum;
        private System.Windows.Forms.Label lblTotalQCount;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowAnswer;
        private System.Windows.Forms.Button btnPrevQ;
        private System.Windows.Forms.Button btnNextQ;
        private System.Windows.Forms.TreeView trvCardSet;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSearchText;
    }
}

