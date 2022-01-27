using UnityEngine;

public class TouchTracker : MonoBehaviour
{
    [SerializeField] private Camera _mainCamera;
    [SerializeField] private Player _player;

    private Vector3 _position;
    public Vector3 Position => _position;

    private void Update()
        => Wath();

    private void OnMouseUp()
    {
        _player.Shot();
    }

    private void Wath()
    {
        RaycastHit hit;
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            var position = hit.point;
            if (position.x > -4 && position.x < 4) _position.x = position.x;
            if (position.z > -9.5 && position.z < -0.5) _position.z = position.z;
            _player.transform.position = new Vector3(_position.x, 0, _position.z);
        }
    }
}
