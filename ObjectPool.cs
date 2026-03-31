/////////////////////////////////////////////
//Assignment/Lab/Project: Space Shooter
//Name: Christopher Bentley
//Section: SGD Programming II (2026SP.SGD.213.4123)
//Instructor:Ven Lewis
//Date: 3/31/2026
/////////////////////////////////////////////
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject bulletPrefab;
    public int poolSize = 20;

    private List<GameObject> pool = new List<GameObject>();    ///// A list to hold the pooled bullet objects

    void Start()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(bulletPrefab);
            obj.SetActive(false);      ///// Deactivates the bullet object so it can be reused later
            pool.Add(obj);
        }
    }

    public GameObject GetBullet()
    {
        foreach (GameObject obj in pool)
        {
            if (!obj.activeInHierarchy)    ///// Checks if the bullet object is inactive (not currently in use) and returns it for reuse
            {
                return obj;
            }
        }

        return null;
    }
}
