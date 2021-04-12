using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exercise_PhotoGallery.MarkupExtension
{
    [ContentProperty("ResourceId")]
    public class EmbeddedImage : IMarkupExtension // nhung anh 
    {
        public string ResourceId { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (String.IsNullOrWhiteSpace(ResourceId))
                return null;
            return ImageSource.FromResource(ResourceId); ;
        }
    }
}
