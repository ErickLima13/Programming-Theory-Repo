using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildOne : ParentClass
{
    private void Initialization()
    {
        nameChild = "Cube";
    }

    // Start is called before the first frame update
    void Start()
    {
        Initialization();
    }

    // Update is called once per frame
    void Update()
    {
        Rotation(Vector3.up);
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
