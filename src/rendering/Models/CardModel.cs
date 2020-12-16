using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sitecore.LayoutService.Client.Response.Model.Fields;

namespace MyProject.Models
{
    public class CardModel
    {
        public TextField Title { get; set; }

        public RichTextField Text { get; set; }

        public HyperLinkField Link { get; set; }

        public ImageField Image { get; set; }
    }
}
