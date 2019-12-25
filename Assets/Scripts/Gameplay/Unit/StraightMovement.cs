using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightMovement :  MonoBehaviour, IMovement
{
    public MovementType getMovementType()
    {
        return MovementType.Straight;
    }
}