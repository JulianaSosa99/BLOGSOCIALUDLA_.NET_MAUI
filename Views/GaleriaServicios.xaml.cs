using BLOGSOCIALUDLA.Models;
using System.Collections.ObjectModel;

namespace BLOGSOCIALUDLA.Views;

public partial class GaleriaServicios : ContentPage
{

    public ObservableCollection<Facultad> Facultades { get; set; }
    public ObservableCollection<Facultad> Facultades2 { get; set; }


    public GaleriaServicios()
	{
        
        InitializeComponent();
        InitializeFacultades();
        BindingContext = this;

    }

    private void InitializeFacultades()
    {
        Facultades = new ObservableCollection<Facultad>
        {
            new Facultad{Name= "FICA", ReadTime= new TimeSpan(0,4,0), Image= "fica.jpg"},
            new Facultad{Name= "Facultad de Medicina", ReadTime= new TimeSpan(0,3,0), Image= "medicina.jpg"},
            new Facultad{Name= "Facultad de Derecho", ReadTime= new TimeSpan(0,2,0), Image= "derecho.jpg"},
            new Facultad{Name= "Facultad de Arquitectura", ReadTime= new TimeSpan(0,3,0), Image= "arquitectura.jpg"},
            new Facultad{Name= "NODO", ReadTime= new TimeSpan(0,3,0), Image= "nodo.jpg"},
            new Facultad{Name= "Escuela de M�sica", ReadTime= new TimeSpan(0,2,0), Image= "musica.jpg"}
        };
        Facultades2 = new ObservableCollection<Facultad>
        {
            new Facultad{Name= "Cl�nica de Odontolog�a", ReadTime= new TimeSpan(0,30,0), Image= "odontologia.jpg"},
            new Facultad{Name= "Escuela de Gastronom�a", ReadTime= new TimeSpan(0,30,0), Image= "gastronomia.jpg"},
            new Facultad{Name= "Servicios de Psicolog�a", ReadTime= new TimeSpan(0,30,0), Image= "psicologia.jpg"},
            new Facultad{Name= "Biblioteca", ReadTime= new TimeSpan(0,30,0), Image= "economia.jpg"},

        };

    }

    private void Salir(object sender, EventArgs e)
    {

        Navigation.PopAsync();
    }

}