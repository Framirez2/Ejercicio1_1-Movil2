using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio1_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        string num1;
        string num2;
        float res;
        public Page1()
        {
            InitializeComponent();
        }

        private async void btnsumar_Clicked(object sender, EventArgs e)
        {
            num1 = NUM1.Text;
            float floatn1 = float.Parse(num1);
            num2 = NUM2.Text;
            float floatn2 = float.Parse(num2);
            res = floatn1 + floatn2;
            await Navigation.PushAsync(new Page2(res));
            
        }
        private async void btnrestar_Clicked(object sender, EventArgs e)
        {
            num1 = NUM1.Text;
            float floatn1 = float.Parse(num1);
            num2 = NUM2.Text;
            float floatn2 = float.Parse(num2);
            res = floatn1 - floatn2;
            await Navigation.PushAsync(new Page2(res));
           
        }
        private async void btndivision_Clicked(object sender, EventArgs e)
        {
            num1 = NUM1.Text;
            float floatn1 = float.Parse(num1);
            num2 = NUM2.Text;
            float floatn2 = float.Parse(num2);
            res = floatn1 / floatn2;
            await Navigation.PushAsync(new Page2(res));
            
        }
        private async void btnmultiplicacion_Clicked(object sender, EventArgs e)
        {
            num1 = NUM1.Text;
            float floatn1 = float.Parse(num1);
            num2 = NUM2.Text;
            float floatn2 = float.Parse(num2);
            res = floatn1 * floatn2;
            await Navigation.PushAsync(new Page2(res));
       
        }
    }
}