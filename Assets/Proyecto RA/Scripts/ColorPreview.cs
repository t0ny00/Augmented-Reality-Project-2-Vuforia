using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColorPreview : MonoBehaviour {
    public GameObject painter;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<RawImage>().color = painter.GetComponent<Painter>().col;
	}
}
