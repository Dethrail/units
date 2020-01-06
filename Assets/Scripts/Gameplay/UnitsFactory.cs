using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Zenject;

public class UnitsFactory : IFactory<UnitType, Unit>
{
    readonly DiContainer _container;
    readonly Unit[] _prefabs;

    public UnitsFactory(
        Unit[] prefabs,
        DiContainer container)
    {
        _container = container;
        _prefabs = prefabs;
    }

    public Unit Create(UnitType unitType)
    {
        var prefab = _prefabs.First(x => x.UnitType == unitType);
        return _container.InstantiatePrefabForComponent<Unit>(prefab);
    }
}