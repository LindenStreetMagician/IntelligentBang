
namespace IntelligentOnlineCowboy
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contestantTextBox1 = new System.Windows.Forms.TextBox();
            this.contestantTextBox2 = new System.Windows.Forms.TextBox();
            this.NextRoundButton = new System.Windows.Forms.Button();
            this.topicTextBox = new System.Windows.Forms.TextBox();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1145, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            this.mainMenuStrip.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "&Menu";
            this.menuToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newGameToolStripMenuItem.Image")));
            this.newGameToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShowShortcutKeys = false;
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.newGameToolStripMenuItem.Text = "Új játék";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(132, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // contestantTextBox1
            // 
            this.contestantTextBox1.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contestantTextBox1.Location = new System.Drawing.Point(320, 57);
            this.contestantTextBox1.Name = "contestantTextBox1";
            this.contestantTextBox1.ReadOnly = true;
            this.contestantTextBox1.Size = new System.Drawing.Size(813, 114);
            this.contestantTextBox1.TabIndex = 3;
            // 
            // contestantTextBox2
            // 
            this.contestantTextBox2.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contestantTextBox2.Location = new System.Drawing.Point(320, 390);
            this.contestantTextBox2.Name = "contestantTextBox2";
            this.contestantTextBox2.ReadOnly = true;
            this.contestantTextBox2.Size = new System.Drawing.Size(813, 114);
            this.contestantTextBox2.TabIndex = 3;
            // 
            // NextRoundButton
            // 
            this.NextRoundButton.BackColor = System.Drawing.Color.Transparent;
            this.NextRoundButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NextRoundButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextRoundButton.FlatAppearance.BorderSize = 0;
            this.NextRoundButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NextRoundButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NextRoundButton.ForeColor = System.Drawing.Color.Transparent;
            this.NextRoundButton.Image = ((System.Drawing.Image)(resources.GetObject("NextRoundButton.Image")));
            this.NextRoundButton.Location = new System.Drawing.Point(12, 220);
            this.NextRoundButton.Name = "NextRoundButton";
            this.NextRoundButton.Size = new System.Drawing.Size(252, 145);
            this.NextRoundButton.TabIndex = 4;
            this.NextRoundButton.UseVisualStyleBackColor = false;
            // 
            // topicTextBox
            // 
            this.topicTextBox.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.topicTextBox.Location = new System.Drawing.Point(320, 237);
            this.topicTextBox.Name = "topicTextBox";
            this.topicTextBox.ReadOnly = true;
            this.topicTextBox.Size = new System.Drawing.Size(813, 78);
            this.topicTextBox.TabIndex = 5;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 564);
            this.Controls.Add(this.topicTextBox);
            this.Controls.Add(this.NextRoundButton);
            this.Controls.Add(this.contestantTextBox2);
            this.Controls.Add(this.contestantTextBox1);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainWindow";
            this.Text = "Intelligent Online Cowboy";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox contestantTextBox1;
        private System.Windows.Forms.TextBox contestantTextBox2;
        private System.Windows.Forms.Button NextRoundButton;
        private System.Windows.Forms.TextBox topicTextBox;
    }
}

