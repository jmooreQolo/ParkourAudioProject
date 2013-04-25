using UnityEngine;
using System.Collections;

public class ParkourCube : MonoBehaviour {
	public Material noneMaterial;
	public Material lowMaterial;
	public Material midMaterial;
	public Material highMaterial;
	public Material nopeMaterial;
	public int type;
	public int level;
	public MaterialChanger mc;
	public AudioSource source;
	public AudioClip slideOkay;
	public AudioClip slideAvoid;
	public AudioClip jumpOkay;
	public AudioClip jumpAvoid;
	
	
	RaycastHit hit;
	// Use this for initialization
	void Start () {
		source.loop=true;
		source.Play();
	}
	
	// Update is called once per frame
	void Update (){
		if(Input.GetKeyDown(KeyCode.L)){
			level++;
			if(level>4) level=0;
			SwitchVisuals(level);
		}
		//jumping
		if(type == 1){
			if(Input.GetKeyDown(KeyCode.Alpha6)){
				SwitchVisuals(0);	
				ChangeJumpOkay();
			}
			if(Input.GetKeyDown(KeyCode.Alpha7)){
				SwitchVisuals(1);
				ChangeJumpOkay();
			}
			if(Input.GetKeyDown(KeyCode.Alpha8)){
				SwitchVisuals(2);
				ChangeJumpOkay();
			}
			if(Input.GetKeyDown(KeyCode.Alpha9)){
				SwitchVisuals(3);
				ChangeJumpOkay();
			}
			if(Input.GetKeyDown(KeyCode.Alpha0)){
				SwitchVisuals(4);
				ChangeJumpAvoid();
			}
			if(Input.GetKeyDown(KeyCode.G)){
				source.volume=.5f;
			}
			if(Input.GetKeyDown(KeyCode.H)){
				source.volume =1f;
			}
			if(Input.GetKeyDown(KeyCode.J)){
				source.volume =0f;
			}
		}
		//sliding
		if(type == 2){
			if(Input.GetKeyDown(KeyCode.Alpha1)){
				SwitchVisuals(0);
				ChangeSlideOkay();
			}
			if(Input.GetKeyDown(KeyCode.Alpha2)){
				SwitchVisuals(1);
				ChangeSlideOkay();
			}
			if(Input.GetKeyDown(KeyCode.Alpha3)){
				SwitchVisuals(2);
				ChangeSlideOkay();
			}
			if(Input.GetKeyDown(KeyCode.Alpha4)){
				SwitchVisuals(3);
				ChangeSlideOkay();
			}
			if(Input.GetKeyDown(KeyCode.Alpha5)){
				SwitchVisuals(4);
				ChangeSlideAvoid();
			}
			if(Input.GetKeyDown(KeyCode.B)){
				source.volume=.5f;
			}
			if(Input.GetKeyDown(KeyCode.N)){
				source.volume =1f;
			}
			if(Input.GetKeyDown(KeyCode.M)){
				source.volume =0f;
			}
		}
		
		if(renderer.isVisible){
			
			GameObject p = GameObject.FindGameObjectWithTag("Player");
			if(Physics.Raycast(this.transform.position, Vector3.Normalize(p.transform.position-this.transform.position),out hit)){
				if(hit.collider.gameObject.CompareTag("Player")){
					source.Play();
				}
				else{
					source.Stop();
				}
			
			
			}
		}
			
		
			
			
	}
	
	void SwitchVisuals(int lev){
		level=lev;
		switch(level){
		case 0:
			mc.visibleMat=noneMaterial;
			mc.StartTransition(mc.visibleMat,1);
			break;
		case 1:
			mc.visibleMat=lowMaterial;
			mc.StartTransition(mc.visibleMat,1);
			break;
		case 2:
			mc.visibleMat=midMaterial;
			mc.StartTransition(mc.visibleMat,1);
			break;
		case 3:
			mc.visibleMat=highMaterial;
			mc.StartTransition(mc.visibleMat,1);
			break;
		case 4:
			mc.visibleMat=nopeMaterial;
			mc.StartTransition(mc.visibleMat,1);
			break;
		}
		
	}
	
	public void ChangeSlideOkay(){
		source.clip = slideOkay;

	}
	public void ChangeSlideAvoid(){
		source.clip = slideAvoid;

	}
	public void ChangeJumpOkay(){
		source.clip = jumpOkay;

	}
	public void ChangeJumpAvoid(){
		source.clip = jumpAvoid;

	}
}
