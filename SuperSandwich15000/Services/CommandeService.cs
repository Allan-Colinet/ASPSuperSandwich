using Microsoft.Data.SqlClient;
using SuperSandwich15000.Models;

namespace SuperSandwich15000.Services
{
    public class CommandeService
    {
        private string _Connectionstring = @"Data Source=GOS-VDI907\TFTIC;Initial Catalog=BDDSandwich;Integrated Security=True;Connect Timeout=60;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public void Create(Commande commande)
        {
            using(SqlConnection sql = new SqlConnection(_Connectionstring))
            {
                using(SqlCommand cmd =  sql.CreateCommand())
                {
                    
                    cmd.CommandText = "INSERT INTO Commande (SandwichId,PainGris,PourQui,Date,Commentaire) VALUES (@SandwichId,@PainGris,@PourQui,@Date,@Commentaire)";
                    cmd.Parameters.AddWithValue("SandwichId", commande.SandwichId);
                    cmd.Parameters.AddWithValue("PainGris", commande.PainGris);
                    cmd.Parameters.AddWithValue("PourQui", commande.PourQui);
                    cmd.Parameters.AddWithValue("Date", commande.Date);
                    cmd.Parameters.AddWithValue("Commentaire", commande.Commentaire);

                    sql.Open();
                    cmd.ExecuteNonQuery();
                    sql.Close();

                }
            }
        }
    }
}
