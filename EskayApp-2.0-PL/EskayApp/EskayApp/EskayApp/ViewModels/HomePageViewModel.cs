using System.Collections.ObjectModel;
using DefaultNamespace;
using Prism.Navigation;

namespace EskayApp.ViewModels
{
    public class HomePageViewModel : BaseViewModel
    {
        public HomePageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Slides = new ObservableCollection<Slide>(new []
            {
                //new Slide("home_yap.jpg", "Thank you for downloading!"),
                new Slide("home_yap100days.jpg", "Gov. Art Yap's First 100 Days Report."),
                //new Slide("home_yapCal.jpg", "Tibuok Bohol ipailawom sa State of Calamity."),
                new Slide("home_yapERC.jpg", "Governor Art Yap Of Bohol and ERC Chair Justice Agnes Devanadera after the conclusion of the two day joint fact finding hearing."),
                new Slide("home_yapFlu.jpg", "Governor Art Yap at the African Swine Fever (ASF) Preparedness and Contingency Briefing for Barangay Livestock Aides.")
            });
        }
        
        public ObservableCollection<Slide> Slides { get; }
    }
}
