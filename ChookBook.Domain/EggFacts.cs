using ChookBook.Domain.Enums;
using ChookBook.Domain.Enums.Poultry;

namespace ChookBook.Domain
{
    public class EggFacts
    {
        public EggColor Color { get; set; }
        public EggLaying Laying { get; set; }
        public EggSize Size { get; set; }
    }
}