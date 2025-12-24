/************************************************************
************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/************************************************************
************************************************************/
public class BallCreator : MonoBehaviour
{
	/****************************************
	****************************************/
	KeyCode key_instantiate_	= KeyCode.Space;
	KeyCode key_check_			= KeyCode.C;
	
	[SerializeField] GameObject prefab_;
	
	
	/****************************************
	****************************************/
	
	/******************************
	******************************/
    void Start()
    {
        
    }
	
	/******************************
	******************************/
    void Update()
    {
		if( Input.GetKeyDown(key_instantiate_) ){
			GameObject go = (GameObject)Instantiate( prefab_, transform.position, Quaternion.identity  );
			go.transform.parent = transform;
			
		}else if( Input.GetKeyDown(key_check_) ){
			Debug.Log( "Materials " + Resources.FindObjectsOfTypeAll(typeof(Material)).Length );
			
		}
    }
}
