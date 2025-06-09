using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifeTime = 5f;

    void Start()
    {
        // Destroy bullet after a few seconds to avoid memory leaks
        Destroy(gameObject, lifeTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("NPCMovement"))
        {
            Destroy(collision.gameObject);  // Destroy the capsule
            Destroy(gameObject);            // Destroy the bullet
        }
    }
}

