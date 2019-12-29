using System.Collections;
using Ui.HUD;
using Ui.MainMenu;
using UnityEngine;

namespace Ui
{
    public class GameUi : MonoBehaviour
    {
        public ControllerMainMenu mainMenuController;
        public ControllerHud hudController;

        private IEnumerator Start()
        {
            mainMenuController.Show();
            hudController.Hide();
            yield break;
        }

        #region Validation
#if UNITY_EDITOR
        private const string HudName = "view - hud";
        private const string MainMenuName = "view - main menu";

        private void OnValidate()
        {
            Transform hud = transform.Find(HudName);
            if (hud == null)
            {
                Debug.LogError(transform.name + " should contain transform with name \"" + HudName + "\"");
            }
            else
            {
                hudController = hud.GetComponent<ControllerHud>();
                if (hudController == null)
                {
                    Debug.LogError(hud.name + " should contain controller");
                }
            }

            Transform mainMenu = transform.Find(MainMenuName);
            if (mainMenu == null)
            {
                Debug.LogError(transform.name + " should contain transform with name \"" + MainMenuName + "\"");
            }
            else
            {
                mainMenuController = mainMenu.GetComponent<ControllerMainMenu>();
                if (mainMenuController == null)
                {
                    Debug.LogError(mainMenu.name + " should contain controller");
                }
            }
        }
#endif

        #endregion
    }
}