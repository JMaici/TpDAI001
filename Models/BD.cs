namespace TPDAI001.Models;       
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;

public class BD
{
    private static string _connectionString = @"Server=A-PHZ2-CIDI-011;DataBase=TPDAI001;Trusted_Connection=True";
    public static List<Pizza> ListarPizzas(){
        List<Pizza> listaP =  new List<Pizza>(); 
        string sql = "sp_ListarPizzas";
         using (SqlConnection db = new SqlConnection(_connectionString))
        {
            listaP = db.Query<Pizza>(sql).ToList();
        }
        return listaP;
    }
    public static Pizza ObtenerPizzaPorID(int Id)
    {
        Pizza P = null;
        string sql = "sp_ObtenerPizzaPorID @pId";
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            P = db.QueryFirstOrDefault<Pizza>(sql, new { pId = Id });
        }
        return P;
    }
    public static void EliminarPizza(int Id)
    {
        string sql = "sp_EliminarPizza @pId";
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(sql, new { pId = Id });
        }
    }
    public static void AgregarPizza(Pizza P)
    {
        string sql = "sp_AgregarPizza @pNombre, @pLibreGluten, @pImporte, @pDescripcion";
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(sql, new { pNombre = P.Nombre, pLibreGluten = P.LibreGluten, pImporte = P.Importe, pDescripcion = P.Descripcion });
        }
    }
    public static void ModificarPizza(int Id, Pizza P)
    {
        string sql = "sp_ModificarPizza @pNombre,  @pLibreGluten,  @pImporte,  @pDescripcion, @pId";
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(sql, new { pId = Id, pNombre = P.Nombre, pLibreGluten = P.LibreGluten, pImporte = P.Importe, pDescripcion = P.Descripcion });
        }
    }


}