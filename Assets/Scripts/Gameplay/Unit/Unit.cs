using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Unit : MonoBehaviour
{
    public IMovement MovementAgent;
    public UnitType UnitType;


    public class Factory : Factory<UnitType, Unit>
    {
        
    }
}