using UnityEngine;

namespace PlayerScripts
{
    public class BallShooter : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        private bool _isMove = false;

        public bool IsMove => _isMove;

        public void Shot(Vector3 direction, float multiplier)
        {
            if (_isMove) return;
            _isMove = true;
            _rigidbody.velocity = (direction - transform.position) * multiplier;
        }
    }
}
