using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject ball;
    public GameObject playerCamera;
    public float ballThrowingForce = 200;

    private bool holdingBall = true;
    // Start is called before the first frame update
    void Start()
    {
        ball.GetComponent<Rigidbody>().useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (holdingBall)
        {
            ball.transform.position = playerCamera.transform.position + playerCamera.transform.forward * 2;
            if (Input.GetMouseButtonDown(0))
            {
                holdingBall = false;
                ball.GetComponent<Rigidbody>().useGravity = true;
                ball.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward * ballThrowingForce);

            }
        }
    }
}
