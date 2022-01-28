using UnityEngine;
using UnityEngine.UI;

namespace UIScripts
{
    public class GameUI : MonoBehaviour
    {
        [SerializeField] private Text _level;
        [SerializeField] private Button _MenuButton;

        private void Start()
            => _MenuButton.onClick.AddListener(UIController.Singletone.ToMenu);

        public void UpdatePanel(int level)
            => _level.text = level.ToString();
    }
}
