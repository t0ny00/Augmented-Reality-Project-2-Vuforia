using UnityEngine;
using System.Collections;
using Vuforia;
public class VBChangeSize : MonoBehaviour, IVirtualButtonEventHandler
{

    private GameObject vb;
    public int sizeChange;
    public GameObject tool;
 
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
        if ((tool.GetComponent<Painter>().width + sizeChange <= 50) &&
            (tool.GetComponent<Painter>().width + sizeChange > 0)) tool.GetComponent<Painter>().width += sizeChange;
        GameObject.Find("Size Text").GetComponent<SizeOfTool>().updateText();
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {

    }
}
