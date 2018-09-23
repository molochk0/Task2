using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class BoxOfMatches
    {
        public string Manufacturer { get; set; }
        public int Count { get; set; }
        public double Time { get; set; }

        public BoxOfMatches()
        {

        }

        public BoxOfMatches(string Manufacturer, int Count, double Time)
        {
            this.Manufacturer = Manufacturer;
            this.Count = Count;
            this.Time = Time;
        }

        public virtual double Quality()
        {
            return Count * Time;
        }

        public override string ToString()
        {
            return "Данная коробка произведена : " + Manufacturer + ". Количество спичек в коробке: " + Count.ToString() + ". Время горения одной спички: " + Time.ToString() + ". Качество: " + Quality().ToString()+ Environment.NewLine;
        }
    }
}
