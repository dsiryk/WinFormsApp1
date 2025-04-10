using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Entity;
using WindowsFormsApp1.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;


namespace WindowsFormsApp1.Service
{
    public class Shop
    {
        private int defaultLevelPrice = 15;
        private int backPrice = 10;
        private int debuffPrice = 25;
        private int currentBackIndex = 0;
        private bool isDebuffActive = false;
        private string[] backgrounds = new string[]
        {
            "чайник_без_фона",
            "чайник_новий_фон"
        };

        public bool buyNewLevel(Storage storage)
        {
            int price = defaultLevelPrice * storage.getLevel();
            if (storage.getClicks() >= price)
            {
                storage.clickIncrement(-price);
                storage.levelUp(); 
                return true;
            }
            return false;
        }

        public bool buyNewBack(Storage storage, Label label)
        {
            if (storage.getClicks() >= backPrice)
            {
                storage.clickIncrement(-backPrice);
                currentBackIndex = (currentBackIndex + 1) % backgrounds.Length;
                label.Text = MessageService.getClicks(storage.getClicks());
                return true;
            }
            return false;
        }

        public bool buyNewBuff(Storage storage, Label label)
        {
            if (!isDebuffActive && storage.getClicks() >= debuffPrice)
            {
                storage.clickIncrement(-debuffPrice);
                storage.setTempMultiplier(0.5f); 
                isDebuffActive = true;
                label.Text = MessageService.getClicks(storage.getClicks());
                return true;
            }
            else if (isDebuffActive && storage.getClicks() >= debuffPrice)
            {
                storage.clickIncrement(-debuffPrice);
                storage.setTempMultiplier(1.0f); 
                isDebuffActive = false;
                label.Text = MessageService.getClicks(storage.getClicks());
                return true;
            }
            return false;
        }

        public Image GetCurrentBackground()
        {
            return (Image)Resources.ResourceManager.GetObject(backgrounds[currentBackIndex]);
        }

        public int getDefaultLevelPrice() => defaultLevelPrice;
        public bool IsDebuffActive() => isDebuffActive;
    }
}