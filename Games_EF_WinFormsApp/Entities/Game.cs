using Games_EF_WinFormsApp.Constants;

namespace Games_EF_WinFormsApp.Entities
{
    public class Game
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int CreatorGameId { get; set; }

        public Genre Genre { get; set; }

        public DateTime DateRelease { get; set; }

        public virtual CreatorGame CreatorGame { get; set; } = null!;
    }
}
