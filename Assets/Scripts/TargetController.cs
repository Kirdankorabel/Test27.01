using System;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public event Action LevelPassed;
    [SerializeField] private Target _targetPrefab;
    [SerializeField] private Vector3 _target1Pos;
    [SerializeField] private Vector3 _target2Pos;
    [SerializeField] private Vector3 _target3Pos;
    private byte TargetCounter = 0;

    public void InstantiateNewTargets()
    {
        Instantiate(_targetPrefab, _target1Pos, Quaternion.identity).TargetDestroyed += (DecrimentedCounter);
        Instantiate(_targetPrefab, _target2Pos, Quaternion.identity).TargetDestroyed += (DecrimentedCounter);
        Instantiate(_targetPrefab, _target3Pos, Quaternion.identity).TargetDestroyed += (DecrimentedCounter);
        TargetCounter = 3;
    }

    public void DecrimentedCounter()
    {
        TargetCounter--;
        if (TargetCounter <= 0)
            LevelPassed?.Invoke();
    }
}
