using System.Collections.ObjectModel;
using DefaultNamespace;
using Prism.Navigation;

namespace EskayApp.ViewModels
{
    public class MainPageViewModel2 : BaseViewModel
    {
        public MainPageViewModel2(INavigationService navigationService) : base(navigationService)
        {
            //Slides = new ObservableCollection<Slide>(new[]
            //  {
            //    new Slide("landing01.png", "Some description for slide one."),
            //    new Slide("landing02.png", "Some description for slide two."),
            //    new Slide("landing03.png", "Some description for slide three.")
            //});
        }
        //public ObservableCollection<Slide> Slides { get; }
    }
}
