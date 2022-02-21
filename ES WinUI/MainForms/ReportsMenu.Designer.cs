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
            this.btnReport1.Location = new System.Drawing.Point(70, 144);
            this.btnReport1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReport1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReport1.Name = "btnReport1";
            this.btnReport1.Size = new System.Drawing.Size(194, 42);
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
            this.btnReport2.Location = new System.Drawing.Point(507, 144);
            this.btnReport2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReport2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReport2.Name = "btnReport2";
            this.btnReport2.Size = new System.Drawing.Size(194, 42);
            this.btnReport2.TabIndex = 1;
            this.btnReport2.Text = "Report 2";
            this.btnReport2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReport2.UseAccentColor = false;
            this.btnReport2.UseVisualStyleBackColor = true;
            this.btnReport2.Click += new System.EventHandler(this.BtnReport2_Click);
            // 
            // ReportsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReport2);
            this.Controls.Add(this.btnReport1);
            this.Name = "ReportsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportsMenu";
            this.Load += new System.EventHandler(this.ReportsMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnReport1;
        private MaterialSkin.Controls.MaterialButton btnReport2;
    }
}