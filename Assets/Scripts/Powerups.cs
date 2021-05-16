using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Powerups : MonoBehaviour
{ 
    DamageDataScriptableObject Damage;

    private void OnTriggerEnter(Collider Powerup)
    {
        if (Powerup.gameObject.CompareTag("Powerup"))
        {
            Damage.Damage++;
            Debug.Log("Pickup'd!");
            Destroy(Powerup.gameObject);
        }
    }
}
