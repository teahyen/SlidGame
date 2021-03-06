using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] wallPrefad;
    public float interval = 2f;
    float term;
    public float range = 3;
    // Start is called before the first frame update
    void Start()
    {
        term = interval;
        StartCoroutine(RandomSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        /*
        term += Time.deltaTime;
        if (term >= interval)
        {
            Vector3 pos = transform.position;
            pos.y += Random.Range(-range, range);
            Instantiate(wallPrefad[Random.Range(0, 3)], pos, transform.rotation);
            term -= interval;
        }
        */
    }

    IEnumerator RandomSpawn()
    {
        while (true)
        {
            Vector3 pos = transform.position;
            pos.y += Random.Range(-range, range);
            Instantiate(wallPrefad[Random.Range(0, 2)], pos, transform.rotation);

            yield return new WaitForSeconds(interval);
        }
    }
}
