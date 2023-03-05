using System.Runtime.CompilerServices;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private int _damage = 3;

    private void OnTriggerEnter(Collider other)
    {
        Destructible destructible = other.GetComponent<Destructible>();

        if (destructible != null)
            destructible.TakeDamage(_damage);
    }
}