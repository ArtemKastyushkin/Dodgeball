using UnityEngine;

[RequireComponent(typeof(Explosion))]
public class FragGrenade : Projectile
{
    private Explosion _explosion;
    private float _timeToExplosion = 2.0f;

    protected override void Start()
    {
        base.Start();
        Damage = 3;
        _explosion = GetComponent<Explosion>();
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();

        _time += Time.deltaTime;

        if (_time > _timeToExplosion)
        {
            _explosion.Explode();
        }
    }
}