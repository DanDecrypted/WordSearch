using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordSearch
{
    public partial class Form1 : Form
    {
        private List<string> m_WordsToFind;
        private int m_PreviousSelection;
        private int m_GridSize;
        private bool m_GridBuilt;
        private List<string> m_WordsFound;
        public Form1()
        {
            InitializeComponent();
            m_WordsFound = new List<string>();
            m_WordsToFind = new List<string>(new string[]{ "integer", "array", "byte", "boolean", "for", "string", "parameter", "while", "method", "loop" });
            m_PreviousSelection = 0;
            m_GridBuilt = false;
        }

        private string ReversedString(string input)
        {
            string temp = "";
            foreach (char c in input)
            {
                temp = c + temp;
            }
            return temp;
        }

        private void RefreshWords()
        {
            if (lstWords.SelectedIndex != null)
            {
                m_PreviousSelection = lstWords.SelectedIndex;
            }

            lstWords.Items.Clear();

            foreach (string wordToFind in m_WordsToFind)
            {
                lstWords.Items.Add(wordToFind);
            }

            lblWords.Text = "Find these " + m_WordsToFind.Count.ToString() + " words";

            lstWords.SelectedIndex = m_PreviousSelection;

            CreateGrid();
        }

        private void CreateGrid()
        {
            //initialise grid
            m_WordsFound = new List<string>();
            m_GridBuilt = false;
            wordGrid.Columns.Clear();
            wordGrid.Rows.Clear();
            if (txtSize.Text != "" && txtSize != null)
            {
                m_GridSize = Convert.ToInt32(txtSize.Text);
                for (int i = 0; i < m_GridSize; i++)
                {
                    wordGrid.Columns.Add("x" + i.ToString(), "x" + i.ToString());
                }
                wordGrid.Rows.Add(m_GridSize - 1);

                Random rndNumber = new Random();
                foreach (string word in m_WordsToFind)
                {
                    bool wordInserted = false;
                    while (!wordInserted)
                    {
                        int xStart = rndNumber.Next(0, m_GridSize - 1);
                        int yStart = rndNumber.Next(0, m_GridSize - 1);
                        int direction = rndNumber.Next(1, 5);
                        wordInserted = InsertWord(direction, word, xStart, yStart, true);
                    }
                }

                for (int x = 0; x < m_GridSize; x++)
                {
                    for (int y = 0; y < m_GridSize; y++)
                    {
                        if (wordGrid[x, y].Value == null)
                            wordGrid[x, y].Value = (char)('a' + rndNumber.Next(0, 26));
                    }
                }
            }
            m_GridBuilt = true;
        }

        private bool InsertWord(int direction, string word, int x, int y, bool checkFit)
        {
            bool canFit = true;
            int xWrapSafe = x;
            int yWrapSafe = y;
            for (int i = 0; i < word.Length; i++)
            {
                if (direction == 1)
                {
                    if (x - i < 0)
                        xWrapSafe = m_GridSize + (x - i);
                    else
                        xWrapSafe = x - i;
                }
                //down
                else if (direction == 2)
                {
                    if (y + i >= m_GridSize)
                        yWrapSafe = 0 + ((y + i) - m_GridSize);
                    else
                        yWrapSafe = y + i;
                }
                //right
                if (direction == 3)
                {
                    if (x + i >= m_GridSize)
                        xWrapSafe = 0 + ((x + i) - m_GridSize);
                    else
                        xWrapSafe = x + i;
                }
                //up
                else if (direction == 4)
                {
                    if (y - i < 0)
                        yWrapSafe = (m_GridSize + (y - i));
                    else
                        yWrapSafe = y - i;
                }

                if (checkFit)
                {
                    if (wordGrid[xWrapSafe, yWrapSafe].Value != null)
                    {
                        canFit = false;
                    }
                }
                else
                    wordGrid[xWrapSafe, yWrapSafe].Value = word[i];
            }

            if (checkFit && canFit)
            {
                //checked that the word can fit, so now we can put it in 
                InsertWord(direction, word, x, y, false);
                System.Diagnostics.Debug.Write("Word " + word + " inserted x:" + x + " y:" + y + " direction:" + direction + " \n");
            }
            return canFit;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshWords();
            lstWords.SelectedIndex = 0;
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            if (txtAdd.Text != "" && txtAdd.Text != null)
            {
                m_WordsToFind.Add(txtAdd.Text);
                RefreshWords();
            }
        }

        private void lstWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEdit.Text = lstWords.Items[lstWords.SelectedIndex].ToString();
        }

        private void btnEditWord_Click(object sender, EventArgs e)
        {
            if (txtEdit.Text != "" && txtEdit.Text != null)
            {
                m_WordsToFind[lstWords.SelectedIndex] = txtEdit.Text;
                RefreshWords();
            }
        }

        private void btnGridSize_Click(object sender, EventArgs e)
        {
            CreateGrid();
        }

        private void wordGrid_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (m_GridBuilt)
            {
                string selectedWord = "";
                foreach (DataGridViewCell cell in wordGrid.SelectedCells)
                {
                    selectedWord += cell.Value.ToString();
                }

                foreach (string word in m_WordsToFind)
                {
                    if ((word == selectedWord) || (word == ReversedString(selectedWord)))
                    {
                        foreach (DataGridViewCell cell in wordGrid.SelectedCells)
                        {
                            cell.Style.BackColor = Color.Green;
                            if (!m_WordsFound.Contains(word))
                            {
                                m_WordsFound.Add(word);
                                MessageBox.Show("Congratulations, You have found \"" + word + "\". " + m_WordsFound.Count.ToString() + "/" + m_WordsToFind.Count.ToString(), "Word Found!");
                            }
                        }
                    }
                }
            }
        }
    }
}
