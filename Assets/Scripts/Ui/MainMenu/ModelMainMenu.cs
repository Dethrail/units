using UnityEngine;

namespace Ui.MainMenu
{
    public class ModelMainMenu : MonoBehaviour
    {
        #region Validation

#if UNITY_EDITOR
        private void OnValidate()
        {
            ViewMainMenu view = GetComponent<ViewMainMenu>();
            if (view == null)
            {
                Debug.LogError("should have view");
                return;
            }
        }
#endif

        #endregion
    }
}