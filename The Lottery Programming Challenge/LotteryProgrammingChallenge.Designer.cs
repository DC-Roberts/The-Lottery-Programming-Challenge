namespace The_Lottery_Programming_Challenge
{
  partial class LotteryForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.GenerateRandomNumbers = new System.Windows.Forms.Button();
      this.LotteryNumbers = new System.Windows.Forms.RichTextBox();
      this.SuspendLayout();
      // 
      // GenerateRandomNumbers
      // 
      this.GenerateRandomNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.GenerateRandomNumbers.Location = new System.Drawing.Point(12, 97);
      this.GenerateRandomNumbers.Name = "GenerateRandomNumbers";
      this.GenerateRandomNumbers.Size = new System.Drawing.Size(171, 42);
      this.GenerateRandomNumbers.TabIndex = 0;
      this.GenerateRandomNumbers.Text = "Generate";
      this.GenerateRandomNumbers.UseVisualStyleBackColor = true;
      this.GenerateRandomNumbers.Click += new System.EventHandler(this.GenerateRandomNumbers_Click);
      // 
      // LotteryNumbers
      // 
      this.LotteryNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LotteryNumbers.Location = new System.Drawing.Point(12, 12);
      this.LotteryNumbers.Multiline = false;
      this.LotteryNumbers.Name = "LotteryNumbers";
      this.LotteryNumbers.ReadOnly = true;
      this.LotteryNumbers.Size = new System.Drawing.Size(776, 79);
      this.LotteryNumbers.TabIndex = 1;
      this.LotteryNumbers.Text = "";
      // 
      // LotteryForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 148);
      this.Controls.Add(this.LotteryNumbers);
      this.Controls.Add(this.GenerateRandomNumbers);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "LotteryForm";
      this.ShowIcon = false;
      this.Text = "Lottery Programming Challenge";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button GenerateRandomNumbers;
    private System.Windows.Forms.RichTextBox LotteryNumbers;
  }
}

