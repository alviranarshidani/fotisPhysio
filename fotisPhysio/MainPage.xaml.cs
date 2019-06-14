using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace fotisPhysio
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : MasterDetailPage
    {
        void Handle_Clicked_4(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Careers());
            IsPresented = false;
        }

        void Handle_Clicked_3(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Contact_Us());
            IsPresented = false;
        }

        void Handle_Clicked_2(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new About_Us());
            IsPresented = false;
        }

        void Handle_Clicked_5(object sender, System.EventArgs e)
        {


        }

        void Handle_Clicked(object sender, System.EventArgs e)

        {
            Detail = new NavigationPage(new Login());
            IsPresented = false;

        }

        public MainPage()
        {
            InitializeComponent();

            Detail = new NavigationPage(new MyHomePage());

            IsPresented = false;
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Services());
            IsPresented = false;
        }
    }
}
