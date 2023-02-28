using UnityEngine;

public class Throw : MonoBehaviour
{
    private float _time;
    private GameObject _projectile;

    [SerializeField]
    private Transform _spawnPoint;
    [SerializeField]
    private float _rateOfFire;
    [SerializeField]
    private ProjectileBag _projectileBag;

    private void Update()
    {
        _time += Time.deltaTime;

        if (Input.GetMouseButton(0))
        {
            if (_time >= _rateOfFire)
            {
                _projectile = _projectileBag.GetProjectile();

                if (_projectile == null) return;
                Instantiate(_projectile, _spawnPoint.position, _spawnPoint.rotation);
                _time = 0;
            }
        }
    }
}