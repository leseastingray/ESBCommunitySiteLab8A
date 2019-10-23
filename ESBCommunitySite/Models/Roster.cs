using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESBCommunitySite.Models
{
    public class Roster
    {
        // list for collection of members
        public static List<Member> members = new List<Member>();

        // enable enumeration
        public static IEnumerable<Member> Members
        {
            get
            {
                return members;
            }
        }

        // method to add members to roster
        public static void AddMember(Member member)
        {
            members.Add(member);
        }

        // get array of members (moved from Member.cs; this might not remain
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

        // method to get list of members who play a particular instrument
        public List<Member> GetMemberFromInstrument(string instrument)
        {
            // instatiate list for members who play the instrument
            List<Member> instrumentMembers = new List<Member>();

            foreach (Member m in members)
            {
                if (m.Instrument == instrument)
                {
                    instrumentMembers.Add(m);
                }
            }
            return instrumentMembers;
        }
    }
}
