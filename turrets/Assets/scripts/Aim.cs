using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim: MonoBehaviour 
{
	public KeyCode LeftKey;
	public KeyCode RightKey;
    public Rigidbody2D rb;
    public float Torque;
   

	void Update()
	{
		if (Input.GetKey(LeftKey))
		{
			// Turn the cab to the left.

		}
		else if (Input.GetKey(RightKey))
		{
			// Turn the cab to the right.
			
		}
	}

}
