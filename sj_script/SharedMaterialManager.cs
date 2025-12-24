/************************************************************
************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/************************************************************
************************************************************/
[RequireComponent(typeof(Renderer))]
public class SharedMaterialManager : MonoBehaviour
{
	/****************************************
	****************************************/
	
	/******************************
	******************************/
    void Start()
    {
		Color color = new Color( Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1.0f );
		Material my_shared_material = transform.GetComponent<Renderer>().sharedMaterial;
		
		
		// my_shared_material.color = color;
		if( my_shared_material.HasProperty("_Color") ){
			my_shared_material.SetColor("_Color", color);
		}
		
		Debug.Log( "Start : Materials " + Resources.FindObjectsOfTypeAll(typeof(Material)).Length );
		
    }
	
	/******************************
	******************************/
    void Update()
    {
    }
}
