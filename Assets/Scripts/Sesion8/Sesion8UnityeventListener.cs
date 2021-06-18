using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sesion8UnityeventListener : MonoBehaviour
{
    public string myName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

     public void GameHasStarted()
    {
        Debug.Log("I am ready!" + gameObject.name);

    }

    public void ListenMyname(string IncomingName)
    {
        if(IncomingName== myName)
        {
            Debug.Log("I am here!!!!" + gameObject.name);

        }
    }
}
