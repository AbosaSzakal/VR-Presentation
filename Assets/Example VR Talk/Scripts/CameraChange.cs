using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public RenderTexture mirror;
    public GameObject[] cameras;
    int current = 0;

    // Start is called before the first frame update
    void Start()
    {
        cameras[current].GetComponent<Camera>().targetTexture = mirror;
    }

    // Update is called once per frame
    void Update()
    {

        if(OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.RTouch))
        {
            Debug.Log("pressed");
            cameras[current].SetActive(false);
            if (current == cameras.Length-1)
                current = 0;
            else current++;
            Debug.Log("pressed" + current);
            cameras[current].SetActive(true);
            cameras[current].GetComponent<Camera>().targetTexture = mirror;
        }
    }
}
