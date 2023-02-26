using Games_EF_WinFormsApp.Constants;
using Games_EF_WinFormsApp.Contexts;
using Games_EF_WinFormsApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace Games_EF_WinFormsApp.Services
{
    public class GameService
    {
        readonly GameContext _context;

        public GameService()
        {
            _context = new();
        }

        public async Task<List<KeyValuePair<string, int>>> GetCreatorGamePairsAsync()
        {
            return await _context.CreatorGames
                .Select(x => new KeyValuePair<string, int>(x.Name, x.Id))
                .ToListAsync();
        }

        public async Task<Game?> GetGameByIdAsync(int id)
        {
            return await _context.Games.FindAsync(id);
        }

        public async Task<List<Game>> GetGamesAsync()
        {
            return await _context.Games.Include(c => c.CreatorGame).ToListAsync();
        }

        public async Task AddGameAsync(string name, int creatorGameId, Genre genre, DateTime dateRelease)
        {
            var game = new Game
            {
                Name = name,
                CreatorGameId = creatorGameId,
                Genre = genre,
                DateRelease = dateRelease
            };

            await _context.AddAsync(game);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteGameAsync(int id)
        {
            var game = await _context.Games.FindAsync(id);
            if (game != null)
            {
                _context.Games.Remove(game);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception(DefaultDB.OBJECT_NOT_FOUND);
            }
        }
    }
}
