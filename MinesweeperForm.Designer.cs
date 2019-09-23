namespace MinesweeperExtended
{
    partial class MinesweeperForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tileGrid = new MinesweeperExtended.MinesweeperForm.TileGrid();
            this.Game_button = new System.Windows.Forms.PictureBox();
            this.flagCounter = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStrip_Game_Expert = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Game_New = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Game_Break1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip_Game_Beginner = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Game_Intermediate = new System.Windows.Forms.ToolStripMenuItem();
            this.expertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Game_Break2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip_Game_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Extension = new System.Windows.Forms.ToolStripMenuItem();
            this.gameModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Game_button)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileGrid
            // 
            this.tileGrid.Location = new System.Drawing.Point(10, 50);
            this.tileGrid.Name = "tileGrid";
            this.tileGrid.Size = new System.Drawing.Size(385, 323);
            this.tileGrid.TabIndex = 0;
            // 
            // Game_button
            // 
            this.Game_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Game_button.BackgroundImage = global::MinesweeperExtended.Properties.Resources.Game;
            this.Game_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Game_button.Location = new System.Drawing.Point(249, 9);
            this.Game_button.Name = "Game_button";
            this.Game_button.Size = new System.Drawing.Size(35, 35);
            this.Game_button.TabIndex = 1;
            this.Game_button.TabStop = false;
            this.Game_button.Click += new System.EventHandler(this.LoadGame);
            // 
            // flagCounter
            // 
            this.flagCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flagCounter.AutoSize = true;
            this.flagCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flagCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flagCounter.Location = new System.Drawing.Point(463, 5);
            this.flagCounter.Name = "flagCounter";
            this.flagCounter.Size = new System.Drawing.Size(2, 39);
            this.flagCounter.TabIndex = 2;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_Game_Expert,
            this.menuStrip_Extension});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(533, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuStrip_Game_Expert
            // 
            this.menuStrip_Game_Expert.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_Game_New,
            this.menuStrip_Game_Break1,
            this.menuStrip_Game_Beginner,
            this.menuStrip_Game_Intermediate,
            this.expertToolStripMenuItem,
            this.menuStrip_Game_Break2,
            this.menuStrip_Game_Exit});
            this.menuStrip_Game_Expert.Name = "menuStrip_Game_Expert";
            this.menuStrip_Game_Expert.Size = new System.Drawing.Size(50, 20);
            this.menuStrip_Game_Expert.Tag = "Expert";
            this.menuStrip_Game_Expert.Text = "Game";
            // 
            // menuStrip_Game_New
            // 
            this.menuStrip_Game_New.Name = "menuStrip_Game_New";
            this.menuStrip_Game_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuStrip_Game_New.Size = new System.Drawing.Size(180, 22);
            this.menuStrip_Game_New.Text = "New";
            this.menuStrip_Game_New.Click += new System.EventHandler(this.MenuStrip_Game_New_Click);
            // 
            // menuStrip_Game_Break1
            // 
            this.menuStrip_Game_Break1.Name = "menuStrip_Game_Break1";
            this.menuStrip_Game_Break1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuStrip_Game_Beginner
            // 
            this.menuStrip_Game_Beginner.Name = "menuStrip_Game_Beginner";
            this.menuStrip_Game_Beginner.Size = new System.Drawing.Size(180, 22);
            this.menuStrip_Game_Beginner.Tag = "Beginner";
            this.menuStrip_Game_Beginner.Text = "Beginer";
            this.menuStrip_Game_Beginner.Click += new System.EventHandler(this.MenuStrip_Game_DifficultyChanged);
            // 
            // menuStrip_Game_Intermediate
            // 
            this.menuStrip_Game_Intermediate.Name = "menuStrip_Game_Intermediate";
            this.menuStrip_Game_Intermediate.Size = new System.Drawing.Size(180, 22);
            this.menuStrip_Game_Intermediate.Tag = "Intermediate";
            this.menuStrip_Game_Intermediate.Text = "Intermediate";
            this.menuStrip_Game_Intermediate.Click += new System.EventHandler(this.MenuStrip_Game_DifficultyChanged);
            // 
            // expertToolStripMenuItem
            // 
            this.expertToolStripMenuItem.Name = "expertToolStripMenuItem";
            this.expertToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.expertToolStripMenuItem.Tag = "Expert";
            this.expertToolStripMenuItem.Text = "Expert";
            this.expertToolStripMenuItem.Click += new System.EventHandler(this.MenuStrip_Game_DifficultyChanged);
            // 
            // menuStrip_Game_Break2
            // 
            this.menuStrip_Game_Break2.Name = "menuStrip_Game_Break2";
            this.menuStrip_Game_Break2.Size = new System.Drawing.Size(177, 6);
            // 
            // menuStrip_Game_Exit
            // 
            this.menuStrip_Game_Exit.Name = "menuStrip_Game_Exit";
            this.menuStrip_Game_Exit.Size = new System.Drawing.Size(180, 22);
            this.menuStrip_Game_Exit.Text = "Exit";
            this.menuStrip_Game_Exit.Click += new System.EventHandler(this.MenuStrip_Game_Exit_Click);
            // 
            // menuStrip_Extension
            // 
            this.menuStrip_Extension.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameModeToolStripMenuItem});
            this.menuStrip_Extension.Name = "menuStrip_Extension";
            this.menuStrip_Extension.Size = new System.Drawing.Size(70, 20);
            this.menuStrip_Extension.Text = "Extension";
            // 
            // gameModeToolStripMenuItem
            // 
            this.gameModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.knightToolStripMenuItem,
            this.noUpToolStripMenuItem,
            this.noVerticalToolStripMenuItem});
            this.gameModeToolStripMenuItem.Name = "gameModeToolStripMenuItem";
            this.gameModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gameModeToolStripMenuItem.Text = "Game mode";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            // 
            // knightToolStripMenuItem
            // 
            this.knightToolStripMenuItem.Name = "knightToolStripMenuItem";
            this.knightToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.knightToolStripMenuItem.Text = "Knight";
            // 
            // noUpToolStripMenuItem
            // 
            this.noUpToolStripMenuItem.Name = "noUpToolStripMenuItem";
            this.noUpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noUpToolStripMenuItem.Text = "No up";
            // 
            // noVerticalToolStripMenuItem
            // 
            this.noVerticalToolStripMenuItem.Name = "noVerticalToolStripMenuItem";
            this.noVerticalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noVerticalToolStripMenuItem.Text = "No vertical";
            // 
            // MinesweeperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 385);
            this.Controls.Add(this.flagCounter);
            this.Controls.Add(this.tileGrid);
            this.Controls.Add(this.Game_button);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MinesweeperForm";
            this.Text = "Minesweeper Extended";
            ((System.ComponentModel.ISupportInitialize)(this.Game_button)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TileGrid tileGrid;
        private System.Windows.Forms.PictureBox Game_button;
        private System.Windows.Forms.Label flagCounter;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Game_Expert;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Game_New;
        private System.Windows.Forms.ToolStripSeparator menuStrip_Game_Break1;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Game_Beginner;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Game_Intermediate;
        private System.Windows.Forms.ToolStripMenuItem expertToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator menuStrip_Game_Break2;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Game_Exit;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Extension;
        private System.Windows.Forms.ToolStripMenuItem gameModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noVerticalToolStripMenuItem;
    }
}

