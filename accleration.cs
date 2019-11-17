using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class accleration : MonoBehaviour
{
    private Vector3 acceleration;
    private Text text_accelerationX;
    private Text text_accelerationY;
    private Text text_accelerationZ;

    // Start is called before the first frame update
    void Start()
    {
        text_accelerationX = GameObject.Find("AccelerationX").GetComponent<Text>();
        text_accelerationY = GameObject.Find("AccelerationY").GetComponent<Text>();
        text_accelerationZ = GameObject.Find("AccelerationZ").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //加速度センサの値を取得
        acceleration = Input.acceleration;

        if (acceleration != null)
        {
            //x,y,zそれぞれの値を出力
            text_accelerationX.text = (acceleration.x).ToString();
            text_accelerationY.text = (acceleration.y).ToString();
            text_accelerationZ.text = (acceleration.z).ToString();
        }

        Debug.Log("Acceleration x:" + this.acceleration.x + "y:" + this.acceleration.y + "z:" + this.acceleration.z);

    }
}
