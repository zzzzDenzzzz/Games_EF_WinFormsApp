namespace Games_EF_WinFormsApp.Entities
{
    public class CreatorGame
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public virtual ICollection<Game> Games { get; set; } = new List<Game>();
    }
}
