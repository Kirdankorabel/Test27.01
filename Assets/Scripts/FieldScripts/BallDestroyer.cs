using UnityEngine;

namespace PlayingField
{
    public class BallDestroyer : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.GetComponent<BallCollisionController>() != null)
                GameController.Singletone.InstantiateNewBall();
        }
    }
}
