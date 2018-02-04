using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickBootn : MonoBehaviour, IPointerClickHandler
{

    public GameObject GoToShare;

    public GameObject image;
    private GameObject OBJcamera;

    public float RorationX = 0;
    public float RorationY;
    public float RorationZ = 0;

    
    // Use this for initialization
    void Start () {
        OBJcamera = GameObject.Find("Main Camera");
        //image = GameObject.Find("Image");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPointerClick(PointerEventData data)
    {
        Debug.Log("OnPointerClick called.");
        OBJcamera.transform.position = GoToShare.transform.position;
        OBJcamera.transform.rotation = Quaternion.Euler(RorationX, RorationY, RorationZ);
    }
 

    public void OnMouseEnter()
    {
        image.gameObject.SetActive(true);
        GetComponent<SpriteRenderer>().material.color = Color.gray;
        




    }
    public void OnMouseExit()
    {
        image.gameObject.SetActive(false);
        GetComponent<SpriteRenderer>().material.color = Color.white;
    }
}
