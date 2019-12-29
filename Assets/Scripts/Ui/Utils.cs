using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#if UNITY_EDITOR
namespace UI
{
    public class Utils
    {
        public static void AttachMethodToButton(GameObject go, string buttonName, UnityAction method)
        {
            Button button = FindButton(go, buttonName);
            if (button != null)
            {
                button.onClick.AddListener(method);
            }
        }

        public static Button FindButton(GameObject go, string transformName)
        {
            Transform foundTransform = go.transform.Find(transformName);
            if (foundTransform == null)
            {
                Debug.LogError(go.name + " should contain button with name \"" + transformName + "\"");
                return null;
            }

            Button foundButton = foundTransform.GetComponent<Button>();
            if (foundButton == null)
            {
                Debug.LogError(foundTransform.name + " should contain button script ");
            }

            return foundButton;
        }
    }
}
#endif