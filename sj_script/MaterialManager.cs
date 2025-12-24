/************************************************************
■Resources.UnloadUnusedAssets()
	materialを含む、使用されていないAssetがunloadされます。
	が、重い処理で、本Functionを使っての掃除は、推奨されていません。
************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/************************************************************
************************************************************/
[RequireComponent(typeof(Renderer))]
public class MaterialManager : MonoBehaviour
{
	/****************************************
	****************************************/
	Material my_material_;
	
	
	/****************************************
	****************************************/
	
	/******************************
	******************************/
    void Start()
    {
		Color color = new Color( Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1.0f );
		my_material_ = transform.GetComponent<Renderer>().material;
		
		
		// my_material_.color = color;
		if( my_material_.HasProperty("_Color") ){
			my_material_.SetColor("_Color", color);
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
		/*
		// ↓で配列全てDestroyする方が安全
		if (my_material_ != null) {
			Destroy(my_material_);
		}
		*/
		
		foreach (var material in GetComponent<Renderer>().materials) {
			Destroy(material);
		}
		
		Debug.Log( "OnDestroy : Materials " + Resources.FindObjectsOfTypeAll(typeof(Material)).Length );
    }
}
