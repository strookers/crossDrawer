using System.Collections.Generic;
using CrossDrawer.Core.Models;
using MvvmCross.Core.ViewModels;

namespace CrossDrawer.Core
{
	public class MyListViewModel : MvxViewModel
	{

        private List<CampingPlace> _campingPlaces;
        public List<CampingPlace> CampingPlaces
        {
            get { return _campingPlaces; }
            set { _campingPlaces = value; RaisePropertyChanged(() => CampingPlaces); }
        }

        public MyListViewModel()
	    {
	        CampingPlace c1 = new CampingPlace {Id = 1, Name = "Søborg Camping", City = "Søborg"};
            CampingPlace c2 = new CampingPlace { Id = 2, Name = "Viborg Camping", City = "Viborg" };
            CampingPlace c3 = new CampingPlace { Id = 3, Name = "Herning Camping", City = "Herning" };
            CampingPlace c4 = new CampingPlace { Id = 4, Name = "Aalborg Camping", City = "Aalborg" };

            _campingPlaces = new List<CampingPlace>();
            _campingPlaces.Add(c1);
            _campingPlaces.Add(c2);
            _campingPlaces.Add(c3);
            _campingPlaces.Add(c4);
	    }
    }
}