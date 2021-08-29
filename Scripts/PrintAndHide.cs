using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public int i;
    public GameObject x;
    public Renderer rend;
    public int a;
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        a = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(x.name +":"+ (++i));
        if (i == 100 && x.tag == "Red")
        {
            x.SetActive(false);
        }

        if (i == a && x.tag == "Blue")
        {
            rend.enabled = false;  
        }
     
    }
}
