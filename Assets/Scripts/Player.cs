using UnityEngine;

public class Player : MonoBehaviour
{
    public float multiplier;
    [SerializeField] private BallShooter _ball;
    private Vector3 _startPosition;

    private void Awake()
        => _startPosition = transform.position;

    public void Shot()
    {
        GameController.Singletone.Ball.Shot(transform.position, multiplier);
        transform.position = _startPosition;
    }
}
