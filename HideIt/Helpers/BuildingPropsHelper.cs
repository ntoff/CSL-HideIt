﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace HideIt
{
    public static class BuildingPropsHelper
    {
        public static readonly string[] FLAGS = { "flag_pole", "flag_pole_wall" };

        public static readonly string[] ADS = {
            "cityad01",
            "roofad01",
            "roofad02",
            "roofad03",
            "roofad04",
            "roofad05",
            "roofad06",
            "roofad07",
            "roofad08",
            "roofad09",
            "roofad10",
            "roofad11",
            "roofad12",
            "sliding_ad01",
            "sliding_ad02",
            "street_ad01",
            "street_ad02",
            "street_ad03",
            "street_ad04",
            "street_ad05",
            "street_ad06",
            "street_ad07",
            "wall_ad01",
            "wall_ad02",
            "wall_ad03",
            "wall_ad04",
            "wall_ad05",
            "wall_ad06" };

        public static readonly string[] BILLBOARDS = {
            "Hologram Ad Game Arcade",
            "Clown",
            "Octopus",
            "Rotating_morelloscone",
            "Rotating_squirrel",
            "Billboard Large Variation 01",
            "Billboard Medium Variation 01",
            "Billboard_3D_variation",
            "Billboard_big_bigbite",
            "billboard_big_Fallout",
            "billboard_big_Fallout_01",
            "billboard_big_Furniture",
            "billboard_big_Furniture_01",
            "billboard_big_Furniture_03",
            "Billboard_big_go_nuts",
            "Billboard_big_jubilee",
            "Billboard_big_popsoda_02",
            "billboard_big_realestate_01",
            "billboard_big_Sparkly_01",
            "Billboard_big_variation",
            "Billboard_big_variation_01",
            "Billboard_big_variation_02",
            "Billboard_big_variation_03",
            "Billboard_big_variation_04",
            "Billboard_big_yakisoba_02",
            "Billboard_big_yaxu_01",
            "Billboard_big_yaxu_03",
            "Billboard_critter_anim",
            "Billboard_lehto_anim",
            "Billboard_medium_flat_bigbite_01",
            "Billboard_medium_flat_bigbite_02",
            "Billboard_medium_flat_go_nuts_01",
            "Billboard_medium_flat_go_nuts_02",
            "Billboard_medium_flat_variation_01",
            "Billboard_pop_soda_anim",
            "billboard_pylon",
            "Billboard_silky_anim",
            "Billboard_small_go_nuts_01",
            "Billboard_small_go_nuts_02",
            "Billboard_small_go_nuts_03",
            "Billboard_small_lehto_01",
            "Billboard_small_lehto_02",
            "Billboard_small_lehto_03",
            "Billboard_small_meaty_01",
            "Billboard_small_meaty_02",
            "Billboard_small_meaty_03",
            "Billboard_small_nightwatch_01",
            "Billboard_small_nightwatch_02",
            "Billboard_small_nightwatch_03",
            "Billboard_small_silky_01",
            "Billboard_small_silky_02",
            "Billboard_small_silky_03",
            "Billboard_small_variation_01",
            "Billboard_small_variation_02",
            "Billboard_small_variation_03",
            "billboard02",
            "Hightech Industrial Medium Billboard Random",
            "Hightech Industrial Small Billboard 01",
            "Hightech Industrial Small Billboard 02",
            "Hightech Industrial Small Billboard 03",
            "Hightech Industrial Small Billboard 04",
            "Hightech Industrial Small Billboard Random",
            "Organic Shop Medium Billboard 01",
            "Organic Shop Medium Billboard 02",
            "Organic Shop Medium Billboard 03",
            "Organic Shop Medium Billboard 07",
            "Organic Shop Medium Billboard Random",
            "Organic Shop Small Billboard 01",
            "Organic Shop Small Billboard 03",
            "Organic Shop Small Billboard 07",
            "Organic Shop Small Billboard Random" };

        public static readonly string[] NEONS = {
            "neon-andys-bowling-alley",
            "neon-burned-bean-coffee",
            "neon-flaming-ring",
            "neon-go-nuts-doughnuts",
            "neon-morellos",
            "neon-open-sign",
            "neon-pinkunicorn",
            "neon-yakisoba-noodles" };

        public static readonly string[] LOGOS = {
            "Hightech Industrial Logo 02",
            "Hightech Industrial Logo 03",
            "Hightech Industrial Logo 04",
            "Hightech Industrial Logo 05",
            "Hightech Industrial Logo 06",
            "Hightech Industrial Logo Random",
            "beergarden_sign",
            "Bigbite sign",
            "Organic Shop 3d Sign 02",
            "Organic Shop 3d Sign 03",
            "Organic Shop 3d Sign 04",
            "Logo_aukio",
            "Logo_banhammer",
            "Logo_barber",
            "Logo_bowling",
            "Logo_burned_bean",
            "Logo_cinema",
            "logo_colossalore",
            "Logo_commercial_variation",
            "Logo_commercial_variation01",
            "Logo_dino",
            "Logo_electricity",
            "Logo_fault_tec",
            "logo_forestfoundation",
            "Logo_industrial_variation",
            "Logo_jubilee",
            "Logo_loimu",
            "logo_mattockwinch",
            "logo_meatybits",
            "logo_morellos",
            "Logo_neckbeard",
            "Logo_news",
            "Logo_nightwatch",
            "logo_office_random",
            "logo_orlysbookstore",
            "Logo_pernu",
            "Logo_plastimold",
            "Logo_rapido",
            "Logo_steel_rhino",
            "Logo_sternberger",
            "Logo_sunnygrain",
            "logo_thelawaccounting",
            "logo_tyrell",
            "Logo_williams",
            "Random Commercial 1 Sign Long",
            "Random Commercial 2 Logo",
            "Random Commercial 2 Logo Cramburgers",
            "Random Commercial 2 Logo State City Insurance",
            "Random Commercial 3 Logo Other" };

        public static readonly string[] SMOKE = { "Factory Smoke", "Factory Smoke Small" };
        public static readonly string STEAM = "Factory Steam";
        public static readonly string[] SOLAR_PANELS = { "Horizontal Solar Panel 01", "Horizontal Solar Panel 02", "Solar panel 01", "Solar panel 02", "Solar panel 03" };
        public static readonly string[] HVAC_SYSTEMS = { "Ac box 01", "Ac box 02", "Ac box 03", "Ac box random", "Air Source Heat Pump 01", "Air Source Heat Pump 02", "Rotating ac", "Ventilation Pipe 01", "Ventilation Pipe 02" };
        public static readonly string[] PARKING_SPACES = { "Invisible Parking Space", "Parking Space", "Parking Space Electric", "Parking Spaces 01", "Parking Spaces 02" };
        public static readonly string[] ABANDONED_CARS = { "Abandoned Car 01", "Abandoned Car 02" };
        public static readonly string[] CARGO_CONTAINERS = { "Cargo container", "Cargo container - disaster response unit" };
        public static readonly string[] GARBAGE_CONTAINERS = { "Large Recycling Container 01", "Large Recycling Container 02", "Small Recycling Container 01", "Small Recycling Container 02", "Small Recycling Container 03", "Trash container 01" };
        public static readonly string[] GARBAGE_BINS_AND_CANS = { "Garbage Bin", "Park Trashbin 01", "Park Trashbin 02", "TrashCan01", "TrashCan02" };
        public static readonly string GARBAGE_PILES = "Trashpile";
        public static readonly string[] TANKS = { "Tank 01", "Tank 02", "Tank 03", "Tank 04" };
        public static readonly string[] BARRELS = { "Barrel 01", "Barrel 02", "Barrel 03", "Barrel 04", "Barrels" };
        public static readonly string[] PALLETS = { "Barrel Pallet 01", "Barrel Pallet 02", "Barrel Pallet 03", "Pallet 01", "Pallet 02", "Pallet 03", "Pallet 04" };
        public static readonly string[] CRATES = { "Crate 01", "Crate pile" };
        public static readonly string[] PLANKS = { "Plank pile", "Plank stack" };
        public static readonly string[] CABLE_REELS = { "Cable reel 01", "Cable reel 02" };
        public static readonly string[] HEDGES = { "hedge", "hedge2", "Hedge 01", "Hedge 02" };
        public static readonly string[] FENCES = { "Amusement Park Fence Queue", "Amusement Park Fence Small 8m", "Amusement Park Fence Small 16m", "Antelope Enclosure Fence 8m", "Antelope Enclosure Fence 16m", "Antelope Enclosure Fence Corner", "Bison Enclosure Fence 8m", "Chainlink Fence 8m", "Chainlink Fence 16m", "industrial_fence", "Modern Fence 01", "Modern Fence 02", "Prison fence", "Prison fence long", "Riding Stable Fence Long", "Riding Stable Fence Short", "Arena Fence 01" };
        public static readonly string[] GATES = { "Antelope Enclosure Gate", "Chainlink Fence Gate", "industrial_gate" };

        private static readonly List<string> PROBABILITY77 = new List<string>() { "flag_pole", "flag_pole_wall", "Solar panel 01", "Solar panel 02", "Solar panel 03", "Ac box random" };
        private static readonly List<string> PROBABILITY88 = new List<string>() { "Rotating ac" };

        private static readonly List<string> HAS_LIGHT_EFFECTS = new List<string>() { "Billboard_pop_soda_anim" };

        public static void UpdateProps(List<string> enablePropNames, List<string> disablePropNames)
        {
            UpdateProps(enablePropNames, false);
            UpdateProps(disablePropNames, true);
        }

        public static void UpdateProp(string propName, bool disable)
        {
            List<string> propNames = new List<string>() { propName };

            UpdateProps(propNames, disable);
        }

        public static void UpdateProps(List<string> propNames, bool disable)
        {
            try
            {
                for (uint i = 0; i < PrefabCollection<BuildingInfo>.LoadedCount(); i++)
                {
                    var buildingInfo = PrefabCollection<BuildingInfo>.GetLoaded(i);

                    UpdateProps(buildingInfo, propNames, disable);
                }
            }
            catch (Exception e)
            {
                Debug.Log("[Hide It!] BuildingPropsHelper:UpdateProps -> Exception: " + e.Message);
            }
        }

        public static void UpdateProp(string prefabName, string propName, bool disable)
        {
            List<string> propNames = new List<string>() { propName };

            UpdateProps(prefabName, propNames, disable);
        }

        public static void UpdateProps(string prefabName, List<string> propNames, bool disable)
        {
            try
            {
                BuildingInfo buildingInfo = PrefabCollection<BuildingInfo>.FindLoaded(prefabName);

                UpdateProps(buildingInfo, propNames, disable);
            }
            catch (Exception e)
            {
                Debug.Log("[Hide It!] BuildingPropsHelper:UpdateProps -> Exception: " + e.Message);
            }
        }

        private static void UpdateProps(BuildingInfo buildingInfo, List<string> propNames, bool disable)
        {
            try
            {
                int probability;

                if (buildingInfo != null && buildingInfo.m_props != null)
                {
                    foreach (BuildingInfo.Prop prop in buildingInfo.m_props)
                    {
                        if (prop?.m_finalProp != null)
                        {
                            if (propNames.Contains(prop.m_finalProp.name))
                            {
                                if (HAS_LIGHT_EFFECTS.Contains(prop.m_finalProp.name))
                                {
                                    if (disable)
                                    {
                                        prop.m_finalProp.m_hasEffects = false;
                                        prop.m_finalProp.m_effectLayer = -1;
                                    }
                                    else
                                    {
                                        prop.m_finalProp.m_hasEffects = true;
                                        prop.m_finalProp.m_effectLayer = 24;
                                    }
                                }

                                probability = 100;

                                if (PROBABILITY77.Contains(prop.m_finalProp.name))
                                {
                                    probability = 77;
                                }
                                else if (PROBABILITY88.Contains(prop.m_finalProp.name))
                                {
                                    probability = 88;
                                }

                                prop.m_probability = disable ? 0 : probability;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Debug.Log("[Hide It!] BuildingPropsHelper:UpdateProps -> Exception: " + e.Message);
            }
        }
    }
}
