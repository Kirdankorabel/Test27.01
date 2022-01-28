using System;
using UnityEngine;

namespace PlayingField
{
    public class Target : MonoBehaviour
    {
        public event Action TargetDestroyed;

        public void DestoyTarget()
        {
            TargetDestroyed?.Invoke();
            Destroy(this.gameObject);
        }
    }
}