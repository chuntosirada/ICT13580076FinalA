using ICT13580076FinalA.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ICT13580076FinalA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewPage : ContentPage
    {
        Product product;
        public NewPage(Product product=null)
        {
            InitializeComponent();

            this.product = product;

            titleLabel.Text = product == null ? "New Product" : "Edit Product";

            saveButtun.Clicked += SaveButtun_Clicked;
            cancelButtun.Clicked += CancelButtun_Clicked;
            
            

        }

        private void CancelButtun_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

       async void SaveButtun_Clicked(object sender, EventArgs e)
        {
            var isOK = await DisplayAlert("ยืนยัน", "คุณต้องการบันทึก", "ใช่", "ไม่ใช่");
            if (isOK)
            {
                if (product == null)
                {
                    product.Name = nameEntry.Text;
                    product.Lastname = surnameEntry.Text;
                    product.Age = int.Parse(ageEntry.Text);
                    product.Gender = genderEntry.Text;
                    product.Department = departmentEntry.Text;
                    product.Phone = int.Parse(numberEntry.Text);
                }
            }
        }
    }
}