using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildTwo : ParentClass
{
    private void Initialization()
    {
        nameChild = "Sphere";
    }

    // Start is called before the first frame update
    void Start()
    {
        Initialization();
    }

    private void Update()
    {
        Rotation(Vector3.one);
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
