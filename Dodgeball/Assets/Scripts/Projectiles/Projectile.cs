using UnityEngine;

abstract public class Projectile : MonoBehaviour
{
    private float _lowerBound = -5.0f;
    private float _lifeTime = 5.0f;
    private float _time;

    protected Rigidbody _rigidbody;
    protected float _speed;
    protected float _damage;

    protected abstract void Awake();
    //protected abstract void OnCollisionEnter(Collision collision);

    protected void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        Vector3 speed = transform.up * _speed;
        _rigidbody.AddForce(speed);
    }

    protected void Update()
    {
        _time += Time.deltaTime;

        if (transform.position.y < _lowerBound || _time > _lifeTime)
            Destroy(gameObject);
    }
}