using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_Listeners : MonoBehaviour {

   public bool leftTriggerInteractive = false;
   public bool rightTriggerInteractive = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public bool getLeftTriggerInteracting()
    {
        return leftTriggerInteractive; 
    }

    public bool getRightTriggerInteracting()
    {
        return rightTriggerInteractive;
    }


   public  void setLeftTriggerInteracting(bool value)
    {
        
        leftTriggerInteractive = value; 
    }

   public  void setRightTriggerInteracting(bool value)
    {
      
        rightTriggerInteractive = value;
    }

    void OnEnable()
    {
        Singleton_Service.RegisterSingletonInstance(this);
    }
    void OnDisable()
    {
        Singleton_Service.UnregisterSingletonInstance(this);
    }
}
