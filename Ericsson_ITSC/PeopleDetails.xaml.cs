using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Ericsson_ITSC_Library;
using Ericsson_ITSC;

namespace Ericsson_ITSC
{
    public partial class PeopleDetails : PhoneApplicationPage
    {
        public static Contact contact;
        public PeopleDetails()
        {
            InitializeComponent();

            DataContext = contact;
        }
    }
}