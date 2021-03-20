using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float jumpSeed = 5f;
    public int isGround =2;
    public Rigidbody2D rd;

    private void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            isGround = 2;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGround>0)
            {
                isGround --;
                rd.AddForce(Vector2.up * jumpSeed, ForceMode2D.Impulse);
            }
        }
    }
}
