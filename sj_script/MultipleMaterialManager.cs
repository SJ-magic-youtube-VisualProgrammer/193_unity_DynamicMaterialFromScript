/************************************************************
************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/************************************************************
************************************************************/
[RequireComponent(typeof(Renderer))]
public class MultipleMaterialManager : MonoBehaviour
{
	/****************************************
	****************************************/
	
	/******************************
	******************************/
    void Start()
    {
		Material[] my_materials = transform.GetComponent<Renderer>().materials;
		
		for( int i = 0; i < my_materials.Length; i++ ){
			Color color = new Color( Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1.0f );
			
			if( my_materials[i].HasProperty("_Color") ){
				my_materials[i].SetColor("_Color", color);
			}
		}
		
		Debug.Log( "Start : Materials " + Resources.FindObjectsOfTypeAll(typeof(Material)).Length );
    }
	
	/******************************
	******************************/
    void Update()
    {
    }
	
	/******************************
	******************************/
	void OnDestroy()
    {
		foreach (var material in GetComponent<Renderer>().materials) {
			Destroy(material);
		}
		
		Debug.Log( "OnDestroy : Materials " + Resources.FindObjectsOfTypeAll(typeof(Material)).Length );
    }
}
