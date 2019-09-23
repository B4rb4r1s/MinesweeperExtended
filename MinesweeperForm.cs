using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MinesweeperExtended.Properties;

namespace MinesweeperExtended
{
    public partial class MinesweeperForm : Form
    {
        // Parameters
        private Difficulty difficulty;
        private GameMode gameMode;
        public MinesweeperForm()
        {
            InitializeComponent();
            this.LoadGame(null, null);
            this.tileGrid.TileStatusChange += this.TileFlagStatusChanged;
        }

        private enum Difficulty { Beginner, Intermediate, Expert }
        private enum GameMode { Normal, Knight, NoUp, NoVert, Swath, Pawn, Orth, FarOrth, Doubled, Taxicab, Horiz }

        // Methods
        private void LoadGame(object sender, EventArgs e)
        {
            int x, y, mines;
            int[][] mooves = new int[][]
                    {
                        new[] {-1, -1}, new[] { 0, -1 }, new[] { 1, -1 }, new[] { 1, 0 },
                        new[] { 1, 1 }, new[] { 0, 1 }, new[] { -1, 1 }, new[] { -1, 0 }
                    };
            
            switch (this.difficulty)
            {
                case Difficulty.Beginner:
                    x = y = 9;
                    mines = 10;
                    break;
                case Difficulty.Intermediate:
                    x = y = 16;
                    mines = 40;
                    break;
                case Difficulty.Expert:
                    x = 30;
                    y = 16;
                    mines = 99;
                    break;
                default:
                    throw new InvalidOperationException("Unimplemented difficulty selected");
            }

            switch (this.gameMode)
            {
                case GameMode.Normal:
                    mooves = new int[][]
                    {
                        new[] {-1, -1}, new[] { 0, -1 }, new[] { 1, -1 }, new[] { 1, 0 },
                        new[] { 1, 1 }, new[] { 0, 1 }, new[] { -1, 1 }, new[] { -1, 0 }
                    };
                    break;
                case GameMode.Knight:
                    mooves = new int[][]
                    {
                        new[] {-1, -2 }, new[] { 1, -2 }, new[] { -2, -1 }, new[] { 2, -1 },
                        new[] { -2, 1 }, new[] { 2, 1 }, new[] { -1, 2 }, new[] { 1, 2 }
                    };
                    break;
                case GameMode.NoUp:
                    mooves = new int[][]
                    {
                        new[] {-1, -1}, new[] { 1, -1 }, new[] { 1, 0 },
                        new[] { 1, 1 }, new[] { 0, 1 }, new[] { -1, 1 }, new[] { -1, 0 }
                    };
                    break;
                case GameMode.NoVert:
                    mooves = new int[][]
                    {
                        new[] {-1, -1}, new[] { 1, -1 }, new[] { 1, 0 },
                        new[] { 1, 1 }, new[] { -1, 1 }, new[] { -1, 0 }
                    };
                    break;
                case GameMode.Swath:
                    mooves = new int[][]
                    {
                        new[] {-1, -1}, new[] { 0, -1 }, new[] { 1, -1 }, new[] { 1, 0 },
                        new[] { 1, 1 }, new[] { 0, 1 }, new[] { -1, 1 }, new[] { -1, 0 },
                        new[] {-2, -2}, new[] {-1, -2}, new[] {0, -2}, new[] {1, -2}, new[] {2, -2},
                        new[] {-2, 2}, new[] {-1, 2}, new[] {0, 2}, new[] {1, 2}, new[] {2, 2},
                        new[] {-2, -1}, new[] {-2, 0}, new[] {-2, 1},
                        new[] {2, -1}, new[] {2, 0}, new[] {2, 1},
                    };
                    break;
                case GameMode.Pawn:
                    mooves = new int[][]
                    {
                        new[] { -1, -1 }, new[] { 0, -1 }, new[] { 1, -1 }, new[] { 0, -2 },
                        new[] { -1, -1 }, new[] { 0, -1 }, new[] { 1, -1 }
                    };
                    break;
                case GameMode.Orth:
                    mooves = new int[][]
                    {
                        new[] { 0, -1 }, new[] { -1, 0 },
                        new[] { 1, 0 }, new[] { 0, 1 }
                    };
                    break;
                case GameMode.FarOrth:
                    mooves = new int[][]
                    {
                        new[] { 0, -1 }, new[] { -1, 0 },
                        new[] { 1, 0 }, new[] { 0, 1 },
                        new[] { 0, -2 }, new[] { -2, 0 },
                        new[] { 2, 0 }, new[] { 0, 2 }
                    };
                    break;
                case GameMode.Doubled:
                    mooves = new int[][]
                    {
                        new[] {-1, -1}, new[] { 0, -1 }, new[] { 1, -1 }, new[] { 1, 0 },
                        new[] { 1, 1 }, new[] { 0, 1 }, new[] { -1, 1 }, new[] { -1, 0 },
                        new[] { 0, -1 }, new[] { -1, 0 }, new[] { 1, 0 }, new[] { 0, 1 }
                    };
                    break;
                case GameMode.Taxicab:
                    mooves = new int[][]
                    {
                        new[] {-1, -1}, new[] { 0, -1 }, new[] { 1, -1 }, new[] { 1, 0 },
                        new[] { 1, 1 }, new[] { 0, 1 }, new[] { -1, 1 }, new[] { -1, 0 },
                        new[] { 0, -1 }, new[] { -1, 0 }, new[] { 1, 0 }, new[] { 0, 1 },
                        new[] { 0, -2 }, new[] { -2, 0 },
                        new[] { 2, 0 }, new[] { 0, 2 }
                    };
                    break;
                case GameMode.Horiz:
                    mooves = new int[][]
                    {
                        new[] { -2, 0 }, new[] { -1, 0 }, new[] { 1, 0 }, new[] { 2, 0 }
                    };
                    break;
                default:
                    throw new InvalidOperationException("Unimplemented gamemode selected");
            }

            this.tileGrid.LoadGrid(new Size(x, y), mines, mooves);
            this.MaximumSize = this.MinimumSize = new Size(this.tileGrid.Width + 36, this.tileGrid.Height + 98);
            this.flagCounter.Text = mines.ToString();
            this.flagCounter.ForeColor = Color.Black;
        }

