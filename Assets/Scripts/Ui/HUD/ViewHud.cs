using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Ui.HUD
{
    [RequireComponent(typeof(ControllerHud))]
    [RequireComponent(typeof(ModelHud))]
    public class ViewHud : MonoBehaviour
    {
        public Button restartButton;
        public Button backButton;

        #region Validation

#if UNITY_EDITOR
        private const string RestartButtonName = "button - restart";
        private const string BackButtonName = "button - back";

        private void OnValidate()
        {
            ControllerHud controller = GetComponent<ControllerHud>();
            ModelHud model = GetComponent<ModelHud>();
            if (controller == null)
            {
                return;
            }

            if (model == null)
            {
                return;
            }

            restartButton = Utils.FindButton(gameObject, RestartButtonName);
            backButton = Utils.FindButton(gameObject, BackButtonName);
            Utils.AttachMethodToButton(gameObject, RestartButtonName, controller.OnRestartClicked);
            Utils.AttachMethodToButton(gameObject, BackButtonName, controller.OnBackClicked);
        }
#endif

        #endregion
    }
}