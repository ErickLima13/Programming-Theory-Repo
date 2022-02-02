using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildTwo : ParentClass
{
    // Start is called before the first frame update
    void Start()
    {
        nameChild = "Sphere";
    }

    private void Update()
    {
        transform.Rotate(1f, 1, 0 * speed);
    }

    public override void ChangeColor()
    {
        color = Color.green;
        material.color = color;
        display.text = "Hello i'm " + nameChild + "!";
        display.color = material.color;
    }

    private void OnMouseDown()
    {
        ChangeColor();
    }
}
