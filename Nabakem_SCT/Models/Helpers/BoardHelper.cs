using Nabakem_SCT.Models.Domains;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Nabakem_SCT.Models.Helpers
{
    public class BoardHelper : BaseDataAccessHelper
    {
        // 게시물 리스트
        public List<Board> GetAllContents()
        {
            string sql = "NOTICE_LIST_USP";

            SetConnectionString();
            List<Board> bbsList = new List<Board>();
            Board bbs;
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.CommandType = CommandType.StoredProcedure;

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    bbs = new Board();
                    bbs.No = reader[0].ToString();
                    bbs.Category = reader[1].ToString();
                    bbs.Fixed = reader[2].ToString();
                    bbs.Subject = reader[3].ToString();
                    bbs.Author = reader[4].ToString();
                    bbs.Created = reader[5].ToString();
                    bbsList.Add(bbs);
                }
                connection.Close();
            }

            return bbsList;
        }
    }
}