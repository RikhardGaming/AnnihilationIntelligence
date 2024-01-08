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
        if(other.tag == "Bad")
        {
            TotalPoints--;
        }
        if(other.tag == "Neutral")
        {
            Debug.Log("Neutral");

        }
    }
}
