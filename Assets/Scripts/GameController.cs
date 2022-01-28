using UnityEngine;
using UIScripts;
using PlayingField;
using PlayerScripts;

public class GameController : MonoBehaviour
{
    private static GameController _singltone;
    public static GameController Singletone => _singltone;

    [SerializeField] private BallShooter _ballPrefab;
    [SerializeField] private Defender _defender;
    [SerializeField] private TargetController _targetController;
    [SerializeField] private TouchTracker _touchTracker;

    private BallShooter _ball;
    private int _level;
    private Vector3 _defenderStartPosition;

    public int Level => _level;
    public BallShooter Ball => _ball;
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

    public void InstantiateNewBall()
    {
        if (_ball != null)
            Destroy(_ball.gameObject);
        _ball = Instantiate(_ballPrefab);
        _defender.transform.position = _defenderStartPosition;
    }

    public void EnableTouchTracker()
        => _touchTracker.enabled = true;

    public void DisableTouchTracker()
        => _touchTracker.enabled = false;

    private void StartNewLevel()
    {
        _level++; 
        _targetController.InstantiateNewTargets();
        InstantiateNewBall();
        _defender.UpdateSpeed();
        UIController.Singletone.UpdateGamePanel();
    }
}
