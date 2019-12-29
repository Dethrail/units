using UnityEngine;
using Zenject;

namespace Ui.MainMenu
{
    public class ControllerMainMenu : MonoBehaviour
    {
        [Inject] private GameUi _gameUi;
        private ViewMainMenu _view;

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
        private void OnValidate()
        {
            _view = GetComponent<ViewMainMenu>();
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