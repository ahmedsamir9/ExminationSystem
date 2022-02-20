
namespace Examination_System.InstructorForms
{
    partial class InstructorMenu
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
            this.btnDetails = new MaterialSkin.Controls.MaterialButton();
            this.btnCourses = new MaterialSkin.Controls.MaterialButton();
            this.btnAssignStudent = new MaterialSkin.Controls.MaterialButton();
            this.btnSignOut = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // btnDetails
            // 
            this.btnDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDetails.Depth = 0;
            this.btnDetails.DrawShadows = true;
            this.btnDetails.HighEmphasis = true;
            this.btnDetails.Icon = null;
            this.btnDetails.Location = new System.Drawing.Point(330, 141);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDetails.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(79, 36);
            this.btnDetails.TabIndex = 0;
            this.btnDetails.Text = "Details";
            this.btnDetails.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDetails.UseAccentColor = false;
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCourses.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCourses.Depth = 0;
            this.btnCourses.DrawShadows = true;
            this.btnCourses.HighEmphasis = true;
            this.btnCourses.Icon = null;
            this.btnCourses.Location = new System.Drawing.Point(330, 214);
            this.btnCourses.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCourses.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(86, 36);
            this.btnCourses.TabIndex = 1;
            this.btnCourses.Text = "Courses";
            this.btnCourses.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCourses.UseAccentColor = false;
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnAssignStudent
            // 
            this.btnAssignStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssignStudent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAssignStudent.Depth = 0;
            this.btnAssignStudent.DrawShadows = true;
            this.btnAssignStudent.HighEmphasis = true;
            this.btnAssignStudent.Icon = null;
            this.btnAssignStudent.Location = new System.Drawing.Point(301, 290);
            this.btnAssignStudent.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAssignStudent.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAssignStudent.Name = "btnAssignStudent";
            this.btnAssignStudent.Size = new System.Drawing.Size(142, 36);
            this.btnAssignStudent.TabIndex = 2;
            this.btnAssignStudent.Text = "Assign Student";
            this.btnAssignStudent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAssignStudent.UseAccentColor = false;
            this.btnAssignStudent.UseVisualStyleBackColor = true;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSignOut.Depth = 0;
            this.btnSignOut.DrawShadows = true;
            this.btnSignOut.HighEmphasis = true;
            this.btnSignOut.Icon = null;
            this.btnSignOut.Location = new System.Drawing.Point(685, 399);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSignOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(87, 36);
            this.btnSignOut.TabIndex = 3;
            this.btnSignOut.Text = "Sign out";
            this.btnSignOut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSignOut.UseAccentColor = false;
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // InstructorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnAssignStudent);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.btnDetails);
            this.Name = "InstructorMenu";
            this.Text = "InstructorMenu";
            this.Load += new System.EventHandler(this.InstructorMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnDetails;
        private MaterialSkin.Controls.MaterialButton btnCourses;
        private MaterialSkin.Controls.MaterialButton btnAssignStudent;
        private MaterialSkin.Controls.MaterialButton btnSignOut;
    }
}