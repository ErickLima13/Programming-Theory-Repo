using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ParentClass : MonoBehaviour
{
    public string nameChild = "Capsule";
    public Color color;
    public Material material;
    public TextMeshProUGUI display;
    public float speed;
    

    // Start is called before the first frame update
    void Start()
    {
        nameChild = "Capsule";
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(1f, 0, 0 * speed);
    }

    public virtual void ChangeColor()
    {
        color = Color.blue;
        material.color = color;
        display.text = "Hello i'm " + nameChild + "!";
        display.color = material.color;
    }


    private void OnMouseDown()
    {
        ChangeColor();
    }
}
