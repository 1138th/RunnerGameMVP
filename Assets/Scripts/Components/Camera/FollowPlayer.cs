using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private PlayerController _target;
    private Camera _camera1;

    private void Start()
    {
        _camera1 = Camera.main;
    }

    private void LateUpdate()
    {
        if (!_camera1) return;
        if (!_target)
        {
            _target = FindObjectOfType<PlayerController>();
        }
        else
        {
            _camera1.transform.position = _target.transform.position + new Vector3(0, 8, -10);
        }
    }
}