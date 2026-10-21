using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CabinetMedical.Models;
using CabinetMedical.Helpers;
using System.Runtime.Remoting.Messaging;
using System.CodeDom;
using System.Windows.Forms;

namespace CabinetMedical.Repositories
{
    public class PacientiRepository
    {
        private Pacient CitestePacient(SqlDataReader reader)
        {
            Pacient p = new Pacient();
            p.Id = (int)reader["Id"];
            p.Nume = reader["Nume"].ToString();
            p.Prenume = reader["Prenume"].ToString() ;
            p.CNP = reader["CNP"].ToString();
            p.DataNasterii = (DateTime)reader["DataNasterii"];
            p.Telefon = reader["Telefon"].ToString();
            p.Email = reader["Email"].ToString();
            p.Adresa = reader["Adresa"].ToString();
            return p;
        }

        public List<Pacient> GetAll()
        {
            List<Pacient> pacienti = new List<Pacient>();
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseHelper.CONNECTION_STRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Id, Nume, Prenume, CNP, DataNasterii, Telefon, Email, Adresa FROM Pacienti", conn))
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                                pacienti.Add(CitestePacient(reader));
                        }
                }
            }
            catch(SqlException ex)
            {
                throw new Exception("Eroare la incarcarea pacientilor: " + ex.Message, ex);
            }
            return pacienti;
        }

        public void Add(Pacient p)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseHelper.CONNECTION_STRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO Pacienti (Nume, Prenume, CNP, DataNasterii, Telefon, Email, Adresa)
                                    VALUES (@Nume, @Prenume, @CNP, @DataNasterii, @Telefon, @Email, @Adresa)", conn))
                    {
                        cmd.Parameters.AddWithValue("@Nume", p.Nume);
                        cmd.Parameters.AddWithValue("@Prenume", p.Prenume);
                        cmd.Parameters.AddWithValue("@CNP", p.CNP);
                        cmd.Parameters.AddWithValue("@DataNasterii", p.DataNasterii);
                        cmd.Parameters.AddWithValue("@Telefon", p.Telefon);
                        cmd.Parameters.AddWithValue("@Email", p.Email);
                        cmd.Parameters.AddWithValue("@Adresa", p.Adresa);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(SqlException ex)
            {
                throw new Exception("Eroare la adaugarea pacientului: " + ex.Message, ex);
            }
        }

        public void Update(Pacient p)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseHelper.CONNECTION_STRING))
                { 
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(@"UPDATE Pacienti
                            SET Nume = @Nume, Prenume = @Prenume, CNP = @CNP, DataNasterii = @DataNasterii, Telefon = @Telefon, Email = @Email, Adresa = @Adresa
                               WHERE Id = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", p.Id);
                        cmd.Parameters.AddWithValue("@Nume", p.Nume);
                        cmd.Parameters.AddWithValue("@Prenume", p.Prenume);
                        cmd.Parameters.AddWithValue("@CNP", p.CNP);
                        cmd.Parameters.AddWithValue("@DataNasterii", p.DataNasterii);
                        cmd.Parameters.AddWithValue("@Telefon", p.Telefon);
                        cmd.Parameters.AddWithValue("@Email", p.Email);
                        cmd.Parameters.AddWithValue("@Adresa", p.Adresa);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Eroare la actualizarea pacientului: " + ex.Message, ex);
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
                        "DELETE FROM Pacienti WHERE Id = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Eroare la stergerea pacientului: " + ex.Message, ex);
            }
        }
    }
}
