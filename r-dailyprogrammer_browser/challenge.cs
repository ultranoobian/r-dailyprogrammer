using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace r_dailyprogrammer_browser
{
    /// <summary>
    /// Summary of all the possible difficulty types as enumerable integers.
    /// </summary>
    enum Difficulties : int
    {
        Easy = 0, EasyIntermediate = 1, Intermidiate = 2, IntermediateHard = 3, Hard = 4,
    }

    class Challenge
    {
        string title;
        DateTime date;
        int challenge_id;
        Difficulties difficulty;
        string body;

        Challenge(string _title, DateTime _date, int _challenge_id, Difficulties _difficulty, string _body)
        {
            this.title = _title;
            this.date = _date;
            this.challenge_id = _challenge_id;
            this.difficulty = _difficulty;
            this.body = _body;
        }


    }

}
