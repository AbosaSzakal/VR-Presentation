using UnityEngine;
using System.Collections;

public class ppt : MonoBehaviour {
    Texture2D[] typedTextures;
    public int current = 0;
    public GameObject demo;
    public string path;

	// Use this for initialization
	void Start () {

        Object[] textures = Resources.LoadAll(path, typeof(Texture2D));
        typedTextures = new Texture2D[textures.Length];
        for (int i = 0; i < textures.Length; i++)
        {
            typedTextures[i] = (Texture2D)textures[i];
        }
        GetComponent<Renderer>().material.mainTexture = typedTextures[0]; 
	}

	// Update is called once per frame
	void Update () {
        if (OVRInput.GetDown(OVRInput.Button.Two, OVRInput.Controller.RTouch))
        {
            if (current == typedTextures.Length - 1)
                current = 0;
            else current++;
            GetComponent<Renderer>().material.mainTexture = typedTextures[current];
            if (current == 1)
                demo.SetActive(true);
            else demo.SetActive(false);

        }
    }



}