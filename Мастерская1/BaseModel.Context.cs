//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Мастерская1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class МастерскаяEntities : DbContext
    {
        private static МастерскаяEntities _context;
        public МастерскаяEntities()
            : base("name=МастерскаяEntities")
        {
        }

        public static МастерскаяEntities GetContext()
        {
            if (_context == null)
                _context = new МастерскаяEntities();

            return _context;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Каталог> Каталог { get; set; }
        public virtual DbSet<Клиент> Клиент { get; set; }
    }
}
