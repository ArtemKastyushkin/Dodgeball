using UnityEngine;

public class Ball : Projectile
{
    protected override void Awake()
    {
        _speed = 800.0f;
    }
}