using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;

namespace Arbetsprov
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MyService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MyService.svc or MyService.svc.cs at the Solution Explorer and start debugging.
    public class MyService : IMyService
    {
        public string AddMessage(string message)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\MessageDb.mdf;Integrated Security=True";

                try
                {
                    conn.Open();
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO Messages (Message) VALUES ('" + message + "')", conn);
                    insertCommand.ExecuteNonQuery();
                }
                catch(Exception e)
                {
                    return "ett fel uppstod, vänligen försök igen.";
                }
                
            }
            return "Meddelande mottaget.";
        }
    }
}
