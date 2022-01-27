using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollisionController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Target>() != null)
        {
            collision.gameObject.GetComponent<Target>().DestoyTarget();
            GameController.Singletone.InstantiateNewBall();//унчтожать в контоллере
        }
        else if (collision.gameObject.GetComponent<Defender>() != null)
        {
            GameController.Singletone.InstantiateNewBall();
        }
    }
}
