using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPT_Videos : MonoBehaviour
{
    public GameObject[] things;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject current = things[GetComponent<ppt>().current];
        foreach(GameObject obj in things)
        {
            if (current != obj)
                obj?.SetActive(false);
            else obj?.SetActive(true);
        }
    }
}