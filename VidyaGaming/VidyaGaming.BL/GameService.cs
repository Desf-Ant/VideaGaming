using VidyaGaming.BL.Contracts;
using VidyaGaming.DAL;

namespace VidyaGaming.BL
{
    public class GameService: IGameService
    {
        public GameService()
        {

        }

        public Game Get(string name)
        {
            throw new NotImplementedException();
        }

        public List<Game> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Game> GetByAscendingGrade()
        {
            throw new NotImplementedException();
        }

        public List<Game> GetByDate(DateOnly date)
        {
            throw new NotImplementedException();
        }

        public List<Game> GetByDescendingGrade()
        {
            throw new NotImplementedException();
        }

        public List<Game> GetByGrade(float grade)
        {
            throw new NotImplementedException();
        }

        public List<Game> GetByPlatform(string platform)
        {
            throw new NotImplementedException();
        }

        public List<Game> GetByType(string type)
        {
            throw new NotImplementedException();
        }
    }
}