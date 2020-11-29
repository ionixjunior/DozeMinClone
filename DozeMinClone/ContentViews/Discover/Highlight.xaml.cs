using Xamarin.Forms;

namespace DozeMinClone.ContentViews.Discover
{
    public partial class Highlight : ContentView
    {
        public Image Cover => CoverImage;
        public Label Author => AuthorLabel;
        public Label Title => TitleLabel;
        public Label Description => DescriptionLabel;

        public Highlight()
        {
            InitializeComponent();
        }
    }
}
