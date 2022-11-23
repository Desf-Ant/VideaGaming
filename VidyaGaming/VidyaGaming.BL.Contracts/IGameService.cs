using VidyaGaming.DAL;

namespace VidyaGaming.BL.Contracts
{
    public interface IGameService 
    {
        public List<Game> GetAll();

        public List<Game> GetByName(string name);

        public List<Game> GetByDescendingGrade();

        public List<Game> GetByAscendingGrade();

        public List<Game> GetByGrade(float grade);

        public List<Game> GetByType(string type);
        public List<Game> GetByDate(DateOnly date);

        public List<Game> GetByPlatform(string platform);

       
    }
}