using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class CreatePackOpenPack : Form
    {
        public static string Mode = "";
        bool FirstSave = false;

        public CreatePackOpenPack(string UpdatedMode)
        {
            InitializeComponent();
            Mode = UpdatedMode;
        }

        private void CreatePackOpenPack_Load(object sender, EventArgs e)
        {
            if (Mode == "Create Pack")
            {
                this.Text = Mode;
            }
            else if (Mode == "Edit Pack")
            {
                this.Text = Mode;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void SaveCardsToPack(string PackName)
        {
            string[] FlashCardSaves = System.IO.File.ReadAllLines(@"FlashCards.txt");
            System.IO.File.WriteAllText(@"FlashCards.txt", String.Empty);

            bool StartHere = false;

            foreach (string Line in FlashCardSaves)
            {
                if (Line == PackName)
                {
                    System.IO.File.AppendAllText("FlashCards.txt", Line + Environment.NewLine);
                    StartHere = true;
                }
                else if (StartHere)
                {
                    foreach (DataGridViewRow Row in CardDataTable.Rows)
                    {
                        string CellLine = "";
                        foreach (DataGridViewCell cell in Row.Cells)
                        {
                            if (cell.Value != null)
                            {
                                CellLine += cell.Value.ToString();
                                CellLine += ":";
                            }
                        }

                        if (CellLine.Length > 0)
                        {
                            CellLine += "End";
                        }

                        System.IO.File.AppendAllText("FlashCards.txt", CellLine + Environment.NewLine);
                    }
                    StartHere = false;
                }
                else
                {
                    System.IO.File.AppendAllText("FlashCards.txt", Line + Environment.NewLine);
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string PackName = "";

            if (Mode == "Create Pack")
            {
                PackName = PackNameTextBox.Text;
                if (FirstSave)
                {
                    CreatePack(PackName);
                    //SaveCardsToPack(PackName);
                }
                else if (!CheckName(PackName))
                {
                    FirstSave = true;
                    CreatePack(PackName);
                    //SaveCardsToPack(PackName);
                }
                else
                {
                    if (MessageBox.Show("Name already taken!" + Environment.NewLine + "Are you sure you want to overwrite it?", "Error: Name Taken", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        FirstSave = true;
                        DeletePack(PackName);
                        CreatePack(PackName);
                        //SaveCardsToPack(PackName);
                    }
                }
            }
            else if (Mode == "Edit Pack")
            {

            }
        }

        public static void CreatePack(string PackName)
        {
            string[] FlashCardSaves = System.IO.File.ReadAllLines(@"FlashCards.txt");
            System.IO.File.WriteAllText(@"FlashCards.txt", String.Empty);

            bool InPackSection = false;
            bool InCardSection = false;

            foreach (string Line in FlashCardSaves)
            {
                if (Line == "-- Packs Start Here --")
                {
                    InPackSection = true;
                    System.IO.File.AppendAllText("FlashCards.txt", Line + Environment.NewLine);
                }
                else if (Line == "-- Flash Cards Start Here --")
                {
                    InPackSection = false;
                    InCardSection = true;
                    System.IO.File.AppendAllText("FlashCards.txt", Line + Environment.NewLine);
                }
                else if (InPackSection && Line != "")
                {
                    System.IO.File.AppendAllText("FlashCards.txt", PackName + Environment.NewLine);
                    System.IO.File.AppendAllText("FlashCards.txt", Line + Environment.NewLine);
                    InPackSection = false;
                }
                else if (InCardSection && Line != "")
                {
                    System.IO.File.AppendAllText("FlashCards.txt", PackName + Environment.NewLine + Environment.NewLine);
                    System.IO.File.AppendAllText("FlashCards.txt", Line + Environment.NewLine);
                    InCardSection = false;
                }
                else
                {
                    System.IO.File.AppendAllText("FlashCards.txt", Line + Environment.NewLine);
                }
            }
        }

        public static void DeletePack(string PackName)
        {
            string[] FlashCardSaves = System.IO.File.ReadAllLines(@"FlashCards.txt");
            System.IO.File.WriteAllText(@"FlashCards.txt", String.Empty);

            bool StartHere = false;

            foreach (string Line in FlashCardSaves)
            {
                if (Line == PackName)
                {
                    StartHere = true;
                }
                else if (Line == "")
                {
                    StartHere = false;
                    System.IO.File.AppendAllText("FlashCards.txt", Line + Environment.NewLine);
                }
                else if (!Line.Contains(":"))
                {
                    StartHere = false;
                    System.IO.File.AppendAllText("FlashCards.txt", Line + Environment.NewLine);
                }
                else if (!StartHere)
                {
                    System.IO.File.AppendAllText("FlashCards.txt", Line + Environment.NewLine);
                }
            }
        }

        public static bool CheckName(string PackName)
        {
            string[] FlashCardSaves = System.IO.File.ReadAllLines(@"FlashCards.txt");

            foreach (string Line in FlashCardSaves)
            {
                if (Line == PackName)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
