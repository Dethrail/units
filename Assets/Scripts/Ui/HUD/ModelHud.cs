using UnityEngine;

namespace UI.HUD
{
    public class ModelHud : MonoBehaviour
    {
        #region Validation

#if UNITY_EDITOR
        private void OnValidate()
        {
            ControllerHud controller = GetComponent<ControllerHud>();
            if (controller == null)
            {
                Debug.LogError("should have controller");
                return;
            }
        }
#endif

        #endregion
    }
}