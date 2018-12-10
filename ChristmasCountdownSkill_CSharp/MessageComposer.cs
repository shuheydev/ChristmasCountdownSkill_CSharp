using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasCountdownSkill_CSharp
{
    public static class MessageComposer
    {
        public static string ComposeDaysToChristmas(TimeSpan toChristmas, int afterYears)
        {
            string speechText = "";

            var afterYearsJpn = "";
            switch (afterYears)
            {
                case 0:
                    afterYearsJpn = "今年";
                    break;
                case 1:
                    afterYearsJpn = "来年";
                    break;
                case 2:
                    afterYearsJpn = "再来年";
                    break;
                default:
                    afterYearsJpn = $"{afterYears}年後";
                    break;
            }

            speechText += $"{afterYearsJpn}のクリスマスまで、あと、";

            speechText += toChristmas.Days == 0 ? "" : $"{toChristmas.Days}日と";
            speechText += toChristmas.Hours == 0 ? "" : $"{toChristmas.Hours}時間";
            speechText += toChristmas.Minutes == 0 ? "" : $"{toChristmas.Minutes}分";
            speechText += toChristmas.Seconds == 0 ? "" : $"{toChristmas.Seconds}秒";
            speechText += "です。";

            return speechText;
        }
    }
}
