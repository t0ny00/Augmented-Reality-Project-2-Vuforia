using UnityEngine;
using System.Collections;
using Vuforia;
public class VBChangeColor : MonoBehaviour,IVirtualButtonEventHandler {

    private GameObject vb;
    public Color color;
    public GameObject tool;
    private Painter painter;
    private GameObject highlight;
	// Use this for initialization
	void Start () {
        vb = transform.gameObject;
        vb.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        painter = tool.GetComponent<Painter>();
        highlight = GameObject.Find("Highlight");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
       
        painter.col = color;
        highlight.transform.position = transform.position;
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
       
    }
}
