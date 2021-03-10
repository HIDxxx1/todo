using MetroFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroSample.Helpers
{
   public sealed class ColorDto
    {
        public ColorDto(MetroColorStyle metroColorStyle)
        {
            Value = metroColorStyle;
        }

        public MetroColorStyle Value { get; }

        public string DisplayValue => Value.ToString();
    }
}
