using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Warsztaty.Core
{
    //nie chcemy słowa model, model jest tylo dla nas
    [Table("Contact")] //raczej powinno się tworzyć schematy pod konkretne modele
    public class ContactModel
    {
        [Key]
        public virtual int Id { get; set; }
        [MaxLength(25)]
        //może też być [Required], ale kontroler powinien to walidować, a nie baza
        public virtual string Name { get; set; }
        public virtual int Number { get; set; }
        public virtual string Email { get; set; }
        public virtual string Phone { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual bool IsActive { get; set; }
    }
}
