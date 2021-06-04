using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sesion6DebugVS : MonoBehaviour
{
    public int startNumber = 10;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Comienza");
        RestaNumero(startNumber);
        Debug.Log("Termina");
    }

    void RestaNumero(int NewNumber)
    {
        NewNumber = NewNumber - 1;


        if(NewNumber==0)
        {
            Debug.Log("Has LLegado Al limite");

        }else
        {
            RestaNumero(NewNumber);
            Debug.Log(NewNumber);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
