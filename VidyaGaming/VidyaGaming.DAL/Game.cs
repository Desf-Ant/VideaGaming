using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidyaGaming.DAL
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public float Note { get; set; } 
        public string Genre { get; set; }       
        public List<String> Commentaires { get; set; }
        public Game() { 
        
        }
    }
}
