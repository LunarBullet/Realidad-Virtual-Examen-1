using System;
using System.Collections;
using System.Collections.Generic;
using Tilia.Interactions.Controllables.LinearDriver;
using UnityEngine;

public class UnlockWithKey : MonoBehaviour
{
    [SerializeField] LinearDriveFacade _linearDriveFacade;
    [SerializeField] private Rigidbody rb;

    [SerializeField] GameObject gabeta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collided with: "+ other.name);
        if (other.name=="collider key")
        {
            _linearDriveFacade.MoveToTargetValue = false;
            rb.isKinematic = false;
            Destroy(this);
        }

        if (expr)
        {
            
        }
        //check
    }

  
}
