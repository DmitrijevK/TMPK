using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tmpk.functsii;
using Xamarin.Forms;

namespace tmpk
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            tmpk.ItemsSource = Menulist();
            var StartPage = typeof(stranitsi.osnova);
            Detail = new NavigationPage((Page)Activator.CreateInstance(StartPage));
            IsPresented = false;
        }

        private List<klas> Menulist()
        {
            var spisok = new List<klas>();

            spisok.Add(new klas()
            {
                Text = "О Школе",
                ImageP = "pilt.png",
                TarPage = typeof(stranitsi.raspisanie)
            });

            spisok.Add(new klas()
            {
                Text = "Расписание",
                ImageP = "pilt.png",
                TarPage = typeof(stranitsi.raspisanie)
            });

            spisok.Add(new klas()
            {
                Text = "Замены",
                ImageP = "pilt.png",
                TarPage = typeof(stranitsi.zameni)
            });

            spisok.Add(new klas()
            {
                Text = "Контакты",
                ImageP = "pilt.png",
                TarPage = typeof(stranitsi.kontakti)
            });

            spisok.Add(new klas()
            {
                Text = "О приложении",
                ImageP = "pilt.png",
                TarPage = typeof(stranitsi.osnova)
            });
            return spisok;
        }

        private void tmpk_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selecte = (klas)e.SelectedItem;
            Type selectedpage = selecte.TarPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedpage));
            IsPresented = false;
        }
    }
}