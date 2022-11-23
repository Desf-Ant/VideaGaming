using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using VidyaGaming.BL.Contracts;
using VidyaGaming.DAL;

namespace VidyaGaming.BL
{
    public class FakeGameService : IGameService
    {
        public FakeGameService()
        {

        }
        public Game GetByName(string name)
        {
            var list = this.GetAll();

            return list.FirstOrDefault(a => a.Name == name);
        }

        public List<Game> GetAll()
        {
            return new List<Game>() 
            { 
            new Game() { 
                Id= 1,
                Name = "League of Legend",
                Type = "Moba",
                Platform = "PC",
                Description ="Meilleur jeu du monde",
                ListGrades = new List<float> {20,10},
                AverageGrade = 15,
                Comments = new List<string> {"J'ai tout perdu sur ce jeu mais je continue","jeu trop toxique"},
                Date = new DateOnly(2009,01,01),
                Image = "https://cdn1.dotesports.com/wp-content/uploads/2019/09/12195522/league-of-legends.jpg"
            } ,
            new Game()
            {
                Id= 2,
                Name = "Rocket League",
                Type = "Foot voiture",
                Platform = "Multi",
                Description ="Pire jeu du monde",
                ListGrades = new List<float> {10,0},
                AverageGrade = 5,
                Comments = new List<string> {"incroyablement nul","jeu de merde"},
                Date = new DateOnly(2015,01,01),
                Image = "https://assets2.rockpapershotgun.com/rocket-league-zephyr-crate.jpg/BROK/resize/1920%3E/format/jpg/quality/80/rocket-league-zephyr-crate.jpg"
            }
            };
        }

        public List<Game> GetByAscendingGrade()
        {
            return this.GetAll().OrderBy(a => a.AverageGrade).ToList();
            
        }

        public List<Game> GetByDate(DateOnly date)
        {
            var list = this.GetAll();

            return list.Where(a => a.Date == date).ToList();
        }

        public List<Game> GetByDescendingGrade()
        {
            return this.GetAll().OrderByDescending(a => a.AverageGrade).ToList();
            
        }

        public List<Game> GetByGrade(float grade)
        {
            var list = this.GetAll();

            return list.Where(a => a.AverageGrade == grade).ToList();
        }

        public List<Game> GetByPlatform(string platform)
        {
            var list = this.GetAll();

            return list.Where(a => a.Platform == platform).ToList();
        }

        public List<Game> GetByType(string type)
        {
            var list = this.GetAll();

            return list.Where(a => a.Type == type).ToList();
        }
    }
}
