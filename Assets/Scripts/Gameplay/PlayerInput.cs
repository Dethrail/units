using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;

public class PlayerInput : MonoBehaviour
{
    [Inject] public EventSystem EventSystem;

    public void Init()
    {
    }

    public bool IsTouch(out Vector2 worldPos)
    {
        if (!Input.GetMouseButton(0))
        {
            worldPos = Vector2.zero;
            return false;
        }

        if (EventSystem.currentSelectedGameObject != null)
        {
            worldPos = Vector2.zero;
            return false;
        }

        if (EventSystem.IsPointerOverGameObject())
        {
            worldPos = Vector2.zero;
            return false;
        }

        for (int i = 0; i < 5; i++)
        {
            if (EventSystem.IsPointerOverGameObject(i))
            {
                worldPos = Vector2.zero;
                return false;
            }
        }

        worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        return true;
    }

    public void Update()
    {
        // Vector2 targetPos;
        // bool isTouch = IsTouch(out targetPos);
        // Debug.Log(isTouch + " " + targetPos);
        // if (isTouch) {
        //     Collider2D[] hits = Physics2D.OverlapCircleAll(targetPos, 0.5f);
        //     foreach (Collider2D collider2d in hits) {
        //     }
        // }

    }
}