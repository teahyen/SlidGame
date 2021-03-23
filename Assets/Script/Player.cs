using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float jumpSeed = 5f;
    public int isGround =2;
    public Rigidbody2D rd;
    [SerializeField]
    public int angle = 90;
    [SerializeField]
    public bool sliding = false;

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
        sliding = true;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround > 0)
        {
            isGround--;
            rd.AddForce(Vector2.up * jumpSeed, ForceMode2D.Impulse);
        }

        if (isGround >= 2)
        {
            sliding = true;
        }
        else
            sliding = false;

        if (Input.GetKeyDown(KeyCode.S) && sliding ==true)
        {
            
            if (Input.GetKeyDown(KeyCode.Space))
                return;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 90));
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            sliding = false;
        }
    }
}
