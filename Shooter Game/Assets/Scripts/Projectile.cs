using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 20f;   // You can adjust this in Inspector
    [SerializeField] float lifeTime = 5f; // Auto destroy after 5s

    void Start()
    {
        Destroy(gameObject, lifeTime); // Clean up after a few seconds
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
