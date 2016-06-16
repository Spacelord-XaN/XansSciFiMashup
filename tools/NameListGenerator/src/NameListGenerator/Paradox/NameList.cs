  
using System;
using Pdoxcl2Sharp;
using System.Collections.Generic;

namespace NameListGenerator.Paradox
{
    public partial class NameList : IParadoxRead, IParadoxWrite
    {
        public bool Randomized { get; set; }
        public ShipNames ShipNames { get; set; }
        public FleetNames FleetNames { get; set; }
        public ArmyNames ArmyNames { get; set; }
        public PlanetNames PlanetNames { get; set; }
        public string CharacterNames { get; set; }

        public NameList()
        {
        }

        public void TokenCallback(ParadoxParser parser, string token)
        {
            switch (token)
            {
            case "randomized": Randomized = parser.ReadBool(); break;
            case "ship_names": ShipNames = parser.Parse(new ShipNames()); break;
            case "fleet_names": FleetNames = parser.Parse(new FleetNames()); break;
            case "army_names": ArmyNames = parser.Parse(new ArmyNames()); break;
            case "planet_names": PlanetNames = parser.Parse(new PlanetNames()); break;
            case "character_names": CharacterNames = parser.ReadString(); break;
            }
        }

        public void Write(ParadoxStreamWriter writer)
        {
            writer.WriteLine("randomized", Randomized);
            if (ShipNames != null)
            {
                writer.Write("ship_names", ShipNames);
            }
            if (FleetNames != null)
            {
                writer.Write("fleet_names", FleetNames);
            }
            if (ArmyNames != null)
            {
                writer.Write("army_names", ArmyNames);
            }
            if (PlanetNames != null)
            {
                writer.Write("planet_names", PlanetNames);
            }
            if (CharacterNames != null)
            {
                writer.WriteLine("character_names", CharacterNames);
            }
        }
    }

    public partial class ShipNames : IParadoxRead, IParadoxWrite
    {
        public IList<string> Generic { get; set; }
        public IList<string> Corvette { get; set; }
        public IList<string> Constructor { get; set; }
        public IList<string> Colonizer { get; set; }
        public IList<string> Science { get; set; }
        public IList<string> Destroyer { get; set; }
        public IList<string> Cruiser { get; set; }
        public IList<string> Battleship { get; set; }
        public IList<string> OrbitalStation { get; set; }
        public IList<string> MiningStation { get; set; }
        public IList<string> ResearchStation { get; set; }
        public IList<string> WormholeStation { get; set; }
        public IList<string> TerraformStation { get; set; }
        public IList<string> ObservationStation { get; set; }
        public IList<string> OutpostStation { get; set; }
        public IList<string> TransportStation { get; set; }
        public IList<string> MilitaryStationSmall { get; set; }
        public IList<string> MilitaryStationMedium { get; set; }
        public IList<string> MilitaryStationLarge { get; set; }

        public ShipNames()
        {
        }

        public void TokenCallback(ParadoxParser parser, string token)
        {
            switch (token)
            {
            case "generic": Generic = parser.ReadStringList(); break;
            case "corvette": Corvette = parser.ReadStringList(); break;
            case "constructor": Constructor = parser.ReadStringList(); break;
            case "colonizer": Colonizer = parser.ReadStringList(); break;
            case "science": Science = parser.ReadStringList(); break;
            case "destroyer": Destroyer = parser.ReadStringList(); break;
            case "cruiser": Cruiser = parser.ReadStringList(); break;
            case "battleship": Battleship = parser.ReadStringList(); break;
            case "orbital_station": OrbitalStation = parser.ReadStringList(); break;
            case "mining_station": MiningStation = parser.ReadStringList(); break;
            case "research_station": ResearchStation = parser.ReadStringList(); break;
            case "wormhole_station": WormholeStation = parser.ReadStringList(); break;
            case "terraform_station": TerraformStation = parser.ReadStringList(); break;
            case "observation_station": ObservationStation = parser.ReadStringList(); break;
            case "outpost_station": OutpostStation = parser.ReadStringList(); break;
            case "transport": TransportStation = parser.ReadStringList(); break;
            case "military_station_small": MilitaryStationSmall = parser.ReadStringList(); break;
            case "military_station_medium": MilitaryStationMedium = parser.ReadStringList(); break;
            case "military_station_large": MilitaryStationLarge = parser.ReadStringList(); break;
            }
        }

