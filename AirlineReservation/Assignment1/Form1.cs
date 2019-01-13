using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Taraneh Khaleghi
/// 7725062
/// 2018.05.29
/// Assn1
/// </summary>
namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[,] airlineReserve = new string[5, 3];
        Button[,] buttonSeat = new Button[5, 3];
        string[] waitingList = new string[10];
        int count = 0;
        int i;
        int j;
        int k = 0;
        private void Form1_Load(object sender, EventArgs e)//initalize buttons to the array//
        {
            buttonSeat[0, 0] = button00;
            buttonSeat[0, 1] = button01;
            buttonSeat[0, 2] = button02;
            buttonSeat[1, 0] = button10;
            buttonSeat[1, 1] = button11;
            buttonSeat[1, 2] = button12;
            buttonSeat[2, 0] = button20;
            buttonSeat[2, 1] = button21;
            buttonSeat[2, 2] = button22;
            buttonSeat[3, 0] = button30;
            buttonSeat[3, 1] = button31;
            buttonSeat[3, 2] = button32;
            buttonSeat[4, 0] = button40;
            buttonSeat[4, 1] = button41;
            buttonSeat[4, 2] = button42;
        }
        private void bookButton_Click(object sender, EventArgs e)       //book the selected seat//
        {
            if (listBox1.Text == "" || listBox2.Text == "")
            {
                MessageBox.Show("Please choose a seat that you want to book");
            }
            else
            {
                i = listBox1.SelectedIndex;
                j = listBox2.SelectedIndex;
                if (nameTextBox.Text == "" || nameTextBox.Text == "Please enter your name")
                {
                    nameTextBox.Text = "Please enter your name";
                }
                else
                {
                    if (buttonSeat[i, j].BackColor == Color.Red)
                    {
                        MessageBox.Show("This seat is reserved before, Please choose a green button or add your name to the waiting list");
                        nameTextBox.Text = "";
                    }
                    else
                    {
                        airlineReserve[i, j] = nameTextBox.Text;
                        buttonSeat[i, j].BackColor = Color.Red;    
                        nameTextBox.Text = "";
                        displayStatuslabel.Text = "";
                        MessageBox.Show(airlineReserve[i, j] + " , your seat reserved");
                    }                 
                }
            }
        }
        private void statusButton_Click(object sender, EventArgs e)     //show the status of the selected seat//
        {
            i = listBox1.SelectedIndex;
            j = listBox2.SelectedIndex;
            if (airlineReserve[i, j] == null)
            {
                displayStatuslabel.Text = "Availabe";
            }
            else
            {
                displayStatuslabel.Text = "Unavailable";
            }
        }
        private void showAllButton_Click(object sender, EventArgs e)     //display all the seats//
        {
            string displayAll = "";
            displayShowAll.Text = "";

            for (int i = 0; i <= airlineReserve.GetUpperBound(0); i++)
            {
                //displayAll += "\n\n";
                for (int j = 0; j <= airlineReserve.GetUpperBound(1); j++)
                {
                    if (airlineReserve[i, j] == null)
                    {
                        displayAll += " Seat " + i + " - " + j+ " is available"+"\n";

                    }
                    else
                    {
                        displayAll += " Reserved by " + airlineReserve[i, j] + "\n";
                    }
                }
            }
            displayShowAll.Text = displayAll;
        }
        private void nameTextBox_Click(object sender, EventArgs e)   //empty  the name of the textbox//
        {
            nameTextBox.Text = "";
        }
        
        private void button00_Click(object sender, EventArgs e) //select the list box items according to the selected buttons//
        {
            displayStatuslabel.Text = "";
            listBox1.SetSelected(0, true);
            listBox2.SetSelected(0, true);
        }
        private void button01_Click(object sender, EventArgs e)
        {
            displayStatuslabel.Text = "";
            listBox1.SetSelected(0, true);
            listBox2.SetSelected(1, true);
        }
        private void button02_Click(object sender, EventArgs e)
        {
            displayStatuslabel.Text = "";
            listBox1.SetSelected(0, true);
            listBox2.SetSelected(2, true);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            displayStatuslabel.Text = "";
            listBox1.SetSelected(1, true);
            listBox2.SetSelected(0, true);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            displayStatuslabel.Text = "";
            listBox1.SetSelected(1, true);
            listBox2.SetSelected(1, true);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            displayStatuslabel.Text = "";
            listBox1.SetSelected(1, true);
            listBox2.SetSelected(2, true);
        }
        private void button20_Click(object sender, EventArgs e)
        {
            displayStatuslabel.Text = "";
            listBox1.SetSelected(2, true);
            listBox2.SetSelected(0, true);
        }
        private void button21_Click(object sender, EventArgs e)
        {
            displayStatuslabel.Text = "";
            listBox1.SetSelected(2, true);
            listBox2.SetSelected(1, true);
        }
        private void button22_Click(object sender, EventArgs e)
        {
            displayStatuslabel.Text = "";
            listBox1.SetSelected(2, true);
            listBox2.SetSelected(2, true);
        }
        private void button30_Click(object sender, EventArgs e)
        {
            displayStatuslabel.Text = "";
            listBox1.SetSelected(3, true);
            listBox2.SetSelected(0, true);
        }
        private void button31_Click(object sender, EventArgs e)
        {
            displayStatuslabel.Text = "";
            listBox1.SetSelected(3, true);
            listBox2.SetSelected(1, true);
        }
        private void button32_Click(object sender, EventArgs e)
        {
            displayStatuslabel.Text = "";
            listBox1.SetSelected(3, true);
            listBox2.SetSelected(2, true);
        }
        private void button40_Click(object sender, EventArgs e)
        {
            displayStatuslabel.Text = "";
            listBox1.SetSelected(4, true);
            listBox2.SetSelected(0, true);
        }
        private void button41_Click(object sender, EventArgs e)
        {
            displayStatuslabel.Text = "";
            listBox1.SetSelected(4, true);
            listBox2.SetSelected(1, true);
        }
        private void button42_Click(object sender, EventArgs e)
        {
            displayStatuslabel.Text = "";
            listBox1.SetSelected(4, true);
            listBox2.SetSelected(2, true);
        }
        private void cancelButton_Click(object sender, EventArgs e)    //cancel the reservation and reserve the seat for the first person in the waitinglist//                                                                        //the cancelled seat to the first person in the waiting list//
        {
            if (listBox1.Text == "" || listBox2.Text == "")
            {
                MessageBox.Show("Please choose a seat that you want to cancel");
            }
            else
            {
                i = listBox1.SelectedIndex;
                j = listBox2.SelectedIndex;
                airlineReserve[i, j] = null;
                buttonSeat[i, j].BackColor = Color.YellowGreen;
                MessageBox.Show(" reservation is cancelled, the seat is availble");
                if (waitingList[0] != null)
                {
                    airlineReserve[i, j] = waitingList[0];
                    MessageBox.Show(airlineReserve[i, j] + " reserved at seat " + i + "-" + j);
                    for (k = 0; k < 9; k++)
                    {
                        waitingList[k] = waitingList[k + 1];
                    }
                    waitingList[9] = null;
                    buttonSeat[i, j].BackColor = Color.Red;
                }
            }
        }
        private void fillAllButton_Click(object sender, EventArgs e)  //reserve all the seats at the same time//
        {
            for (int i = 0; i <= airlineReserve.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= airlineReserve.GetUpperBound(1); j++)
                {
                    buttonSeat[i, j].BackColor = Color.Red;
                    airlineReserve[i, j] = "Reseved";
                }
            }
        }
        private void showWaitingListButton_Click(object sender, EventArgs e)  //display all the waiting list's names//
        {
            string displayAll = "";
            displayWaiting.Text = "";
            for (int k = 0; k < waitingList.Length; k++)
            {
                displayAll += waitingList[k]+"\n";
            }
            displayWaiting.Text = displayAll;
        }
        private void addToWaitingButton_Click(object sender, EventArgs e)  //add the name of the user to the waiting list if all seats are reserved//
        {
            count = 0;
            for (int i = 0; i <= airlineReserve.GetUpperBound(0); i++)
                    {
                        for (int j = 0; j <= airlineReserve.GetUpperBound(1); j++)
                        {
                            if (buttonSeat[i, j].BackColor == Color.Red)
                            {
                                count++;
                            }
                        }
                    }
            if (count == 15)
            {
                if (nameTextBox.Text == "")
                {
                    nameTextBox.Text = "Please Enter Your Name";
                }
                else
                {
                    if (k < 10)
                    {
                        waitingList[k] = nameTextBox.Text;
                        k = k + 1;
                        MessageBox.Show(nameTextBox.Text+" your name has been reserved in the waiting list");
                        nameTextBox.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Waiting List Is Full");
                    }
                }
            }
            else
            {
                MessageBox.Show("Sorry,You can't add your name to the waiting list!You can book the green seat.");
            }
        }
    }
}

