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
    public partial class OpenPack : Form
    {
        string PackName = "";
        string Word = "";
        string Description = "";
        int PackLength = 0;
        int SkipNumber = 0;
        int LineNumber = 0;

        public OpenPack(string PackName)
        {
            InitializeComponent();
            WordTextBox.TabStop = false;
            DescriptionTextBox.TabStop = false;
            this.PackName = PackName;
        }

        private void OpenPack_Load(object sender, EventArgs e)
        {
            string[] FlashCardSaves = System.IO.File.ReadAllLines(@"FlashCards.txt");

            bool InPacks = false;
            bool RightPack = false;
            bool StartCounting = false;

            foreach (string Line in FlashCardSaves)
            {
                if (Line == "-- Flash Cards Start Here --")
                {
                    InPacks = true;
                }
                else if (InPacks && Line == PackName)
                {
                    RightPack = true;
                }
                else if (InPacks && RightPack)
                {
                    LineNumber = Array.IndexOf(FlashCardSaves, Line);
                    RightPack = false;
                    StartCounting = true;
                }
                else if (Line == "")
                {
                    StartCounting = false;
                }
                else if (StartCounting)
                {
                    PackLength++;
                }
            }

            GetWordDes();
            WordTextBox.Text = Word;
            DescriptionTextBox.Text = Description;
        }

        public void GetWordDes()
        {
            string[] FlashCardSaves = System.IO.File.ReadAllLines(@"FlashCards.txt");
            string ActiveWord = FlashCardSaves[LineNumber + SkipNumber];

            int ColonNumber = 0;
            string WordBeingFound = "";

            foreach (char Letter in ActiveWord)
            {
                if (Letter != Convert.ToChar(":"))
                {
                    WordBeingFound += Letter;
                }
                else if (ColonNumber == 0)
                {
                    Word = WordBeingFound;
                    WordBeingFound = "";
                    ColonNumber++;
                }
                else if (ColonNumber == 1)
                {
                    Description = WordBeingFound;
                    WordBeingFound = "";
                    ColonNumber++;
                    break;
                }
                else
                {
                    ColonNumber++;
                }
            }
        }

        private void PreviousCardButton_Click(object sender, EventArgs e)
        {
            if (SkipNumber != 0)
            {
                SkipNumber--;
            }
            GetWordDes();
            WordTextBox.Text = Word;
            DescriptionTextBox.Text = Description;
            DescriptionTextBox.Visible = false;
            ShowHideDescriptionButton.Text = "Show Description";
        }

        private void ShowHideDescriptionButton_Click(object sender, EventArgs e)
        {
            if (DescriptionTextBox.Visible)
            {
                ShowHideDescriptionButton.Text = "Show Description";
                DescriptionTextBox.Visible = !DescriptionTextBox.Visible;
            }
            else
            {
                ShowHideDescriptionButton.Text = "Hide Description";
                DescriptionTextBox.Visible = !DescriptionTextBox.Visible;
            }
        }

        private void NextCardButton_Click(object sender, EventArgs e)
        {
            if (SkipNumber != PackLength)
            {
                SkipNumber++;
            }
            GetWordDes();
            WordTextBox.Text = Word;
            DescriptionTextBox.Text = Description;
            DescriptionTextBox.Visible = false;
            ShowHideDescriptionButton.Text = "Show Description";
        }
    }
}
