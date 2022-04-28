using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public CombatRequirement[] Requirements = { //Go by RankEnum,Kills,Ratio
            new CombatRequirement(Attandee.EnuRank.Enlist,0,0), //Enlist
            new CombatRequirement(Attandee.EnuRank.Cadet,4,0.5), //Cadet
            new CombatRequirement(Attandee.EnuRank.Private,4,1), //Private
            new CombatRequirement(Attandee.EnuRank.Corporal,5,1), //Corporal
            new CombatRequirement(Attandee.EnuRank.Sergant,6,1), //Sergeant
            new CombatRequirement(Attandee.EnuRank.Master_Sergeant,7,1), //Master Sergeant
            new CombatRequirement(Attandee.EnuRank.Warrant_Officer,0,0) //Officer Rankings and above
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

                CombatRequirement req = null;

                foreach (CombatRequirement _req in Requirements)
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
        public QuestionModule(string _name, List<Attandee> _at)
            : base(_name, _at)
        {
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
    public class CombatRequirement
    {

        public Attandee.EnuRank Rank { get; private set; }
        public int Kills { get; private set; }
        public double Ratio { get; private set; }

        public CombatRequirement(Attandee.EnuRank _indx, int _kills, double _ratio)
        {
            Rank = _indx;
            Kills = _kills;
            Ratio = _ratio;
        }


    }
}
