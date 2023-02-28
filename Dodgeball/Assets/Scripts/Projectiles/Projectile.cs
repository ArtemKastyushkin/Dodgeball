using UnityEngine;

abstract public class Projectile : MonoBehaviour
{
    private float _speed = 800.0f;
    private float _lowerBound = -5.0f;

    protected Rigidbody _rigidbody;
    protected float _time = 0;

    protected virtual void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        Vector3 speed = transform.up * _speed;
        _rigidbody.AddForce(speed);
    }

    protected virtual void FixedUpdate()
    {
        if (transform.position.y < _lowerBound)
            Destroy(gameObject);
    }

    protected virtual void OnCollisionEnter(Collision collision)
    {
        Destructible destructible = collision.gameObject.GetComponent<Destructible>();

        if (destructible != null)
            destructible.Destroy();
    }
}