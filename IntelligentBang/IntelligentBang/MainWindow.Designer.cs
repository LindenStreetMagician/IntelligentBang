
namespace IntelligentBang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.NewGameTool = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGameContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TopContestantTextBox = new System.Windows.Forms.TextBox();
            this.BottomContestantTextBox = new System.Windows.Forms.TextBox();
            this.NextRoundButton = new System.Windows.Forms.Button();
            this.TopicTextBox = new System.Windows.Forms.TextBox();
            this.TopContestantDogedButton = new System.Windows.Forms.Button();
            this.BottomContestantDogedButton = new System.Windows.Forms.Button();
            this.GraveyardImageButton = new System.Windows.Forms.Button();
            this.GraveyardTextBox = new System.Windows.Forms.TextBox();
            this.mainMenuStrip.SuspendLayout();
            this.NewGameContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGameTool});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1145, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            this.mainMenuStrip.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // NewGameTool
            // 
            this.NewGameTool.DropDown = this.NewGameContextMenuStrip;
            this.NewGameTool.Name = "NewGameTool";
            this.NewGameTool.Size = new System.Drawing.Size(50, 20);
            this.NewGameTool.Text = "Menu";
            this.NewGameTool.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // NewGameContextMenuStrip
            // 
            this.NewGameContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.NewGameContextMenuStrip.Name = "contextMenuStrip1";
            this.NewGameContextMenuStrip.OwnerItem = this.NewGameTool;
            this.NewGameContextMenuStrip.Size = new System.Drawing.Size(115, 26);
            this.NewGameContextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.NewGameContextMenuStrip_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.toolStripMenuItem1.Text = "Új Játék";
            // 
            // TopContestantTextBox
            // 
            this.TopContestantTextBox.Enabled = false;
            this.TopContestantTextBox.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TopContestantTextBox.Location = new System.Drawing.Point(320, 57);
            this.TopContestantTextBox.Name = "TopContestantTextBox";
            this.TopContestantTextBox.ReadOnly = true;
            this.TopContestantTextBox.Size = new System.Drawing.Size(813, 114);
            this.TopContestantTextBox.TabIndex = 3;
            // 
            // BottomContestantTextBox
            // 
            this.BottomContestantTextBox.Enabled = false;
            this.BottomContestantTextBox.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BottomContestantTextBox.Location = new System.Drawing.Point(320, 410);
            this.BottomContestantTextBox.Name = "BottomContestantTextBox";
            this.BottomContestantTextBox.ReadOnly = true;
            this.BottomContestantTextBox.Size = new System.Drawing.Size(813, 114);
            this.BottomContestantTextBox.TabIndex = 3;
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
            this.NextRoundButton.Click += new System.EventHandler(this.NextRoundButton_Click);
            // 
            // TopicTextBox
            // 
            this.TopicTextBox.Enabled = false;
            this.TopicTextBox.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TopicTextBox.Location = new System.Drawing.Point(320, 220);
            this.TopicTextBox.Multiline = true;
            this.TopicTextBox.Name = "TopicTextBox";
            this.TopicTextBox.ReadOnly = true;
            this.TopicTextBox.Size = new System.Drawing.Size(813, 145);
            this.TopicTextBox.TabIndex = 5;
            this.TopicTextBox.TextChanged += new System.EventHandler(this.TopicTextBox_TextChanged);
            // 
            // TopContestantDogedButton
            // 
            this.TopContestantDogedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TopContestantDogedButton.Image = ((System.Drawing.Image)(resources.GetObject("TopContestantDogedButton.Image")));
            this.TopContestantDogedButton.Location = new System.Drawing.Point(61, 37);
            this.TopContestantDogedButton.Name = "TopContestantDogedButton";
            this.TopContestantDogedButton.Size = new System.Drawing.Size(146, 134);
            this.TopContestantDogedButton.TabIndex = 7;
            this.TopContestantDogedButton.UseVisualStyleBackColor = true;
            this.TopContestantDogedButton.Visible = false;
            this.TopContestantDogedButton.Click += new System.EventHandler(this.TopContestantDogedButton_Click);
            // 
            // BottomContestantDogedButton
            // 
            this.BottomContestantDogedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BottomContestantDogedButton.Image = ((System.Drawing.Image)(resources.GetObject("BottomContestantDogedButton.Image")));
            this.BottomContestantDogedButton.Location = new System.Drawing.Point(61, 410);
            this.BottomContestantDogedButton.Name = "BottomContestantDogedButton";
            this.BottomContestantDogedButton.Size = new System.Drawing.Size(146, 134);
            this.BottomContestantDogedButton.TabIndex = 7;
            this.BottomContestantDogedButton.UseVisualStyleBackColor = true;
            this.BottomContestantDogedButton.Visible = false;
            this.BottomContestantDogedButton.Click += new System.EventHandler(this.BottomContestantDogedButton_Click);
            // 
            // GraveyardImageButton
            // 
            this.GraveyardImageButton.Enabled = false;
            this.GraveyardImageButton.Image = ((System.Drawing.Image)(resources.GetObject("GraveyardImageButton.Image")));
            this.GraveyardImageButton.Location = new System.Drawing.Point(12, 602);
            this.GraveyardImageButton.Name = "GraveyardImageButton";
            this.GraveyardImageButton.Size = new System.Drawing.Size(164, 125);
            this.GraveyardImageButton.TabIndex = 8;
            this.GraveyardImageButton.UseVisualStyleBackColor = true;
            // 
            // GraveyardTextBox
            // 
            this.GraveyardTextBox.Enabled = false;
            this.GraveyardTextBox.Location = new System.Drawing.Point(206, 602);
            this.GraveyardTextBox.Multiline = true;
            this.GraveyardTextBox.Name = "GraveyardTextBox";
            this.GraveyardTextBox.ReadOnly = true;
            this.GraveyardTextBox.Size = new System.Drawing.Size(927, 125);
            this.GraveyardTextBox.TabIndex = 9;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 739);
            this.Controls.Add(this.GraveyardTextBox);
            this.Controls.Add(this.GraveyardImageButton);
            this.Controls.Add(this.BottomContestantDogedButton);
            this.Controls.Add(this.TopContestantDogedButton);
            this.Controls.Add(this.TopicTextBox);
            this.Controls.Add(this.NextRoundButton);
            this.Controls.Add(this.BottomContestantTextBox);
            this.Controls.Add(this.TopContestantTextBox);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainWindow";
            this.Text = "Intelligent Bang";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.NewGameContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem NewGameTool;
        private System.Windows.Forms.TextBox TopContestantTextBox;
        private System.Windows.Forms.Button NextRoundButton;
        private System.Windows.Forms.TextBox TopicTextBox;
        private System.Windows.Forms.Button TopContestantDogedButton;
        private System.Windows.Forms.Button BottomContestantDogedButton;
        private System.Windows.Forms.TextBox BottomContestantTextBox;
        private System.Windows.Forms.Button GraveyardImageButton;
        private System.Windows.Forms.TextBox GraveyardTextBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip NewGameContextMenuStrip;
    }
}

