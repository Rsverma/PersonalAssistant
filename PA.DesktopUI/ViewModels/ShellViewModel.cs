using PADesktopUI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PADesktopUI.ViewModels
{
    public class ShellViewModel
    {
        public void GreetUser()
        {
            SpeechHelper.Instance.SpeakGreeting();
        }
    }
}
