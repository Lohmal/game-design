using UnityEngine;

public class FrameRateTest : MonoBehaviour
{

    [SerializeField] private int targetFps = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        Application.targetFrameRate = targetFps;
    }
    void OnDisable() // runs when we press Stop
    {
        Application.targetFrameRate = -1; // no limit
    }
}
