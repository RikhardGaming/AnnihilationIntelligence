using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSystem : MonoBehaviour
{
    [SerializeField] public int TotalPoints;
    [SerializeField] public int playerStep;

    //variabel av script med navn aiTalk
    private AITalk aiTalk;

    private MovePlayer player;
    

    private void Start()
    {
        // find GameObject with tag (case sensitive), then what component to get.
        aiTalk = GameObject.FindGameObjectWithTag("dialogbox").GetComponent<AITalk>();

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<MovePlayer>();
        
    }
    private void Update()
    {
        // make aiTalk sin step variabel = TotalPoints.
        aiTalk.karma = TotalPoints;

       
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Good"))
        {
            TotalPoints++;
        }
        if(other.CompareTag("Bad"))
        {
            TotalPoints--;
        }
        
    }
}
