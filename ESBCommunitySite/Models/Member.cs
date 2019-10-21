using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESBCommunitySite.Models
{
    public class Member
    {
        public string Name { get; set; }
        // should this just be a method?
        public string Instrument { get; set; }
        public string DateJoined { get; set; }
        public bool Board { get; set; }
        public bool SectionLeader { get; set; }

        // method to add additional instrument (for members who play 
        //  more than one instrument)
        public static void AddInstrument(string instrument)
        {
            Member.AddInstrument(instrument);
        }

        // get list
        public static Member[] GetMembers()
        {
            Member sCossey = new Member
            {
                Name = "Sherry Cossey",
                Instrument = "clarinet",
                DateJoined = "Septemeber 1978",
                Board = true,
                SectionLeader = true
            };
            Member lBerry = new Member
            {
                Name = "Loren Berry",
                Instrument = "bass trombone" + "euphonium",
                DateJoined = "November 1999",
                Board = false,
                SectionLeader = false
            };
            Member dHolmes = new Member
            {
                Name = "David Holmes",
                Instrument = "trumpet" + "cornet",
                DateJoined = "June 2003",
                Board = true,
                SectionLeader = false
            };
            Member aLese = new Member
            {
                Name = "Amy Lese",
                Instrument = "bass trombone",
                DateJoined = "September 2015",
                Board = true,
                SectionLeader = false
            };
            Member sMaricle = new Member
            {
                Name = "Steve Maricle",
                Instrument = "trumpet" + "cornet",
                DateJoined = "June 2007",
                Board = false,
                SectionLeader = true
            };
            return new Member[] { sCossey, lBerry, dHolmes, aLese, sMaricle };
        }
    }
}
