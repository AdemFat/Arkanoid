using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    public int health;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        health--;
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
