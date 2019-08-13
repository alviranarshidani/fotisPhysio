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
        void Careers_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Careers());
            IsPresented = false;
        }

        void Contact_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Contact_Us());
            IsPresented = false;
        }

        void About_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new About_Us());
            IsPresented = false;
        }

        void HomeHandler(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new MyHomePage());

            IsPresented = false;

        }

        void Login_Clicked(object sender, System.EventArgs e)

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

        void Services_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Services());
            IsPresented = false;
        }
    }
}