        public void Write(ParadoxStreamWriter writer)
        {
            if (Generic != null)
            {
                writer.Write("generic={ ");
                foreach (var val in Generic)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (Corvette != null)
            {
                writer.Write("corvette={ ");
                foreach (var val in Corvette)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (Constructor != null)
            {
                writer.Write("constructor={ ");
                foreach (var val in Constructor)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (Colonizer != null)
            {
                writer.Write("colonizer={ ");
                foreach (var val in Colonizer)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (Science != null)
            {
                writer.Write("science={ ");
                foreach (var val in Science)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (Destroyer != null)
            {
                writer.Write("destroyer={ ");
                foreach (var val in Destroyer)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (Cruiser != null)
            {
                writer.Write("cruiser={ ");
                foreach (var val in Cruiser)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (Battleship != null)
            {
                writer.Write("battleship={ ");
                foreach (var val in Battleship)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (OrbitalStation != null)
            {
                writer.Write("orbital_station={ ");
                foreach (var val in OrbitalStation)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (MiningStation != null)
            {
                writer.Write("mining_station={ ");
                foreach (var val in MiningStation)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (ResearchStation != null)
            {
                writer.Write("research_station={ ");
                foreach (var val in ResearchStation)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (WormholeStation != null)
            {
                writer.Write("wormhole_station={ ");
                foreach (var val in WormholeStation)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (TerraformStation != null)
            {
                writer.Write("terraform_station={ ");
                foreach (var val in TerraformStation)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (ObservationStation != null)
            {
                writer.Write("observation_station={ ");
                foreach (var val in ObservationStation)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (OutpostStation != null)
            {
                writer.Write("outpost_station={ ");
                foreach (var val in OutpostStation)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (TransportStation != null)
            {
                writer.Write("transport={ ");
                foreach (var val in TransportStation)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (MilitaryStationSmall != null)
            {
                writer.Write("military_station_small={ ");
                foreach (var val in MilitaryStationSmall)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (MilitaryStationMedium != null)
            {
                writer.Write("military_station_medium={ ");
                foreach (var val in MilitaryStationMedium)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (MilitaryStationLarge != null)
            {
                writer.Write("military_station_large={ ");
                foreach (var val in MilitaryStationLarge)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
        }
    }

    public partial class FleetNames : IParadoxRead, IParadoxWrite
    {
        public IList<string> RandomNames { get; set; }
        public string SequentialName { get; set; }

        public FleetNames()
        {
        }

        public void TokenCallback(ParadoxParser parser, string token)
        {
            switch (token)
            {
            case "random_names": RandomNames = parser.ReadStringList(); break;
            case "sequential_name": SequentialName = parser.ReadString(); break;
            }
        }

        public void Write(ParadoxStreamWriter writer)
        {
            if (RandomNames != null)
            {
                writer.Write("random_names={ ");
                foreach (var val in RandomNames)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (SequentialName != null)
            {
                writer.WriteLine("sequential_name", SequentialName);
            }
        }
    }

    public partial class ArmyNames : IParadoxRead, IParadoxWrite
    {
        public IList<string> Defense { get; set; }
        public IList<string> Assault { get; set; }
        public IList<string> Slave { get; set; }
        public IList<string> Clone { get; set; }
        public IList<string> Robotic { get; set; }
        public IList<string> Android { get; set; }
        public IList<string> Psionic { get; set; }
        public IList<string> Xenomorph { get; set; }
        public IList<string> GeneWarrior { get; set; }

        public ArmyNames()
        {
        }

        public void TokenCallback(ParadoxParser parser, string token)
        {
            switch (token)
            {
            case "defense_army": Defense = parser.ReadStringList(); break;
            case "assault_army": Assault = parser.ReadStringList(); break;
            case "slave_army": Slave = parser.ReadStringList(); break;
            case "clone_army": Clone = parser.ReadStringList(); break;
            case "robotic_army": Robotic = parser.ReadStringList(); break;
            case "android_army": Android = parser.ReadStringList(); break;
            case "psionic_army": Psionic = parser.ReadStringList(); break;
            case "xenomorph_army": Xenomorph = parser.ReadStringList(); break;
            case "gene_warrior_army": GeneWarrior = parser.ReadStringList(); break;
            }
        }

        public void Write(ParadoxStreamWriter writer)
        {
            if (Defense != null)
            {
                writer.Write("defense_army={ ");
                foreach (var val in Defense)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (Assault != null)
            {
                writer.Write("assault_army={ ");
                foreach (var val in Assault)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (Slave != null)
            {
                writer.Write("slave_army={ ");
                foreach (var val in Slave)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (Clone != null)
            {
                writer.Write("clone_army={ ");
                foreach (var val in Clone)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (Robotic != null)
            {
                writer.Write("robotic_army={ ");
                foreach (var val in Robotic)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (Android != null)
            {
                writer.Write("android_army={ ");
                foreach (var val in Android)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (Psionic != null)
            {
                writer.Write("psionic_army={ ");
                foreach (var val in Psionic)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (Xenomorph != null)
            {
                writer.Write("xenomorph_army={ ");
                foreach (var val in Xenomorph)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (GeneWarrior != null)
            {
                writer.Write("gene_warrior_army={ ");
                foreach (var val in GeneWarrior)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
        }
    }

    public partial class PlanetNames : IParadoxRead, IParadoxWrite
    {
        public PlanetClassNameList Generic { get; set; }
        public PlanetClassNameList Desert { get; set; }
        public PlanetClassNameList Arid { get; set; }
        public PlanetClassNameList Tropical { get; set; }
        public PlanetClassNameList Continental { get; set; }
        public PlanetClassNameList Gaia { get; set; }
        public PlanetClassNameList Ocean { get; set; }
        public PlanetClassNameList Tundra { get; set; }
        public PlanetClassNameList Arctic { get; set; }

        public PlanetNames()
        {
        }

        public void TokenCallback(ParadoxParser parser, string token)
        {
            switch (token)
            {
            case "generic": Generic = parser.Parse(new PlanetClassNameList()); break;
            case "pc_desert": Desert = parser.Parse(new PlanetClassNameList()); break;
            case "pc_arid": Arid = parser.Parse(new PlanetClassNameList()); break;
            case "pc_tropical": Tropical = parser.Parse(new PlanetClassNameList()); break;
            case "pc_continental": Continental = parser.Parse(new PlanetClassNameList()); break;
            case "pc_gaia": Gaia = parser.Parse(new PlanetClassNameList()); break;
            case "pc_ocean": Ocean = parser.Parse(new PlanetClassNameList()); break;
            case "pc_tundra": Tundra = parser.Parse(new PlanetClassNameList()); break;
            case "pc_arctic": Arctic = parser.Parse(new PlanetClassNameList()); break;
            }
        }

        public void Write(ParadoxStreamWriter writer)
        {
            if (Generic != null)
            {
                writer.Write("generic", Generic);
            }
            if (Desert != null)
            {
                writer.Write("pc_desert", Desert);
            }
            if (Arid != null)
            {
                writer.Write("pc_arid", Arid);
            }
            if (Tropical != null)
            {
                writer.Write("pc_tropical", Tropical);
            }
            if (Continental != null)
            {
                writer.Write("pc_continental", Continental);
            }
            if (Gaia != null)
            {
                writer.Write("pc_gaia", Gaia);
            }
            if (Ocean != null)
            {
                writer.Write("pc_ocean", Ocean);
            }
            if (Tundra != null)
            {
                writer.Write("pc_tundra", Tundra);
            }
            if (Arctic != null)
            {
                writer.Write("pc_arctic", Arctic);
            }
        }
    }

    public partial class PlanetClassNameList : IParadoxRead, IParadoxWrite
    {
        public IList<string> Names { get; set; }

        public PlanetClassNameList()
        {
        }

        public void TokenCallback(ParadoxParser parser, string token)
        {
            switch (token)
            {
            case "names": Names = parser.ReadStringList(); break;
            }
        }

        public void Write(ParadoxStreamWriter writer)
        {
            if (Names != null)
            {
                writer.Write("names={ ");
                foreach (var val in Names)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
        }
    }

    public partial class CharacterNameList : IParadoxRead, IParadoxWrite
    {
        public int Weight { get; set; }
        public IList<string> FirstNamesMale { get; set; }
        public IList<string> FirstNamesFemale { get; set; }
        public IList<string> SecondNames { get; set; }
        public IList<string> RegnalFirstNamesMale { get; set; }
        public IList<string> RegnalFirstNamesFemale { get; set; }
        public IList<string> RegnalSecondNames { get; set; }

        public CharacterNameList()
        {
        }

        public void TokenCallback(ParadoxParser parser, string token)
        {
            switch (token)
            {
            case "weight": Weight = parser.ReadInt32(); break;
            case "first_names_male": FirstNamesMale = parser.ReadStringList(); break;
            case "first_names_female": FirstNamesFemale = parser.ReadStringList(); break;
            case "second_names": SecondNames = parser.ReadStringList(); break;
            case "regnal_first_names_male": RegnalFirstNamesMale = parser.ReadStringList(); break;
            case "regnal_first_names_female": RegnalFirstNamesFemale = parser.ReadStringList(); break;
            case "regnal_second_names": RegnalSecondNames = parser.ReadStringList(); break;
            }
        }

        public void Write(ParadoxStreamWriter writer)
        {
            writer.WriteLine("weight", Weight);
            if (FirstNamesMale != null)
            {
                writer.Write("first_names_male={ ");
                foreach (var val in FirstNamesMale)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (FirstNamesFemale != null)
            {
                writer.Write("first_names_female={ ");
                foreach (var val in FirstNamesFemale)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (SecondNames != null)
            {
                writer.Write("second_names={ ");
                foreach (var val in SecondNames)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (RegnalFirstNamesMale != null)
            {
                writer.Write("regnal_first_names_male={ ");
                foreach (var val in RegnalFirstNamesMale)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (RegnalFirstNamesFemale != null)
            {
                writer.Write("regnal_first_names_female={ ");
                foreach (var val in RegnalFirstNamesFemale)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
            if (RegnalSecondNames != null)
            {
                writer.Write("regnal_second_names={ ");
                foreach (var val in RegnalSecondNames)
                {
                    writer.Write(val);
                    writer.Write(" ");
                }
                writer.WriteLine("}");
            }
        }
    }

}
