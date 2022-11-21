namespace Sudoku
{
    partial class Complexity
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
            this.Title = new System.Windows.Forms.Label();
            this.complexityLevel = new System.Windows.Forms.ComboBox();
            this.Go = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Red Ring Bold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(78, 101);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(259, 68);
            this.Title.TabIndex = 4;
            this.Title.Text = "Complexity:";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // complexityLevel
            // 
            this.complexityLevel.Font = new System.Drawing.Font("Red Ring Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.complexityLevel.FormattingEnabled = true;
            this.complexityLevel.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.complexityLevel.Location = new System.Drawing.Point(111, 172);
            this.complexityLevel.Name = "complexityLevel";
            this.complexityLevel.Size = new System.Drawing.Size(189, 36);
            this.complexityLevel.TabIndex = 5;
            // 
            // Go
            // 
            this.Go.BackColor = System.Drawing.SystemColors.Highlight;
            this.Go.Font = new System.Drawing.Font("Red Ring Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Go.Location = new System.Drawing.Point(135, 244);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(139, 73);
            this.Go.TabIndex = 6;
            this.Go.Text = "Go!";
            this.Go.UseVisualStyleBackColor = false;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // Complexity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 418);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.complexityLevel);
            this.Controls.Add(this.Title);
            this.Name = "Complexity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Complexity_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ComboBox complexityLevel;
        private System.Windows.Forms.Button Go;
    }
}