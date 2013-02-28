using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DegreePlanner
{
    static class sqlQuery
    {
        static private string connectionString = "Server=instance39020.db.xeround.com;Port=6887;Database=csv_db;Uid=admin;Pwd=password";     

        static public List<Course> getAllCoursesFromTable(String tableName)
        {
            List<Course> courses = new List<Course>();
            MySqlConnection con = new MySqlConnection(connectionString);
            string query = "SELECT * FROM `" + tableName + "`";
            MySqlCommand cmd = new MySqlCommand(query);
            MySqlDataReader reader = null;
            string result = null;
            con.Open();
            cmd.Connection = con;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result = reader.GetString(0) + " " + reader.GetString(1) + '\n';
                Course addCourse = new Course(reader.GetString(0), reader.GetInt32(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4));
                courses.Add(addCourse);
            }
            con.Close();
            return courses;
        }

        static public Course getCourseByDeptCourseNum(MySqlConnection con, string dept, string courseNum)
        {
            Course rvalue = new Course();
           // MySqlConnection con = new MySqlConnection(connectionString);
            string query = "SELECT * FROM `classes` WHERE Department = \"" + dept + "\" AND Course_Num = " + courseNum;
            MySqlCommand cmd = new MySqlCommand(query);
            MySqlDataReader reader = null;
            string result = null;
         //   con.Open();
            cmd.Connection = con;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                rvalue = new Course(reader.GetString(0), reader.GetInt32(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4));
            }
         //   con.Close();
            reader.Close();
            return rvalue;
        }

        static public MySqlConnection sqlConnect()
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            return con;
        }

        static public void sqlClose(MySqlConnection con)
        {
            con.Close();
            return;
        }


    }
}
