using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour
{
    public UIVirtualJoystick movement;


    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "laser")
        {
            
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}