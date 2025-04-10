using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1.Service
{
    public static class MessageService
    {
        public static string getClicks(int clicks) => $"Кліків: {clicks}";
        public static string getMult(float multiplier) => $"Множник: {multiplier:F1}x"; 
    }
}