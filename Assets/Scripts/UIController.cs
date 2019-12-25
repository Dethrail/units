using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Zenject;

public class UiController : MonoBehaviour {
    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _gameMenu;

    [Inject] private GameController _gameController;

    private void Awake()
    {
        Debug.Log(_gameController.name);
        _gameMenu.SetActive(false);
    }

    private void Update()
    {
        
    }

#if UNITY_EDITOR
    private const string MainMenuName = "main menu";
    private const string ButtonRestart = "button - restart";
    private const string ButtonBack = "button - back";

    private const string GameMenuName = "game menu";
    private const string ButtonPlay = "button - play";
    private const string ButtonExit = "button - exit";

    
    private void OnValidate()
    {
        Transform mainMenuTransform = transform.Find(MainMenuName);
        if (mainMenuTransform == null) {
            Debug.LogError("UI should have view with name \"" + MainMenuName + "\"");
        }
        else {
            _mainMenu = mainMenuTransform.gameObject;

            AttachMethodToButton(_mainMenu, ButtonPlay, OnPlayClicked);
            AttachMethodToButton(_mainMenu, ButtonExit, OnExitClicked);
        }

        Transform gameMenuTransform = transform.Find(GameMenuName);

        if (gameMenuTransform == null) {
            Debug.LogError("UI should have child with name \"" + GameMenuName + "\"");
        }
        else {
            _gameMenu = gameMenuTransform.gameObject;
            AttachMethodToButton(_gameMenu, ButtonRestart, OnRestartClicked);
            AttachMethodToButton(_gameMenu, ButtonBack, OnBackClicked);
        }
    }

    private void AttachMethodToButton(GameObject go, string buttonName, UnityAction method)
    {
        Transform restartButtonTransform = go.transform.Find(buttonName);
        if (restartButtonTransform == null) {
            Debug.LogError("main menu should have button with name \"" + buttonName + "\"");
        }
        else {
            Button exitButton = restartButtonTransform.gameObject.GetComponent<Button>();
            exitButton.onClick.AddListener(method);
        }
    }
#endif

    public void ShowMainMenu()
    {
        _mainMenu.SetActive(true);
    }

    public void HideMainMenu()
    {
        _mainMenu.SetActive(false);
    }

    public void ShowGameMenu()
    {
        _gameMenu.SetActive(true);
    }

    public void HideGameMenu()
    {
        _gameMenu.SetActive(false);
    }

    public void OnPlayClicked()
    {
        Debug.Log("Play");
        ShowGameMenu();
        HideMainMenu();
    }
    
    public void OnBackClicked()
    {
        Debug.Log("Back");
        ShowMainMenu();
        HideGameMenu();
    }

    public void OnExitClicked()
    {
        Debug.Log("Exit");
    }

    public void OnRestartClicked()
    {
        Debug.Log("Restart");
    }
}