using Microsoft.AspNetCore.Mvc;
using TPDAI001.Models;
namespace TPDAI001.Models;  
public class Pizza{
    private int? _Id;
    private string? _Nombre;
    private bool? _LibreGluten;
    private float? _Importe;
    private string? _Descripcion;
    public Pizza(int Id, string Nombre, string Descripcion, float Importe, bool LibreGluten)
    {
        _Descripcion = Descripcion;
        _Nombre = Nombre;
        _LibreGluten = LibreGluten;
        _Importe = Importe;
        _Descripcion = Descripcion;

    }
    public int? Id
    {
        get
        {
            return _Id;
        }
        set
        {
            _Id = value;
        }
    }

    public string? Nombre
    {
        get
        {
            return _Nombre;
        }
        set
        {
            _Nombre = value;
        }
    }

    public bool? LibreGluten
    {
        get
        {
            return _LibreGluten;
        }
        set
        {
            _LibreGluten = value;
        }
    }
    public float? Importe
    {
        get
        {
            return _Importe;
        }
        set
        {
            _Importe = value;
        }
    }
    public string? Descripcion
    {
        get
        {
            return _Descripcion;
        }
        set
        {
            _Descripcion = value;
        }
    }
    public Pizza()
    {

    }
}
    
