using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LaserSpawnerScript : MonoBehaviour
{
    public GameObject laserPrefab; // The laser prefab with the LaserScript attached
    public Text waveText; // Reference to the UI Text element for wave display
    public Text winText; // Reference to the UI Text element for win message
    public float spawnInterval = 5f; // Time interval between waves
    public float laserDistance = 100f; // Distance for each laser
    public int maxWaves = 5; // Maximum number of waves

    private int currentWave = 0;

    private void Start()
    {
        StartCoroutine(SpawnWaves());
        winText.text = ""; // Ensure win text is empty at the start
    }

    private IEnumerator SpawnWaves()
    {
        while (currentWave < maxWaves)
        {
            currentWave++;
            waveText.text = "Wave " + currentWave;

            // Spawn lasers according to the current wave number
            for (int i = 0; i < currentWave; i++)
            {
                SpawnLaser();
            }

            // Wait for the specified interval before the next wave
            yield return new WaitForSeconds(spawnInterval);
        }

        // Display the win message after the final wave
        waveText.text = ""; // Optionally clear the wave text
        winText.text = "You Win!";
    }

    private void SpawnLaser()
    {
        // Instantiate the laser prefab
        GameObject newLaser = Instantiate(laserPrefab, transform.position, transform.rotation);

        // Set the laser distance if needed
        LaserScript laserScript = newLaser.GetComponent<LaserScript>();
        if (laserScript != null)
        {
            laserScript.laserDistance = laserDistance;
        }
    }
}
