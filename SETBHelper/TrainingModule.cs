using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SETBHelper
{
    public class TrainingModule
    {

        public string Name { get; private set;}
        public List<Attandee> Attandees = new List<Attandee>();
        public string Notes = "";
        public List<int> PassedAttendees { get; private set; } = new List<int>();

        public TrainingModule(string _name, List<Attandee> _at)
        {
            Name = _name;
            Attandees = _at;
        }

    }

    public class CombatModule : TrainingModule
    {

        public Requirement[] Requirements = { //Go by RankEnum,Kills,Ratio
            new Requirement(Attandee.EnuRank.Enlist,0,0), //Enlist
            new Requirement(Attandee.EnuRank.Cadet,4,0.5), //Cadet
            new Requirement(Attandee.EnuRank.Private,4,1), //Private
            new Requirement(Attandee.EnuRank.Corporal,5,1), //Corporal
            new Requirement(Attandee.EnuRank.Sergant,6,1), //Sergeant
            new Requirement(Attandee.EnuRank.Master_Sergeant,7,1), //Master Sergeant
            new Requirement(Attandee.EnuRank.Warrant_Officer,0,0) //Officer Rankings and above
        };

        public List<CombatResult> CmbtResults = new List<CombatResult>();


        public CombatModule(string _name, List<Attandee> _at)
            :base(_name,_at)
        {
        }

        public void SetResult(int _ATIndex, int _kills, int _deaths)
        {
            bool alrAdded = false;
            foreach(CombatResult cr in CmbtResults)
            {
                if (cr.ATIndex == _ATIndex)
                {
                    alrAdded = true;
                    cr.Kills = _kills;
                    cr.Deaths = _deaths;
                }
            }

            if(!alrAdded)
            {
                CombatResult cmbtRes = new CombatResult(_ATIndex, _kills, _deaths);
                CmbtResults.Add(cmbtRes);
            }
        }

        public void CalculateResults()
        {
            PassedAttendees.Clear();

            foreach(CombatResult cr in CmbtResults)
            {
                double ratio = cr.Kills / cr.Deaths;
                Attandee at = null;

                for(int i = 0; i < Attandees.Count;i++)
                {
                    if(cr.ATIndex == i)
                    {
                        at = Attandees[i];
                    }
                }

                Requirement req = null;

                foreach (Requirement _req in Requirements)
                {
                    if(_req.Rank == at.Rank)
                    {
                        req = _req;
                    }
                }
                
                if(ratio >= req.Ratio && cr.Kills >= req.Kills)
                {
                    PassedAttendees.Add(cr.ATIndex);
                }

            }
        }


    }

    public class SimulationModule : TrainingModule
    {
        
        public SimulationModule(string _name, List<Attandee> _at)
            : base(_name, _at)
        {
        }

        public void TogglePassed(int _ATIndex)
        {
            if(!PassedAttendees.Contains(_ATIndex))
            {
                PassedAttendees.Add(_ATIndex);
            }
            else
            {
                PassedAttendees.Remove(_ATIndex);
            }
        }
    }

    public class QuestionModule : TrainingModule
    {

        private string sString = "##SWYgeW91IHNhdyBhIGJyZWFjaGVkIEhDWiBvciBMQ1ogU0NQLCB3aGF0IGFyZSB0aGUgcmVxdWlyZW1lbnRzIGZvciB5b3UgdG8gcmUtY29udGFpbiBpdD8gDQpJZiB5b3Ugc2F3IGEgQ0QgZ29pbmcgaW50byBIQ1osIHdoYXQgcmFuayBpcyBuZWVkZWQgdG8gcHVyc3VlIHRoZSBDRD8gDQpXaGF0IGRvIHlvdSBkbyBpZiBhbiBGUCBmYWlscyB0byBwcm92aWRlIElEPyANCldoYXQgZG8geW91IGRvIHdoZW4gYW4gU0QgYnJlYWtzIHRoZSBnZW5lcmFsIGd1aWRlbGluZXM/IA0KSWYgYSBDRCBtZW51cyBvciBsZWZ0IHRoZSBnYW1lIHdoaWxlIHlvdSB3ZXJlIGN1ZmZpbmcgaGltLCB3aGF0IHdvdWxkIGRvIGlmIHRoZXkgam9pbiBiYWNrPyANCklmIGEgQ0Qgd2FzIG9uIHRoZSB0ZXJtaW5hdGlvbiBsaW5lLCB3aGF0IGZvcm0gb2Ygbm9uLWxldGhhbCBwdW5pc2htZW50IHdvdWxkIHlvdSB1c2U/IA0KSWYgeW91IHNhdyBhIEwwIHRoYXQgd2FuZGVyZWQgaW50byBMQ1osIHdoYXQgd291bGQgeW91IGRvPyANCklmIHlvdSBzYXcgYSBDRCBnb2luZyB1cCB0byB0aGUgY29tcG91bmQgc3VyZmFjZSwgd2hhdCBhcmUgdGhlIHJlcXVpcmVtZW50cyBmb3IgeW91IHRvIHB1cnN1ZT8gIA==##";
        private string hString = "##V2hhdCByYW5rIGFuZCBGb3VuZGF0aW9uIGxldmVsIGFyZSByZXF1aXJlZCBmb3IgeW91IHRvIGV4aXQgdGhlIHNpdGUgdG8gdGhlIGNvbXBvdW5kIHN1cmZhY2U/IA0KSG93IG11Y2ggdGltZSBkbyB5b3UgU0MgYSBDRCB0aGF0IGlzIGV2YWRpbmcgU0M/IA0KTGlzdCB0aHJlZSBjaXJjdW1zdGFuY2VzIHRoYXQgd2FycmFudCB0aGUgdGVybWluYXRpb24gb2YgRm91bmRhdGlvbiBTdGFmZj8NClVuZGVyIHdoYXQgY2lyY3Vtc3RhbmNlcyBjYW4geW91IHJlY29udGFpbiBhbiBTQ1AgZnJvbSBlaXRoZXIgTENaIG9yIEhDWj8NCldoZW4gY2FuIGh1bXZlZXMgYmUgdXNlZD8NCldoZW4gc2hvdWxkIGJhdG9ucyAmIHNsZWRnZWhhbW1lcnMgYmUgdXNlZD8NCldoZW4gY2FuIGRldGFpbiBiZSB1c2VkPw0KV2hlbiBzaG91bGQgYSBDRCBiZSBTQ2VkIGZvciA1IG1pbnV0ZXM/DQpXaGVuIHNob3VsZCBhIENEIGJlIFNDZWQgZm9yIDEwIG1pbnV0ZXM/DQpXaGVuIHNob3VsZCBhIENEIGJlIFNDZWQgZm9yIDE1IG1pbnV0ZXM/DQpXaGVuIHNob3VsZCBhIENEIGJlIHNjZWQgZm9yIDIwIG1pbnV0ZXM/DQpXaGVuIGNhbiBkZXBhcnRtZW50IG1lbWJlcnMgZW50ZXIgSENaPw0KV2hhdCBpdGVtcyBhcmUgY29uc2lkZXJlZCBjb250cmFiYW5kPw0KV2hhdCByYW5rIGlzIHJlcXVpcmVkIHRvIHRyYW5zcG9ydCBIQ1ogYW5kIFNIQ1ogdGVzdHM/IA==##";
        private string pString = "##V2hhdCBpcyBtYXggbnVtYmVyIG9mIGNvbWJhdGl2ZSBwZXJzb25uZWwgYXQgQ0RDWiB1bmRlciBub3JtYWwgY2lyY3Vtc3RhbmNlcz8gDQpXaGF0IGlzIHRoZSBwcmltYXJ5IGNvbWJhdGl2ZSBmb3JjZSBpbiB0aGUgQ0RDWj8NCldoYXQgaXMgdGhlIHByaW1hcnkgY29tYmF0aXZlIGZvcmNlIGluIHRoZSBMQ1o/DQpXaGF0IGlzIHRoZSBwcmltYXJ5IGNvbWJhdGl2ZSBmb3JjZSBpbiB0aGUgRVo/DQpXaGF0IGlzIHRoZSBwcmltYXJ5IGNvbWJhdGl2ZSBmb3JjZSBpbiB0aGUgSENaPw0KV2hhdCBpcyB0aGUgcHJpbWFyeSBjb21iYXRpdmUgZm9yY2UgaW4gdGhlIFNIQ1o/DQpXaGF0IGlzIHRoZSBwcmltYXJ5IGNvbWJhdGl2ZSBmb3JjZSBvbiBTdXJmYWNlPw0KRGVmaW5lIEZQQ09OIE5PUk1BTC4NCkRlZmluZSBGUENPTiBBTFBIQS4NCkRlZmluZSBGUENPTiBCUkFWTy4NCkRlZmluZSBGUENPTiBDSEFSTElFLg0KV2hhdCByYW5rIGNhbiBjYWxsIG9mZiBwYXRyb2xzPw0KV2hhdCByYW5rcyBjYW4gcGFydGFrZSBpbiBwYXRyb2xzPw0KV2hhdCByYW5rIGNhbiBsZWFkIGEgc3VyZmFjZSBwYXRyb2wgd2hlbiBNVEYgYXJlIGFic2VudD8NCldoYXQgcmFua3MgY2FuIHBhcnRha2UgaW4gc3VyZmFjZSBwYXRyb2xzPw0KQ2FuIHBhdHJvbHMgdmVudHVyZSBwYXN0IHRoZSBib29tZ2F0ZT8NCldoYXQgR09DIHJhbmsgd291bGQgbGVhZCBhIHBhdHJvbD8NCldoYXQgd291bGQgeW91IHNheSBpbiByYWRpbyB3aGVuIGFubm91bmNpbmcgYSBwYXRyb2w/##";
        private string aString = "####";

        private List<string> sList = new List<string>();
        private List<string> hList = new List<string>();
        private List<string> pList = new List<string>();
        private List<string> aList = new List<string>();
        private List<List<string>> totalLists = new List<List<string>>(); // <== THIS IS CARNAGE

        private List<int> lastS = new List<int>();
        private List<int> lastH = new List<int>();
        private List<int> lastP = new List<int>();
        private List<List<int>> totalLasts = new List<List<int>>(); // <== THIS IS CARNAGE

        public int NeededQuestionCount = 10;
        public int PerCount = 2;
        public bool OverfillPerCount = true;

        public Requirement[] Requirements = { //Go by RankEnum,Needed Right,Out of Total
            new Requirement(Attandee.EnuRank.Enlist,0,0), //Enlist
            new Requirement(Attandee.EnuRank.Cadet,5,10), //Cadet
            new Requirement(Attandee.EnuRank.Private,6,10), //Private
            new Requirement(Attandee.EnuRank.Corporal,7,10), //Corporal
            new Requirement(Attandee.EnuRank.Sergant,8,10), //Sergeant
            new Requirement(Attandee.EnuRank.Master_Sergeant,9,10), //Master Sergeant
            new Requirement(Attandee.EnuRank.Warrant_Officer,0,0) //Officer Rankings and above
        };

        public List<QuestionResult> correctQuestions = new List<QuestionResult>();

        public QuestionModule(string _name, List<Attandee> _at)
            : base(_name, _at)
        {
            GenLists();
        }

        private void GenLists()
        {
            sList = (Encoding.UTF8.GetString(Convert.FromBase64String(sString.Remove(sString.Length - 2, 2).Remove(0, 2)))).Split('\n').ToList<string>();
            hList = (Encoding.UTF8.GetString(Convert.FromBase64String(hString.Remove(hString.Length - 2, 2).Remove(0, 2)))).Split('\n').ToList<string>();
            pList = (Encoding.UTF8.GetString(Convert.FromBase64String(pString.Remove(pString.Length - 2, 2).Remove(0, 2)))).Split('\n').ToList<string>();
            totalLists.Add(sList);
            totalLists.Add(hList);
            totalLists.Add(pList);

            totalLasts.Add(lastS);
            totalLasts.Add(lastH);
            totalLasts.Add(lastP);
        }


        public string GiveQuestions()
        {
            string output = "";
            int totalCount = 1;
            int totalRetrys = 0;

            Random perRandom = new Random();
            Random catRandom = new Random();

            //Fill min Req

            for(int i = 0; i<totalLists.Count;i++)
            {
                for(int x = 0; x <= PerCount;x++)
                {
                    int randm = perRandom.Next(0, totalLists[i].Count);
                    while(totalLasts[i].Contains(randm) && totalRetrys < 20)
                    {
                        randm = perRandom.Next(0, totalLists[i].Count);
                        totalRetrys++;
                    }
                    totalRetrys = 0;
                    totalLasts[i].Add(randm);
                    output += $"{totalCount}) {totalLists[i][randm]}\n\n";
                    totalCount++;
                    
                }

            }

            //Overfill

            if(OverfillPerCount)
            {    
                while(totalCount <= NeededQuestionCount)
                {
                    int randmcat = catRandom.Next(0, totalLists.Count);
                    int randm = perRandom.Next(0, totalLists[randmcat].Count);
                    while (totalLasts[randmcat].Contains(randm) && totalRetrys < 20)
                    {
                        randm = perRandom.Next(0, totalLists[randmcat].Count);
                        totalRetrys++;
                    }
                    totalRetrys = 0;
                    totalLasts[randmcat].Add(randm);
                    output += $"{totalCount}) {totalLists[randmcat][randm]}\n\n";
                    totalCount++;
                }                

            }

            return output;
        }

        public void CalculateResults()
        {
            PassedAttendees.Clear();
            foreach(Attandee at in Attandees)
            {
                int gotRight = 0;
                foreach(QuestionResult res in correctQuestions)
                {
                    if(res.ATIndex == Attandees.IndexOf(at))
                    {
                        gotRight++;
                    }
                }

                Requirement req = null;
                foreach(Requirement _req in Requirements)
                {
                    if(_req.Rank == at.Rank)
                    {
                        req = _req;
                    }
                }

                if(gotRight >= req.Kills)
                {
                    PassedAttendees.Add(Attandees.IndexOf(at));
                }
            }

        }


    }

    public class RecontainmentModule : SimulationModule
    {
        public RecontainmentModule(string _name, List<Attandee> _at)
            : base(_name, _at)
        {
        }


    }

    public class CombatResult
    {

        public int ATIndex { get; private set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }

        public CombatResult(int _ATindx,int _kills,int _deaths)
        {
            ATIndex = _ATindx;
            Kills = _kills;
            Deaths = _deaths;
        }


    }
    public class Requirement
    {

        public Attandee.EnuRank Rank { get; private set; }
        public int Kills { get; private set; }
        public double Ratio { get; private set; }

        public Requirement(Attandee.EnuRank _indx, int _kills, double _ratio)
        {
            Rank = _indx;
            Kills = _kills;
            Ratio = _ratio;
        }


    }

    public class QuestionResult
    {

        public int ATIndex { get; private set; }
        public int QuestionIndex { get; private set; }


        public QuestionResult(int _atIndex, int _questionIndex)
        {
            ATIndex = _atIndex;
            QuestionIndex = _questionIndex;
        }


    }


}
