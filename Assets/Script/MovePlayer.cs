using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private float minimum = 0f;
    private float maximum = 1f;

    static float t = 0f;



    [SerializeField] private float speed;
    [SerializeField] private GameObject Player;
    [SerializeField] private Transform RightTarget;
    [SerializeField] private Transform RightTarget2;
    [SerializeField] private Transform LeftTarget;
    [SerializeField] private Transform LeftTarget2;

    private void Update()
    {
        

        transform.position = new Vector3(Mathf.Lerp(minimum, maximum, speed), 0, 0);
        speed += 0.5f * Time.deltaTime;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = Vector3.MoveTowards(transform.position, RightTarget.position, speed);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {

        }



    }

}
