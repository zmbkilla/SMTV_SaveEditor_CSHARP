namespace SMTV_SaveEditor_CSHARP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openDecryptedSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopPlayMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveUtilityOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveutilCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoEncodeDecodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDecryptedSaveToolStripMenuItem,
            this.stopPlayMusicToolStripMenuItem,
            this.saveUtilityOptionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openDecryptedSaveToolStripMenuItem
            // 
            this.openDecryptedSaveToolStripMenuItem.Image = global::SMTV_SaveEditor_CSHARP.Properties.Resources.Google_Noto_Emoji_Objects_62917_open_file_folder;
            this.openDecryptedSaveToolStripMenuItem.Name = "openDecryptedSaveToolStripMenuItem";
            this.openDecryptedSaveToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.openDecryptedSaveToolStripMenuItem.Click += new System.EventHandler(this.openDecryptedSaveToolStripMenuItem_Click);
            this.openDecryptedSaveToolStripMenuItem.MouseHover += new System.EventHandler(this.openDecryptedSaveToolStripMenuItem_MouseHover);
            // 
            // stopPlayMusicToolStripMenuItem
            // 
            this.stopPlayMusicToolStripMenuItem.Name = "stopPlayMusicToolStripMenuItem";
            this.stopPlayMusicToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.stopPlayMusicToolStripMenuItem.Text = "Stop/Play Music";
            this.stopPlayMusicToolStripMenuItem.Click += new System.EventHandler(this.stopPlayMusicToolStripMenuItem_Click);
            // 
            // saveUtilityOptionsToolStripMenuItem
            // 
            this.saveUtilityOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveutilCommandsToolStripMenuItem});
            this.saveUtilityOptionsToolStripMenuItem.Name = "saveUtilityOptionsToolStripMenuItem";
            this.saveUtilityOptionsToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.saveUtilityOptionsToolStripMenuItem.Text = "Save Utility options";
            // 
            // saveutilCommandsToolStripMenuItem
            // 
            this.saveutilCommandsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoEncodeDecodeToolStripMenuItem});
            this.saveutilCommandsToolStripMenuItem.Name = "saveutilCommandsToolStripMenuItem";
            this.saveutilCommandsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.saveutilCommandsToolStripMenuItem.Text = "Saveutil commands";
            // 
            // autoEncodeDecodeToolStripMenuItem
            // 
            this.autoEncodeDecodeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputToolStripMenuItem,
            this.executeToolStripMenuItem});
            this.autoEncodeDecodeToolStripMenuItem.Name = "autoEncodeDecodeToolStripMenuItem";
            this.autoEncodeDecodeToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.autoEncodeDecodeToolStripMenuItem.Text = "Auto Encode/ Decode";
            // 
            // inputToolStripMenuItem
            // 
            this.inputToolStripMenuItem.Name = "inputToolStripMenuItem";
            this.inputToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.inputToolStripMenuItem.Text = "Input";
            this.inputToolStripMenuItem.Click += new System.EventHandler(this.inputToolStripMenuItem_Click);
            // 
            // executeToolStripMenuItem
            // 
            this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            this.executeToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.executeToolStripMenuItem.Text = "Execute";
            this.executeToolStripMenuItem.Click += new System.EventHandler(this.executeToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 105);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Player data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(349, 105);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(540, 384);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 177);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Money / Glory";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(14, 245);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "Player Stats";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(14, 313);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 50);
            this.button4.TabIndex = 5;
            this.button4.Text = "Demons";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(14, 391);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 50);
            this.button5.TabIndex = 6;
            this.button5.Text = "Essences";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(119, 105);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 50);
            this.button6.TabIndex = 7;
            this.button6.Text = "Items";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Shin Megami Tensei V Save Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openDecryptedSaveToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem stopPlayMusicToolStripMenuItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripMenuItem saveUtilityOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveutilCommandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoEncodeDecodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;
        private System.Windows.Forms.Button button6;
    }
}

