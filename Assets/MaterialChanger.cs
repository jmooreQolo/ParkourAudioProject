using UnityEngine;
using System.Collections;

public class MaterialChanger : MonoBehaviour {

	//mStart is original material for the object
	//mTarget is what we're transitioning to
	//mCurrent is currently blended material (used for reversing transition)
	Material m_current, m_target;
	public Material m_start;
	public Timer timer;
	bool transitioning;
	bool visible;
	public float timeToTrans=3f;
	public Material visibleMat;
	
	// Use this for initialization
	void Awake () {	
		transitioning = false;
		m_start = new Material(this.renderer.material);
		m_current = new Material(this.renderer.material);
		m_target = new Material(m_current);
		visible=false;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(renderer.isVisible);
		if(renderer.isVisible && !visible){
			visible=true;
			StartTransition(visibleMat,timeToTrans);
		}
		else if(!(renderer.isVisible)){
			visible=false;
			revert();
		}
		if(transitioning) Transition();
	}
	
	//This begins a transition
	public void StartTransition(Material mat, float time)
	{
		EndTransition();
		m_target = new Material(mat);
		timer = new Timer(time);
		transitioning = true;
	}
	
	//Transitions betweent the currentMaterial and the targetMaterial based on
	//how close the timer is to completion.
	void Transition()
	{
		renderer.material.Lerp(m_current, m_target, timer.progress());
		if (timer.isFinished()){
			renderer.material = m_target;
			EndTransition();
		}
	}
	
	//This function stops the timer and sets the currentMaterial to the
	//currently lerped material.
	void EndTransition()
	{
		m_current.CopyPropertiesFromMaterial(renderer.material);	
		transitioning = false;
	}
	
	//Return a copy of the current material. Note that mCurrent is only updated
	//when a transition is ended
	public Material Current()
	{
		return new Material(m_current);	
	}
	
	public void revert(){
		EndTransition();
		renderer.material = m_start;
	}
	
	public void reverseTransition(float time){
		StartTransition(m_start, time);
	}
	


}