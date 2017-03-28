using UnityEngine;
using System.Collections;

public class OutlineChanger : MonoBehaviour {

    public float outlineValue = 0.0001f;
    private Renderer rend;
	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void Picked()
    {
        rend.material.SetFloat("_Outline", outlineValue);
    }

    public void Unpicked()
    {
        rend.material.SetFloat("_Outline", 0);
    }
}
