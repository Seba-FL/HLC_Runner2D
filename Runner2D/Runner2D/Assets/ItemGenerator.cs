using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject[] Prefabs;
    public float minTime = 1f;
    public float maxTime = 2f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCorountine(0));
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator SpawnCorountine(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        Instantiate(Prefabs[Random.Range(0, Prefabs.Length)], new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), Quaternion.identity);

        // Para que vuelva a ejecutarse la corruntina con un tiempo aleatorio
        StartCoroutine(SpawnCorountine(Random.Range(minTime, maxTime)));
    }
    /*
    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Tocado");
    }*/
}
