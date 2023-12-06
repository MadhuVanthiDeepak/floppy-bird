using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipes : MonoBehaviour
{
     [SerializeField]public GameObject pipe;
    public Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GeneratePipe());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator GeneratePipe()
    {
        while (true)
        {


            yield return new WaitForSeconds(3f);
            float randy = Random.Range(-1f, 3.5f);
             pos = new Vector3(4f, randy, 0f);
            Instantiate(pipe, pos, Quaternion.identity);
        }
    }
}
