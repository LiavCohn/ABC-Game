namespace Exe4._2
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.BtnAbcBuildGame = new System.Windows.Forms.Button();
            this.btnMemoryGame = new System.Windows.Forms.Button();
            this.tltExplain = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAbcBuildGame
            // 
            this.BtnAbcBuildGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnAbcBuildGame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAbcBuildGame.FlatAppearance.BorderSize = 5;
            this.BtnAbcBuildGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnAbcBuildGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnAbcBuildGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAbcBuildGame.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbcBuildGame.Location = new System.Drawing.Point(466, 64);
            this.BtnAbcBuildGame.Name = "BtnAbcBuildGame";
            this.BtnAbcBuildGame.Padding = new System.Windows.Forms.Padding(3);
            this.BtnAbcBuildGame.Size = new System.Drawing.Size(179, 134);
            this.BtnAbcBuildGame.TabIndex = 0;
            this.BtnAbcBuildGame.Text = "Build The ABC!";
            this.tltExplain.SetToolTip(this.BtnAbcBuildGame, "Put all the Abc by their order!\r\nCan you do it in just 60 seconds?\r\n");
            this.BtnAbcBuildGame.UseVisualStyleBackColor = false;
            this.BtnAbcBuildGame.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnMemoryGame
            // 
            this.btnMemoryGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMemoryGame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMemoryGame.FlatAppearance.BorderSize = 5;
            this.btnMemoryGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMemoryGame.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoryGame.Location = new System.Drawing.Point(466, 249);
            this.btnMemoryGame.Name = "btnMemoryGame";
            this.btnMemoryGame.Padding = new System.Windows.Forms.Padding(3);
            this.btnMemoryGame.Size = new System.Drawing.Size(179, 134);
            this.btnMemoryGame.TabIndex = 1;
            this.btnMemoryGame.Text = "Memory Game!";
            this.tltExplain.SetToolTip(this.btnMemoryGame, "Find capital letters, and their companions,\r\nThe lowers case letters!\r\nFinding a " +
        "pair will reward you with 5 additional \r\nSeconds!\r\nBut be carefull..you start wi" +
        "th only 20!\r\n\r\n\r\n\r\n");
            this.btnMemoryGame.UseVisualStyleBackColor = false;
            this.btnMemoryGame.Click += new System.EventHandler(this.button2_Click);
            // 
            // tltExplain
            // 
            this.tltExplain.IsBalloon = true;
            this.tltExplain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tltExplain.ToolTipTitle = "Game Explantion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(601, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "©Liav Cohn\r\n";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Exe4._2.Properties.Resources.animals_abc;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(687, 471);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMemoryGame);
            this.Controls.Add(this.BtnAbcBuildGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "ABC Game!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAbcBuildGame;
        private System.Windows.Forms.Button btnMemoryGame;
        private System.Windows.Forms.ToolTip tltExplain;
        private System.Windows.Forms.Label label1;
    }
}

