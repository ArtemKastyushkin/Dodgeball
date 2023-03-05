using UnityEngine;

public class Explosion : MonoBehaviour
{
    private float _explosionLifeTime = 1.0f;
    private Projectile _projectile;

    [SerializeField]
    private float _radius;

    [SerializeField]
    private GameObject _explosionEffect;

    private void Start()
    {
        _projectile = GetComponent<Projectile>();
    }

    public void Explode()
    {
        Collider[] overlappedColliders = Physics.OverlapSphere(transform.position, _radius);

        for (int i = 0; i < overlappedColliders.Length; i++)
        {
            Destructible destructible = overlappedColliders[i].GetComponent<Destructible>();

            if (destructible != null)
            {
                destructible.TakeDamage(_projectile.Damage);
            }
        }

        if (_explosionEffect != null)
        {
            var explosion = Instantiate(_explosionEffect, transform.position, Quaternion.identity);
            Destroy(explosion, _explosionLifeTime);
        }
        Destroy(gameObject);
    }
}