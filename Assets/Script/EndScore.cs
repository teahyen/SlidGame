using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour
{
    [SerializeField]
    public Text list_score;
    

    public void Start()
    {
        GameManager.Instance.UpdateScore(list_score);
    }
}