        private void MenuStrip_Game_New_Click(object sender, EventArgs e)
        {
            this.LoadGame(null, null);
        }

        private void MenuStrip_Game_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuStrip_Game_DifficultyChanged(object sender, EventArgs e)
        {
            this.difficulty = (Difficulty)Enum.Parse(typeof(Difficulty), (string)((ToolStripMenuItem)sender).Tag);
            this.LoadGame(null, null);
        }
        private void MenuStrip_Expansion_GameModeChanged(object sender, EventArgs e)
        {
            this.gameMode = (GameMode)Enum.Parse(typeof(GameMode), (string)((ToolStripMenuItem)sender).Tag);
            this.LoadGame(null, null);
        }

        private void TileFlagStatusChanged(object sender, TileGrid.TileFlagStatusChangedEventArgs e)
        {
            this.flagCounter.Text = e.Flags.ToString();
            this.flagCounter.ForeColor = e.LabelColor;
        }

        // Classes
        private class TileGrid : Panel
        {
            // Parameters
            private static readonly HashSet<Tile> gridSearchBlacklist = new HashSet<Tile>();
            private static readonly Random random = new Random();
            private Size gridSize;
            private int mines;
            private int flags;
            private bool minesGenerated;
            internal event EventHandler<TileFlagStatusChangedEventArgs> TileStatusChange = delegate { };
            private Tile this[Point point] => (Tile)this.Controls[$"Tile_{point.X}_{point.Y}"];

            // Methods
            private void Tile_MouseDown(object sender, MouseEventArgs e)
            {
                Tile tile = (Tile)sender;
                if (!tile.Opened)
                {
                    switch (e.Button)
                    {
                        case MouseButtons.Left when !tile.Flagged:
                            if (!this.minesGenerated)
                            {
                                this.GenerateMines(tile);
                            }

                            if (tile.Mined)
                            {
                                this.DisableTiles(true);
                            }
                            else
                            {
                                tile.TestAdjacentTiles();
                                gridSearchBlacklist.Clear();
                            }
                            break;
                        case MouseButtons.Right when this.flags > 0:
                            if (tile.Flagged)
                            {
                                tile.Flagged = false;
                                this.flags++;
                            }
                            else
                            {
                                tile.Flagged = true;
                                this.flags--;
                            }
                            TileStatusChange(this, new TileFlagStatusChangedEventArgs(this.flags, this.flags < this.mines * 0.25 ? Color.Red : Color.Black));
                            break;
                    }
                }

                this.CheckForWin();
            }

