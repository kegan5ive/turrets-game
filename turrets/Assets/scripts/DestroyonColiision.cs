using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyonColiision : MonoBehaviour {

    public string ColliderTag;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == ColliderTag)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == ColliderTag)
        {
            Destroy(gameObject);
        }
    }
}
