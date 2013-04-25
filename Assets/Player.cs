using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public AudioSource source;
	public AudioClip walkingClip;
	public AudioClip slidingClip;
	public AudioClip jumpingClip;
	public CharacterMotor charMot;
	public CharacterController ch;
	public Transform cam;
	
	bool isSliding;
	
	public float targetingWidth = .3f;
	public float targetingHeight = .3f;
	public int numberOfRaysPerRow = 5;
	public int numberOfRaysPerCol = 5;
	
	// Use this for initialization
	void Start () {
		isSliding = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.LeftShift)){
			ch.height= .5f;
			//ch.center=new Vector3(0f,1f,0f);
			cam.localPosition= new Vector3(0f,0f,0f);
			isSliding = true;	
		}
		else{
			if(isSliding){
				this.transform.Translate(new Vector3(0f,1.3f,0f));
				isSliding=false;
			}
			//this.transform.Translate(new Vector3(0f,1.3f,0f));

			ch.height= 2f;
			//ch.center=new Vector3(0f,0f,0f);
			cam.localPosition= new Vector3(0f,.5f,0f);
			
			
		}
		if(!charMot.IsJumping() && charMot.IsGrounded() && !isSliding){
			if(Input.GetAxis("Horizontal") !=0 || Input.GetAxis("Vertical") !=0){
				if(!source.isPlaying){
					source.clip=walkingClip;
					source.Play();
					source.loop=true;
				}
			}
		}
		else if(charMot.IsJumping()){
			if(!source.isPlaying){
				source.clip = jumpingClip;
				source.Play();
				source.loop=false;
			}
		}
		else if(isSliding){
			if(!source.isPlaying){
				source.clip=slidingClip;
				source.Play();
				source.loop=false;
			}
			
		}
		else{
			source.Stop();
		}
		
		
		
		
		
	}
}
