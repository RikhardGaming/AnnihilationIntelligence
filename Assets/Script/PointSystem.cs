using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSystem : MonoBehaviour
{
    [SerializeField] public int TotalPoints;

    public AITalk point;
    public GameObject OtherObject;

    private void Start()
    {


        point = OtherObject.GetComponent<AITalk>();
    }



    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Good"))
        {
            
        }
        if(other.CompareTag("Bad"))
        {

        }
        
    }
}
