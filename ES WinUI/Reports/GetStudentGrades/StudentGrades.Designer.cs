namespace Examination_System.Reports.GetStudentGrades
{
    partial class StudentGrades
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
            this.btnShowReport = new MaterialSkin.Controls.MaterialButton();
            this.tbStudentID = new MaterialSkin.Controls.MaterialTextBox();
            this.btnBack = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // btnShowReport
            // 
            this.btnShowReport.AutoSize = false;
            this.btnShowReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowReport.Depth = 0;
            this.btnShowReport.DrawShadows = true;
            this.btnShowReport.HighEmphasis = true;
            this.btnShowReport.Icon = null;
            this.btnShowReport.Location = new System.Drawing.Point(338, 317);
            this.btnShowReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnShowReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(243, 41);
            this.btnShowReport.TabIndex = 3;
            this.btnShowReport.Text = "Show Report";
            this.btnShowReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnShowReport.UseAccentColor = false;
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.BtnShowReport_Click);
            // 
            // tbStudentID
            // 
            this.tbStudentID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStudentID.Depth = 0;
            this.tbStudentID.Font = new System.Drawing.Font("Roboto", 12F);
            this.tbStudentID.Hint = "Student ID";
            this.tbStudentID.Location = new System.Drawing.Point(202, 136);
            this.tbStudentID.MaxLength = 50;
            this.tbStudentID.MouseState = MaterialSkin.MouseState.OUT;
            this.tbStudentID.Multiline = false;
            this.tbStudentID.Name = "tbStudentID";
            this.tbStudentID.Size = new System.Drawing.Size(515, 50);
            this.tbStudentID.TabIndex = 2;
            this.tbStudentID.Text = "";
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = false;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Depth = 0;
            this.btnBack.DrawShadows = true;
            this.btnBack.HighEmphasis = true;
            this.btnBack.Icon = null;
            this.btnBack.Location = new System.Drawing.Point(28, 418);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 43);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBack.UseAccentColor = false;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // StudentGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 495);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.tbStudentID);
            this.Name = "StudentGrades";
            this.Text = "Student Grades Report";
            this.Load += new System.EventHandler(this.StudentGradesDept_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnShowReport;
        private MaterialSkin.Controls.MaterialTextBox tbStudentID;
        private MaterialSkin.Controls.MaterialButton btnBack;
    }
}