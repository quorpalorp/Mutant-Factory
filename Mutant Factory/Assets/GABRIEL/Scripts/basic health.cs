using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Unity.VisualScripting;

public class basichealth : MonoBehaviour
{
    private float health = 10;
    private float bleedRate = 0;
    private bool isBleeding = false;
    private bool gotGeeked = false;
    //public static float damageQueue;
    public float maxHealth = 10;
    public float healRate = 0.5f;
    public float healWaitTime = 3;
    //public bool canHeal = false;

    private Rigidbody2D _rb2d;
    public Animator animator;
    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("got geeked", gotGeeked);

        //if (canHeal == true)
        //{
        //    WaitForSeconds(healWaitTime);
        //    health += healRate * Time.deltaTime;
        //}

        if (health <= 0)
        {
           gotGeeked = true;
        }
    }
}

// metro boomin make it boom