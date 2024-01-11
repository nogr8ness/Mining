using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;

namespace ChamaBasinMiner
{
    public partial class Form1 : Form
    {
        private int currentStep;

        private string mineralSymbol;
        private string mineralName;
        private int mineralTonnage;
        
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            //SC1
            makeLabel(20, 40, "How many minerals types do you want to create?");
            currentStep = 1;
        }

        //SC2
        private void makeLabel(int x, int y, String str)
        {
            Label label = new Label();
            label.Text = str;
            label.Location = new Point(x, y);
            label.AutoSize = true;

            Controls.Add(label);
        }

        
        private void userInputInt()
        {
            //SC3
            try
            {
                int numMinerals = Convert.ToInt32(txtEntry.Text);

                //SC4
                if(numMinerals <= 0 || numMinerals > 10)
                {
                    MessageBox.Show("Your entry needs to be greater than 0 and NOT greater than 10. \nPlease enter a new number", "Error");
                }
                else
                {
                    makeLabel(10, 40, "You selected to create " + numMinerals + " minerals.");
                    makeLabel(10, 60, "You will now enter the mineral symbol...");
                    makeLabel(10, 80, "Please enter the three to five alphanumeric mineral...");

                    btnEnterData.Location = new Point(100, 100);
                    txtEntry.Location = new Point(20, 100);

                    currentStep++;
                }
            }
            catch
            {
                MessageBox.Show("You entered an improper value. Please enter a whole number.", "Error");
            }
        }

        
        private void Next_Click(object sender, EventArgs e)
        {
            //SC5
            if(currentStep == 1)
            {
                userInputInt();
                return;
            }

            if(currentStep == 2)
            {
                userInputMineralSymbol();
                return;
            }
            
            if(currentStep == 3)
            {
                userInputTempMineralName();
                return;
            }

            if(currentStep == 4)
            {
                userInputTempTonnage();
                return;                
            }
        }
    
        private void makeMineralsProcess(String str)
        {
           
        }
        
        //SC7
        private void userInputMineralSymbol()
        {
            if(txtEntry.TextLength < 3 || txtEntry.TextLength > 5)
            {
                MessageBox.Show("That is an improper value. Please try again.", "Error");
            }
            else
            {
                txtEntry.Location = new Point(20, 140);
                btnEnterData.Location = new Point(100, 140);

                makeLabel(10, 120, "Please enter the mineral name...");

                currentStep++;
                mineralSymbol = txtEntry.Text;
            }
        }
        
        //SC8
        private void userInputTempMineralName()
        {
            mineralName = txtEntry.Text;

            makeLabel(10, 160, "Please enter the total amount of tons...");
            txtEntry.Location = new Point(100, 180);
            btnEnterData.Location = new Point(20, 180);

            currentStep++;
        }
        
        //SC9
        private void userInputTempTonnage()
        {
            
            //SC10
            try
            {
                int tonnage = Convert.ToInt32(txtEntry.Text);

                mineralTonnage = tonnage;

                Minerals mineral = new Minerals(mineralSymbol, mineralName, mineralTonnage);

                makeLabel(10, 200, mineral.ToString());
            }
            catch
            {
                MessageBox.Show("You entered an improper value. Please enter a whole number.", "Error");
            }
        }

        //SC11 already works
        private void Enter_KeyDown(object sender, KeyEventArgs e)
        {

        }
        
    }
}


