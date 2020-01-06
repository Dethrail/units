using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace UI.MainMenu
{
    [RequireComponent(typeof(ViewMainMenu))]
    public class ControllerMainMenu : MonoBehaviour
    {
        [Inject] private GameUi _gameUi;
        private ViewMainMenu _view;
        private ModelMainMenu _model;
        public Button playButton;
        public Button exitButton;

        public void OnPlayClicked()
        {
            Debug.Log("Play");
            _gameUi.hudController.Show();
            Hide();
        }

        public void OnExitClicked()
        {
            Debug.Log("Exit");
        }

        public void Show()
        {
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }

        #region Validation

#if UNITY_EDITOR
        private const string PlayButtonName = "button - play";
        private const string ExitButtonName = "button - exit";

        private void OnValidate()
        {
            _view = GetComponent<ViewMainMenu>();
            if (_view == null)
            {
                return;
            }

            playButton = Utils.FindButton(gameObject, PlayButtonName);
            exitButton = Utils.FindButton(gameObject, ExitButtonName);
            Utils.AttachMethodToButton(gameObject, PlayButtonName, OnPlayClicked);
            Utils.AttachMethodToButton(gameObject, ExitButtonName, OnExitClicked);
        }
#endif

        #endregion
    }
}