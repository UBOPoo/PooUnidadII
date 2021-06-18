using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionArea : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

       
        if(other.CompareTag("Player"))
        {
            GetComponentInParent<EnemyMetal>().PlayerDetected(other.transform);

        }
    }
}
