﻿using UnityEngine;

public class Character : MonoBehaviour {

    protected Animator Animator;
    protected Rigidbody2D Body;

    /// <summary>
    /// The name of the character.
    /// </summary>
    public string name;

    /// <summary>
    /// The backend identifier of the character.
    /// </summary>
    public string charId;
    /// <summary>
    /// The character's current health.
    /// </summary>
    public int health;

    /// <summary>
    /// The character's maximum health.
    /// </summary>
    public int maxHealth;

    /// <summary>
    /// The maximum amount of shield provided by armor.
    /// </summary>
    public int maxShield;
    
    /// <summary>
    /// The current amount of shield left.
    /// </summary>
    public int shield;

    protected const float WalkSpeed = 5.0f;
    protected const float RunSpeed = 9.0f;

    protected virtual void Start() {
        Animator = gameObject.GetComponent<Animator>();
        Body = gameObject.GetComponent<Rigidbody2D>();
    }

}
