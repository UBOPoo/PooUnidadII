using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTriggerC : MonoBehaviour
{
    public delegate void FNotify();
    public static event FNotify OnGameBegin;

    public delegate void FNotifyName(string NameToSend);
    public static event FNotifyName OnNameCalled;


    // Start is called before the first frame update
    void Start()
    {
       // if(OnGameBegin!=null)
             OnGameBegin?.Invoke();
         


    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnNameCalled?.Invoke("Ignacio");
        }
    }

}
