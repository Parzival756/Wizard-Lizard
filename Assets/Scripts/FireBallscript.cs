using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallscript : MonoBehaviour
{
    public GameObject projectile;
    public float projectileSpeed;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject fireball = Instantiate(projectile, transform) as GameObject;
            Rigidbody rb = fireball.GetComponent<Rigidbody>();
            rb.velocity = transform.forward * projectileSpeed;
            fireball.transform.parent = null;
        }
    }
}
