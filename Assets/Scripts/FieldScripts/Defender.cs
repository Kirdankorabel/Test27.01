using System.Collections;
using UnityEngine;

namespace PlayingField
{
    public class Defender : MonoBehaviour
    {
        [SerializeField] private float _levelAcceleration;
        [SerializeField] private float _baseSpeed;
        private float _speed;

        private void Update()
            => StartCoroutine(MoveCorutine());

        public void UpdateSpeed()
            => _speed = _baseSpeed * (1 + (GameController.Singletone.Level - 1) * _levelAcceleration);

        private IEnumerator MoveCorutine()
        {
            var v3 = GameController.Singletone.BallPosition - transform.position;
            var direction = new Vector3(v3.x, 0, 0).normalized;
            transform.position = transform.position + Time.deltaTime * direction * _speed;
            yield return null;
        }
    }
}
