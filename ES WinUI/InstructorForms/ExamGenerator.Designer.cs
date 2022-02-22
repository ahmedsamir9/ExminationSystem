
namespace Examination_System.InstructorForms
{
    partial class ExamGenerator
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMCQNum = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTFNum = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(93, 104);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(223, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Enter Number Of T/F Questions";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(629, 399);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(158, 36);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "save";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(93, 211);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(230, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Enter Number of MCQ Questions";
            // 
            // txtMCQNum
            // 
            this.txtMCQNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMCQNum.Depth = 0;
            this.txtMCQNum.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtMCQNum.Location = new System.Drawing.Point(96, 263);
            this.txtMCQNum.MaxLength = 50;
            this.txtMCQNum.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMCQNum.Multiline = false;
            this.txtMCQNum.Name = "txtMCQNum";
            this.txtMCQNum.Size = new System.Drawing.Size(315, 50);
            this.txtMCQNum.TabIndex = 3;
            this.txtMCQNum.Text = "";
            // 
            // txtTFNum
            // 
            this.txtTFNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTFNum.Depth = 0;
            this.txtTFNum.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtTFNum.Location = new System.Drawing.Point(100, 143);
            this.txtTFNum.MaxLength = 50;
            this.txtTFNum.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTFNum.Multiline = false;
            this.txtTFNum.Name = "txtTFNum";
            this.txtTFNum.Size = new System.Drawing.Size(311, 50);
            this.txtTFNum.TabIndex = 4;
            this.txtTFNum.Text = "";
            // 
            // ExamGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTFNum);
            this.Controls.Add(this.txtMCQNum);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialLabel1);
            this.Name = "ExamGenerator";
            this.Text = "ExamGenerator";
            this.Load += new System.EventHandler(this.ExamGenerator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtMCQNum;
        private MaterialSkin.Controls.MaterialTextBox txtTFNum;
    }
}