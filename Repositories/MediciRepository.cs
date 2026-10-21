using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CabinetMedical.Models;
using CabinetMedical.Helpers;

namespace CabinetMedical.Repositories
{
    public class MediciRepository
    {
        private Medic CitesteMedic(SqlDataReader reader)
        {
            Medic m = new Medic();
            m.Id= (int)reader["Id"];
            m.Nume = reader["Nume"].ToString();
            m.Prenume = reader["Prenume"].ToString() ;
            m.Specialitate = reader["Specialitate"].ToString() ;
            m.Telefon = reader["Telefon"].ToString();
            m.Email = reader["Email"].ToString ();
            return m;
        }

        public List<Medic> GetAll()
        {
            List<Medic> medici = new List<Medic>();
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseHelper.CONNECTION_STRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Id, Nume, Prenume, Specialitate, Telefon, Email FROM Medici", conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            medici.Add(CitesteMedic(reader));
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Eroare la incarcarea medicilor: " + ex.Message, ex);
            }
            return medici;
        }

        public void Add(Medic m)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseHelper.CONNECTION_STRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO Medici (Nume, Prenume, Specialitate, Telefon, Email)
                        VALUES (@Nume, @Prenume, @Specialitate, @Telefon, @Email)", conn))
                    {
                        cmd.Parameters.AddWithValue("@Nume", m.Nume);
                        cmd.Parameters.AddWithValue("@Prenume", m.Prenume);
                        cmd.Parameters.AddWithValue("@Specialitate", m.Specialitate);
                        cmd.Parameters.AddWithValue("@Telefon", m.Telefon);
                        cmd.Parameters.AddWithValue("@Email", m.Email);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Eroare la adaugarea medicului: " + ex.Message, ex);
            }
        }

        public void Update(Medic m)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(DatabaseHelper.CONNECTION_STRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        @"UPDATE Medici
                          SET Nume = @Nume,Prenume = @Prenume, Specialitate = @Specialitate, Telefon = @Telefon, Email = @Email
                          WHERE Id = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", m.Id);
                        cmd.Parameters.AddWithValue("@Nume", m.Nume);
                        cmd.Parameters.AddWithValue("@Prenume", m.Prenume);
                        cmd.Parameters.AddWithValue("@Specialitate", m.Specialitate);
                        cmd.Parameters.AddWithValue("@Telefon", m.Telefon);
                        cmd.Parameters.AddWithValue("@Email", m.Email);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Eroare la actualizarea medicului: " + ex.Message, ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(DatabaseHelper.CONNECTION_STRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Medici WHERE Id = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery ();
                    }
                }
            }
            catch (SqlException ex) 
            {
                throw new Exception("Eroare la stergerea medicului: " + ex.Message, ex);
            }

        }

    }
}
