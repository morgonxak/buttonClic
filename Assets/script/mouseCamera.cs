using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseCamera : MonoBehaviour {
    
    public float sensitivity = 1F;
    private Vector3 MousePos;
    private float MyAngle = 0F;

    // Use this for initialization
    void Start () {
        transform.position = new Vector3(6.62f, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        MousePos = Input.mousePosition;
        //cube.GetComponent<Transform>().position = Vector3.Lerp(cube.GetComponent<Transform>().position, new Vector3(8, 2, -3), Time.deltaTime);
        //transform.rotation = Quaternion.Lerp(camera.transform.rotation.SetEuler,Quaternion.Euler(transform.position.x, transform.position.y,0), Time.deltaTime);
    }

    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            MyAngle = 0;
            // расчитываем угол, как:
            // разница между позицией мышки и центром экрана, делённая на размер экрана
            //  (чем дальше от центра экрана тем сильнее поворот)
            // и умножаем угол на чуствительность из параметров
            // поворот по х -40 до 60
            //
            MyAngle = sensitivity * ((MousePos.x - (Screen.width / 2)) / Screen.width);




            transform.RotateAround(transform.position,new Vector3(0,1,0), MyAngle);




            MyAngle = sensitivity * ((MousePos.y - (Screen.height / 2)) / Screen.height);

            transform.RotateAround(transform.position, transform.right, -MyAngle);
        }
       
        

    }
}
