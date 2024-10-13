using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    [SerializeField] private float _horizontalSensivity;
    Vector3 _mousePosition;
    private float _rotationX = 0;

    private void Update()
    {
        //Debug.Log(Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 1, Input.mousePosition.z)));
        //_mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 1, Input.mousePosition.z));
        //Vector3 forward = _mousePosition - transform.position;
        //transform.rotation = Quaternion.LookRotation(forward, Vector3.up);
        float rotationY = transform.eulerAngles.y + Input.GetAxis("Mouse X") * _horizontalSensivity;
        _rotationX += Input.GetAxis("Mouse Y");

        _rotationX = Mathf.Clamp(_rotationX, -100, 100);

        transform.rotation = Quaternion.Euler(-_rotationX, rotationY, 0);

        _mousePosition = Quaternion.Euler(0, rotationY, 0) * transform.forward;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, _mousePosition * 5);
    }
}
