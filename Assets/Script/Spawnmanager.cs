using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnmanager : MonoBehaviour
{
    public GameObject top, bottom;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawnbottom());
        StartCoroutine(SpawnUp());
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

     IEnumerator Spawnbottom()
    {
        while (true)
        {


            yield return new WaitForSeconds(3f);
            Vector3 pos = new Vector3(11f, -2.8f, 0f);
            Instantiate(bottom, pos, bottom.transform.rotation);
        }
    }
    IEnumerator SpawnUp()
    {
        while (true) {
        yield return new WaitForSeconds(5f);
        Vector3 pos = new Vector3(11f, 2.8f,0f);
        Instantiate(top, pos, top.transform.rotation);
        }
    }
}
