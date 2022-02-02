using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildOne : ParentClass
{
    // Start is called before the first frame update
    void Start()
    {
        nameChild = "Cube";
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 1, 0 * speed);
    }

    public override void ChangeColor()
    {
        color = Color.red;
        material.color = color;
        display.text = "Hello i'm " + nameChild + "!";
        display.color = material.color;
    }

    private void OnMouseDown()
    {
        ChangeColor();
    }
}