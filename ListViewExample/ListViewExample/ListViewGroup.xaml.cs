using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        public ObservableCollection<Group> Groups { get; set; }
        public ListViewGroup()
        {
            InitializeComponent();
            Groups = new ObservableCollection<Group>
        {
            new Group("Alfa")
            {
                new Item { Title = "Chacha", Subtitle = "Pika" },
                new Item { Title = "Chachu", Subtitle = "Trebol" },
                new Item { Title = "Chicha", Subtitle = "Corazon" },
            },
            new Group("Beta")
            {
                new Item { Title = "Cuadrado", Subtitle = "Play" },
                new Item { Title = "Triangulo", Subtitle = "Xbox" },
                new Item { Title = "cruz", Subtitle = "Nintendo" },
      
            },
            new Group("Omega")
            {
                new Item { Title = "Herencia", Subtitle = "Java" },
                new Item { Title = "Encalpsulamiento", Subtitle = "Swift" },
                new Item { Title = "Abstraccion", Subtitle = "c#" },
         
            },
        };
            GroupedView.ItemsSource = Groups;
        }
    }
}