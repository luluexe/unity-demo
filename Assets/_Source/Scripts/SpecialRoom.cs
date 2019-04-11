using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialRoom : MonoBehaviour
{

    public Material material01;
    public Material material02;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material = material01;
       
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "SpecialRoom")
        {
            GetComponent<Renderer>().material = material02;
            Invoke("material02", 1.0f);
           
        }
    }

    public void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "SpecialRoom")
        {
            GetComponent<Renderer>().material = material01;
            Invoke("material01", 1.0f);

        }
    }
}
