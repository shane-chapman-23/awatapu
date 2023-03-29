using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newPlayerData", menuName = "Data/Player Data/Base Data")]

public class PlayerData : ScriptableObject
{
    [Header("Abilities Unlocked")]
    public bool doubleJumpUnlocked = false;

    [Header("Move State")]
    public float movementVelocity = 7f;

    [Header("Jump State")]
    public float jumpVelocity = 10f;
    public int amountOfJumpsLeft = 2;

    [Header("In Air State")]
    public float coyoteTime = 0.2f;
    public float fallMultiplier = 2.5f;

    [Header("Check Variables")]
    public float groundCheckRadius = 0.3f;
    public LayerMask whatIsGround;

}
