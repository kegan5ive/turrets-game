using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_ : MonoBehaviour {
    public Rigidbody2D rb;
    public float force = 10.0f;
	// Use this for initialization
	void Start () {
        rb.AddForce(-transform.up * force );
	}
}
