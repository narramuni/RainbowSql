using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AzureRainbow
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                string connectionString = ConfigurationManager.ConnectionStrings["Server=tcp:saipavan.database.windows.net,1433;" +
                    "Initial Catalog=RainbowSql;Persist Security Info=False;" +
                    "User ID=SaipavanSql;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;" +
                    "TrustServerCertificate=False;Connection Timeout=30;"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Students", connection);
                    
                }
            }
        }
    }
}