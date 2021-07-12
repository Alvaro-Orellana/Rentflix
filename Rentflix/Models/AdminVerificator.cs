using System;
using System.Collections;
using System.Collections.Generic;

namespace Rentflix.Models
{
    public class AdminVerificator
    {

        // Dummy data. Lista para testear verificacion de admin
        // En caso real se guarda en bd o se accede de otra manera?
        private static IList administatorsEmails = new List<String>()
        {
            "example_admin1@mail.com",
            "example_admin2@mail.com",
            "example_admin3@mail.com",
            "example_admin4@mail.com"
        };



        public AdminVerificator()
        {
        }


        public string getCurrentUserEmail()
        {
            //var id = User.Identity.Name;
            //Console.WriteLine("TEST " + id);
            //Console.WriteLine(id);

            //private UserManager<Cliente> manager;

            //string email = UserManager<Cliente>
            //FindById(User.Identity.Name);


            //string UserEmail = await AspNetUserManager.GetEmailAsync(User.Identity.GetUserId());
            //string e = Membership.GetUser().Email;
            return "";
        }



        public bool isCurrentUserAdmin()
        {
            var userEmail = getCurrentUserEmail();
            if(AdminVerificator.administatorsEmails.Contains(userEmail))
            {
                return false;
            } else
            {
                return false;
            }

        }



    }
}
