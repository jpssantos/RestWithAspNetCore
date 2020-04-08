using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Services
{
    public class LocalMailServices : IMailServices
    {
        private string _mailTo = "joaopaulosama@gmail.com";
        private string _mailFrom = "teste@teste.com";

        public void Send(string subject, string message)
        {
            //send email -output to debug window
            Debug.WriteLine($"Mail from {_mailFrom} to {_mailTo}, with LocalMailService.");
            Debug.WriteLine($"Subject: {subject}");
            Debug.WriteLine($"Message: {message}");
        }
    }
}
