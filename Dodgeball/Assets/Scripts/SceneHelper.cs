using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneHelper : MonoBehaviour
{
    [SerializeField]
    private Destructible _destructible;

    private void Start()
    {

        if (_destructible != null)
            _destructible.Kill.AddListener(ReloadScene);
    }

    private void OnDestroy()
    {
        if (_destructible != null)
            _destructible.Kill.RemoveListener(ReloadScene);
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}