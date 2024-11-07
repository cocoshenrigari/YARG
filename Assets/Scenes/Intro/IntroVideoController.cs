using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class IntroVideoPlayer : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();

        // Play the video and register an event handler for when it finishes.
        videoPlayer.loopPointReached += OnVideoEnd;
        videoPlayer.Play();
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        // Option 1: Unload the current scene without loading a new one
        //SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);

        // Option 2: Load the main scene and replace the intro scene
         SceneManager.LoadScene("PersistentScene"); // Replace "MainScene" with the actual scene name.
    }
}
