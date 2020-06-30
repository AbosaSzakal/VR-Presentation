using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Countdown : MonoBehaviour
{

    public float timeLeft = 900; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        GetComponent<Text>().text = ((int)(timeLeft / 60)).ToString() + " : " + ((int)(timeLeft % 60)).ToString();
    }
}
