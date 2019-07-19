using System.Collections.Generic;

namespace BikeDistributor
{
    public class BikeList
    { 
        public Dictionary<string, Bike> bikes = new Dictionary<string, Bike>() {
            { "Defy", new Bike("Giant", "Defy 1", Bike.OneThousand) },
            { "Elite", new Bike("Specialized","Venge Elite", Bike.TwoThousand) },
            { "DuraAce", new Bike("Specialized", "S-Works Venge Dura-Ace", Bike.FiveThousand) },
            { "Vilano", new Bike("Urbana", "Vilano 1", 3500)}
        };
    }
}
