using UnityEngine;
using System.Collections;

public class ParkourCube : MonoBehaviour {
	public Material noneMaterial;
	public Material lowMaterial;
	public Material midMaterial;
	public Material highMaterial;
	public Material nopeMaterial;
	public int level;
	public MaterialChanger mc;
	public AudioSource source;
	public AudioClip slideOkay;
	public AudioClip slideAvoid;
	public AudioClip jumpOkay;
	public AudioClip jumpAvoid;
	
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update (){
		
	}
	
	void SwitchVisuals(int lev){
		obsticalType=obstical;
		level=lev;
		switch(level){
		case 0:
			mc.visibleMat=noneMaterial;
			break;
		case 1:
			mc.visibleMat=lowMaterial;
			break;
		case 2:
			mc.visibleMat=midMaterial;
			break;
		case 3:
			mc.visibleMat=highMaterial;
			break;
		case 4:
			mc.visibleMat=nopeMaterial;
			break;
		}
		
	}
	
	public void ChangeSlideOkay(){
		source.clip = slideOkay;
		source.Play();
	}
	public void ChangeSlideAvoid(){
		source.clip = slideAvoid;
		source.Play();
	}
	public void ChangeJumpOkay(){
		source.clip = jumpOkay;
		source.Play();
	}
	public void ChangeSlideOkay(){
		source.clip = jumpAvoid;
		source.Play();
	}
}
