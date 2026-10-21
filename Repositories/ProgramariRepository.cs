using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CabinetMedical.Models;
using CabinetMedical.Helpers;

namespace CabinetMedical.Repositories
{
    public class ProgramariRepository
    {
        private Programare CitesteProgramare(SqlDataReader reader)
        {
            Programare p = new Programare();
            p.Id = (int)reader["Id"];
            p.IdPacient = (int)reader["IdPacient"];
            p.IdMedic = (int)reader["IdMedic"];
            p.DataProgramarii = (DateTime)reader["DataProgramarii"];
            p.Diagnostic = reader["Diagnostic"].ToString();
            p.Observatii = reader["Observatii"].ToString();
            p.NumePacient = reader["NumePacient"].ToString();
            p.NumeMedic = reader["NumeMedic"].ToString();
            return p;
        }

        public List<Programare> GetAll()
        {
            List<Programare> programari = new List<Programare>();
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseHelper.CONNECTION_STRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        @"SELECT p.Id, p.IdPacient, p.IdMedic, p.DataProgramarii, 
                                 p.Diagnostic, p.Observatii,
                                 pac.Nume + ' ' + pac.Prenume AS NumePacient,
                                 m.Nume + ' ' + m.Prenume AS NumeMedic
                          FROM Programari p
                          JOIN Pacienti pac ON p.IdPacient = pac.Id
                          JOIN Medici m ON p.IdMedic = m.Id", conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            programari.Add(CitesteProgramare(reader));
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Eroare la incarcarea programarilor: " + ex.Message, ex);
            }
            return programari;
        }

        public void Add(Programare p)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseHelper.CONNECTION_STRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        @"INSERT INTO Programari (IdPacient, IdMedic, DataProgramarii, Diagnostic, Observatii)
                          VALUES (@IdPacient, @IdMedic, @DataProgramarii, @Diagnostic, @Observatii)", conn))
                    {
                        cmd.Parameters.AddWithValue("@IdPacient", p.IdPacient);
                        cmd.Parameters.AddWithValue("@IdMedic", p.IdMedic);
                        cmd.Parameters.AddWithValue("@DataProgramarii", p.DataProgramarii);
                        cmd.Parameters.AddWithValue("@Diagnostic", p.Diagnostic);
                        cmd.Parameters.AddWithValue("@Observatii", p.Observatii);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Eroare la adaugarea programarii: " + ex.Message, ex);
            }
        }

        public void Update(Programare p)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseHelper.CONNECTION_STRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        @"UPDATE Programari
                          SET IdPacient       = @IdPacient,
                              IdMedic         = @IdMedic,
                              DataProgramarii = @DataProgramarii,
                              Diagnostic      = @Diagnostic,
                              Observatii      = @Observatii
                          WHERE Id = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", p.Id);
                        cmd.Parameters.AddWithValue("@IdPacient", p.IdPacient);
                        cmd.Parameters.AddWithValue("@IdMedic", p.IdMedic);
                        cmd.Parameters.AddWithValue("@DataProgramarii", p.DataProgramarii);
                        cmd.Parameters.AddWithValue("@Diagnostic", p.Diagnostic);
                        cmd.Parameters.AddWithValue("@Observatii", p.Observatii);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Eroare la actualizarea programarii: " + ex.Message, ex);
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
                        "DELETE FROM Programari WHERE Id = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Eroare la stergerea programarii: " + ex.Message, ex);
            }
        }
    }
}