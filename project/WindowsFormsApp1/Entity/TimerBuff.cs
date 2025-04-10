using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using WindowsFormsApp1.Service;

namespace WindowsFormsApp1.Entity
{
    public class TimerBuff
    {
        public Storage storage;
        public Label label;
        public System.Windows.Forms.Timer timer;
        public int duration;

        public TimerBuff(Storage storage, Label label, int duration)
        {
            this.storage = storage;
            this.label = label;
            this.duration = duration;
            this.timer = new System.Windows.Forms.Timer();
            this.timer.Interval = duration;
            this.timer.Tick += Timer_Tick;
        }

        public void Start()
        {
            storage.setTempMultiplier(2.0f); 
            timer.Start();
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            storage.setTempMultiplier(1.0f); 
            timer.Stop();
            label.Text = MessageService.getClicks(storage.getClicks());
        }
    }
}