using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Ericsson_ITSC;
using Ericsson_ITSC_Library;
using Microsoft.Phone.Maps.Controls;
using Microsoft.Phone.Maps.Services;
using System.Device.Location;

namespace Ericsson_ITSC
{
    public partial class Office_Locations : PhoneApplicationPage
    {
        private GeoCoordinate MyCoordinate = null;
        private GeocodeQuery MyGeocodeQuery = null;

        private bool _isRouteSearch = false;    // it is true when route is being searched, false otherwise!!

        private void SearchForTerm(String searchTerm)
        {
            MyGeocodeQuery=new GeocodeQuery();
            MyGeocodeQuery.SearchTerm = searchTerm;
            MyGeocodeQuery.GeoCoordinate = MyCoordinate == null ? new GeoCoordinate(0, 0) : MyCoordinate;
            MyGeocodeQuery.QueryCompleted +=MyGeocodeQuery_QueryCompleted;
            MyGeocodeQuery.QueryAsync();
        }

        void MyGeocodeQuery_QueryCompleted(object sender, QueryCompletedEventArgs<IList<MapLocation>> e)
        {
            throw new NotImplementedException();
        }
        public Office_Locations()
        {
            InitializeComponent();
        }
        private List<GeoCoordinate> MyCoordinates = new List<GeoCoordinate>();
        //private bool _isRouteSearch = false;    // it is true when route is being searched, false otherwise!!
        
        private void GeocodeQuery_QueryCompleted(object sender, QueryCompletedEventArgs<IList<MapLocation>> e)
        {
            if(e.Error==null)
            {
                if(e.Result.Count>0)
                {
                    if (_isRouteSearch)
                    {

                    }
                    else
                    {
                        for(int i=0;i<e.Result.Count;i++)
                        {
                            MyCoordinates.Add(e.Result[i].GeoCoordinate);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No match found. Narrow your search e.g. Izmir TR.");
                }
            }
        }
    }
}