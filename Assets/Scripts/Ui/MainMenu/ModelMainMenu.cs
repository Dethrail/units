using UnityEngine;

namespace UI.MainMenu
{
    public class ModelMainMenu
    {
        #region Validation

#if UNITY_EDITOR
        private void OnValidate()
        {
            // ControllerMainMenu controller = GetComponent<ControllerMainMenu>();
            // if (controller== null)
            // {
            //     Debug.LogError("should have controller");
            //     return;
            // }
        }
#endif

        #endregion
    }
}