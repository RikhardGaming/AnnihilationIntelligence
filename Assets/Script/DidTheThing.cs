using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DidTheThing : MonoBehaviour
{
    [SerializeField] public bool followOrder;


    private void Start()
    {
        followOrder = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Good"))
        {
            followOrder = true;
        }
        if (other.CompareTag("Bad"))
        {
            followOrder = false;
        }
    }

}
