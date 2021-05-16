using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public GameObject BGizzard, SGizzard, GGizzard, Playa;
    public GameObject Manager;
    public int Phealth;

    private void Start()
    {
        Phealth = Manager.GetComponent<GameManager>().Phealth;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other != BGizzard && SGizzard && GGizzard && Playa)
        {
            Debug.Log(other);
            Destroy(gameObject);
        }
        else if (BGizzard = other.transform.root.gameObject)
        {
            Debug.Log(other);
        }
        else if (SGizzard = other.transform.root.gameObject)
        {
            Debug.Log(other);
        }
        else if (GGizzard = other.transform.root.gameObject)
        {
            Debug.Log(other);
        }
        else if (Playa = other.transform.root.gameObject)
        {
            Debug.Log("Hitplayer");
            Destroy(gameObject);
            Phealth--;
        }
    }
}