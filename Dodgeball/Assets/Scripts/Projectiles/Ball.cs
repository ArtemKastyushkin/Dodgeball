using UnityEngine;

public class Ball : Projectile
{
    private float _lifeTime = 4.0f;

    protected override void FixedUpdate()
    {
        base.FixedUpdate();

        _time += Time.deltaTime;

        if (_time > _lifeTime)
            Destroy(gameObject);
    }
}