using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZigZagMovement : MonoBehaviour, IMovement
{
    public MovementType getMovementType()
    {
        return MovementType.ZigZag;
    }
}
