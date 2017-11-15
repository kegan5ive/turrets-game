using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
// Represents a mapping of a key code to an animator.
public class KeyStateMapping
{
    // The key associated with a particular animation.
    public KeyCode Key;

    // The animation state associated with the key.
    public int StateValue;
}
