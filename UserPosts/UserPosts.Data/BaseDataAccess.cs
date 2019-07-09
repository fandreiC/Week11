using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UserPosts.Domain;
using UserPosts.Services;

namespace UserPosts.Data
{
    public abstract class BaseDataAccess<T> : IBaseRepository<T> where T: BaseEntity
    {
        protected abstract string GetFile();

        public IList<T> GetAll()
        {
            string file = this.GetFile();

            var text = File.ReadAllText(file);
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };

            var list = JsonConvert.DeserializeObject<IList<T>>(text, settings);

            return list;
        }

        public T GetById(int id)
        {
            string file = this.GetFile();

            var text = File.ReadAllText(file);
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };

            var list = JsonConvert.DeserializeObject<IList<T>>(text, settings);

            return list.SingleOrDefault(x => x.Id == id);
        }
    }
}
