﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMeteor : MonoBehaviour{

    public GameObject vfx;
    public Transform startPoint;
    public Transform endPoint;

    void Start(){
        Vector3 startPos = startPoint.position;
        GameObject objVFX = Instantiate(vfx, startPos, Quaternion.identity) as GameObject;
        Vector3 endPos = endPoint.position;
        RotateTo(objVFX, endPos);
    }

    void RotateTo(GameObject obj, Vector3 destination){
        Vector3 direction = destination - obj.transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        obj.transform.localRotation = Quaternion.Lerp(obj.transform.rotation, rotation, 1);
    }
}
