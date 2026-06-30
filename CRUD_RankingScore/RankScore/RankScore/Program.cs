using System;
using Microsoft.Data.SqlClient;

namespace PlayRankConsoleApp
{
    class Program
    {
        // Change server name if needed
        static string connectionString =
            @"Server=VDL177;
              Database=PlayRankDBS;
              Trusted_Connection=True;
              TrustServerCertificate=True;";

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== PLAYRANK SYSTEM =====");
                Console.WriteLine("1. Add Team");
                Console.WriteLine("2. View Teams");
                Console.WriteLine("3. Add Player");
                Console.WriteLine("4. View Players");
                Console.WriteLine("5. Search Player");
                Console.WriteLine("6. Delete Team");
                Console.WriteLine("7. Exit");

                Console.Write("\nEnter Choice : ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddTeam();
                        break;

                    case 2:
                        ViewTeams();
                        break;

                    case 3:
                        AddPlayer();
                        break;

                    case 4:
                        ViewPlayers();
                        break;

                    case 5:
                        SearchPlayer();
                        break;

                    case 6:
                        DeleteTeam();
                        break;

                    case 7:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }

        static void AddTeam()
        {
            try
            {
                Console.Write("Enter Team Name : ");
                string teamName = Console.ReadLine();

                Console.Write("Enter City : ");
                string city = Console.ReadLine();

                string query =
                    "INSERT INTO Teams(TeamName,City) VALUES(@TeamName,@City)";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@TeamName", teamName);
                    cmd.Parameters.AddWithValue("@City", city);

                    con.Open();

                    cmd.ExecuteNonQuery();

                    Console.WriteLine("Team Added Successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }

        static void ViewTeams()
        {
            try
            {
                string query = "SELECT * FROM Teams";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, con);

                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    Console.WriteLine("\n--- TEAM LIST ---");

                    while (reader.Read())
                    {
                        Console.WriteLine(
                            reader["TeamId"] + "   | " +
                            reader["TeamName"] + " | " +
                            reader["City"]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }

        static void AddPlayer()
        {
            try
            {
                Console.Write("Player Name : ");
                string playerName = Console.ReadLine();

                Console.Write("Age : ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Team Id : ");
                int teamId = Convert.ToInt32(Console.ReadLine());

                string query =
                @"INSERT INTO Players
                (
                    PlayerName,
                    Age,
                    TeamId
                )
                VALUES
                (
                    @PlayerName,
                    @Age,
                    @TeamId
                )";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@PlayerName", playerName);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@TeamId", teamId);

                    con.Open();

                    cmd.ExecuteNonQuery();

                    Console.WriteLine("Player Added Successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }

        static void ViewPlayers()
        {
            try
            {
                string query =
                @"SELECT
                    P.PlayerId,
                    P.PlayerName,
                    P.Age,
                    T.TeamName
                  FROM Players P
                  INNER JOIN Teams T
                  ON P.TeamId = T.TeamId";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, con);

                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    Console.WriteLine("\n--- PLAYER LIST ---");

                    while (reader.Read())
                    {
                        Console.WriteLine(
                            reader["PlayerId"] + " | " +
                            reader["PlayerName"] + " | Age: " +
                            reader["Age"] + " | Team: " +
                            reader["TeamName"]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }

        static void SearchPlayer()
        {
            try
            {
                Console.Write("Enter Player Name : ");
                string searchName = Console.ReadLine();

                string query =
                @"SELECT
                    P.PlayerId,
                    P.PlayerName,
                    P.Age,
                    T.TeamName
                  FROM Players P
                  INNER JOIN Teams T
                  ON P.TeamId = T.TeamId
                  WHERE P.PlayerName LIKE @PlayerName";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@PlayerName",
                        "%" + searchName + "%");

                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    Console.WriteLine("\n--- SEARCH RESULT ---");

                    while (reader.Read())
                    {
                        Console.WriteLine(
                            reader["PlayerId"] + " | " +
                            reader["PlayerName"] + " | Age: " +
                            reader["Age"] + " | Team: " +
                            reader["TeamName"]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }

        static void DeleteTeam()
        {
            try
            {
                Console.Write("Enter Team Id : ");

                int teamId =
                    Convert.ToInt32(Console.ReadLine());

                string query =
                    "DELETE FROM Teams WHERE TeamId=@TeamId";

                using (SqlConnection con =
                    new SqlConnection(connectionString))
                {
                    SqlCommand cmd =
                        new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@TeamId", teamId);

                    con.Open();

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        Console.WriteLine("Team Deleted");
                    else
                        Console.WriteLine("Team Not Found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }
    }
}