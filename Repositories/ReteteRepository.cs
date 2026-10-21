using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CabinetMedical.Models;
using CabinetMedical.Helpers;

namespace CabinetMedical.Repositories
{
    public class ReteteRepository
    {
        private Reteta CitesteReteta(SqlDataReader reader)
        {
            Reteta r = new Reteta();
            r.Id = (int)reader["Id"];
            r.IdProgramare = (int)reader["IdProgramare"];
            r.DataEliberarii = (DateTime)reader["DataEliberarii"];
            r.Medicamente = reader["Medicamente"].ToString();
            r.Observatii = reader["Observatii"].ToString();
            r.NumePacient = reader["NumePacient"].ToString();
            r.NumeMedic = reader["NumeMedic"].ToString();
            return r;
        }

        public List<Reteta> GetAll()
        {
            List<Reteta> retete = new List<Reteta>();
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseHelper.CONNECTION_STRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        @"SELECT r.Id, r.IdProgramare, r.DataEliberarii, r.Medicamente, r.Observatii,
                                 pac.Nume + ' ' + pac.Prenume AS NumePacient,
                                 m.Nume + ' ' + m.Prenume AS NumeMedic
                          FROM Retete r
                          JOIN Programari p ON r.IdProgramare = p.Id
                          JOIN Pacienti pac ON p.IdPacient = pac.Id
                          JOIN Medici m ON p.IdMedic = m.Id", conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            retete.Add(CitesteReteta(reader));
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Eroare la incarcarea retetelor: " + ex.Message, ex);
            }
            return retete;
        }

        public void Add(Reteta r)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseHelper.CONNECTION_STRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        @"INSERT INTO Retete (IdProgramare, DataEliberarii, Medicamente, Observatii)
                          VALUES (@IdProgramare, @DataEliberarii, @Medicamente, @Observatii)", conn))
                    {
                        cmd.Parameters.AddWithValue("@IdProgramare", r.IdProgramare);
                        cmd.Parameters.AddWithValue("@DataEliberarii", r.DataEliberarii);
                        cmd.Parameters.AddWithValue("@Medicamente", r.Medicamente);
                        cmd.Parameters.AddWithValue("@Observatii", r.Observatii);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Eroare la adaugarea retetei: " + ex.Message, ex);
            }
        }

        public void Update(Reteta r)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseHelper.CONNECTION_STRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        @"UPDATE Retete
                          SET IdProgramare   = @IdProgramare,
                              DataEliberarii = @DataEliberarii,
                              Medicamente    = @Medicamente,
                              Observatii     = @Observatii
                          WHERE Id = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", r.Id);
                        cmd.Parameters.AddWithValue("@IdProgramare", r.IdProgramare);
                        cmd.Parameters.AddWithValue("@DataEliberarii", r.DataEliberarii);
                        cmd.Parameters.AddWithValue("@Medicamente", r.Medicamente);
                        cmd.Parameters.AddWithValue("@Observatii", r.Observatii);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Eroare la actualizarea retetei: " + ex.Message, ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseHelper.CONNECTION_STRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Retete WHERE Id = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Eroare la stergerea retetei: " + ex.Message, ex);
            }
        }
    }
}