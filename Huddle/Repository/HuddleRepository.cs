using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Huddle.Models;
using System.Data.Entity;
using System.Data.SqlClient;



namespace Huddle.Repository
{

    public interface IHuddleRepository
    {
        IEnumerable<HuddleModel> Getdata();
    }
    public class HuddleRepository : IHuddleRepository
    {
        public HuddleRepository()
        {

        }

        public IEnumerable<HuddleModel> Getdata()
        {
            var customers = new List<HuddleModel>
            {
                new HuddleModel  {ID=1,Name= "House"},
                new HuddleModel  {ID=2,Name= "Sherlock"},
                new HuddleModel  {ID=3,Name= "Batman"},
                new HuddleModel  {ID=4,Name= "John"},
                new HuddleModel {ID=5,Name = "Jokker"}
            };
            return customers;

        }

    }

}

//    var customers = new List<HuddleModel>
//{
//    new HuddleModel  {ID=1,Name= "Jalpesh"},
//    new HuddleModel {ID=2,Name = "Vishal"}
//};