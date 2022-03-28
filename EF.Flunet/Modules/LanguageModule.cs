using EF.DataLayer.Context;
using EF.DataLayer.Entities;

namespace EF.Flunet.Modules
{
    public class LanguageModule : IDisposable
    {
        public readonly EmployeeContext _context;

        public LanguageModule(EmployeeContext context)
        {
            _context = context;
        }

        public void Add(Language language)
        {
            if (language == null)
                throw new ArgumentNullException(nameof(language));
            _context.Language.Add(language);
            Committ();
        }

        public void Edit(Language language)
        {
            if (language == null)
                throw new ArgumentNullException(nameof(language));
            _context.Language.Update(language);
            Committ();
        }

        public void Delete(Language language)
        {
            if (language == null)
                throw new ArgumentNullException(nameof(language));
            _context.Language.Remove(language);
            Committ();
        }

        public Language GetById(int id)
        {
            return _context.Language.Where(x => x.Id == id).FirstOrDefault();
        }

        //get all

        //get by name

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Committ()
        {
            _context.SaveChanges();
        }

    }
}
