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
    public partial class PackSelectForm : Form
    {
        public PackSelectForm()
        {
            InitializeComponent();
            CheckAnyErrors();
            UpdatePackList();
        }

        public void CheckAnyErrors()
        {
            string[] FlashCardSaves = System.IO.File.ReadAllLines(@"FlashCards.txt");

            bool ErrorsFound = false;

            if (FlashCardSaves[0] != "Warning: Only Edit If You Know What You Are Doing!")
            {
                ErrorsFound = true;
            }

            if (ErrorsFound == true)
            {
                if (MessageBox.Show("Errors were found where the packs were saved..." + Environment.NewLine + "Do you want to restore from the backup file?", "Error: File Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    string[] BackUpFile = System.IO.File.ReadAllLines(@"BackUp\FlashCards.txt");

                    foreach (string Line in BackUpFile)
                    {
                        if (Line != "-- Saves End At This Line --")
                        {
                            System.IO.File.AppendAllText(@"FlashCards.txt", Line + Environment.NewLine);
                        }
                        else
                        {
                            System.IO.File.AppendAllText(@"FlashCards.txt", Line);
                        }
                    }
                    MessageBox.Show("File has been restored from backup.", "File Restored", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    System.IO.File.WriteAllText(@"FlashCards.txt", String.Empty);

                    System.IO.File.AppendAllText(@"FlashCards.txt", "Warning: Only Edit If You Know What You Are Doing!" + Environment.NewLine + Environment.NewLine);
                    System.IO.File.AppendAllText(@"FlashCards.txt", "-- Packs Start Here --" + Environment.NewLine + Environment.NewLine);
                    System.IO.File.AppendAllText(@"FlashCards.txt", "-- Flash Cards Start Here --" + Environment.NewLine + Environment.NewLine);
                    System.IO.File.AppendAllText(@"FlashCards.txt", "-- Saves End At This Line --");

                    MessageBox.Show("File restored to defaults", "File Restored", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void UpdatePackList()
        {
            PackList.Items.Clear();
            string[] FlashCardSaves = System.IO.File.ReadAllLines("FlashCards.txt");

            bool StartHere = false;

            foreach (string Line in FlashCardSaves)
            {
                if (Line == "-- Packs Start Here --")
                {
                    StartHere = true;
                }
                else if (Line == "-- Flash Cards Start Here --")
                {
                    break;
                }
                else if (StartHere && Line.Length > 0)
                {
                    PackList.Items.Add(Line);
                }
            }
        }

        private void OpenPackButton_Click(object sender, EventArgs e)
        {
            if (PackList.SelectedItem != null)
            {
                this.Hide();
                OpenPack OpenPack = new OpenPack(Convert.ToString(PackList.SelectedItem));
                OpenPack.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Error: No pack selected, please select a pack to open.", "Error: No Selected Pack", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreatePackButton_Click(object sender, EventArgs e)
        {
            CreatePackOpenPack CreatePackOpenPack = new CreatePackOpenPack("Create Pack");
            CreatePackOpenPack.ShowDialog();
            UpdateList();
        }

        private void DeletePack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this pack?", "Delete Pack", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                DeleteSelectedPack(Convert.ToString(PackList.SelectedItem));
                UpdateList();
            }
        }

        public void UpdateList()
        {
            PackList.Items.Clear();
            string[] FlashCardSaves = System.IO.File.ReadAllLines(@"FlashCards.txt");

            bool StartHere = false;

            foreach (string Line in FlashCardSaves)
            {
                if (Line == "-- Packs Start Here --")
                {
                    StartHere = true;
                }
                else if (Line == "-- Flash Cards Start Here --")
                {
                    break;
                }
                else if (StartHere && Line.Length > 0)
                {
                    PackList.Items.Add(Line);
                }
            }
        }

        public static void DeleteSelectedPack(string PackName)
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
    }
}
