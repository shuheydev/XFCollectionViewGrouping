using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using XFCollectionViewGrouping.Data;

namespace XFCollectionViewGrouping.Services
{
    public class DataService
    {
        public static async Task<Person[]> GetPeople()
        {
            var assembly = Assembly.GetExecutingAssembly();
            using var stream = assembly.GetManifestResourceStream("XFCollectionViewGrouping.Data.PeopleData.json");

            var people = await System.Text.Json.JsonSerializer.DeserializeAsync<Person[]>(stream);

            return people;
        }

        private DataService()
        {

        }
    }
}
