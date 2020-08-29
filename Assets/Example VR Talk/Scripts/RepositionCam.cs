using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepositionCam : MonoBehaviour
{


    public GameObject cam;
    public Transform target;

    public GameObject stage;


    // Start is called before the first frame update
    void OnEnable()
    {
        cam.transform.position = target.transform.position;
        cam.transform.rotation = target.transform.rotation;
        stage.SetActive(false);
    }

    private void OnDisable()
    {
        stage.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
