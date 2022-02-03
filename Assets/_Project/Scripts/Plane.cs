using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    private float speed = 1;

    // Update is called once per frame
    void Update()
    {
        Rotation();
    }

    private void Rotation()
    {
        transform.Rotate(0f, -1, 0 * speed);
    }
}
