using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sliding : MonoBehaviour
{
    [SerializeField]
    public int angle=90;
    [SerializeField]
    public bool sliding = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) &&sliding == false)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0,0,90));
            sliding = true;
        }
        else if(Input.GetKeyUp(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            sliding = false;
        }
    }
}
