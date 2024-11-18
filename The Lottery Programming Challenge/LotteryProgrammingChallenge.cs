using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Lottery_Programming_Challenge
{
  public partial class LotteryForm : Form
  {
    public LotteryForm()
    {
      InitializeComponent();
    }
    string myNumbers = "";
    //Use variables to allow easy scalability 
    int maxNumbers = 6;
    int minRange = 1;
    int maxRange = 49;

    private void GenerateRandomNumbers_Click(object sender, EventArgs e)
    {
      List<int> list = new List<int>();
      Random r = new Random();
      string generatedNumbers = "";

      //While loop to reach the max numbers (6 default, 7 with "bonus ball"
      while(list.Count < maxNumbers)
      {
        //Generate random number within range, use of variables in case 1-49 changes
        int randomNumber = r.Next(minRange, maxRange);
        //If the number is not already in the list, add it, otherwise loop again
        if (!list.Contains(randomNumber)) 
        { 
          list.Add(randomNumber);
        }
      }
      //Numerically sort
      list.Sort();

      //Loop to add list items to a variable, with a space between each number
      for(int i = 0; i < list.Count; i++)
      {
        generatedNumbers += list[i] + " ";
      }

      //Final step to add numbers to the text box
      LotteryNumbers.Text = generatedNumbers;
      LotteryNumbers.SelectAll();
      LotteryNumbers.SelectionAlignment = HorizontalAlignment.Center;
    }
  }
}
