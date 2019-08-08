using UnityEngine;
using System.Collections;

public class handanimations : MonoBehaviour
{
    Animator anim;
  
    int GrabStickUp = Animator.StringToHash("GrabStickUp");
    int GrabStickFront = Animator.StringToHash("GrabStickFront");


    void Start ()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        
    }
	public void fire()
	{
			anim.SetTrigger(GrabStickUp);
		Invoke ("latedfire",0.1f);
	}
  
	void latedfire()
	{
		anim.SetTrigger(GrabStickFront);
	}
}