using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SETBHelper
{
    class Training
    {

        public DateTime Date { get; private set; }
        public List<Attandee> Attandees { get; private set; } = new List<Attandee>();
        public List<TrainingModule> TModules { get; private set; } = new List<TrainingModule>();
        public string Host { get; private set; }

        public Training(string _host)
        {
            Host = _host;
            Date = DateTime.Now;
            //DEBUG -- DELETE IN RELEASE
            CombatModule test = new CombatModule("Combat Module",Attandees);
            TModules.Add(test);
        }

        public void AddAttendee(string _input)
        {
            string name = null ;
            Attandee.EnuRank rank = Attandee.EnuRank.Enlist;
            string dname = null;


            string[] splitValues = _input.Split('|');
            for(int i = 0; i < splitValues.Length;i++)
            {
                if (i == 0)
                    name = splitValues[0].Trim();
                if (i == 1)
                    switch(splitValues[1].Trim())
                    {
                        case "Enlist":
                            rank = Attandee.EnuRank.Enlist;
                            break;
                        case "Cadet":
                            rank = Attandee.EnuRank.Cadet;
                            break;
                        case "Private":
                            rank = Attandee.EnuRank.Private;
                            break;
                        case "Corporal":
                            rank = Attandee.EnuRank.Corporal;
                            break;
                        case "Sergant":
                            rank = Attandee.EnuRank.Sergant;
                            break;
                        case "Master Sergeant":
                            rank = Attandee.EnuRank.Master_Sergeant;
                            break;
                        case "Warrant Officer":
                            rank = Attandee.EnuRank.Warrant_Officer;
                            break;
                        default:
                            rank = Attandee.EnuRank.Enlist;
                            break;
                    }
                if (i == 2)
                    dname = splitValues[2].Trim();
                if (i >= 3)
                    Debug.WriteLine($"Overflow in provided AttandeeData at Index:\"{i}\", provided Data:\"{_input}\"");
            }

            Attandee atToAdd = new Attandee(name,rank,dname);

            bool alrAdded = false;
            foreach(Attandee at in Attandees)
            {
                if(at.Name == name)
                {
                    alrAdded = true;
                }
            }

            if (!alrAdded)
            {
                Attandees.Add(atToAdd);
                MessageBox.Show($"Adding Attendee with Data: {name} {rank} {dname}");
            }
        }

        public void AddAttendee(string _name, Attandee.EnuRank _rank, string _dname)
        {
            Attandee atToAdd = new Attandee(_name, _rank, _dname);

            bool alrAdded = false;
            foreach (Attandee at in Attandees)
            {
                if (at.Name == _name)
                {
                    alrAdded = true;
                }
            }

            if (!alrAdded)
                Attandees.Add(atToAdd);
        }

        public void RemoveAttendee(Attandee _at)
        {
            if(Attandees.Contains(_at))
            {
                Attandees.Remove(_at);
            }
        }

        public void AddModule(TrainingModule tm)
        {
            TModules.Add(tm);
        }
        public void RemoveModule(TrainingModule tm)
        {
            TModules.Remove(tm);
        }

        public string GiveResults()
        {
            List<FinalResult> results = new List<FinalResult>();

            //Calculate Results
            foreach(TrainingModule m in TModules)
            {
                foreach(int i in m.PassedAttendees)
                {
                    bool alrHasRes = false;
                    foreach(FinalResult r in results)
                    {
                        if(r.ATIndex == i)
                        {
                            alrHasRes = true;
                            r.AddScore();
                        }                       
                    }
                    if(!alrHasRes)
                    {
                        FinalResult res = new FinalResult(i);
                        results.Add(res);
                    }
                }
            }
            //Give out String to Copy

            string output = null;

            output += "Attendees that have passed:\n";

            foreach(FinalResult fr in results)
            {
                output += $"@{Attandees[fr.ATIndex].Name} - {fr.Score}TP\n";
            }

            return output;
        }
    }

    class FinalResult
    {
        public int ATIndex { get; private set; }
        public double Score { get; private set; } = 0.5;

        public FinalResult(int _atIndx)
        {
            ATIndex = _atIndx;
        }

        public void AddScore()
        {
            Score += 0.5;
        }
    }
}
