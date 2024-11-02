using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class IntroVideoController : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.loopPointReached += OnVideoEnd;  // Subscribe to the event
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        SceneManager.LoadScene("MenuScene");  // Replace "MainMenu" with the exact name of your main menu scene
    }
}
