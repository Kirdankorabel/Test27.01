using UnityEngine;

namespace UIScripts
{
    public class ScreenController : MonoBehaviour
    {
        [SerializeField] private Canvas _canvas;

        private void Awake()
        {
            var width = Screen.width;
            _canvas.scaleFactor = width / 1080f;
        }
    }
}
