using System;
using System.Collections.Generic;

namespace YouFactsSamples
{
    public class YouFactData
    {
        public YouFactData()
        {
        }
        public static IEnumerable<YouFactData> All { private set; get; }
        public string TheFact { get; set; }
        public string ShortFact { get; set; }
        static YouFactData()
        {
            List<YouFactData> all = new List<YouFactData>();
            all.Add(new YouFactData() { TheFact = "I've walked around in an abandoned insane asylum", ShortFact = "asylum" });
            all.Add(new YouFactData() { TheFact = "Im good at badminton", ShortFact = "badminton" });
            all.Add(new YouFactData() { TheFact = "I've been to Mexico", ShortFact = "Mexico" });
            all.Add(new YouFactData() { TheFact = "I want to be a game-designer", ShortFact = "game-designer" });
            all.Add(new YouFactData() { TheFact = "I've never broken a bone", ShortFact = "broken bone" });
            All = all;

        }
    }
}