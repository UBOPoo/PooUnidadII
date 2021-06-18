using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Sesion8UnityEventTrigger : MonoBehaviour
{
    public UnityEvent OnGameBegin;

    public UnityEvent<string> OnNameCalled;


    private void Start()
    {
        OnGameBegin.Invoke();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            OnNameCalled.Invoke("Ignacio");
        }
    }

}
