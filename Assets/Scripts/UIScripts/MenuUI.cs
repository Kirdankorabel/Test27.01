using UnityEngine;
using UnityEngine.UI;

namespace UIScripts
{
    public class MenuUI : MonoBehaviour
    {
        [SerializeField] private string gameButtonText = "Продолжить";
        [SerializeField] private Text _gameButtonText;
        [SerializeField] private Button _gameButton;
        [SerializeField] private Button _exitButton;

        private void Start()
        {
            _gameButton.onClick.AddListener(UIController.Singletone.ToPlay);
            _gameButton.onClick.AddListener(() => _gameButtonText.text = gameButtonText);
            _exitButton.onClick.AddListener(Application.Quit);
        }
    }
}
