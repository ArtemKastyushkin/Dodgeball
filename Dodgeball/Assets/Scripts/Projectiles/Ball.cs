using UnityEngine;

public class Ball : Projectile
{
    private float _lifeTime = 4.0f;

    protected override void Start()
    {
        base.Start();
        Damage = 1;
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();

        _time += Time.deltaTime;

        if (_time > _lifeTime)
            Destroy(gameObject);
    }
}