using UnityEngine;

public class GameController : MonoBehaviour
{//пространства имен
    private static GameController _singltone;
    public static GameController Singletone => _singltone;

    [SerializeField] private Ball _ballPrefab;
    [SerializeField] private Defender _defender;
    [SerializeField] private TargetController _targetController;

    private Ball _ball;
    private int _level;
    private Vector3 _defenderStartPosition;

    public int Level => _level;
    public Ball Ball => _ball;
    public Vector3 BallPosition => _ball.transform.position;

    private void Awake()
    {
        _level = 0;
        _singltone = this;
        _defenderStartPosition = _defender.transform.position;        
    }

    private void Start()
    {
        _targetController.LevelPassed += (StartNewLevel);
        StartNewLevel();
    }

    private void StartNewLevel()
    {
        _level++; 
        _targetController.InstantiateNewTargets();
        InstantiateNewBall();
        _defender.UpdateSpeed();
        UIController.Singletone.UpdateGamePanel();
    }

    public void InstantiateNewBall()
    {
        if(_ball != null)
            Destroy(_ball.gameObject);
        _ball = Instantiate(_ballPrefab);
        _defender.transform.position = _defenderStartPosition;
    }
}
