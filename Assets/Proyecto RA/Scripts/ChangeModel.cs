using UnityEngine;
using System.Collections;

public class ChangeModel : MonoBehaviour {

    public GameObject ARCamera;
	
    // Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    if(ARCamera.GetComponent<Painter>().tool == Painter.Tool.Brush)
        {
            transform.Find("Brush").gameObject.SetActive(true);
            transform.Find("Eraser").gameObject.SetActive(false);
        }
        else if (ARCamera.GetComponent<Painter>().tool == Painter.Tool.Eraser)
        {
            transform.Find("Brush").gameObject.SetActive(false);
            transform.Find("Eraser").gameObject.SetActive(true);
        }
    }
}
