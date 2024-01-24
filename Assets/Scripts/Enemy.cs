using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public float speed;
    public string name = "Elucidator";
    
    public GameObject ground;
    public Transform enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Attack()
    {
        Debug.Log("Attack");
    }

    void Movement()
    {
        Debug.Log("Movement");
    }

    void Hit()
    {
        Debug.Log("Hit");
    }

    void Jump()
    {
        Debug.Log("Jump");
    }
}

