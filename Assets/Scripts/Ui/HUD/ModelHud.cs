using UnityEngine;

namespace Ui.HUD
{
    public class ModelHud : MonoBehaviour
    {
        #region Validation

#if UNITY_EDITOR
        private void OnValidate()
        {
            ViewHud view = GetComponent<ViewHud>();
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