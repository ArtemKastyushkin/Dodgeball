using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private float _throwingSpeed = 800.0f;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        Vector3 speed = transform.up * _throwingSpeed;
        _rigidbody.AddForce(speed);
    }
}