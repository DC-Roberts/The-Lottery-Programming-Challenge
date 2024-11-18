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
    int maxNumbers = 6;
    int minRange = 1;
    int maxRange = 49;

    private void GenerateRandomNumbers_Click(object sender, EventArgs e)
    {
      List<int> list = new List<int>();
      Random r = new Random();
      string generatedNumbers = "";

      while(list.Count < maxNumbers)
      {
        int randomNumber = r.Next(minRange, maxRange);
        if (!list.Contains(randomNumber)) 
        { 
          list.Add(randomNumber);
        }
      }

      list.Sort();

      for(int i = 0; i < list.Count; i++)
      {
        generatedNumbers += list[i] + " ";
      }

      LotteryNumbers.Text = generatedNumbers;
      LotteryNumbers.SelectAll();
      LotteryNumbers.SelectionAlignment = HorizontalAlignment.Center;
    }
  }
}
