﻿using System;
using System.Collections.Generic;
using System.Text;
using Warsztaty.ViewModel;

namespace Warsztaty.Core.Services
{
    public class ContactService
    {
        public void Add(ContactViewModel contact)
        {
            var toSave = new ContactModel()
            {
                
                CreatedDate =  DateTime.Now,
                Email = contact.Email,
                Name = contact.Name,
                Number = contact.Number,
                Phone = contact.Phone
            };
            //toSave.CreatedDate = DateTime.Now;
            var db = new DataContext();
            db.Add<ContactModel>(toSave);
            db.SaveChanges();
        }
    }
}
