using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace towerOfHanoi
{

    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        public double speed = 1;
    public int num = 0;
    public Panel[] arr;
    
    public Label x = new Label();
    
    public Label[] myarr = new Label[20];
        // int xi = 0;
        //int co = 0;

        // ask people about time and stuff


        public async void towerOfHanoi(int n, char from_rod,
                       char to_rod, char m_rod)
    {
            /*
        myarr[co] = new Label();
      //  myarr[co].Text = $"towerOfHanoi( {n} , {from_rod}  , {to_rod}  , {m_rod})  ";
        myarr[co].Location = new Point(1000, 476 - xi);
         //   422, 384
        myarr[co].Size = new Size(170, 60);
        xi += 30;


        this.Controls.Add(myarr[co]); myarr[co].BringToFront();
  
        co++;
            */
            if (n == 0)
        {



                return; 
        }
            
            towerOfHanoi(n - 1, from_rod, m_rod, to_rod);
            // Task.Delay(2000);  

            // itemm.Focus();
            Task.Delay(TimeSpan.FromSeconds(speed)).Wait();
            if (to_rod == 'B') //  422, 385  
            arr[n].Location = new Point(422 + (num - n -1) * 10, 385 - (num - n - 1 ) * 23);
        if (to_rod == 'C')
            arr[n].Location = new Point(722 + (num - n -1) * 10, 385 - (num - n - 1 ) * 23);
        if (to_rod == 'A')
            arr[n].Location = new Point(118 + (num - n -1) * 10, 385 - (num - n- 1) * 23);
            //  Console.WriteLine("Move disk " + n + " from rod " + from_rod + " to rod " + to_rod);
            towerOfHanoi(n - 1, m_rod, to_rod, from_rod); 
        }
    public void addToStack(string s)
        {
            Button temp = new Button();
            temp.Text = s ;

            stackFlowPanel.Controls.Add(temp);

        }
    private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startB_Click(object sender, EventArgs e)
        {
            string s = speedCb.Text;
            if (s == "5x") { speed = 0.5; } else if (s == "4x") { speed = 1; } else if (s == "3x") { speed = 2; } else if (s == "2x") { speed = 3; } else if (s == "1x") { speed = 4; } else if (s == "0.5x") { speed = 5; }
            
            
            
            
            num = int.Parse(numTb.Text) + 1;
            arr = new Panel[num];
            makeNewBars(num);

            Task.Factory.StartNew(() =>towerOfHanoi(num - 1, 'A', 'C', 'B') );

            
        }

        private void removeB_Click(object sender, EventArgs e)
        {
            removerLab();
        }
        private void removerLab()
        {
            for (int i = num - 1; i != 0; i--)
            {


                this.Controls.Remove(arr[i]);
            }
        }
        public void makeNewBars(int num)
            {


            int xo = 0, yo = 0;
            for (int i = num -1 ; i != 0; i--)
            {
               // addToStack("towerOfHanoi( { n }, { from_rod}  , { to_rod}  , { m_rod})  ");

                arr[i] = new Panel();
                arr[i].BorderStyle = BorderStyle.FixedSingle;
                arr[i].Location = new Point(118 + xo / 2, 385 - yo);
                arr[i].BackColor = Color.White;
                arr[i].Size = new Size(256 - xo, 22);


                //arr[i].Focus();
                yo += 23;
                xo += 20;

               this.Controls.Add(arr[i]); arr[i].BringToFront();
            }
        }

        private void numTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
