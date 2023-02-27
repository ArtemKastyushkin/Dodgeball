using UnityEngine;
using UnityEngine.Events;

public class Destructible : MonoBehaviour
{
    public UnityEvent ApplyDestroying;

    public void Destroy()
    {
        ApplyDestroying.Invoke();
    }
}