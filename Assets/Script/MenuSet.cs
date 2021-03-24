using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSet : MonoBehaviour
{
    [SerializeField]
    private GameObject mal;
    [SerializeField]
    private GameObject help;

    public bool isMal;


    public void Help1()
    {
        help.SetActive(!help.activeInHierarchy);
    }
}
