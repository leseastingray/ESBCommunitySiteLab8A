using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESBCommunitySite.Models
{
    public static class ExtensionMethods
    {
        public static IEnumerable<Member> FilterByInstrument(this IEnumerable<Member> memberEnum, string instrument)
        {
            foreach (Member memb in memberEnum)
            {
                if(memb?.Instrument == instrument)
                {
                    yield return memb;
                }
            }
        }
    }
}
