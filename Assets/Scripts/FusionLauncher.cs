using Fusion;
using UnityEngine;

public class FusionLauncher : MonoBehaviour
{
    public GameMode mode; // Host for User, Client for Mentor

    async void Start()
    {
        var runner = GetComponent<NetworkRunner>();
        await runner.StartGame(new StartGameArgs
        {
            GameMode = mode,
            SessionName = "MentorLinkSession",
            SceneManager = gameObject.AddComponent<NetworkSceneManagerDefault>()
        });
    }
}