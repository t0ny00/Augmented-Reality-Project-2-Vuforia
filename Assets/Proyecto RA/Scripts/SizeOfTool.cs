using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class SizeOfTool : MonoBehaviour
{

    public GameObject painter;
    private Text message;

    // Use this for initialization
    void Start()
    {
        message = GetComponent<Text>();
        message.text = "Tool Size: " + painter.GetComponent<Painter>().width;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void updateText()
    {
        message.text = "Tool Size: " + painter.GetComponent<Painter>().width;
    }
}
