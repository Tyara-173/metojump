using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Tiles : MonoBehaviour
{
    public static int[] tilesarray = {1,1,0,1,0,1,1,0,2,0,2,0,2,2,2,0,1,0};
    public GameObject tile;
    public GameObject tile2;
    float pixelsize = 5.12f;
    float tilepos = 0f;
    void Start()
    {
    }
    void Update()
    {
        for (float i = tilepos; i < Meto.position+6; i++){
            Debug.Log(i);
            Vector2 vector2 = new Vector2(i * pixelsize,-9);
            if(tilesarray[(int)(i+1) % tilesarray.Length] == 1){
                Instantiate (tile,vector2,new Quaternion(0,0,0,0));
            }
            if(tilesarray[(int)(i+1) % tilesarray.Length] == 2){
                Instantiate (tile2,vector2,new Quaternion(0,0,0,0));
            }
        }
        tilepos = Meto.position;
        transform.DOMoveX((Meto.position+1)*pixelsize,0.2f);
    }
}
