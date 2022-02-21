namespace Examination_System
{
    partial class StudentMenu
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
            this.btnShowDetails = new MaterialSkin.Controls.MaterialButton();
            this.btnTakeExam = new MaterialSkin.Controls.MaterialButton();
            this.btnShowGrades = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.AutoSize = false;
            this.btnShowDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowDetails.Depth = 0;
            this.btnShowDetails.DrawShadows = true;
            this.btnShowDetails.HighEmphasis = true;
            this.btnShowDetails.Icon = null;
            this.btnShowDetails.Location = new System.Drawing.Point(345, 196);
            this.btnShowDetails.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnShowDetails.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(205, 50);
            this.btnShowDetails.TabIndex = 0;
            this.btnShowDetails.Text = "Show Details";
            this.btnShowDetails.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnShowDetails.UseAccentColor = false;
            this.btnShowDetails.UseVisualStyleBackColor = true;
            this.btnShowDetails.Click += new System.EventHandler(this.BtnShowDetails_Click);
            // 
            // btnTakeExam
            // 
            this.btnTakeExam.AutoSize = false;
            this.btnTakeExam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTakeExam.Depth = 0;
            this.btnTakeExam.DrawShadows = true;
            this.btnTakeExam.HighEmphasis = true;
            this.btnTakeExam.Icon = null;
            this.btnTakeExam.Location = new System.Drawing.Point(345, 277);
            this.btnTakeExam.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTakeExam.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTakeExam.Name = "btnTakeExam";
            this.btnTakeExam.Size = new System.Drawing.Size(205, 50);
            this.btnTakeExam.TabIndex = 1;
            this.btnTakeExam.Text = "TAKE AN EXAM";
            this.btnTakeExam.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTakeExam.UseAccentColor = false;
            this.btnTakeExam.UseVisualStyleBackColor = true;
            this.btnTakeExam.Click += new System.EventHandler(this.BtnTakeExam_Click);
            // 
            // btnShowGrades
            // 
            this.btnShowGrades.AutoSize = false;
            this.btnShowGrades.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowGrades.Depth = 0;
            this.btnShowGrades.DrawShadows = true;
            this.btnShowGrades.HighEmphasis = true;
            this.btnShowGrades.Icon = null;
            this.btnShowGrades.Location = new System.Drawing.Point(345, 358);
            this.btnShowGrades.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnShowGrades.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShowGrades.Name = "btnShowGrades";
            this.btnShowGrades.Size = new System.Drawing.Size(205, 50);
            this.btnShowGrades.TabIndex = 2;
            this.btnShowGrades.Text = "Show Exams Grade";
            this.btnShowGrades.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnShowGrades.UseAccentColor = false;
            this.btnShowGrades.UseVisualStyleBackColor = true;
            this.btnShowGrades.Click += new System.EventHandler(this.BtnShowGrades_Click);
            // 
            // StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 542);
            this.Controls.Add(this.btnShowGrades);
            this.Controls.Add(this.btnTakeExam);
            this.Controls.Add(this.btnShowDetails);
            this.MaximizeBox = false;
            this.Name = "StudentMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentMenu";
            this.Load += new System.EventHandler(this.StudentMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnShowDetails;
        private MaterialSkin.Controls.MaterialButton btnTakeExam;
        private MaterialSkin.Controls.MaterialButton btnShowGrades;
    }
}