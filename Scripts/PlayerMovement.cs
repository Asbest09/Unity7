using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _runSpeed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private Rigidbody _rb;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            _rb.AddForce(Vector3.up * _jumpForce);

        if (Input.GetKey(KeyCode.S))
            transform.Translate(Camera.main.Quaterion * Vector3.back * _speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * _speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * _speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.W))
        {
            if(Input.GetKey(KeyCode.LeftShift))
                transform.Translate(Vector3.forward * _runSpeed * Time.deltaTime);
            else
                transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        }
    }
}
