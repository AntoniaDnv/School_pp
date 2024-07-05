
using System.Collections.Generic;

namespace singleton
{
   
    public sealed class UserManager
    {
        private UserManager() { }
        private static UserManager instance = null;
        public static UserManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserManager();
                }
                return instance;
            }
        }
        Dictionary<string, int> newProfile = new Dictionary<string, int>();
        public void Registration(string username, int password)
        {
            username = Console.ReadLine();
            password = int.Parse(Console.ReadLine());
           
            newProfile.Add(username, password);
    
        }
        public void Login(string username, int password)
        {
            username = Console.ReadLine();
            password = int.Parse(Console.ReadLine());
            if( newProfile.ContainsKey(username) && newProfile.ContainsValue(password))
            {
                Console.WriteLine($"Wellcome {username}!");
            }
            else
            {
                Console.WriteLine("User not found!");
            }
        }
        public void ProfileManagment(string username, int password)
        {
            Console.WriteLine("What do you want to change in your profile?");
            string command = Console.ReadLine();
            if(command =="change username")
            {
                // change the dictionary key
            }
            if(command =="change password")
            {
                // chnage the dictionary value
            }

        }
    }

}