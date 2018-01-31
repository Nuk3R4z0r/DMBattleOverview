using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMBattleOverview
{
    public partial class Form1 : Form
    {
        bool[] _numbersInUse;
        CryptoRandom _rnd;
        string[] attributes;
        int turnCounter;

        public Form1()
        {
            InitializeComponent();
            _numbersInUse = new bool[50];
            _rnd = new CryptoRandom();
            attributes = new string[5];
            lDataBox.View = View.Details;
            lDataBox.GridLines = true;
            lDataBox.FullRowSelect = true;
            lDataBox.HideSelection = false;
            lDataBox.MultiSelect = false;
            turnCounter = 0;
        }

        private void bMonInsert_Click(object sender, EventArgs e)
        {
            if (cNameBox.Text.Trim(' ') != "" && (tInsertNumber.Text.Trim(' ') != "" || cNumberBox.Checked))
            {
                //NUMBER
                int number = 0;
                if (cNumberBox.Checked == true)
                    number = GetNumber();
                else
                    number = Convert.ToInt32(tInsertNumber.Text);
                _numbersInUse[number] = true;


                //INITIATIVE
                int mod = 0;
                if (tIniModBox.Text.Trim(' ') != "")
                    mod = Convert.ToInt16(tIniModBox.Text);

                int initiative = (int)_rnd.Next(1, 20) + mod;
                if (cRollBox.Checked == true)
                    initiative = (int)_rnd.Next(1, 20) + mod;
                else
                    initiative = mod;

                //GENDER
                string gender = cInsertGender.Text;
                if(cInsertGender.Text == "Random")
                {
                    int test = (int)_rnd.Next(0, 1);

                    if(test == 0)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }
                }

                ListSortAdd(new string[] { initiative.ToString(), number.ToString(), cNameBox.Text, tInsertHealthBox.Text, gender });

                lDataBox.Items[turnCounter].Selected = true;
            }
        }

        int GetNumber()
        {
            int number = 0;

            foreach (bool b in _numbersInUse)
            {
                if (b == false)
                    break;
                else
                    number++;
            }

            return number;
        }
        
        private void ListSortAdd(string[] newItem)
        {
            int listSize = lDataBox.Items.Count;
            ListViewItem item = new ListViewItem(newItem);

            if (listSize != 0)
            {
                for (int i = 0; i < listSize; i++)
                {
                    int nextInitiative = Convert.ToInt32(lDataBox.Items[i].SubItems[0].Text);

                    if(nextInitiative < Convert.ToInt32(newItem[0]))
                    {
                        lDataBox.Items.Insert(i, item);
                        break;
                    }
                    else if(i == lDataBox.Items.Count - 1)
                    {
                        lDataBox.Items.Insert(i + 1, item);
                        break;
                    }
                }
            }
            else
            {
                lDataBox.Items.Insert(0, item);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lDataBox.Items.Clear();
            for(int i = 0; i < _numbersInUse.Length; i++)
                _numbersInUse[i] = false;
        }

        private void lDataBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lDataBox.Items.Count > 0 && lDataBox.SelectedIndices.Count > 0)
            {
                for(int i = 0; i < attributes.Length; i++)
                    attributes[i] = lDataBox.Items[lDataBox.SelectedIndices[0]].SubItems[i].Text;

                tUpdateIni.Text = attributes[0];
                tUpdateNumber.Text = attributes[1];
                tUpdateName.Text = attributes[2];
                tUpdateHealth.Text = attributes[3];
                cUpdateGender.Text = attributes[4];
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lDataBox.SelectedIndices.Count > 0)
            {
                if (tUpdateIni.Text == attributes[0])
                {
                    ListViewItem item = new ListViewItem(new string[] { tUpdateIni.Text, tUpdateNumber.Text, tUpdateName.Text, tUpdateHealth.Text, cUpdateGender.Text });
                    lDataBox.Items[lDataBox.SelectedIndices[0]] = item;
                }
                else
                {
                    lDataBox.Items.RemoveAt(lDataBox.SelectedIndices[0]);
                    ListSortAdd(new string[] { tUpdateIni.Text, tUpdateNumber.Text, tUpdateName.Text, tUpdateHealth.Text, cUpdateGender.Text });
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lDataBox.Items.Count != 0)
            {
                lDataBox.Items[turnCounter].Selected = false; //releases old selection

                if (turnCounter == lDataBox.Items.Count - 1)
                    turnCounter = 0;
                else
                    turnCounter++;

                lDataBox.Items[turnCounter].Selected = true; //selects the new selection

                lDataBox_SelectedIndexChanged(sender, e);
                if(attributes[1] == "")
                    lblCurrentTurn.Text = attributes[2] + "'s turn!";
                else
                    lblCurrentTurn.Text = attributes[1] + "'s turn!";
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (lDataBox.Items.Count != 0)
            {
                lDataBox.Items[turnCounter].Selected = false; //releases old selection

                if (turnCounter == 0)
                    turnCounter = lDataBox.Items.Count - 1;
                else
                    turnCounter--;

                lDataBox.Items[turnCounter].Selected = true; //selects the new selection

                lDataBox_SelectedIndexChanged(sender, e);
                lblCurrentTurn.Text = attributes[2] + "'s turn!";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lDataBox.Items.RemoveAt(lDataBox.SelectedIndices[0]);
        }

        private void btnPlayerInsert_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 8; i++)
            {
                Control nameBoxes = Controls.Find("tCharacterBox" + i, true)[0];
                Control iniBoxes = playerBoxes.Controls.Find("tCharacterIniBox" + i, true)[0];

                if (nameBoxes.Text.Trim(' ') != "" && iniBoxes.Text.Trim(' ') != "")
                {
                    ListSortAdd(new string[] { iniBoxes.Text, "", nameBoxes.Text, "", "" });
                }
            }
        }
    }
}
