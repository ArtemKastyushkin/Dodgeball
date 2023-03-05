using UnityEngine;

abstract public class Projectile : MonoBehaviour
{
    private float _speed = 800.0f;
    private float _lowerBound = -5.0f;
    private int _throwDamage = 1;

    private int _collisionCount = 0;

    protected Rigidbody _rigidbody;
    protected float _time = 0;

    public int Damage { get; protected set; } 

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
        _collisionCount++;

        Destructible destructible = collision.gameObject.GetComponent<Destructible>();

        if (destructible != null)
        {
            FirstPersonMovement fpsMovement = collision.gameObject.GetComponent<FirstPersonMovement>();
            if (fpsMovement != null && _collisionCount > 1) return;

            destructible.TakeDamage(_throwDamage);
        }
    }
}