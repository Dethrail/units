using Ui.MainMenu;
using UnityEngine;
using Zenject;

namespace Ui.HUD
{
    public class ControllerHud : MonoBehaviour
    {
        [Inject] private GameUi _gameUi;
        private ViewHud _view;

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

        #region Validation

#if UNITY_EDITOR
        private void OnValidate()
        {
            _view = GetComponent<ViewHud>();
            if (_view == null)
            {
                Debug.LogError("should have view");
                return;
            }
        }
#endif

        #endregion
    }
}