using UnityEngine;

public class Throw : MonoBehaviour
{
    private float _time;

    [SerializeField]
    private GameObject _projectile;
    [SerializeField]
    private Transform _spawnPoint;
    [SerializeField]
    private float _rateOfFire;

    private void Update()
    {
        _time += Time.deltaTime;

        if (Input.GetMouseButton(0))
        {
            if (_time >= _rateOfFire)
            {
                if (_projectile == null) return;
                Instantiate(_projectile, _spawnPoint.position, _spawnPoint.rotation);
                _time = 0;
            }
        }
    }
}