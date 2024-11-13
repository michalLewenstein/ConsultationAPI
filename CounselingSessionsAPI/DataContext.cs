using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace CounselingSessionsAPI
{
    public class DataContext : IDataContext
    {
        public List<Client> Clients { get; set; }
      

        //ctor
        public DataContext()
        {
            Clients = new List<Client> {
                new Client{Id=1,Name="talya",Description="Girl, single", Phon="0585842366",Email="talya@gmail.com"},
                new Client{Id=1,Name="efrat",Description="women, merried", Phon="0589999366",Email="efrat@gmail.com"}
               };
        }
    } 
}
