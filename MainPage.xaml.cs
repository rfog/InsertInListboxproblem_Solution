using System;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Phone.Controls;

namespace InsertInListboxproblem
{
    public partial class MainPage : PhoneApplicationPage
    {
        private static readonly Random s_rnd = new Random();

        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Tap(object sender, GestureEventArgs e)
        {
            switch (s_rnd.Next(0, 3))
            {
                case 0:
                    var itemText = new ListBoxItemText("Hola mundo");
                    ListBox.Items.Add(itemText);
                    ListBox.ScrollIntoView(itemText);
                    break;
                case 1:
                    var itemImgBien = new ListBoxItemImage(StaticResources.ImageBien);
                    ListBox.Items.Add(itemImgBien);
                    ListBox.ScrollIntoView(itemImgBien);
                    break;
                case 2:
                    var itemImgMal = new ListBoxItemImage(StaticResources.ImageMal);
                    ListBox.Items.Add(itemImgMal);
                    ListBox.ScrollIntoView(itemImgMal);
                    break;
            }
        }

        private void ButtonNoBug_Tap(object sender, GestureEventArgs e)
        {
            switch (s_rnd.Next(0, 3))
            {
                case 0:
                    var itemText = new ListBoxItemText("Hola mundo");
                    ListBox.Items.Add(itemText);
                    //ListBox.ScrollIntoView(itemText);
                    ForceScrollListBox();
                    break;
                case 1:
                    var itemImgBien = new ListBoxItemImage(StaticResources.ImageBien);
                    ListBox.Items.Add(itemImgBien);
                    //                    ListBox.ScrollIntoView(itemImgBien);
                    ForceScrollListBox();
                    break;
                case 2:
                    var itemImgMal = new ListBoxItemImage(StaticResources.ImageMal);
                    ListBox.Items.Add(itemImgMal);
                    //                    ListBox.ScrollIntoView(itemImgMal);
                    ForceScrollListBox();
                    break;
            }
        }

        private void ScrollToLast_Tap(object sender, GestureEventArgs e)
        {
            ScrollToLast();
        }

        private void ForceScrollListBox()
        {
            var fake = new Grid {/*Tag=99*/};
            ListBox.Items.Add(fake);
            ListBox.ScrollIntoView(fake);
        }

        private void ScrollToLast()
        {
            int count = ListBox.Items.Count;
            if (count == 0)
                return;

            var fake = new Grid {/*Tag = 99*/};
            ListBox.Items.Add(fake);
            ListBox.ScrollIntoView(fake);
            /*
            var elem = (Grid)ListBox.Items[count - 1];
            if (elem == null || (elem.Tag!=null && ((int) elem.Tag) == 99))
                elem = new Grid {Tag = 99};

            ListBox.ScrollIntoView(elem);*/
        }
    }
}