using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFCollectionViewGrouping.Data;
using XFCollectionViewGrouping.Services;

namespace XFCollectionViewGrouping
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public List<Person> People { get; set; }

        public List<PeopleGroup> GroupedPeople { get; set; }

        public MainPage()
        {
            InitializeComponent();

            var people = DataService.GetPeople().Result;

            this.People = people.ToList();

            //ここからグループ化
            //LastNameでグループ化する
            this.GroupedPeople = this.People.GroupBy(p => p.LastName)
                                            .Select(g => new PeopleGroup(g.Key, g.ToList()))
                                            .ToList();

            this.BindingContext = this;
        }
    }
}
