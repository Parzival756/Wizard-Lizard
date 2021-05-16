using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SausageController : MonoBehaviour
{
    [SerializeField] Animator Moving;
    private bool IsMoving;
    DamageDataScriptableObject Damage;
    public CharacterController controller;
    public float speed;
    public float turnspeed;
    public Vector3 movDir;
    public int damage;
    public int Phealth;
    public GameObject Enemyprojectile;

    private void Awake()
    {
        Phealth = Enemyprojectile.GetComponent<EnemyProjectile>().Phealth;
    }
    private void Start()
    {
        damage = Damage.Damage;
    }
    // Update is called once per frame
    void Update()
    {
        Movement();

        if (Input.GetKeyDown("w"))
        {
            Moving.SetBool("IsMoving", true);

        }
        else if (Input.GetKeyUp("w"))
        {
            Moving.SetBool("IsMoving", false);
        }
    }

    void Movement()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * turnspeed * Time.deltaTime, 0);
        movDir = transform.forward * Input.GetAxis("Vertical") * speed;
        controller.Move(movDir * Time.deltaTime);
    }    

    void playerhealth()
    {
        if(Phealth == 0)
        {
            Destroy(gameObject);
        }
    }
}
