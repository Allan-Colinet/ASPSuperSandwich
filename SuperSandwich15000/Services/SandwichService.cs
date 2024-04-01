using Microsoft.Data.SqlClient;
using SuperSandwich15000.Models;

namespace SuperSandwich15000.Services
{
    public class SandwichService
    {
        private string _Connectionstring = @"Data Source=GOS-VDI907\TFTIC;Initial Catalog=BDDSandwich;Integrated Security=True;Connect Timeout=60;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public List<Sandwich> GetAll()
        { 
            List<Sandwich> listeSandwich = new List<Sandwich>();
            using (SqlConnection sql = new SqlConnection(_Connectionstring))
            {
                using(SqlCommand cmd = sql.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Sandwich ";
                    sql.Open();
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listeSandwich.Add(new Sandwich()
                            {
                                Id = (int)reader["Id"],
                                Nom = (string)reader["Nom"],
                                Prix = (decimal)reader["Prix"],

                            });
                        }
                    }
                    sql.Close();
                }
            }
            return listeSandwich;
        }

        public Sandwich GetById(int id)
        {
            Sandwich sandwichCommande = new Sandwich();
            using (SqlConnection sql = new SqlConnection(_Connectionstring))
            {
                using (SqlCommand cmd = sql.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Sandwich WHERE Id = @Id ";
                    cmd.Parameters.AddWithValue("Id", id);
                    sql.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sandwichCommande.Id = (int)reader["Id"];
                            sandwichCommande.Nom = (string)reader["Nom"];
                            sandwichCommande.Prix = (decimal)reader["Prix"];
                        }
                    }
                    sql.Close();
                }
            }
            return sandwichCommande;
        }
    }
}

