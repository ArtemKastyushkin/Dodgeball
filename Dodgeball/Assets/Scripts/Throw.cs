using UnityEngine;

public class Throw : MonoBehaviour
{
    private float _time;
    private GameObject _projectile;
    private ProjectileBag _projectileBag;

    [SerializeField]
    private Transform _spawnPoint;
    [SerializeField]
    private float _rateOfFire;

    private void Start()
    {
        _projectileBag = GameObject.Find("Projectile Bag").GetComponent<ProjectileBag>();
    }

    private void Update()
    {
        _time += Time.deltaTime;

        if (Input.GetMouseButton(0))
        {
            if (_time >= _rateOfFire)
            {
                if (_projectileBag == null) return;
                _projectile = _projectileBag.GetProjectile();

                if (_projectile == null) return;
                Instantiate(_projectile, _spawnPoint.position, _spawnPoint.rotation);
                _time = 0;
            }
        }
    }
}