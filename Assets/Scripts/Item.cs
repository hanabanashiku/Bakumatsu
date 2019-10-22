﻿using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

/// <summary>
/// Represents an inventory item
/// </summary>
public class Item : MonoBehaviour {
    
    /// <summary>
    /// The internal identifier of the item.
    /// </summary>
    public string Identifier { get; }
    
    /// <summary>
    /// The name of the item
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// A description of the item.
    /// </summary>
    public string Description { get; }

    /// <summary>
    /// The item's image.
    /// </summary>
    public Sprite Sprite { get; }
    
    /// <summary>
    /// The cost of the item, in mon.
    /// </summary>
    public int Price { get; }

    public Item(string id, string name, string desc, Sprite sprite, int cost) {
        Identifier = id;
        Name = name;
        Description = desc;
        Sprite = sprite;
        Price = cost;
    }
}
