using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerhealth : MonoBehaviour {

	public int health = 3;
    public string ColliderTag;

    public Animator animate;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == ColliderTag)
        {
            health--;
            animate.SetTrigger("Damage");
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == ColliderTag)
        {
            health--;
            animate.SetTrigger("Damage");
        }
    }
}
