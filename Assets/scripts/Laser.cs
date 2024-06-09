using UnityEngine;

public class Laser : MonoBehaviour
{
    public float speed = 5f;
    private Vector3 direction;

    void Start()
    {
        direction = (Vector3.zero - transform.position).normalized;
    }

    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player Loses!");
            Destroy(other.gameObject); // or handle game over logic
        }
    }
}
