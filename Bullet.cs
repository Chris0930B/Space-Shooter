/////////////////////////////////////////////
//Assignment/Lab/Project: Space Shooter
//Name: Christopher Bentley
//Section: SGD Programming II (2026SP.SGD.213.4123)
//Instructor:Ven Lewis
//Date: 3/31/2026
/////////////////////////////////////////////
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public float lifeTime = 2f;

    void OnEnable()
    {
        Invoke("Deactivate", lifeTime);    ///// Schedules the Deactivate method to be called after the bullet's lifetime expires, allowing it to be reused from the object pool
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);    ///// Moves the bullet forward at a constant speed, creating the effect of the bullet traveling through space
    }

    void Deactivate()
    {
        gameObject.SetActive(false);   ////// Deactivates the bullet object, allowing it to be reused from the object pool when needed again
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<Enemy>().TakeDamage(10);   ///// Checks if the bullet collides with an enemy, and if so, it calls the TakeDamage method on the enemy's script to apply damage and then deactivates the bullet
            gameObject.SetActive(false);
        }
    }
}
