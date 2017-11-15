using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Rotates an object.
public class Rotate : MonoBehaviour 
{
    #region EDITOR FIELDS

    [SerializeField]
    // A reference to the rigidbody.
    private Rigidbody2D rigidBody;

    [SerializeField]
    // The torque to apply to the rigidbody.
    private float torque;

    [SerializeField]
    // The key used to rotate the object to the right.
    private KeyCode rightKey;

    [SerializeField]
    // The key used to rotate the object to the left.
    private KeyCode leftKey;

    #endregion

    // Update is executed once per frame.
    void Update()
    {
        // If the right key is held down...
        if (Input.GetKey(rightKey))
        {
            // Apply a rightward torque.
            rigidBody.AddTorque(-torque);
        }
        // Or if the left key is held down...
        else if (Input.GetKey(leftKey))
        {
            // Apply a leftward torque.
            rigidBody.AddTorque(torque);
        }
    }
}
