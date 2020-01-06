using System.Collections;
using System.Collections.Generic;
using UI;
using UI.MainMenu;
using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;

public class UiInstaller : MonoInstaller
{
    public GameUi gameUi;
    public Unit[] prefabs;

    public override void InstallBindings()
    {
        Container.Bind(gameUi.GetType()).FromInstance(gameUi);
        Container.BindFactory<UnitType, Unit, Unit.Factory>()
            .FromIFactory(b => b.To<UnitsFactory>().AsSingle().WithArguments(prefabs));
    }
}