            internal void LoadGrid(Size gridSize, int mines, int[][] mode)
            {
                this.minesGenerated = false;
                this.Controls.Clear();
                this.gridSize = gridSize;
                this.mines = this.flags = mines;
                this.Size = new Size(gridSize.Width * Tile.LENGTH, gridSize.Height * Tile.LENGTH);
                for (int x = 0; x < gridSize.Width; x++)
                {
                    for (int y = 0; y < gridSize.Height; y++)
                    {
                        Tile tile = new Tile(x, y);
                        tile.MouseDown += Tile_MouseDown;
                        this.Controls.Add(tile);
                    }
                }

                foreach (Tile tile in this.Controls)
                {
                    tile.SetAdjacentTiles(mode);
                }
            }

            private void DisableTiles(bool gameLost)
            {
                foreach (Tile tile in this.Controls)
                {
                    tile.MouseDown -= this.Tile_MouseDown;
                    if (gameLost)
                    {
                        tile.Image = !tile.Opened && tile.Mined && !tile.Flagged ? Resources.Mine :
                            tile.Flagged && !tile.Mined ? Resources.FalseFlag : tile.Image;
                    }
                }
            }

            private void CheckForWin()
            {
                if (this.flags != 0 || this.Controls.OfType<Tile>().Count(tile => tile.Opened || tile.Flagged) != this.gridSize.Width * this.gridSize.Height)
                {
                    return;
                }
                MessageBox.Show("Congratulations! You solved the game!","Game Solved", MessageBoxButtons.OK);
                this.DisableTiles(false);
            }

            private void GenerateMines(Tile safeTile)
            {
                int safeTilesCount = safeTile.AdjacentTiles.Length + 1;
                Point[] usedPositions = new Point[this.mines + safeTilesCount];
                usedPositions[0] = safeTile.GridPosition;
                for (int i = 1; i < safeTilesCount; i++)
                {
                    usedPositions[i] = safeTile.AdjacentTiles[i - 1].GridPosition;
                }

                for (int i = safeTilesCount; i < usedPositions.Length; i++)
                {
                    Point point = new Point(random.Next(this.gridSize.Width), random.Next(this.gridSize.Height));
                    if (!usedPositions.Contains(point))
                    {
                        this[point].Mine();
                        usedPositions[i] = point;
                    }
                    else
                    {
                        i--;
                    }
                }

                this.minesGenerated = true;
            }

            // Classes
            private class Tile : PictureBox
            {
                // Parameters
                // MOOVES
                // Public
                internal const int LENGTH = 32;
                //private static readonly int[][] adjacentCoords =
                //{
                //    new[] {-1, -1}, new[] { 0, -1 }, new[] { 1, -1 }, new[] { 1, 0 },
                //    new[] { 1, 1 }, new[] { 0, 1 }, new[] { -1, 1 }, new[] { -1, 0 }
                //};
                //private static readonly int[][] knightCoords =
                //{
                //    new[] {-1, -2 }, new[] { 1, -2 }, new[] { -2, -1 }, new[] { 2, -1 },
                //    new[] { -2, 1 }, new[] { 2, 1 }, new[] { -1, 2 }, new[] { 1, 2 }
                //};
                //private static readonly int[][] noUpCoords =
                //{
                //    new[] {-1, -1}, new[] { 1, -1 }, new[] { 1, 0 },
                //    new[] { 1, 1 }, new[] { 0, 1 }, new[] { -1, 1 }, new[] { -1, 0 }
                //};
                //private static readonly int[][] noVertCoords =
                //{
                //    new[] {-1, -1}, new[] { 1, -1 }, new[] { 1, 0 },
                //    new[] { 1, 1 }, new[] { -1, 1 }, new[] { -1, 0 }
                //};
                //private static readonly int[][] swathCoords =
                //{
                //    new[] {-1, -1}, new[] { 0, -1 }, new[] { 1, -1 }, new[] { 1, 0 },
                //    new[] { 1, 1 }, new[] { 0, 1 }, new[] { -1, 1 }, new[] { -1, 0 },
                //    new[] {-2, -2}, new[] {-1, -2}, new[] {0, -2}, new[] {1, -2}, new[] {2, -2},
                //    new[] {-2, 2}, new[] {-1, 2}, new[] {0, 2}, new[] {1, 2}, new[] {2, 2},
                //    new[] {-2, -1}, new[] {-2, 0}, new[] {-2, 1},
                //    new[] {2, -1}, new[] {2, 0}, new[] {2, 1},
                //};
                //private static readonly int[][] pawnCoords =
                //{
                //    new[] { -1, -1 }, new[] { 0, -1 }, new[] { 1, -1 }, new[] { 0, -2 },
                //    new[] { -1, -1 }, new[] { 0, -1 }, new[] { 1, -1 }
                //};

