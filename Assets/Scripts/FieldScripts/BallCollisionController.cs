using UnityEngine;

namespace PlayingField
{
    public class BallCollisionController : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.GetComponent<Target>() != null)
                collision.gameObject.GetComponent<Target>().DestoyTarget();
        }
    }
}
