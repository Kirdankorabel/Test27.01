using UnityEngine;

public class UIController : MonoBehaviour
{
    private static UIController _singltone;
    public static UIController Singletone => _singltone;

    [SerializeField] private GameUI _gameUI;
    [SerializeField] private GameObject MenuUI;

    private void Awake()
    {
        _singltone = this;
    }

    public void UpdateGamePanel()
        => _gameUI.UpdatePanel(GameController.Singletone.Level);
}
