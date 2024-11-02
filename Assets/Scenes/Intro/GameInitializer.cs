using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInitializer : MonoBehaviour
{
    void Start()
    {
        // Load PersistentScene if it's not already loaded
        if (!SceneManager.GetSceneByName("PersistentScene").isLoaded)
        {
            SceneManager.LoadScene("PersistentScene", LoadSceneMode.Additive);
        }
    }
}