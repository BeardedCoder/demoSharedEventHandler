namespace DemoMultipleControlsOneHandler
{
  partial class MainForm
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
      this.firstButton = new System.Windows.Forms.Button();
      this.secondButton = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // firstButton
      // 
      this.firstButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.firstButton.Location = new System.Drawing.Point(12, 112);
      this.firstButton.Name = "firstButton";
      this.firstButton.Size = new System.Drawing.Size(99, 34);
      this.firstButton.TabIndex = 0;
      this.firstButton.Text = "One";
      this.firstButton.UseVisualStyleBackColor = true;
      this.firstButton.Click += new System.EventHandler(this.HandleClick);
      this.firstButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleKeyPress);
      // 
      // secondButton
      // 
      this.secondButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.secondButton.Location = new System.Drawing.Point(117, 112);
      this.secondButton.Name = "secondButton";
      this.secondButton.Size = new System.Drawing.Size(99, 34);
      this.secondButton.TabIndex = 1;
      this.secondButton.Text = "Two";
      this.secondButton.UseVisualStyleBackColor = true;
      this.secondButton.Click += new System.EventHandler(this.HandleClick);
      this.secondButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleKeyPress);
      // 
      // label1
      // 
      this.label1.AutoEllipsis = true;
      this.label1.Location = new System.Drawing.Point(6, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(210, 21);
      this.label1.TabIndex = 2;
      this.label1.Text = "Multiple Controls that share event handlers";
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(9, 43);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(207, 35);
      this.label2.TabIndex = 3;
      this.label2.Text = "The two buttons share a Click handler and a KeyPress handler";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(228, 172);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.secondButton);
      this.Controls.Add(this.firstButton);
      this.Name = "MainForm";
      this.Text = "Demo";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button firstButton;
    private System.Windows.Forms.Button secondButton;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
  }
}

