using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventListenerC : MonoBehaviour
{

    public string myName;


    private void OnDisable()
    {
        EventTriggerC.OnGameBegin -= EventTriggerC_OnGameBegin;
        EventTriggerC.OnNameCalled -= EventTriggerC_OnNameCalled;
    }

    private void OnEnable()
    {
        EventTriggerC.OnGameBegin += EventTriggerC_OnGameBegin;
        EventTriggerC.OnNameCalled += EventTriggerC_OnNameCalled;

    }

    private void EventTriggerC_OnNameCalled(string NameToSend)
    {
         if(myName==NameToSend)
        {
            Debug.Log("I am here learning for the test !" + gameObject.name);

        }
    }

    public void EventTriggerC_OnGameBegin()
    {
        Debug.Log("Im ready from C" + gameObject.name);

    }
}
