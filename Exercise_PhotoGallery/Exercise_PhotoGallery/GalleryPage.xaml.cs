using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exercise_PhotoGallery
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GalleryPage : ContentPage
    {
        private int currentId = 1;
        
        public GalleryPage()
        {
            InitializeComponent();
            currentId = 1;
            LoadImage();
        }

        void LoadImage()
        {
            var imageSource = new UriImageSource { Uri = new Uri(String.Format("https://loremflickr.com/320/240/{0}", currentId)) };//download image
            imageSource.CachingEnabled = false;
            image.Source = imageSource;
        }

         void btn_Next(object sender, EventArgs e)
        {
            currentId++;
            if (currentId > 5)
            {
                currentId = 1;
                
            }
            LoadImage();

        }

        void btn_Previous(object sender, EventArgs e)
        {
            currentId--;
            if (currentId==0)
            {
                currentId = 5;
               
                
            }
            LoadImage();
        }
    }
}