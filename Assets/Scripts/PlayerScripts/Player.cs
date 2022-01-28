using UnityEngine;

namespace PlayerScripts
{
    public class Player : MonoBehaviour
    {
        public float multiplier;
        [SerializeField] private GameObject _arrow;
        private BallShooter _ball;
        private Vector3 _arrowStartPosition;

        private void Awake()
            => _arrowStartPosition = _arrow.transform.localPosition;

        public void MovePlayer(Vector3 position)
        {
            _ball = GameController.Singletone.Ball;
            if (_ball.IsMove) return;

            transform.position = position;
            var direction = position - _ball.transform.position;
            transform.forward = direction.normalized;
            var scaleFactor = direction.magnitude / 25;
            _arrow.transform.localScale = new Vector3(scaleFactor, scaleFactor, scaleFactor);
            _arrow.transform.localPosition = _arrowStartPosition + new Vector3(0, 0, scaleFactor);
        }

        public void Shot()
            => GameController.Singletone.Ball.Shot(transform.position, multiplier);
    }
}
