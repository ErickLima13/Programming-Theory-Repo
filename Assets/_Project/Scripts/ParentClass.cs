using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ParentClass : MonoBehaviour
{
    
    public string nameChild;

    public Color color;
    public Material material;
    public TextMeshProUGUI display;

    private float speed = 1;
    

    private void Initialization()
    {
        nameChild = "Capsule";
    }

    // Start is called before the first frame update
    void Start()
    {
        Initialization();
    }

    // Update is called once per frame
    void Update()
    {
        Rotation(Vector3.right);
    }

    public virtual void ChangeColor()
    {
        color = Color.blue;
        material.color = color;
        display.text = "Hello i'm " + nameChild + "!";
        display.color = material.color;
    }


    public void Rotation(Vector3 angle)
    {
        transform.Rotate(angle* speed);        
    }

    private void OnMouseDown()
    {
        ChangeColor();
        
    }

    public void Exit()
    {
        GameManager.instance.Exit();
    }
}
