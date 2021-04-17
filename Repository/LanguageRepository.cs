using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_mvc_web.Data;
using dotnet_mvc_web.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_mvc_web.Repository
{
    public class LanguageRepository
    {
        private readonly BookStoreContext _context = null;
        public LanguageRepository(BookStoreContext context)
        {
            _context = context;
        }
        public async Task<int> AddNewLanguage(LanguageModel language)
        {
            var newLanguage = new Language()
            {
                Id = language.Id,
                Name = language.Name,
                Description = language.Description
            };
            await _context.Language.AddAsync(newLanguage);
            await _context.SaveChangesAsync();
            return newLanguage.Id;
        }
        public async Task<List<LanguageModel>> GetLanguages()
        {
            return await _context.Language.Select(x => new LanguageModel()
            {
                Id = x.Id,
                Description = x.Description,
                Name = x.Name,
            }).ToListAsync();
        }
    }
}