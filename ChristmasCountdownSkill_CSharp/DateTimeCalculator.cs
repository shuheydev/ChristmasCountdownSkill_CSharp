using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ChristmasCountdownSkill_CSharp
{
    public static class DateTimeCalculator
    {
        public static TimeSpan ToChristmas(int afterYears)
        {
            var today = DateTimeOffset.UtcNow;

            //return ((new DateTimeOffset(today.Year + afterYears, 12, 25, 0, 0, 0, TimeSpan.FromHours(9.0))) - today);
            var a = ((new DateTimeOffset(today.Year + afterYears, 12, 25, 0, 0, 0, TimeSpan.FromHours(9.0))) - today);
            return a;
        }
    }

    public static class AfterYearConverter
    {
        public static int GetAfterYearsFromJapanese(string afterYearsJpn)
        {
            int afterYears = 0;

            //DateTime構造体を使うと、マシンのローカルタイムが使われるため、正しく時間差が取得できない。
            var today = DateTimeOffset.UtcNow;
            var thisChristmas = new DateTimeOffset(today.Year, 12, 25, 0, 0, 0, TimeSpan.FromHours(9));

            switch (afterYearsJpn)
            {
                case "次":
                    //現在が12月25日0時より前か後かで変わる
                    if (today < thisChristmas)
                    {
                        //クリスマス前
                        afterYears = 0;
                    }
                    else
                    {
                        //クリスマス後
                        afterYears = 1;
                    }
                    break;
                case "次の次":
                    //現在が12月25日0時より前か後かで変わる
                    if (today < thisChristmas)
                    {
                        //クリスマス前
                        afterYears = 1;
                    }
                    else
                    {
                        //クリスマス後
                        afterYears = 2;
                    }
                    break;
                case "来年":
                    afterYears = 1;
                    break;
                case "再来年":
                    afterYears = 2;
                    break;
                default:
                    break;
            }




            return afterYears;
        }
    }
}
