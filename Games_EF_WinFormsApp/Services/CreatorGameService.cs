using Games_EF_WinFormsApp.Constants;
using Games_EF_WinFormsApp.Contexts;
using Games_EF_WinFormsApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace Games_EF_WinFormsApp.Services
{
    public class CreatorGameService
    {
        readonly GameContext _context;

        public CreatorGameService()
        {
            _context = new();
        }

        public async Task<List<CreatorGame>> GetCreatorGamesAsync()
        {
            return await _context.CreatorGames.ToListAsync();
        }

        public async Task<CreatorGame?> GetCreatorGameByIdAsync(int id)
        {
            return await _context.CreatorGames.FindAsync(id);
        }

        public async Task AddCreatorGameAsync(string name)
        {
            var creator = new CreatorGame
            {
                Name = name,
            };

            await _context.AddAsync(creator);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCreatorGameAsync(int id)
        {
            var creator = await _context.CreatorGames.FindAsync(id);
            if (creator != null)
            {
                if (creator.Games != null && creator.Games.Any())
                {
                    throw new Exception(DefaultDB.DELETION_IS_NOT_POSSIBLE);
                }

                _context.Remove(creator);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception(DefaultDB.OBJECT_NOT_FOUND);
            }
        }
    }
}
