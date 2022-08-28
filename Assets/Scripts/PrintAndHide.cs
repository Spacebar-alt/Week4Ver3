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
        if (this.tag == "Red")
        {
            i = 100;
            this.gameObject.SetActive(false);
        }
        if (this.tag == "Blue")
        {
            i = Random.Range(200, 250);
            rend.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(this.name + ":" + ++i);
    }
}
