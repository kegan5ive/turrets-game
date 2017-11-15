using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour 
{
    [SerializeField]
    // List of key mappings, which associate key codes with animation states.
    private List<KeyStateMapping> keyStateMappings = new List<KeyStateMapping>();

    [SerializeField]
    // The name of the state variable used by the animator.
    private string stateVariable = "State";

    [SerializeField]
    // The value of the idle state.
    private int idleStateValue = 0;

    [SerializeField]
    // A reference to the animator.
    private Animator animator = null;

    // Update method is called every frame.
    void Update()
    {
        // Set the default state to idle.
        animator.SetInteger(stateVariable, idleStateValue);

        // Loop through all the key state mappings...
        foreach (KeyStateMapping ksm in keyStateMappings)
        {
            // If a given key is held down...
            if (Input.GetKey(ksm.Key))
            {
                // Set the state of the animator appropriately.
                animator.SetInteger(stateVariable, ksm.StateValue);
            }
        }
    }
}


