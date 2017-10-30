using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour {

	public KeyCode upkey;
	public KeyCode downkey;
	public KeyCode leftkey;
	public KeyCode rightkey;
	public Rigidbody2D rb;
	public float force = 10f;

	void Update () 
	{
		if (Input.GetKey (upkey)) 
		{
			rb.AddForce (Vector2.up * force);

		}
		else if (Input.GetKey (downkey)) 
		{
			rb.AddForce (Vector2.down * force);

		}
		 else if (Input.GetKey (leftkey))
		{
			rb.AddForce (Vector2.left * force);

		}
		else if (Input.GetKey (rightkey)) 
		{
			rb.AddForce (Vector2.right * force);
		}
	}
}