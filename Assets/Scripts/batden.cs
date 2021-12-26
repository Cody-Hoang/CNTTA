using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batden : MonoBehaviour
{
    public Light lightUp;
    // Start is called before the first frame update
    void Start()
    {
        lightUp.intensity =0f;
    }

    // Update is called once per frame
    void Update()
    {
        // neu nguoi an nut 6 thi intensity bang 4
        // nguoc lai thi ve 0
        if (Input.GetKey("6"))
        {
            lightUp.intensity = 1f;

        }
        else if(Input.GetKey("7"))
        {
            lightUp.intensity = 0f;
        }
    }
}
