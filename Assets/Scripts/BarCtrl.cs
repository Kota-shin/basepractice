using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarCtrl : MonoBehaviour
{
    public float x_speed;

    void Start()
    {
        
    }

    
    void Update()
    {
        //Barの座標を取得
        Transform BarTrans = GameObject.Find("Bar").transform;
        Vector3 pos = BarTrans.position;

        //左キー入力時左に動く
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Barの座標が20以下の時移動が可能
            if (pos.x < 20)
                {
                  this.transform.Translate(x_speed, 0f, 0f);
                }
        }

        //右キー入力時に右に動く
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Barの座標が-20以上の時移動が可能
            if (pos.x > -20)
                {
                    this.transform.Translate(-x_speed, 0f, 0f);
                }
        }
    }
}
