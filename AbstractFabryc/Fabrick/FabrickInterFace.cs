using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabryc.Fabrick
{
    public interface IDraw //Интерфейс для продуктов
    {
        void Draw(Graphics g, Point location);
    }
    public interface IFigureFabrick //Интерфейс для фабрик
    {
        IDraw CreateFigure(string color, string type);
    }
}
