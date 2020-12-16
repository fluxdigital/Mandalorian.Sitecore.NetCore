using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sitecore.LayoutService.Client.Response.Model.Fields;

namespace MyProject.Models
{
    public class HeroModel
    {
        public TextField Title { get; set; }
        public TextField Intro { get; set; }
        public TextField Text { get; set; }
        public HyperLinkField Link { get; set; }
        public ImageField BackgroundImage { get; set; }
    }
}
