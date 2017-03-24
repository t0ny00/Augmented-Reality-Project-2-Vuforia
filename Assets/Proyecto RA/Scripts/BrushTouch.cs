using UnityEngine;
using System.Collections;

public class BrushTouch : MonoBehaviour {

    private RectTransform rec;
    public Transform pointer;
    public GameObject ARCamera;
    public Color color;
	// Use this for initialization
	void Start () {
        rec = gameObject.GetComponent<RectTransform>();
	}
	
	// Update is called once per frame
	void Update () {

        Rect imgRect = new Rect(Camera.main.WorldToScreenPoint(rec.position).x, Camera.main.WorldToScreenPoint(rec.position).y, rec.sizeDelta.x, rec.sizeDelta.y);
        print(imgRect.position.y);
        if (imgRect.Contains(Camera.main.WorldToScreenPoint(pointer.transform.position)))
        {
            ARCamera.GetComponent<Painter>().col = color;
        }

    }
}
