using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using WindowsFormsApp1.Entity;

namespace WindowsFormsApp1.Entity
{
    public class Storage
    {
        private int clicks = 0;
        private int level = 1;
        private float baseClickMultiplier = 1.0f;
        private float tempMultiplier = 1.0f;

        public int getClicks() => clicks;
        public int getLevel() => level;
        public float getClickMultiplier() => baseClickMultiplier * tempMultiplier;

        public void clickIncrement()
        {
            clicks += (int)(1 * getClickMultiplier()); 
        }

        public void clickIncrement(int value)
        {
            clicks += value;
        }

        public void levelUp()
        {
            level++;
            baseClickMultiplier *= 2;
        }

        public void setTempMultiplier(float multiplier)
        {
            tempMultiplier = multiplier;
        }

        public void addBuff(TimerBuff buff) { }
        public void runBuff() {  }
    }
}

