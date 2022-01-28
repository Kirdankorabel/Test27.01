using UnityEngine;

namespace UIScripts
{
    public class UIController : MonoBehaviour
    {
        private static UIController _singltone;
        public static UIController Singletone => _singltone;

        [SerializeField] private GameUI _gameUI;
        [SerializeField] private MenuUI _menuUI;

        private void Awake()
            => _singltone = this;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
                ToMenu();
        }

        public void UpdateGamePanel()
            => _gameUI.UpdatePanel(GameController.Singletone.Level);

        public void ToPlay()
        {
            GameController.Singletone.EnableTouchTracker();
            _gameUI.gameObject.SetActive(true);
            _menuUI.gameObject.SetActive(false);
            Time.timeScale = 1;
        }

        public void ToMenu()
        {
            GameController.Singletone.DisableTouchTracker();
            _menuUI.gameObject.SetActive(true);
        }
    }
}
