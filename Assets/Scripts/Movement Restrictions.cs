using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementRestrictions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Get the current position
        Vector3 position = transform.position;

        // Clamp the Y position between -4.5 and 0
        position.y = Mathf.Clamp(position.y, -4.5f, 0f);

        // Apply the clamped position back to the player
        transform.position = position;
    }
}