using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarColorChangeOnCollision : MonoBehaviour
{
    SkinnedMeshRenderer thisRenderer;
    //Shader changeColor;

    // Start is called before the first frame update
    void Start()
    {
        //changeColor = GetComponent<Shader>();
        thisRenderer = GetComponent<SkinnedMeshRenderer>();
    }

    public void OnTriggerEnter(Collider other)
    {
        Color randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        thisRenderer.material.SetColor("_Color", randomColor);
        //Material newMaterial = new Material(changeColor.material);
        //newMaterial.SetColor("_Color", randomColor);
        //changeColor.material = newMaterial;
        Debug.Log("OnTriggerEnter : " + other.gameObject.name);
    }
}
