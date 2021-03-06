﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Movement;
using ActionsList;

namespace Ship
{
    namespace LancerClassPursuitCraft
    {
        public class LancerClassPursuitCraft : GenericShip
        {

            public LancerClassPursuitCraft() : base()
            {
                Type = "Lancer-class Pursuit Craft";
                IconicPilots.Add(Faction.Scum, typeof(AsajjVentress));
                ShipBaseSize = BaseSize.Large;
                ShipBaseArcsType = Arcs.BaseArcsType.ArcMobile;

                ManeuversImageUrl = "https://vignette.wikia.nocookie.net/xwing-miniatures/images/f/f5/MS_LANCER-CLASS.png";

                Firepower = 3;
                Agility = 2;
                MaxHull = 7;
                MaxShields = 3;

                PrintedUpgradeIcons.Add(Upgrade.UpgradeType.Crew);
                PrintedUpgradeIcons.Add(Upgrade.UpgradeType.Illicit);
                PrintedUpgradeIcons.Add(Upgrade.UpgradeType.Illicit);

                PrintedActions.Add(new TargetLockAction());
                PrintedActions.Add(new EvadeAction());
                PrintedActions.Add(new RotateArcAction());

                AssignTemporaryManeuvers();
                HotacManeuverTable = new AI.LancerPursuitCraftTable();

                factions.Add(Faction.Scum);
                faction = Faction.Scum;

                SkinName = "Lancer-class Pursuit Craft";

                SoundShotsPath = "Slave1-Fire";
                ShotsCount = 3;

                for (int i = 1; i < 3; i++)
                {
                    SoundFlyPaths.Add("Slave1-Fly" + i);
                }
            }

            private void AssignTemporaryManeuvers()
            {
                Maneuvers.Add("1.L.B", MovementComplexity.Normal);
                Maneuvers.Add("1.F.S", MovementComplexity.Normal);
                Maneuvers.Add("1.R.B", MovementComplexity.Normal);
                Maneuvers.Add("2.L.T", MovementComplexity.Normal);
                Maneuvers.Add("2.L.B", MovementComplexity.Normal);
                Maneuvers.Add("2.F.S", MovementComplexity.Easy);
                Maneuvers.Add("2.R.B", MovementComplexity.Normal);
                Maneuvers.Add("2.R.T", MovementComplexity.Normal);
                Maneuvers.Add("3.L.T", MovementComplexity.Easy);
                Maneuvers.Add("3.L.B", MovementComplexity.Easy);
                Maneuvers.Add("3.F.S", MovementComplexity.Easy);
                Maneuvers.Add("3.R.B", MovementComplexity.Easy);
                Maneuvers.Add("3.R.T", MovementComplexity.Easy);
                Maneuvers.Add("4.F.S", MovementComplexity.Easy);
                Maneuvers.Add("5.F.S", MovementComplexity.Normal);
                Maneuvers.Add("5.F.R", MovementComplexity.Complex);
            }

        }
    }
}
