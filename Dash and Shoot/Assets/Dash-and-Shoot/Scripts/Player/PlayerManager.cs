using UnityEngine;

/// <summary>
/// Manages game states
/// Manages game settings
/// </summary>
public class PlayerManager: MonoBehaviour
{
    [Header("Players")]
    [SerializeField] private GameObject _playerVR;
    [SerializeField] private GameObject _playerPC;
    [SerializeField] private GameObject _playerAndroid;

    void Start()
    {
        SpawnPlayer();
    }

    private void SpawnPlayer()
    {
        Debug.Log("Current plateform ==>" + Application.platform);
        if (UnityEngine.XR.XRDevice.isPresent)
        {
            Instantiate(_playerVR, Vector3.zero, Quaternion.identity);
        }
        else if (Application.platform == RuntimePlatform.Android)
        {
            Instantiate(_playerAndroid, Vector3.zero, Quaternion.identity);
        }
        else if (Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.WindowsEditor)
        {
            Instantiate(_playerPC, Vector3.zero, Quaternion.identity);
        }
    }

}
