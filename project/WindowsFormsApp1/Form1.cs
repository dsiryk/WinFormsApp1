using System;
using System.Windows.Forms;
using WindowsFormsApp1.Service;
using WindowsFormsApp1.Entity;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Storage storage;
        Shop shop;
        TimerBuff timerBuff;

        public Form1()
        {
            InitializeComponent();
            storage = new Storage();
            shop = new Shop();
            perClickLabel.Text = MessageService.getMult(storage.getClickMultiplier());
            clickCounter.Text = MessageService.getClicks(storage.getClicks());
            button1.BackgroundImage = shop.GetCurrentBackground();
            button1.BackgroundImageLayout = ImageLayout.Stretch;

            timerBuff = new TimerBuff(storage, clickCounter, 5000);
            buyBuff.Text = shop.IsDebuffActive() ? "Зняти дебаф" : "Купити дебаф";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            storage.clickIncrement();
            clickCounter.Text = MessageService.getClicks(storage.getClicks());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (shop.buyNewLevel(storage))
            {
                clickCounter.Text = MessageService.getClicks(storage.getClicks());
                perClickLabel.Text = MessageService.getMult(storage.getClickMultiplier());
                priceLabel.Text = $"Ціна: {shop.getDefaultLevelPrice() * storage.getLevel()}";
            }
            else
            {
                MessageBox.Show("Недостатньо кліків!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buyBuff_Click(object sender, EventArgs e)
        {
            if (shop.buyNewBuff(storage, clickCounter))
            {
                perClickLabel.Text = MessageService.getMult(storage.getClickMultiplier());
                buyBuff.Text = shop.IsDebuffActive() ? "Зняти дебаф" : "Купити дебаф";
            }
            else if (!shop.IsDebuffActive() && storage.getClicks() >= 50)
            {
                storage.clickIncrement(-50);
                timerBuff.Start();
                clickCounter.Text = MessageService.getClicks(storage.getClicks());
                perClickLabel.Text = MessageService.getMult(storage.getClickMultiplier());
                buyBuff.Text = "Баф активний";
                Timer disableTimer = new Timer { Interval = 5000 };
                disableTimer.Tick += (s, ev) => { buyBuff.Text = "Купити дебаф"; disableTimer.Stop(); };
                disableTimer.Start();
            }
            else
            {
                MessageBox.Show("Недостатньо кліків!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (shop.buyNewBack(storage, clickCounter))
            {
                button1.BackgroundImage = shop.GetCurrentBackground();
            }
            else
            {
                MessageBox.Show("Недостатньо кліків!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void perClickLabel_Click(object sender, EventArgs e)
        {
            perClickLabel.Text = MessageService.getMult(storage.getClickMultiplier());
        }
    }
}