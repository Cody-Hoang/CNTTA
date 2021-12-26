using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quatcay : MonoBehaviour
{   // khoi tao doi tuong cube ma vat dc chon quay quanh truc y cua no 
    public GameObject cube;
    // toc do quay
    public float speed = 0f;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        // goi ham
        orbitAround();
    }
    public void orbitAround()
    {
        // su dung tranform.rateAround  de quay vat the 

        // nut 8 voi toc do quay la 1000
        if (Input.GetKey("8"))
        {
            speed = 1000f;
        }
        if (Input.GetKey("9"))
        {


            speed = 0f;

        }
        transform.RotateAround(cube.transform.position, new Vector3(0f,0f,1f), speed * Time.deltaTime);
    }
}
