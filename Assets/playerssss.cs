using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerssss : MonoBehaviour {
    public static playerssss instance;
    public BleedBehavior bleed;//player Been Attcked
    public Text ShowXt;
    private void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Damage()
    {
        bleed.enabled = true;
        bleed.BloodAmount = 0.7f;
    }

    public void ShowXT(int Num)
    {
        ShowXt.text = Num.ToString();
    }

}
