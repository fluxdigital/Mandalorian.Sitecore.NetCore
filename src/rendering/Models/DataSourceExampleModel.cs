using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sitecore.LayoutService.Client.Response.Model.Fields;

namespace MyProject.Models
{
    public class DataSourceExampleModel
    {
        public TextField Title { get; set; }
        public RichTextField BodyText { get; set; }
        public ImageField FeaturedImage { get; set; }
        public HyperLinkField PromoLink { get; set; }
        public DateField ExampleDate { get; set; }

        public TextField Summary { get; set; }
    }
}
