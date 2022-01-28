using UnityEngine;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{
    public string gameButtonText = "Продолжить";
    [SerializeField] private Text _gameButtonText;
    [SerializeField] private Button _gameButton;
    [SerializeField] private Button _exitButton;

    private void Start()
    {
        _gameButton.onClick.AddListener(UIController.Singletone.ToPlay);
    }
}
