using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class DBConnection
    {

        string STRcon = @"Data Source=WIN-PEIQLV7NIPB\SQLEXPRESS;Initial Catalog=hw;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        string STRcmd;

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader readar;

        public DBConnection()
        {
            con = new SqlConnection(STRcon);
        }
        public string ReadItemsTable()
        {
            string res = "";
            STRcmd = "SELECT * FROM TBItem ";
            cmd = new SqlCommand(STRcmd, con);

            try
            {
                con.Open();
                readar = cmd.ExecuteReader();

                while (readar.Read())
                {
                    int code = int.Parse(readar["Code"].ToString());
                    string name = readar["Name"].ToString();
                    string description = readar["Description"].ToString();
                    double price = (double)readar["Price"];
                    Item item = new Item(code, name, description, price);
                    res += item + "\n";
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            { con.Close(); }

            return res;
        }
        public int AddItemToDB(Item item)
        {
            int rowAffect = 0;

            STRcmd = $"INSERT INTO TBItem (Name, Price, Description) VALUES ('{item.Name}', {item.Price}, '{item.Description}')";
            cmd = new SqlCommand(STRcmd, con);

           
            try
            {
                con.Open();
                rowAffect = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return rowAffect;

        }
        public int DeleteItemFronDB(int code)
        {
            int rowAffect = 0;

            STRcmd = $"DELETE FROM TBItem WHERE Code ={code}";
            cmd = new SqlCommand(STRcmd, con);

            try
            {
                con.Open();
                rowAffect = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                con.Close();
            }
            return rowAffect;

        }
    }
}
