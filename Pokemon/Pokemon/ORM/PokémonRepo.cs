using Dapper;
using Pokemon.Models;
using StockLister.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.ORM
{
    public class PokémonRepo:SqlLiteBaseRepository
    {
        public PokémonRepo()
        {
            if (!DatabaseExists())
            {
                CreateDatabase();
            }
        }
        public int FavoritePokémon(FavoritePokémons favoritePokémon)
        {
            string sql = "INSERT OR IGNORE INTO Favorite (Name) Values (@name);";

            using (var connection = DbConnectionFactory())
            {
                connection.Open();
                return connection.Execute(sql, favoritePokémon);
            }
        }

        public int DeleteFavo(string basename)
        {
            string sql = "DELETE FROM Favorite WHERE name = @name;";

            using (var connection = DbConnectionFactory())
            {
                connection.Open();
                return connection.Execute(sql, new { name = basename });
            }
        }

        public IEnumerable<FavoritePokémons> GetFavorites()
        {
            string sql = "SELECT * FROM Favorite;";

            using (var connection = DbConnectionFactory())
            {
                return connection.Query<FavoritePokémons>(sql);
            }
        }
    }
}
