using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] public int MoveCounter;
    [SerializeField] private bool CanMove;
    [SerializeField] private float speed;
    [SerializeField] private Transform Player;


    [SerializeField] private Transform RightTarget;
    [SerializeField] private Transform RightTarget2;
    [SerializeField] private Transform RightTarget3;
    [SerializeField] private Transform RightTarget4;
    [SerializeField] private Transform RightTarget5;
    [SerializeField] private Transform RightTarget6;
    [SerializeField] private Transform RightTarget7;
    [SerializeField] private Transform RightTarget8;
    [SerializeField] private Transform RightTarget9;


    [SerializeField] private Transform LeftTarget;
    [SerializeField] private Transform LeftTarget2;
    [SerializeField] private Transform LeftTarget3;
    [SerializeField] private Transform LeftTarget4;
    [SerializeField] private Transform LeftTarget5;
    [SerializeField] private Transform LeftTarget6;
    [SerializeField] private Transform LeftTarget7;
    [SerializeField] private Transform LeftTarget8;
    [SerializeField] private Transform LeftTarget9;



    private AITalk aiTalk;


    private void Awake()
    {
        CanMove = true;
    }

    private void Start()
    {
        aiTalk = GameObject.FindGameObjectWithTag("dialogbox").GetComponent<AITalk>();
        MoveCounter = 0;
    }

    private void Update()
    {

            
            if (CanMove == true && Input.GetKey(KeyCode.RightArrow) && MoveCounter == 0)
        {
            Player.transform.position = RightTarget.position;
            CanMove = false;
            MoveCounter = 1;
            aiTalk.step++;

            StartCoroutine(SuckMyDickCounter());
        }


        if (CanMove == true && Input.GetKey(KeyCode.RightArrow) && MoveCounter == 1)
        {
            Player.transform.position = RightTarget2.position;
            CanMove = false;
            MoveCounter = 2;
            aiTalk.step++;


            StartCoroutine(SuckMyDickCounter());
        }


        if (CanMove == true && Input.GetKey(KeyCode.RightArrow) && MoveCounter == 2)
        {
            Player.transform.position = RightTarget3.position;
            CanMove = false;
            MoveCounter = 3;
            aiTalk.step++;

            StartCoroutine(SuckMyDickCounter());
        }


        if (CanMove == true && Input.GetKey(KeyCode.RightArrow) && MoveCounter == 3)
        {

            Player.transform.position = RightTarget4.position;
            CanMove = false;
            MoveCounter = 4;
            aiTalk.step++;

            StartCoroutine(SuckMyDickCounter());
        }

        if (CanMove == true && Input.GetKey(KeyCode.RightArrow) && MoveCounter == 4)
        {
            Player.transform.position = RightTarget5.position;
            CanMove = false;
            MoveCounter = 5;
            aiTalk.step++;

            StartCoroutine(SuckMyDickCounter());
        }

        if (CanMove == true && Input.GetKey(KeyCode.RightArrow) && MoveCounter == 5)
        {

            Player.transform.position = RightTarget6.position;
            CanMove = false;
            MoveCounter = 6;
            aiTalk.step++;

            StartCoroutine(SuckMyDickCounter());
        }

        if (CanMove == true && Input.GetKey(KeyCode.RightArrow) && MoveCounter == 6)
        {
            Player.transform.position = RightTarget7.position;
            CanMove = false;
            MoveCounter = 7;
            aiTalk.step++;

            StartCoroutine(SuckMyDickCounter());
        }

        if (CanMove == true && Input.GetKey(KeyCode.RightArrow) && MoveCounter == 7)
        {

            Player.transform.position = RightTarget8.position;
            CanMove = false;
            MoveCounter = 8;
            aiTalk.step++;

            StartCoroutine(SuckMyDickCounter());
        }

        if (CanMove == true && Input.GetKey(KeyCode.RightArrow) && MoveCounter == 8)
        {

            Player.transform.position = RightTarget9.position;
            CanMove = false;
            MoveCounter = 9;
            aiTalk.step++;

            StartCoroutine(SuckMyDickCounter());
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////


        if (CanMove == true && Input.GetKey(KeyCode.LeftArrow) && MoveCounter == 0)
        {

            Player.transform.position = LeftTarget.position;
            CanMove = false;
            MoveCounter++;
            aiTalk.step++;

            StartCoroutine(SuckMyDickCounter());
        }

        if (CanMove == true && Input.GetKey(KeyCode.LeftArrow) && MoveCounter == 1)
        {

            Player.transform.position = LeftTarget2.position;
            CanMove = false;
            MoveCounter++;
            aiTalk.step++;

            StartCoroutine(SuckMyDickCounter());
        }

        if (CanMove == true && Input.GetKey(KeyCode.LeftArrow) && MoveCounter == 2)
        {

            Player.transform.position = LeftTarget3.position;
            CanMove = false;
            MoveCounter++;
            aiTalk.step++;

            StartCoroutine(SuckMyDickCounter());
        }

        if (CanMove == true && Input.GetKey(KeyCode.LeftArrow) && MoveCounter == 3)
        {

            Player.transform.position = LeftTarget4.position;
            CanMove = false;
            MoveCounter++;
            aiTalk.step++;

            StartCoroutine(SuckMyDickCounter());
        }

        if (CanMove == true && Input.GetKey(KeyCode.LeftArrow) && MoveCounter == 4)
        {

            Player.transform.position = LeftTarget5.position;
            CanMove = false;
            MoveCounter++;
            aiTalk.step++;

            StartCoroutine(SuckMyDickCounter());
        }

        if (CanMove == true && Input.GetKey(KeyCode.LeftArrow) && MoveCounter == 5)
        {

            Player.transform.position = LeftTarget6.position;
            CanMove = false;
            MoveCounter++;
            aiTalk.step++;

            StartCoroutine(SuckMyDickCounter());
        }

        if (CanMove == true && Input.GetKey(KeyCode.LeftArrow) && MoveCounter == 6)
        {

            Player.transform.position = LeftTarget7.position;
            CanMove = false;
            MoveCounter++;
            aiTalk.step++;

            StartCoroutine(SuckMyDickCounter());
        }

        if (CanMove == true && CanMove == true && Input.GetKey(KeyCode.LeftArrow) && MoveCounter == 7)
        {

            Player.transform.position = LeftTarget8.position;
            CanMove = false;
            MoveCounter++;
            aiTalk.step++;

            StartCoroutine(SuckMyDickCounter());
        }

        if (CanMove == true && Input.GetKey(KeyCode.LeftArrow) && MoveCounter == 8)
        {

            Player.transform.position = LeftTarget9.position;
            CanMove = false;
            MoveCounter++;
            aiTalk.step++;

            StartCoroutine(SuckMyDickCounter());
        }





    }

    IEnumerator SuckMyDickCounter()
    {
        yield return new WaitForSeconds(2);
        CanMove = true;
    }


}

