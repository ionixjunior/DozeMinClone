using DozeMinClone.ViewModels;
using Xamarin.Forms;

namespace DozeMinClone
{
    public partial class MainPage : ContentPage
    {
        private DiscoverViewModel _viewModel;

        public MainPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new DiscoverViewModel {
                Cover = "charles_petzold.jpg",
                Author = "Charles Petzold",
                Title = "Creating Mobile Apps with Xamarin.Forms",
                Description = "The book Creating Mobile Apps with Xamarin.Forms by Charles Petzold is a guide for learning how to write Xamarin.Forms applications. The only prerequisite is knowledge of the C# programming language."
            };

            Header?.Search?.SetBinding(Entry.TextProperty, nameof(_viewModel.Search));
            Highlight?.Cover?.SetBinding(Image.SourceProperty, nameof(_viewModel.Cover));
            Highlight?.Author?.SetBinding(Label.TextProperty, nameof(_viewModel.Author));
            Highlight?.Title?.SetBinding(Label.TextProperty, nameof(_viewModel.Title));
            Highlight?.Description?.SetBinding(Label.TextProperty, nameof(_viewModel.Description));
        }
    }
}
