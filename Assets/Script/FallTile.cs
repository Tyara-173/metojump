using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FallTile : MonoBehaviour
{
    Transform trans;
    void Start()
    {
        trans = this.transform;
    }

    void Update()
    {
        if(Tiles.tilesarray[(int)(Meto.position+1) % Tiles.tilesarray.Length] == 2){
            FallOut();
        }
    }
    public void FallOut(){
        // this.gameObject.transform.DOScaleY(0,2f);
        // this.trans.DOScaleY(0,2f);
        this.trans.DOShakePosition(2f,0.1f,2,1, false, false);
        this.trans.DOMoveY(-15f,2f).SetDelay(2.2f);
        // Tiles.tilesarray[(int)(Meto.position+1) % Tiles.tilesarray.Length] = 0;
    }
}
