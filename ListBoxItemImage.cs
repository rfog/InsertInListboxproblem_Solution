using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Coding4Fun.Phone.Controls;

namespace InsertInListboxproblem
{
    internal class ListBoxItemText : Grid
    {
        private readonly TextBlock m_text;

        public ListBoxItemText(string text)
        {
            Margin = new Thickness(10, 10, 10, 10);
            ColumnDefinitions.Add(new ColumnDefinition());
            RowDefinitions.Add(new RowDefinition());

            var bubble = new ChatBubble();
            SetColumn(bubble, 0);
            SetRow(bubble, 0);
            Children.Add(bubble);

            var spExternal = new StackPanel();
            bubble.Content = spExternal;

            m_text = new TextBlock {Text = text};
            SetColumn(m_text, 0);
            SetRow(m_text, 0);
            spExternal.Children.Add(m_text);

            var txt = new TextBlock
                {
                    HorizontalAlignment = HorizontalAlignment.Right,
                    TextAlignment = TextAlignment.Right,
                    MaxWidth = 400,
                    MinWidth = 300,
                    Style = (Style) Resources["PhoneTextSubtleStyle"],
                    FontSize = 15,
                    Margin = new Thickness(20, 0, 0, 0),
                    Text = DateTime.Now.ToShortTimeString(),
                };
            spExternal.Children.Add(txt);
        }
    }

    internal class ListBoxItemImage : Grid
    {
        private readonly Image m_image;

        public ListBoxItemImage(BitmapImage img)
        {
            Margin = new Thickness(10, 10, 10, 10);
            ColumnDefinitions.Add(new ColumnDefinition());
            RowDefinitions.Add(new RowDefinition());

            var bubble = new ChatBubble();
            SetColumn(bubble, 0);
            SetRow(bubble, 0);
            Children.Add(bubble);

            var spExternal = new StackPanel();
            bubble.Content = spExternal;

            m_image = new Image {MaxHeight = 300, MaxWidth = 300, Source = img};
            SetColumn(m_image, 0);
            SetRow(m_image, 0);
            spExternal.Children.Add(m_image);

            var txt = new TextBlock
                {
                    HorizontalAlignment = HorizontalAlignment.Right,
                    TextAlignment = TextAlignment.Right,
                    MaxWidth = 400,
                    MinWidth = 300,
                    Style = (Style) Resources["PhoneTextSubtleStyle"],
                    FontSize = 15,
                    Margin = new Thickness(20, 0, 0, 0),
                };
            txt.Text = DateTime.Now.ToShortTimeString();
            spExternal.Children.Add(txt);
        }

        public void Modify(BitmapImage img)
        {
        }
    }
}