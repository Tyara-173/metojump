using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Meto : MonoBehaviour
{
    float pixelsize = 5.12f;
    public static float position = -1;
    GameObject result;
    void Start()
    {
        result = GameObject.Find("Menu").transform.GetChild(0).gameObject;
    }

    void Update()
    {
        Vector3 vec = transform.position;
        if(Tiles.tilesarray[(int)(position+1) % Tiles.tilesarray.Length] == 0){
            Death(0.3f);
        }else{
            if(Input.GetKeyDown(KeyCode.Z)){
                position++;
                transform.DOJump(new Vector3(position*pixelsize,-2.4f,vec.z),1f,1,0.4f);
            }
            if(Input.GetKeyDown(KeyCode.X)){
                position += 2;
                Jump();
                transform.DOJump(new Vector3(position*pixelsize,-2.4f,vec.z),2f,1,0.4f);
            }
        }
        // if(Tiles.tilesarray[(int)(position+1) % Tiles.tilesarray.Length] == 2){
        //     Death(2.2f);
        // }
    }
    void Jump(){
        for (double i = 0; i <= 2; i += 0.1)
        {
            transform.DOScaleX((float)Math.Cos(i*Math.PI),0.15f).SetDelay(0.15f*(float)i);
        }
    }
    public void Death(float time){
        transform.DOMoveY(-15f,0.2f).SetDelay(time);
        result.SetActive(true);
    }
}
