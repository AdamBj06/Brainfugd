using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brainfugd
{
    public partial class Form1 : Form
    {
        List<PictureBox> Cells = new List<PictureBox>();
        List<string> CellsType = new List<string>();
        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cells.Add(pcb_Start);
            CellsType.Add("Start");
            Cells.Add(pcb1);
            CellsType.Add("Empty");
            int nCells = (ClientSize.Width - Cells[0].Location.X) / 55 + 1;
            for(int i = 2; i < nCells; i++)
            {
                PictureBox p = new PictureBox()
                {
                    Name = "pcb" + Cells.Count,
                    Location = new Point(Cells[i - 1].Location.X + 55, Cells[i - 1].Location.Y),
                    Size = new Size(50, 50),
                    BackColor = Color.White,
                };
                Controls.Add(p);
                Cells.Add(p);
                CellsType.Add("Empty");
            }
        }

        int selectedCell = 0;
        private async void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!ProgramRunning)
            {
                if (e.KeyCode == Keys.Right && CellsType[selectedCell] == "End")
                {
                    Cells[selectedCell].Top += 10;
                    selectedCell = 0;
                    Cells[selectedCell].Top -= 10;
                }
                else if (e.KeyCode == Keys.Right && selectedCell < Cells.Count - 1)
                {
                    NextCell();
                }
                if (e.KeyCode == Keys.Left && selectedCell > 0)
                {
                    PreviousCell();
                }
                if (selectedCell != 0)
                {
                    if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
                    {
                        Cells[selectedCell].BackColor = Color.White;
                        CellsType[selectedCell] = "Empty";
                    }
                    if (e.KeyCode == Keys.Oemplus)
                    {
                        Cells[selectedCell].BackColor = Color.Blue;
                        CellsType[selectedCell] = "Plus";
                    }
                    if (e.KeyCode == Keys.OemMinus)
                    {
                        Cells[selectedCell].BackColor = Color.Yellow;
                        CellsType[selectedCell] = "Minus";
                    }
                    if (e.KeyCode == Keys.Oemcomma)
                    {
                        Cells[selectedCell].BackColor = Color.Orange;
                        CellsType[selectedCell] = "Input";
                    }
                    if (e.KeyCode == Keys.OemPeriod)
                    {
                        Cells[selectedCell].BackColor = Color.Cyan;
                        CellsType[selectedCell] = "Output";
                    }
                    if (e.KeyCode == Keys.E)
                    {
                        Cells[selectedCell].BackColor = Color.Purple;
                        CellsType[selectedCell] = "End";
                    }
                }
                if (e.KeyCode == Keys.Enter && selectedCell == 0)
                {
                    RunProgram();
                }
            }
            
            if(e.KeyCode == Keys.Escape && ProgramRunning)
            {
                List<string> a = new List<string>(CellsType);
                CellsType.Clear();
                await Task.Delay(200);
                CellsType = new List<string>(a);
            }
        }

        bool ProgramRunning = false;
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (selectedCell != 0 && !ProgramRunning)
            {
                if (e.KeyChar == '<')
                {
                    Cells[selectedCell].BackColor = Color.Green;
                    CellsType[selectedCell] = "Previous";
                }
                if (e.KeyChar == '>')
                {
                    Cells[selectedCell].BackColor = Color.Red;
                    CellsType[selectedCell] = "Next";
                }
                if (e.KeyChar == '[')
                {
                    Cells[selectedCell].BackColor = Color.Black;
                    CellsType[selectedCell] = "StartLoop";
                }
                if (e.KeyChar == ']')
                {
                    Cells[selectedCell].BackColor = Color.DarkGray;
                    CellsType[selectedCell] = "EndLoop";
                }
            }
        }

        private async void RunProgram()
        {
            ProgramRunning = true;
            lbl_OutputLetters.Text = "";
            lbl_OutputNumber.Text = "";
            Label[] Memories = new Label[5];
            int x = 4;
            foreach(Control c in Controls)
            {
                if(c is Label && c != lbl_OutputLetters && c != lbl_OutputNumber)
                {
                    c.Text = "00";
                    Memories[x] = (Label)c;
                    x--;
                }
            }
            int[] MemoriesValue = {0, 0, 0, 0, 0};
            int selectedMemory = 0;
            Memories[0].BackColor = Color.White;
            for(int i = 1; i < CellsType.Count; i++)
            {
                switch (CellsType[i])
                {
                    case "Start":
                        break;
                    case "Empty":
                        break;
                    case "Plus":
                        MemoriesValue[selectedMemory]++;
                        Memories[selectedMemory].Text = MemoriesValue[selectedMemory].ToString();
                        break;
                    case "Minus":
                        MemoriesValue[selectedMemory]--;
                        Memories[selectedMemory].Text = MemoriesValue[selectedMemory].ToString();
                        break;
                    case "Previous":
                        Memories[selectedMemory].BackColor = BackColor;
                        selectedMemory--;
                        Memories[selectedMemory].BackColor = Color.White;
                        break;
                    case "Next":
                        Memories[selectedMemory].BackColor = BackColor;
                        selectedMemory++;
                        Memories[selectedMemory].BackColor = Color.White;
                        break;
                    case "Input":
                        Random rand = new Random();
                        MemoriesValue[selectedMemory] = rand.Next(1, 99);//
                        Memories[selectedMemory].Text = MemoriesValue[selectedMemory].ToString();
                        break;
                    case "Output":
                        lbl_OutputNumber.Text = MemoriesValue[selectedMemory].ToString();
                        lbl_OutputLetters.Text += (char)(MemoriesValue[selectedMemory] + 64);
                        break;
                    case "StartLoop":
                        break;
                    case "EndLoop":
                        if (MemoriesValue[selectedMemory] != 0)
                        {
                            while (CellsType[selectedCell] != "StartLoop")
                            {
                                PreviousCell();
                                i--;
                            }
                            PreviousCell();
                            i--;
                        }
                        break;
                    case "End":
                        NextCell();
                        return;
                    default:
                        break;
                }
                NextCell();
                await Task.Delay(50);
            }
            ProgramRunning = false;
        }

        private void NextCell()
        {
            Cells[selectedCell].Top += 10;
            selectedCell++;
            Cells[selectedCell].Top -= 10;
        }
        private void PreviousCell()
        {
            Cells[selectedCell].Top += 10;
            selectedCell--;
            Cells[selectedCell].Top -= 10;
        }
    }
}
