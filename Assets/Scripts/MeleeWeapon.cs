﻿using System;
using UnityEngine;

/// <summary>
/// A sword or other close-range weapon.
/// </summary>
[Serializable]
[CreateAssetMenu(menuName = "Items/Weapons/Melee", fileName = "MeleeWeapons.asset")]
public class MeleeWeapon : Weapon {
    public enum Types {
        OneHanded, TwoHanded
    }

    /// <summary>
    /// The weapon classification
    /// </summary>
    public Types type;

}