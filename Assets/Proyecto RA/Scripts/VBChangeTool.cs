using UnityEngine;
using System.Collections;
using Vuforia;
public class VBChangeTool : MonoBehaviour, IVirtualButtonEventHandler
{

    private GameObject vb;
    public GameObject painter;
    public Painter.Tool tool;
    public GameObject main;
    public GameObject other;

    // Use this for initialization
    void Start()
    {
        vb = transform.gameObject;
        vb.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        painter.GetComponent<Painter>().tool = tool;
        if (main.name == "VB Eraser")
        {
            main.GetComponent<OutlineChanger>().Picked();
            other.GetComponent<VBBrushHandler>().Unpicked();
        }
        else
        {
            main.GetComponent<VBBrushHandler>().Picked();
            other.GetComponent<OutlineChanger>().Unpicked();
        }
        
        
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {

    }
}
