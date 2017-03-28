using UnityEngine;
using System.Collections;
using Vuforia;

public class ChangeSize : MonoBehaviour {

    private RectTransform rec;
    public Transform pointer;
    public GameObject ARCamera;
    public GameObject sizeText;
    public int sizeChange;
    private bool is_tool_visible;
    private float time_delta;
    private bool can_update = false;
    
    // Use this for initialization
    void Start () {
        rec = gameObject.GetComponent<RectTransform>();
    }
	
	// Update is called once per frame
	void Update () {

        time_delta += Time.deltaTime;
        if ((ARCamera.GetComponent<Painter>().width + sizeChange <= 50) &&
            (ARCamera.GetComponent<Painter>().width + sizeChange > 0)) can_update = true;
        is_tool_visible = pointer.parent.GetComponent<DefaultTrackableEventHandler>().track;
        Rect imgRect = new Rect(Camera.main.WorldToScreenPoint(rec.position).x, Camera.main.WorldToScreenPoint(rec.position).y, rec.sizeDelta.x, rec.sizeDelta.y);
        if (imgRect.Contains(Camera.main.WorldToScreenPoint(pointer.transform.position)) && is_tool_visible && time_delta > 3f && can_update)
        {
            ARCamera.GetComponent<Painter>().width += sizeChange;
            time_delta = 0;
            sizeText.GetComponent<SizeOfTool>().updateText();
            can_update = false;
        }
    }
}
