using UnityEngine;

public class LaserScript : MonoBehaviour
{
    public float laserDistance = 100f; // Max distance the laser can travel
    private LineRenderer lineRenderer;

    void Start()
    {
        // Get the LineRenderer component
        lineRenderer = GetComponent<LineRenderer>();

        // Ensure the LineRenderer has at least 2 positions
        lineRenderer.positionCount = 2;
    }

    void Update()
    {
        // Start position of the laser (position of the GameObject this script is attached to)
        Vector3 startPosition = transform.position;

        // Direction of the laser (forward direction of the GameObject)
        Vector3 direction = transform.forward;

        // Perform the Raycast
        RaycastHit hit;
        Vector3 endPosition;
        if (Physics.Raycast(startPosition, direction, out hit, laserDistance))
        {
            // If the laser hits something, set the end position to the hit point
            endPosition = hit.point;
        }
        else
        {
            // If the laser hits nothing, set the end position to the max distance point
            endPosition = startPosition + (direction * laserDistance);
        }

        // Update the LineRenderer positions
        lineRenderer.SetPosition(0, startPosition);
        lineRenderer.SetPosition(1, endPosition);
    }
}
