using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Experiment
{
    public partial class Form1 : Form
    {
        int scorx;
        Random rn = new Random();
        
        public Form1()
        {
            InitializeComponent();
            l2.Text = "500";
            scorx = 500;

            this.btn1.Location = new System.Drawing.Point(rn.Next(0,360),rn.Next(0,600));
            this.btn2.Location = new System.Drawing.Point(rn.Next(0, 334), rn.Next(0, 432));
            this.btn3.Location = new System.Drawing.Point(rn.Next(0, 339), rn.Next(0, 424));
            this.btn4.Location = new System.Drawing.Point(rn.Next(0,383), rn.Next(0, 440));
            this.btn5.Location = new System.Drawing.Point(rn.Next(0, 380), rn.Next(0, 469));
            this.btn6.Location = new System.Drawing.Point(rn.Next(0, 337), rn.Next(0, 436));
            this.btn7.Location = new System.Drawing.Point(rn.Next(0, 387), rn.Next(0, 440));
            this.btn8.Location = new System.Drawing.Point(rn.Next(0, 353), rn.Next(0, 434));
            this.btn9.Location = new System.Drawing.Point(rn.Next(0, 341), rn.Next(0, 469));
            this.btn10.Location = new System.Drawing.Point(rn.Next(0, 375), rn.Next(0, 439));

         /*   Button startbtn = new Button();
            this.Visible = true;*/
          
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.Text="1";
            chk(btn1);
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            
            btn2.Text = "1";
            chk(btn2);
            btn1.Text = "";
            
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
           
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            
            btn3.Text = "2";
            
            
            chk1(btn3);
            btn1.Text = "";
            btn2.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            
            btn4.Text = "2";
            chk1(btn4);

            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
           
            btn5.Text = "3";
            chk2(btn5);
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
           
            btn6.Text = "3";
            chk2(btn6);
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            
            btn7.Text = "4";
            chk3(btn7);
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            
            btn8.Text = "4";
            chk3(btn8);
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            
            btn9.Text = "";
            btn10.Text = "";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            
            btn9.Text = "5";
            chk4(btn9);
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            
            btn10.Text = "";
        }

        private void btn10_Click(object sender, EventArgs e)
        {
          
           
            btn10.Text = "5";
            chk4(btn10);
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
           
        }

         

          public void chk(Button b)
         {


             if (btn1.Text == btn2.Text )
             {
                 btn1.Visible = false;
                 btn2.Visible = false;
             }
             else
             {
                
                 scorx = scorx - 20;
                 l2.Text = "" + scorx;
             }
             empty();
            
    }
          public void chk1(Button b)
          {
              if (btn3.Text == btn4.Text)
              {
                  btn3.Visible = false;
                  btn4.Visible = false;
              }
              else
              {
                  
                  scorx = scorx - 20;
                  l2.Text = "" + scorx;
              }
              empty();
          }

          public void chk2(Button b)
          {
              if (btn5.Text == btn6.Text)
              {
                  btn5.Visible = false;
                  btn6.Visible = false;
              }
              else
              {
                  
                  scorx = scorx - 20;
                  l2.Text = "" + scorx;
              }
              empty();
          }
          public void chk3(Button b)
          {
              if (btn7.Text == btn8.Text)
              {
                  btn7.Visible = false;
                  btn8.Visible = false;
              }
              else
              {
                  
                  scorx = scorx - 20;
                  l2.Text = "" + scorx;
              }
              empty();
          }
          public void chk4(Button b)
          {
              if (btn9.Text == btn10.Text)
              {
                  btn9.Visible = false;
                  btn10.Visible = false;
              }
              else
              {
                  
                  scorx = scorx - 20;
                  l2.Text = "" + scorx;
              }
              empty();
              
          }

          public void empty()
          {
              if (btn1.Visible == false && btn2.Visible == false && btn3.Visible == false && btn4.Visible == false && btn5.Visible == false && btn6.Visible == false && btn7.Visible == false && btn8.Visible == false && btn9.Visible == false && btn10.Visible == false)
              {
                  MessageBox.Show("Score: "+scorx);
                  End a = new End();
                  a.Show();
                  this.Hide();
                  

              }
          }

          private void Exitbtn_Click(object sender, EventArgs e)
          {
              Sure s = new Sure();
              s.Visible = true;
          }

          private void againBtn_Click(object sender, EventArgs e)
          {
              this.Visible = true;
          }
          

         

    }
}
