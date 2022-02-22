namespace Examination_System.MainForms
{
    partial class ReportsMenu
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
            this.btnReport1 = new MaterialSkin.Controls.MaterialButton();
            this.btnReport2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // btnReport1
            // 
            this.btnReport1.AutoSize = false;
            this.btnReport1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReport1.Depth = 0;
            this.btnReport1.DrawShadows = true;
            this.btnReport1.HighEmphasis = true;
            this.btnReport1.Icon = null;
            this.btnReport1.Location = new System.Drawing.Point(56, 117);
            this.btnReport1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnReport1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReport1.Name = "btnReport1";
            this.btnReport1.Size = new System.Drawing.Size(146, 34);
            this.btnReport1.TabIndex = 0;
            this.btnReport1.Text = "Report 1";
            this.btnReport1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReport1.UseAccentColor = false;
            this.btnReport1.UseVisualStyleBackColor = true;
            this.btnReport1.Click += new System.EventHandler(this.BtnReport1_Click);
            // 
            // btnReport2
            // 
            this.btnReport2.AutoSize = false;
            this.btnReport2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReport2.Depth = 0;
            this.btnReport2.DrawShadows = true;
            this.btnReport2.HighEmphasis = true;
            this.btnReport2.Icon = null;
            this.btnReport2.Location = new System.Drawing.Point(380, 117);
            this.btnReport2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnReport2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReport2.Name = "btnReport2";
            this.btnReport2.Size = new System.Drawing.Size(146, 34);
            this.btnReport2.TabIndex = 1;
            this.btnReport2.Text = "Report 2";
            this.btnReport2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReport2.UseAccentColor = false;
            this.btnReport2.UseVisualStyleBackColor = true;
            this.btnReport2.Click += new System.EventHandler(this.BtnReport2_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(12, 329);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(146, 34);
            this.materialButton1.TabIndex = 2;
            this.materialButton1.Text = "back";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Depth = 0;
            this.materialButton2.DrawShadows = true;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(56, 188);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(146, 34);
            this.materialButton2.TabIndex = 3;
            this.materialButton2.Text = "Report 3";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // ReportsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.btnReport2);
            this.Controls.Add(this.btnReport1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReportsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportsMenu";
            this.Load += new System.EventHandler(this.ReportsMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnReport1;
        private MaterialSkin.Controls.MaterialButton btnReport2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}