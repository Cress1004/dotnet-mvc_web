using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_mvc_web.Models;

namespace dotnet_mvc_web.Repository
{
    public interface ILanguageRepository
    {
        Task<int> AddNewLanguage(LanguageModel language);
        Task<List<LanguageModel>> GetLanguages();
    }
}