                private bool flagged;

                internal Tile(int x, int y)
                {
                    this.Name = $"Tile_{x}_{y}";
                    this.Location = new Point(x * LENGTH, y * LENGTH);
                    this.GridPosition = new Point(x, y);
                    this.Size = new Size(LENGTH, LENGTH);
                    this.Image = Resources.Tile;
                    this.SizeMode = PictureBoxSizeMode.Zoom;
                }

                internal Tile[] AdjacentTiles { get; private set; }
                internal Point GridPosition { get; }
                internal bool Opened { get; private set; }
                internal bool Mined { get; private set; }
                internal bool Flagged
                {
                    get => this.flagged;
                    set
                    {
                        this.flagged = value;
                        this.Image = value ? Resources.Flag : Resources.Tile;
                    }
                }

                // Methods
                internal void SetAdjacentTiles(int[][] posibleMooves)
                {
                    TileGrid tileGrid = (TileGrid)this.Parent;
                    List<Tile> adjacentTiles = new List<Tile>(8);

                    foreach (int[] adjacentCoord in posibleMooves)
                    //foreach (int[] adjacentCoord in adjacentCoords)
                    //foreach (int[] adjacentCoord in knightCoords)
                    //foreach (int[] adjacentCoord in noUpCoords)
                    //foreach (int[] adjacentCoord in noVertCoords)
                    //foreach (int[] adjacentCoord in swathCoords)
                    //foreach (int[] adjacentCoord in pawnCoords)
                    {
                        Tile tile = tileGrid[new Point(this.GridPosition.X + adjacentCoord[0], this.GridPosition.Y + adjacentCoord[1])];
                        if (tile != null)
                        {
                            adjacentTiles.Add(tile);
                        }
                    }

                    this.AdjacentTiles = adjacentTiles.ToArray();
                }

                private int AdjacentMines => this.AdjacentTiles.Count(tile => tile.Mined);

                internal void TestAdjacentTiles()
                {
                    if (this.flagged || gridSearchBlacklist.Contains(this))
                    {
                        return;
                    }

                    gridSearchBlacklist.Add(this);
                    if (this.AdjacentMines == 0)
                    {
                        foreach (Tile tile in this.AdjacentTiles)
                        {
                            tile.TestAdjacentTiles();
                        }
                    }
                    this.Open();
                }

                internal void Mine()
                {
                    this.Mined = true;
                    //this.Image = Resources.Mine;
                }

                internal void Open()
                {
                    this.Opened = true;
                    this.Image = (Image)Resources.ResourceManager.GetObject($"_{this.AdjacentMines}_Tile");
                    // ???
                    // if (this.AdjacentMines == 0) this.Image = Resources.Empty_Tile;
                }
            }

            internal class TileFlagStatusChangedEventArgs : EventArgs
            {
                internal int Flags { get; }
                internal Color LabelColor { get; }
                internal TileFlagStatusChangedEventArgs(int flags, Color labelColor)
                {
                    this.Flags = flags;
                    this.LabelColor = labelColor;

                }
            }
        }
    }
}
