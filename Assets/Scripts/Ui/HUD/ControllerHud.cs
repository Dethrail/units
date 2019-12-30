using UI;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace UI.HUD
{
    [RequireComponent(typeof(ViewHud))]
    [RequireComponent(typeof(ModelHud))]
    public class ControllerHud : MonoBehaviour
    {
        [Inject] private GameUi _gameUi;
        private ViewHud _view;
        private ModelHud _model;

        public void OnRestartClicked()
        {
            Debug.Log("Restart");
        }

        public void OnBackClicked()
        {
            Debug.Log("Back");
            _gameUi.mainMenuController.Show();
            Hide();
        }

        public void Show()
        {
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }

        public Button restartButton;
        public Button backButton;

        #region Validation

#if UNITY_EDITOR
        private const string RestartButtonName = "button - restart";
        private const string BackButtonName = "button - back";

        private void OnValidate()
        {
            _view = GetComponent<ViewHud>();
            _model = GetComponent<ModelHud>();
            if (_view == null)
            {
                return;
            }

            if (_model == null)
            {
                return;
            }

            restartButton = Utils.FindButton(gameObject, RestartButtonName);
            backButton = Utils.FindButton(gameObject, BackButtonName);
            Utils.AttachMethodToButton(gameObject, RestartButtonName, OnRestartClicked);
            Utils.AttachMethodToButton(gameObject, BackButtonName, OnBackClicked);
        }
#endif

        #endregion
    }
}