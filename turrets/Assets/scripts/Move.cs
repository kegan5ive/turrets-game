using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Moves an object using key input.
public class Move : MonoBehaviour 
{
    #region EDITOR FIELDS

    [SerializeField]
    // A reference to the rigidbody.
    private Rigidbody2D rigidBody;

    [SerializeField]
    // The force to apply to the rigidbody.
    private float force;

    [SerializeField]
    // The key used to move the object forward.
    private KeyCode forwardKey;

    [SerializeField]
    // The key used to move the object backwards.
    private KeyCode backKey;

    #endregion

    // Update is executed once each frame.
    void Update()
    {
        // If the forward key is held down...
        if (Input.GetKey(forwardKey))
        {
            // Apply a forwards force.
            rigidBody.AddForce(transform.up * force);
        }
        // Or if the back key is held down...
        else if (Input.GetKey(backKey))
        {
            // Apply a backwards force.
            rigidBody.AddForce(-transform.up * force);
        }
    }
}
