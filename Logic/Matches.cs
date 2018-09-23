using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Matches:BoxOfMatches
    {

        public double QualityP { get; set; }

        public Matches(double QualityP, Logic.BoxOfMatches m)
        {
            this.QualityP = QualityP;
            base.Manufacturer = m.Manufacturer;
            base.Count = m.Count;
            base.Time = m.Time;
        }

        public override double Quality()
        {
            return (100 - QualityP) * base.Quality() / 100;
        }
        public override string ToString()
        {
            return "Данная коробка произведена : " + Manufacturer + ". Количество спичек в коробке: " + Count.ToString() + ". Время горения одной спички: " + Time.ToString() + ". Качество: " + Quality().ToString() + Environment.NewLine;
        }
    }
}
