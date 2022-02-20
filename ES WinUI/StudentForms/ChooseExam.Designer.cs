﻿namespace Examination_System.StudentForms
{
    partial class ChooseExam
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
            this.cbExams = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnTakeExam = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // cbExams
            // 
            this.cbExams.AutoResize = false;
            this.cbExams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbExams.Depth = 0;
            this.cbExams.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbExams.DropDownHeight = 174;
            this.cbExams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExams.DropDownWidth = 121;
            this.cbExams.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbExams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbExams.FormattingEnabled = true;
            this.cbExams.IntegralHeight = false;
            this.cbExams.ItemHeight = 43;
            this.cbExams.Location = new System.Drawing.Point(270, 202);
            this.cbExams.MaxDropDownItems = 4;
            this.cbExams.MouseState = MaterialSkin.MouseState.OUT;
            this.cbExams.Name = "cbExams";
            this.cbExams.Size = new System.Drawing.Size(407, 49);
            this.cbExams.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(278, 134);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(301, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Choose an Exam, then click take the exam.";
            this.materialLabel1.Click += new System.EventHandler(this.MaterialLabel1_Click);
            // 
            // btnTakeExam
            // 
            this.btnTakeExam.AutoSize = false;
            this.btnTakeExam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTakeExam.Depth = 0;
            this.btnTakeExam.DrawShadows = true;
            this.btnTakeExam.HighEmphasis = true;
            this.btnTakeExam.Icon = null;
            this.btnTakeExam.Location = new System.Drawing.Point(341, 439);
            this.btnTakeExam.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTakeExam.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTakeExam.Name = "btnTakeExam";
            this.btnTakeExam.Size = new System.Drawing.Size(258, 43);
            this.btnTakeExam.TabIndex = 2;
            this.btnTakeExam.Text = "Take Exam";
            this.btnTakeExam.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTakeExam.UseAccentColor = false;
            this.btnTakeExam.UseVisualStyleBackColor = true;
            this.btnTakeExam.Click += new System.EventHandler(this.BtnTakeExam_Click);
            // 
            // ChooseExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 542);
            this.Controls.Add(this.btnTakeExam);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cbExams);
            this.MaximizeBox = false;
            this.Name = "ChooseExam";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseExam";
            this.Load += new System.EventHandler(this.ChooseExam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cbExams;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnTakeExam;
    }
}