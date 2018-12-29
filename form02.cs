 using System;
 using System.Drawing;
 using System.Windows.Forms;
 
 class form02
 {
     public static void Main()
     {
         MyForm mf = new MyForm();
         Application.Run(mf);
     }
 }
 
 class MyForm : Form
 {
    public MyForm()
    {
        BackColor = SystemColors.Window;
    }
}
 
 
