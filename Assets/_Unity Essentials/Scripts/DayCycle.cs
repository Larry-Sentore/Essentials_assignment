using UnityEngine;

public class DayCycle : MonoBehaviour
{
    [Tooltip("Real-world seconds for one full day (360° rotation).")]
    [SerializeField] private float secondsPerDay = 60f;

    void Update()
    {
        // Degrees to rotate this frame: 360° spread across the full day duration.
        float degreesPerSecond = 360f / secondsPerDay;
        transform.Rotate(Vector3.right, degreesPerSecond * Time.deltaTime, Space.World);
    }
}