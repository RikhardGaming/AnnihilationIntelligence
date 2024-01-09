using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSystem : MonoBehaviour
{
    [SerializeField] private int TotalPoints;


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Good"))
        {
            TotalPoints++;
        }
        if(other.CompareTag("Bad"))
        {
            TotalPoints--;
        }
        
    }
}
