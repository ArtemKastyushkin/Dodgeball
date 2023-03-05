using UnityEngine;
using UnityEngine.Events;

public class Destructible : MonoBehaviour
{
    [SerializeField]
    private int _health = 1;

    [HideInInspector]
    public UnityEvent Kill;

    public void TakeDamage(int damage)
    {
        _health -= damage;

        if (_health <= 0)
            Kill.Invoke();
    }
}