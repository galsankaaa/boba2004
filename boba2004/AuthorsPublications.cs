//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace boba2004
{
    using System;
    using System.Collections.Generic;
    
    public partial class AuthorsPublications
    {
        public int id { get; set; }
        public int IdAuthor { get; set; }
        public int idPublication { get; set; }
    
        public virtual Author Author { get; set; }
        public virtual Publication Publication { get; set; }
    }
}