using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Ui.MainMenu
{
    [RequireComponent(typeof(ControllerMainMenu))]
    [RequireComponent(typeof(ModelMainMenu))]
    public class ViewMainMenu : MonoBehaviour
    {
        public Button playButton;
        public Button exitButton;

        #region Validation

#if UNITY_EDITOR
        private const string PlayButtonName = "button - play";
        private const string ExitButtonName = "button - exit";

        private void OnValidate()
        {
            ControllerMainMenu controller = GetComponent<ControllerMainMenu>();
            ModelMainMenu model = GetComponent<ModelMainMenu>();
            if (controller == null)
            {
                return;
            }

            if (model == null)
            {
                return;
            }

            playButton = Utils.FindButton(gameObject, PlayButtonName);
            exitButton = Utils.FindButton(gameObject, ExitButtonName);
            Utils.AttachMethodToButton(gameObject, PlayButtonName, controller.OnPlayClicked);
            Utils.AttachMethodToButton(gameObject, ExitButtonName, controller.OnExitClicked);
        }
#endif

        #endregion
    }
}