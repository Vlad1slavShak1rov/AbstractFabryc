using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabryc.Fabrick
{
    public class FigureFactory : IFigureFabrick
    {
        public IDraw CreateFigure(string color, string type)
        {
            Color c = color.ToLower() switch
            {
                "синий" => Color.Blue,
                "красный" => Color.Red,
                _ => Color.Black,
            };

            return new Figure(c, type);
        }
    }   
}
