using System;
using System.Collections.Generic;
using System.Linq;
using InfoNovitas.LoginSample.Repositories.DatabaseModel;

namespace InfoNovitas.LoginSample.Repositories.Publishers
{
    public class PublisherRepository : IPublisherRepository
    {
        public int Add(Publisher item)
        {
            using (var context = new IdentityExDbEntities())
            {
                var added = context.Publishers.Add(item);
                context.SaveChanges();
                return added.Id;
            }
        }

        public bool Delete(Publisher item)
        {
            using (var context = new IdentityExDbEntities())
            {
                context.Publishers.Remove(item);
                context.SaveChanges();
                return true;
            }
        }

        public List<Publisher> FindAll()
        {
            using (var context = new IdentityExDbEntities())
            {
                return context.Publishers.ToList();
            }
        }

        public Publisher FindBy(int key)
        {
            throw new NotImplementedException();
        }

        public Publisher Save(Publisher item)
        {
            throw new NotImplementedException();
        }
    }
}
