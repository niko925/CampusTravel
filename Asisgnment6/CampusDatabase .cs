using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;


namespace Asisgnment6
{
    public static class CampusDatabase
    {
        private static string path = getDir(System.IO.Directory.GetCurrentDirectory()) + @"\CAMPUS.mdf";
        public static string Path
        {
            get { return path; }
            set { path = value; }
        }

        public static SqlConnection GetConnection()
        {
            //want to include a backslash character itself, you need two backslashes or use the @ verbatim string: "\\Tasks" or @"\Tasks".
            //string connectStr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =C:\Users\NikoBenick\Documents\Visual Studio 2015\Projects415\Asisgnment6\Asisgnment6\CAMPUS.mdf; Integrated Security = True";
            string connectStr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + path + @"; Integrated Security = True";
            SqlConnection connect = new SqlConnection(connectStr);

            return connect;
        }

        public static string getDir(string path)
        {
            int loop = 2;
            string dir = path;
            for (int i = 0; i < loop; i++) {
                System.IO.DirectoryInfo dirInfo = System.IO.Directory.GetParent(dir);
                dir = dirInfo.FullName;
            }
            return dir;
        }


    
        public static List<Agent> GetAgent()
        {
            List<Agent> agentList = new List<Agent>();
            SqlConnection conn = GetConnection();
            //IIF(Amount IS NULL,0,Amount) -> if amount = null then make is 0
            string select = "SELECT AgentId, AgentName, OfficeLocation, SUM(1) AS NumSale, SUM(IIF(Amount IS NULL,0,Amount)) AS Total FROM AGENT LEFT JOIN OFFICE ON OfficeKey=OfficeId LEFT JOIN SALE ON AgentKey=AgentId GROUP BY AgentId, AgentName, OfficeLocation ORDER BY AgentId";
            SqlCommand output = new SqlCommand(select, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = output.ExecuteReader();
                while (reader.Read())
                {
                    Agent agent = new Agent();

                    agent.AgentID = (int)reader["AgentId"];
                    agent.AgentName = reader["AgentName"].ToString();
                    agent.OfficeLocation = reader["OfficeLocation"].ToString();
                    agent.NumSales = (int)reader["NumSale"];
                    agent.TotalSales = (decimal)reader["Total"];

                    agentList.Add(agent);
                }
                reader.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { conn.Close(); }
            return agentList;
        }

        public static List<Destination> GetDestination()
        {
            List<Destination> destinationList = new List<Destination>();
            SqlConnection conn = GetConnection();
            string select = "SELECT *";
            select += "FROM DESTINATION";
            SqlCommand output = new SqlCommand(select, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = output.ExecuteReader();
                while (reader.Read())
                {
                    Destination destination = new Destination();
                    destination.DestinationId = (int)reader["DestinationId"];
                    destination.DestinationName = reader["DestinationName"].ToString();

                    destinationList.Add(destination);
                }
                reader.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { conn.Close(); }
            return destinationList;
        }

        public static List<Agent> GetAgentBooking()
        {
            List<Agent> bookingList = new List<Agent>();
            SqlConnection conn = GetConnection();
            string select = "SELECT AgentId, AgentName, OfficeLocation, SUM(1) AS NumSale, SUM(IIF(Amount IS NULL,0,Amount)) AS Total";
            select += "FROM AGENT LEFT JOIN OFFICE ON OfficeKey=OfficeId LEFT JOIN SALE ON AgentKey=AgentId";
            select += "GROUP BY AgentId, AgentName, OfficeLocation";
            select += "ORDER BY AgentId";
            SqlCommand output = new SqlCommand(select, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = output.ExecuteReader();
                while (reader.Read())
                {
                    Agent agent = new Agent();

                    agent.AgentID = (int)reader["AgentId"];
                    agent.AgentName = reader["AgentName"].ToString();
                    agent.OfficeLocation = reader["OfficeLocation"].ToString();
                    agent.NumSales = (int)reader["NumSale"];
                    agent.TotalSales = (decimal)reader["Total"];

                    bookingList.Add(agent);
                }
                reader.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { conn.Close(); }
            return bookingList;
        }
        
        // Parameter:
        //     integer Sale Id
        // Summary:
        //     return a sale data
        public static Sale GetSale(int saleId)
        {
            
            SqlConnection conn = GetConnection();
            string select = "SELECT * "
                           + "FROM SALE LEFT JOIN AGENT ON AgentKey=AgentId LEFT JOIN OFFICE ON OfficeKey=OfficeId  LEFT JOIN DESTINATION ON DestinationKey=DestinationId "
                           + "WHERE SaleId=" + saleId;
            SqlCommand output = new SqlCommand(select, conn);
            Sale sale = new Sale();
            try
            {
                conn.Open();
                SqlDataReader reader = output.ExecuteReader();
                while (reader.Read())
                {
                    sale.SaleId = (int)reader["SaleId"];
                    sale.SaleDate = (DateTime)reader["SaleDate"];
                    sale.AgentKey = (int)reader["AgentKey"];
                    sale.AgentName = reader["AgentName"].ToString();
                    sale.Amount = (decimal)reader["Amount"];
                    sale.DestinationKey = (int)reader["DestinationKey"];
                    sale.DestinationName = reader["DestinationName"].ToString();
                    sale.OfficKey = (int)reader["OfficeId"];
                    sale.OfficeLocation = reader["OfficeLocation"].ToString();
                }
                reader.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { conn.Close(); }
            return sale;
        }

       
        //Parameter:
        //    integer agent Id, integer destination Id, string amount above, string amount below
        //Summary:
        //     return a List of sale data
        public static List<Sale> GetSale(int agentId, int destinationId, string amountUp, string amountDown)
        {
             
            List<Sale> saleList = new List<Sale>();
            SqlConnection conn = GetConnection();
            string select = "SELECT * FROM SALE LEFT JOIN AGENT ON AgentKey=AgentId LEFT JOIN OFFICE ON OfficeKey=OfficeId  LEFT JOIN DESTINATION ON DestinationKey=DestinationId ";
            string where ="";
            
            if (agentId != 0)
            {
                where += "AND AgentKey=" + agentId;
            }
            if(destinationId != 0)
            {
                where += "AND DestinationKey=" + destinationId;
            }
            if (amountUp != "")
            {
                where += "AND Amount>=" + amountUp;
            }
            if(amountDown != "")
            {
                where += "AND Amount<=" + amountDown;
            }
            if (where.Length >0)
            {
                select = select + "WHERE " +where.Substring(4);
            }
            //test select command
            Console.Write(select);
            select += "ORDER BY SaleId";
            SqlCommand output = new SqlCommand(select, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = output.ExecuteReader();
                while (reader.Read())
                {
                    Sale sale = new Sale();
                    sale.SaleId = (int)reader["SaleId"];
                    sale.SaleDate = (DateTime)reader["SaleDate"];
                    sale.AgentKey = (int)reader["AgentKey"];
                    sale.AgentName = reader["AgentName"].ToString();
                    sale.Amount = (decimal)reader["Amount"];
                    sale.DestinationKey = (int)reader["DestinationKey"];
                    sale.DestinationName = reader["DestinationName"].ToString();
                    sale.OfficKey = (int)reader["OfficeId"];
                    sale.OfficeLocation = reader["OfficeLocation"].ToString();

                    saleList.Add(sale);
                }
                reader.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { conn.Close(); }

            return saleList;
        }    


    public static void AddSale(DateTime saleDate, int agentId, int destinationId, decimal amount)
        {
            
            string update = "INSERT INTO SALE (SaleDate,AgentKey,Amount,DestinationKey) VALUES (@saleDate,@agentKey,@amount,@destinationKey)";
            

            SqlConnection conn = GetConnection();
            SqlCommand cdInsert = new SqlCommand(update, conn);
            cdInsert.Parameters.AddWithValue("@saleDate", saleDate);
            cdInsert.Parameters.AddWithValue("@agentKey", agentId);
            cdInsert.Parameters.AddWithValue("@destinationKey", destinationId);
            cdInsert.Parameters.AddWithValue("@amount", amount);

            try
            {
                conn.Open();
                cdInsert.ExecuteNonQuery();
            }
            catch (Exception e1)
            {
                throw e1;
            }
            finally { conn.Close(); }
        }

        //Parameter:
        //     integer Sale Id
        //Summary:
        //     Delete a Sale from Sale Table
        
        public static void DeleteSale(int saleId)
        {
            /*
             * UPDATE table_name
             * SET column1=value1,column2=value2,...
             *WHERE some_column=some_value;
             */
            string delete = "DELETE FROM SALE ";
            SqlConnection conn = GetConnection();
            delete += "WHERE SaleId=" + saleId;
            SqlCommand cdDelete = new SqlCommand(delete, conn);
            try
            {
                conn.Open();
                cdDelete.ExecuteNonQuery();
            }
            catch (Exception e1)
            {
                throw e1;

            }
            finally { conn.Close(); }
 
        }

        //Parameter:
        //     integer Sale Id
        //Summary:
        //     update the Sale to SALE Table
        public static void UpdateSale(int saleId, DateTime saleDate, int agentId, int destinationId, decimal amount)
        {
            string update = "UPDATE SALE "
                          + "SET SaleDate=@saleDate,AgentKey=@agentKey,Amount=@amount,DestinationKey=@destinationKey "
                          + "WHERE SaleId=" + saleId;
            SqlConnection conn = GetConnection();
            SqlCommand cdUpdate = new SqlCommand(update, conn);
            cdUpdate.Parameters.AddWithValue("@saleDate", saleDate);
            cdUpdate.Parameters.AddWithValue("@agentKey", agentId);
            cdUpdate.Parameters.AddWithValue("@destinationKey", destinationId);
            cdUpdate.Parameters.AddWithValue("@amount", amount);
            try
            {
                conn.Open();
                cdUpdate.ExecuteNonQuery();
            }
            catch (Exception e1)
            {
                throw e1;
            }
            finally { conn.Close(); }
        }

        public static void AddAgent(string agentName, int officeKey)
        {
            string insert = "INSERT INTO AGENT(AgentName, OfficeKey) VALUES(@agentName,@officeKey)";

            SqlConnection conn = GetConnection();
            SqlCommand cdInsert = new SqlCommand(insert, conn);
            cdInsert.Parameters.AddWithValue("@agentName", agentName);
            cdInsert.Parameters.AddWithValue("@officeKey", officeKey);
            try
            {
                conn.Open();
                cdInsert.ExecuteNonQuery();
            }
            catch (Exception e1)
            {
                throw e1;
            }
            finally { conn.Close(); }
        }
    }
    
}
