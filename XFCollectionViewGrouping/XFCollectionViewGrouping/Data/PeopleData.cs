using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace XFCollectionViewGrouping.Data
{

    //public class Rootobject
    //{
    //    public Person[] People { get; set; }
    //}

    //public class Person
    //{
    //    []
    //    public int id { get; set; }
    //    public string first_name { get; set; }
    //    public string last_name { get; set; }
    //    public string email { get; set; }
    //    public string gender { get; set; }
    //    public string ip_address { get; set; }
    //}


    public class Rootobject
    {
        public Person[] People { get; set; }
    }

    public class Person
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("gender")]
        public string Gender { get; set; }
        [JsonPropertyName("ip_address")]
        public string IpAddress { get; set; }
    }


    public class PeopleGroup : List<Person>
    {
        //グループのヘッダに表示するために使う.
        public string LastName { get; private set; }

        public PeopleGroup(string lastName, List<Person> people) : base(people)
        {
            this.LastName = lastName;
        }
    }

}
