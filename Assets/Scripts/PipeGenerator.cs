using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    public float waitTime = 1;
    private float timer = 0;
    public GameObject pipe;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        generatePipe();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timer > waitTime)
        {
            generatePipe();
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    void generatePipe()
    {
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position += new Vector3(0, Random.Range(-height, height), 0);
        Destroy(newPipe, 10);
    }
}
