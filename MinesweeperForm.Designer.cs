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
            this.components = new System.ComponentModel.Container();
            this.tileGrid = new MinesweeperExtended.MinesweeperForm.TileGrid();
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
            this.swathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pawnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orthogonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farOrthogonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doubledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxicabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Game_button = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Game_button)).BeginInit();
            this.SuspendLayout();
            // 
            // tileGrid
            // 
            this.tileGrid.Location = new System.Drawing.Point(12, 72);
            this.tileGrid.Name = "tileGrid";
            this.tileGrid.Size = new System.Drawing.Size(385, 323);
            this.tileGrid.TabIndex = 0;
            // 
            // flagCounter
            // 
            this.flagCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flagCounter.AutoSize = true;
            this.flagCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flagCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flagCounter.Location = new System.Drawing.Point(463, 27);
            this.flagCounter.Name = "flagCounter";
            this.flagCounter.Size = new System.Drawing.Size(2, 39);
            this.flagCounter.TabIndex = 2;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_Game_Expert,
            this.menuStrip_Extension,
            this.infoToolStripMenuItem});
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
            this.menuStrip_Game_New.Size = new System.Drawing.Size(141, 22);
            this.menuStrip_Game_New.Text = "New";
            this.menuStrip_Game_New.Click += new System.EventHandler(this.MenuStrip_Game_New_Click);
            // 
            // menuStrip_Game_Break1
            // 
            this.menuStrip_Game_Break1.Name = "menuStrip_Game_Break1";
            this.menuStrip_Game_Break1.Size = new System.Drawing.Size(138, 6);
            // 
            // menuStrip_Game_Beginner
            // 
            this.menuStrip_Game_Beginner.Name = "menuStrip_Game_Beginner";
            this.menuStrip_Game_Beginner.Size = new System.Drawing.Size(141, 22);
            this.menuStrip_Game_Beginner.Tag = "Beginner";
            this.menuStrip_Game_Beginner.Text = "Beginer";
            this.menuStrip_Game_Beginner.Click += new System.EventHandler(this.MenuStrip_Game_DifficultyChanged);
            // 
            // menuStrip_Game_Intermediate
            // 
            this.menuStrip_Game_Intermediate.Name = "menuStrip_Game_Intermediate";
            this.menuStrip_Game_Intermediate.Size = new System.Drawing.Size(141, 22);
            this.menuStrip_Game_Intermediate.Tag = "Intermediate";
            this.menuStrip_Game_Intermediate.Text = "Intermediate";
            this.menuStrip_Game_Intermediate.Click += new System.EventHandler(this.MenuStrip_Game_DifficultyChanged);
            // 
            // expertToolStripMenuItem
            // 
            this.expertToolStripMenuItem.Name = "expertToolStripMenuItem";
            this.expertToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.expertToolStripMenuItem.Tag = "Expert";
            this.expertToolStripMenuItem.Text = "Expert";
            this.expertToolStripMenuItem.Click += new System.EventHandler(this.MenuStrip_Game_DifficultyChanged);
            // 
            // menuStrip_Game_Break2
            // 
            this.menuStrip_Game_Break2.Name = "menuStrip_Game_Break2";
            this.menuStrip_Game_Break2.Size = new System.Drawing.Size(138, 6);
            // 
            // menuStrip_Game_Exit
            // 
            this.menuStrip_Game_Exit.Name = "menuStrip_Game_Exit";
            this.menuStrip_Game_Exit.Size = new System.Drawing.Size(141, 22);
            this.menuStrip_Game_Exit.Text = "Exit";
            this.menuStrip_Game_Exit.Click += new System.EventHandler(this.MenuStrip_Game_Exit_Click);
            // 
            // menuStrip_Extension
            // 
            this.menuStrip_Extension.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameModeToolStripMenuItem});
            this.menuStrip_Extension.Name = "menuStrip_Extension";
            this.menuStrip_Extension.Size = new System.Drawing.Size(73, 20);
            this.menuStrip_Extension.Text = "Expension";
            // 
            // gameModeToolStripMenuItem
            // 
            this.gameModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.knightToolStripMenuItem,
            this.noUpToolStripMenuItem,
            this.noVerticalToolStripMenuItem,
            this.swathToolStripMenuItem,
            this.pawnToolStripMenuItem,
            this.orthogonalToolStripMenuItem,
            this.farOrthogonalToolStripMenuItem,
            this.doubledToolStripMenuItem,
            this.taxicabToolStripMenuItem,
            this.horizontalToolStripMenuItem});
            this.gameModeToolStripMenuItem.Name = "gameModeToolStripMenuItem";
            this.gameModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gameModeToolStripMenuItem.Text = "Game mode";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.normalToolStripMenuItem.Tag = "Normal";
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.MenuStrip_Extansion_GameModeChanged);
            // 
            // knightToolStripMenuItem
            // 
            this.knightToolStripMenuItem.Name = "knightToolStripMenuItem";
            this.knightToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.knightToolStripMenuItem.Tag = "Knight";
            this.knightToolStripMenuItem.Text = "Knight";
            this.knightToolStripMenuItem.Click += new System.EventHandler(this.MenuStrip_Extansion_GameModeChanged);
            // 
            // noUpToolStripMenuItem
            // 
            this.noUpToolStripMenuItem.Name = "noUpToolStripMenuItem";
            this.noUpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.noUpToolStripMenuItem.Tag = "NoUp";
            this.noUpToolStripMenuItem.Text = "No up";
            this.noUpToolStripMenuItem.Click += new System.EventHandler(this.MenuStrip_Extansion_GameModeChanged);
            // 
            // noVerticalToolStripMenuItem
            // 
            this.noVerticalToolStripMenuItem.Name = "noVerticalToolStripMenuItem";
            this.noVerticalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.noVerticalToolStripMenuItem.Tag = "NoVert";
            this.noVerticalToolStripMenuItem.Text = "No vertical";
            this.noVerticalToolStripMenuItem.Click += new System.EventHandler(this.MenuStrip_Extansion_GameModeChanged);
            // 
            // swathToolStripMenuItem
            // 
            this.swathToolStripMenuItem.Name = "swathToolStripMenuItem";
            this.swathToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.swathToolStripMenuItem.Tag = "Swath";
            this.swathToolStripMenuItem.Text = "Swarm";
            this.swathToolStripMenuItem.Click += new System.EventHandler(this.MenuStrip_Extansion_GameModeChanged);
            // 
            // pawnToolStripMenuItem
            // 
            this.pawnToolStripMenuItem.Name = "pawnToolStripMenuItem";
            this.pawnToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pawnToolStripMenuItem.Tag = "Pawn";
            this.pawnToolStripMenuItem.Text = "Pawn";
            this.pawnToolStripMenuItem.Click += new System.EventHandler(this.MenuStrip_Extansion_GameModeChanged);
            // 
            // orthogonalToolStripMenuItem
            // 
            this.orthogonalToolStripMenuItem.Name = "orthogonalToolStripMenuItem";
            this.orthogonalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.orthogonalToolStripMenuItem.Tag = "Orth";
            this.orthogonalToolStripMenuItem.Text = "Orthogonal";
            this.orthogonalToolStripMenuItem.Click += new System.EventHandler(this.MenuStrip_Extansion_GameModeChanged);
            // 
            // farOrthogonalToolStripMenuItem
            // 
            this.farOrthogonalToolStripMenuItem.Name = "farOrthogonalToolStripMenuItem";
            this.farOrthogonalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.farOrthogonalToolStripMenuItem.Tag = "FarOrth";
            this.farOrthogonalToolStripMenuItem.Text = "Far orthogonal";
            this.farOrthogonalToolStripMenuItem.Click += new System.EventHandler(this.MenuStrip_Extansion_GameModeChanged);
            // 
            // doubledToolStripMenuItem
            // 
            this.doubledToolStripMenuItem.Name = "doubledToolStripMenuItem";
            this.doubledToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.doubledToolStripMenuItem.Tag = "Doubled";
            this.doubledToolStripMenuItem.Text = "Doubled";
            this.doubledToolStripMenuItem.Click += new System.EventHandler(this.MenuStrip_Extansion_GameModeChanged);
            // 
            // taxicabToolStripMenuItem
            // 
            this.taxicabToolStripMenuItem.Name = "taxicabToolStripMenuItem";
            this.taxicabToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.taxicabToolStripMenuItem.Tag = "Taxicab";
            this.taxicabToolStripMenuItem.Text = "Diamond";
            this.taxicabToolStripMenuItem.Click += new System.EventHandler(this.MenuStrip_Extansion_GameModeChanged);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.horizontalToolStripMenuItem.Tag = "Horiz";
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.MenuStrip_Extansion_GameModeChanged);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            // 
            // Game_button
            // 
            this.Game_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Game_button.BackgroundImage = global::MinesweeperExtended.Properties.Resources.Game;
            this.Game_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Game_button.Location = new System.Drawing.Point(249, 31);
            this.Game_button.Name = "Game_button";
            this.Game_button.Size = new System.Drawing.Size(35, 35);
            this.Game_button.TabIndex = 1;
            this.Game_button.TabStop = false;
            this.Game_button.Click += new System.EventHandler(this.LoadGame);
            // 
            // MinesweeperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flagCounter);
            this.Controls.Add(this.tileGrid);
            this.Controls.Add(this.Game_button);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MinesweeperForm";
            this.Text = "Minesweeper Extended";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Game_button)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem swathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pawnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orthogonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farOrthogonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doubledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taxicabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}

