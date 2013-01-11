using System;
using System.Windows.Media.Imaging;

namespace InsertInListboxproblem
{
    public static class StaticResources
    {
        public static BitmapImage ImageBien = new BitmapImage(new Uri("/bien.png", UriKind.Relative));
        public static BitmapImage ImageMal = new BitmapImage(new Uri("/mal.png", UriKind.Relative));
    }
}