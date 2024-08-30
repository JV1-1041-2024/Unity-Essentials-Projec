using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    // Duration of the day in seconds, editable in the Inspector
    public float dayDuration = 86400f; // Default is 86400 seconds (24 hours)

    // Update is called once per frame
    void Update()
    {
        // Calculate the rotation angle based on the time elapsed and day duration
        float rotationAngle = (360f / dayDuration) * Time.deltaTime;

        // Rotate the directional light around the X-axis
        transform.Rotate(new Vector3(rotationAngle, 0f, 0f));
    }
}
