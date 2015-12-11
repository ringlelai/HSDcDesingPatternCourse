using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.DTO.Behavioral.Interpreter
{
    public enum ChineseUnit
    {
        [DescriptionAttribute("拾")]
        Ten = 1,
        [DescriptionAttribute("佰")]
        Hundred = 2,
        [DescriptionAttribute("仟")]
        Thousand = 3,
        [DescriptionAttribute("萬")]
        TenThousand = 4,
        [DescriptionAttribute("億")]
        HundredMillion = 8,
        [DescriptionAttribute("兆")]
        ThousandBillion = 12
    }

    public enum ChineseNumber
    {
        [DescriptionAttribute("壹")]
        One = 1,
        [DescriptionAttribute("貳")]
        Two = 2,
        [DescriptionAttribute("參")]
        Three = 3,
        [DescriptionAttribute("肆")]
        Four = 4,
        [DescriptionAttribute("伍")]
        Five = 5,
        [DescriptionAttribute("陸")]
        Six = 6,
        [DescriptionAttribute("柒")]
        Seven = 7,
        [DescriptionAttribute("捌")]
        Eight = 8,
        [DescriptionAttribute("玖")]
        Nine = 9,
        [DescriptionAttribute("零")]
        Zero = 0
    }
}
