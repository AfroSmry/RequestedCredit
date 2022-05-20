using ApiOne.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace ApiTwo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public StatusController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                      select Applications.ApplicationNum, Applications.ApplicationDate, Applications.BranchBank, Applications.BranchBankAddr,
                      Applications.CreditManagerId, Applications.FirstName, Applications.MiddleName, Applications.LastName, Applications.CreditType,
                      Applications.RequestedAmount, Applications.RequestedCurrency, Applications.ScoringStatus
                      from dbo.Applications";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("RequestConn");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader); ;

                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }
        
        [HttpGet("{id}")]
        public JsonResult GetById(int id)
        {
            string query = @"
                    select *from dbo.Applications
                    where ApplicationNum = " + id + @" 
                    ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("RequestConn");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader); ;

                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }

        [HttpPut]
        public JsonResult Put(Application app)
        {
            string query = @"
                    update dbo.Applications set 
                    ScoringStatus = '" + app.ScoringStatus + @"'
                    where ApplicationNum = " + app.ApplicationNum + @" 
                    ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("RequestConn");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader); ;

                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Updated Successfully");
        }
    }
}
