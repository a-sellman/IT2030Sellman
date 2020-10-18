using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _8_1.Models
{
    public class Destination
    {
        public string AccomodationEmail { get; set; }

        public string AccomodationName { get; set; }

        public string AccomodationPhone { get; set; }

        [Required(ErrorMessage = "Please Enter An End Date")]
        public int EndDate { get; set; }

        [Required(ErrorMessage = "Please Enter A Start Date")]
        public int StartDate { get; set; }

        public string ThingToDo1 { get; set; }
        public string ThingToDo2 { get; set; }
        public string ThingToDo3 { get; set; }

        [Required(ErrorMessage = "Please Enter A Destination.")]
        [Key]
        public string TripID { get; set; }
    }

    /*   public void Button1_Click(object sender, EventArgs e)

      {
          string TripID = TripID.Text.ToString();
          string AccomodationName = AccomodationName.Text.ToString();
          string AccomodationEmail = AccomodationEmail.Text.ToString();
          string AccomodationPhone = AccomodationPhone.Text.ToString();
          string ThingToDo1 = ThingToDo1.Text.ToString();
          string ThingToDo2 = ThingToDo2.Text.ToString();
          string ThingToDo3 = ThingToDo3.Text.ToString();
          string StartDate = StartDate.Text.ToString();
          string EndDate = EndDate.Text.ToString();

          try
          {
              using (var conn = new SqlConnection())
              {
                  conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                  conn.Open();

                  var insertCommand = new SqlCommand("INSERT INTO [Destination] (TripID, AccomodationName, AccomodationEmail, AccomodationPhone, ThingToDo1, ThingToDo2, ThingToDo3, StartDate, EndDate) VALUES (@TripID, @AccomodationName, @AccomodationEmail, @AccomodationPhone, @StartDate, @EndDate, @ThingToDo1, @ThingToDo2, @ThingToDo3); ", conn);

                  insertCommand.Parameters.Add(new SqlParameter("TripID", TripID));
                  insertCommand.Parameters.Add(new SqlParameter("StartDate", StartDate));
                  insertCommand.Parameters.Add(new SqlParameter("EndDate", EndDate));
                  insertCommand.Parameters.Add(new SqlParameter("AccomodationEmail", AccomodationEmail));
                  insertCommand.Parameters.Add(new SqlParameter("AccomodationPhone", AccomodationPhone));
                  insertCommand.Parameters.Add(new SqlParameter("AccomodationName", AccomodationName));
                  insertCommand.ExecuteNonQuery();
                  conn.Close();
                  Page.ClientScript.RegisterStartupScript(this.GetType(), "close", "<script language=javascript>window.opener.location.reload(true);self.close();</script>");
              }
          }
          catch (Exception ex)
          {
              throw ex;
          }
      }
    */
}