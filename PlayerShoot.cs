/////////////////////////////////////////////
//Assignment/Lab/Project: Space Shooter
//Name: Christopher Bentley
//Section: SGD Programming II (2026SP.SGD.213.4123)
//Instructor:Ven Lewis
//Date: 3/31/2026
/////////////////////////////////////////////
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Transform firePoint;
    public ObjectPool pool;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();    ///// Calls the Shoot method when the space key is pressed, allowing the player to fire a bullet
        }
    }

    void Shoot()
    {
        GameObject bullet = pool.GetBullet();

        if (bullet != null)
        {
            bullet.transform.position = firePoint.position;    ////// Sets the bullet's position to the fire point's position and rotation, and activates the bullet
            bullet.transform.rotation = firePoint.rotation;
            bullet.SetActive(true);
        }
    }
}
