using System;
using System.Collections;
using System.Collections.Generic;

namespace Rentflix.Models
{
    public class AdminVerificator
    {

        // Dummy data. Para testear verificacion de admin
        // ¿ En caso real se guarda en app.db o se accede remotamente de otra manera?
        private static IList administatorsEmails = new List<String>()
        {
            // " Mails pertenecientes a administradores "
            "example_admin1@mail.com",
            "example_admin2@mail.com",
            "example_admin3@mail.com",
            "example_admin4@mail.com",
            // Mail de prueba para probar roles usuario y admin
            //"abc@123.com"
        };



        public AdminVerificator()
        {
        }


        public string getCurrentUserEmail()
        {
            // Consulta por obtencion de correo usuario

            //var id = User.Identity.Name;
            //Console.WriteLine("TEST " + id);
            //Console.WriteLine(id);

            //private UserManager<Cliente> manager;

            //string email = UserManager<Cliente>
            //FindById(User.Identity.Name);

            //string UserEmail = await AspNetUserManager.GetEmailAsync(User.Identity.GetUserId());
            //string e = Membership.GetUser().Email;


            // Mail de prueba. Este seria el correo del usuario actual
            return "abc@123.com";
        }



        public bool isCurrentUserAdmin()
        {
            var userEmail = getCurrentUserEmail();
            var isCurrentUserAdmin = AdminVerificator.administatorsEmails.Contains(userEmail);

            return isCurrentUserAdmin;

        }



    }
}
