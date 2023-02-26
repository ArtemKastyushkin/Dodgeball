using UnityEngine;

public class Throw : MonoBehaviour
{
    private float _time;

    public GameObject Projectile;
    public Transform SpawnPoint;
    public float RateOfFire;

    private void Update()
    {
        _time += Time.deltaTime;

        if (Input.GetMouseButton(0))
        {
            if (_time >= RateOfFire)
            {
                if (Projectile == null) return;
                Instantiate(Projectile, SpawnPoint.position, SpawnPoint.rotation);
                _time = 0;
            }
        }
    }
}