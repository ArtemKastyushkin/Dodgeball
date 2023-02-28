using UnityEngine;

public class ProjectileBag : MonoBehaviour
{
    private int _bagCapacity = 10;
    private int[] _projectilesBag;

    private int _pointer = 0;

    [SerializeField]
    private GameObject[] _projectiles;

    private void Start()
    {
        _projectilesBag = new int[_bagCapacity];
        FillBag();
    }

    private void Update()
    {
        if (_pointer == _bagCapacity)
        {
            _pointer = 0;
            FillBag();
        }
    }

    private void FillBag()
    {
        for (int i = 0; i < _projectiles.Length; i++)
        {
            _projectilesBag[i] = Random.Range(0, _projectiles.Length);
        }
    }

    public GameObject GetProjectile()
    {
        return _projectiles[_projectilesBag[_pointer++]];
    }
}