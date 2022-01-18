using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilitiesLibrary
{
    /*                      FORM TRANSITION
     
     -this class is responsible for animating launching ang closing form with fade effect.
     -you can customize here their duration.
     
     */

    public class FormTransition
    {
        public async void FadeOutHide(Form current, int interval)
        {
            while (current.Opacity > 0.0)
            {
                await Task.Delay(interval);
                current.Opacity -= .1;
            }
            current.Hide();
        }
        public async void FadeOutDispose(Form current, int interval)
        {
            while (current.Opacity > 0.0)
            {
                await Task.Delay(interval);
                current.Opacity -= .1;
            }
            current.Dispose();
        }
    }
}
