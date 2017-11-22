using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Projekt
{
    class Bruger
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Kodeord { get; set; }
        public static int count = 1;
        //yo yo yo usup man

        public Bruger()
        {
            
        }

        public Bruger(string email, string kodeord)
        {
            Id = count++;
            Email = email;
            Kodeord = kodeord;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Email)}: {Email}";
        }
    }
}
