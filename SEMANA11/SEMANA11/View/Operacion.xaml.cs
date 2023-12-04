using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SEMANA11.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Operacion : ContentView
    {
        public Operacion()
        {
            InitializeComponent();
            this.BindingContext = new ViewModels.OperacionViewModel();
        }

        public static implicit operator Page(Operacion v)
        {
            throw new NotImplementedException();
        }
    }
}
