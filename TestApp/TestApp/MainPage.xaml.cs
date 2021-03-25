using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestApp
{
    public partial class MainPage : ContentPage
    {
        private int back = 1;
        public MainPage()
        {
            InitializeComponent();
        }

        private void SubmitClick(object sender, EventArgs e)
        {
            Output.Text = "Your Name is:" + FirstName.Text + " " + Middle.Text + " " + LastName.Text;
        }

        private void ChangeBackGround(object sender, EventArgs e)
        {
            //back = new Random(11);
            if (back == 1)
            {
                Layout.BackgroundColor = Color.Aqua;
                Backgroundc.Text = "Aqua";
                back++;
            }
            else if(back == 2)
            {
                Layout.BackgroundColor = Color.Blue;
                Backgroundc.Text = "Blue";
                back++;
            }
            else if (back == 3)
            {
                Layout.BackgroundColor = Color.Navy;
                Backgroundc.Text = "Navy";
                back++;
            }
            else
            {
                Layout.BackgroundColor = Color.Beige;
                Backgroundc.Text = "Baige";
                back = 1;
            }
        }
    }
}