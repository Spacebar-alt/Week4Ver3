using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    // Start is called before the first frame update
    int i = 3;

    public Renderer rend;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(this.name + ":" + ++i);
    }
}