using Sitecore.LayoutService.Client.Response.Model.Fields;

namespace MyProject.Models
{
    public class ContentTextModel
    {
        public TextField Title { get; set; }
        public TextField Text { get; set; }
        public HyperLinkField Link { get; set; }
    }
}
