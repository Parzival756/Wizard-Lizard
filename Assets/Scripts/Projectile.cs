using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject BronzeGizzard, SilverGizzard, GoldGizzard, Player;
    public GameObject Manager;

    public int Bhealth, Shealth, Ghealth;

    private void Start()
    {
        Bhealth = Manager.GetComponent<GameManager>().Bhealth;
        Shealth = Manager.GetComponent<GameManager>().Shealth;
        Ghealth = Manager.GetComponent<GameManager>().Ghealth;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other != BronzeGizzard && SilverGizzard && GoldGizzard && Player)
        {
            Debug.Log(other);
            Destroy(gameObject);
        }
        else if (BronzeGizzard = other.transform.root.gameObject)
        {
            Debug.Log(other);
            Destroy(gameObject);
            Bhealth--;
        }
        else if (SilverGizzard = other.transform.root.gameObject)
        {
            Debug.Log(other);
            Destroy(gameObject);
            Shealth--;
        }
        else if(GoldGizzard = other.transform.root.gameObject)
        {
            Debug.Log(other);
            Destroy(gameObject);
            Ghealth--;
        }
        else if(Player = other.transform.root.gameObject)
        {
            Debug.Log("Hitplayer");
        }
    }
}
