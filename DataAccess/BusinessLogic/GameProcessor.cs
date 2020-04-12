using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.BusinessLogic
{
    public static class GameProcessor
    {
        public static int CreateGame(string name, string game, string map, string args, string connString)
        {
            var data = new
            {
                Name = name,
                Game = game,
                Map = map,
                Args = args
            };

            string sql = @"insert into dbo.GameTable (Name, Game, Map, Args)
                         values (@Name, @Game, @Map, @Args);";
            return SqlDataAccess.ModifyDatabase(sql, data, connString);
        }

        public static int RemoveGame(int id, string connString)
        {
            string sql = @"DELETE FROM dbo.GameTable WHERE Id=@Id;";
            return SqlDataAccess.ModifyDatabase(sql, new { Id = id }, connString);
        }

        public static List<GameModel> LoadGames(string connString)
        {
            string sql = @"select * from dbo.GameTable;";
            return SqlDataAccess.LoadData<GameModel>(sql, connString);
        }
    }
}
