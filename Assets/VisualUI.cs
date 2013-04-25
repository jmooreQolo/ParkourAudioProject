using UnityEngine;
using System.Collections;

public class VisualUI : MonoBehaviour {
	public int mainButtonWidth;
	public int mainButtonHeight;
	public int mainButtonX;
	public int mainButtonY;
	public int typeButtonWidth;
	public int typeButtonHeight;
	
	bool mainMenuToggle;
	
	
	float jumpRValue;
	float jumpBValue;
	float jumpGValue;
	float jumpHeight;
	float jumpVolume;
	
	float runRValue;
	float runBValue;
	float runGValue;
	float runHeight;
	float runVolume;
	
	float slideRValue;
	float slideBValue;
	float slideGValue;
	float slideHeight;
	float slideVolume;
	
	public AudioSource source;
	public AudioClip confirm;
	public AudioClip deny;
	public AudioClip move;
	public AudioClip select;
	
	public Texture2D mainLogo;
	public Texture2D runLogo;
	public Texture2D jumpLogo;
	public Texture2D slideLogo;
	
	
	int controlWindow;
	// Use this for initialization
	void Start () {
		mainButtonWidth = 150;
		mainButtonHeight = 150;
		mainButtonX = Screen.width - mainButtonHeight;
		mainButtonY = 0;
		typeButtonWidth = mainButtonWidth/2;
		typeButtonHeight = mainButtonHeight/2;
		mainMenuToggle = false;
		source.loop=false;
		controlWindow = 3;
		slideHeight = 6;
		slideVolume = 5;
		runHeight = 6;
		runVolume = 5;
		jumpHeight = 6;
		jumpVolume = 5;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.P)){
				Debug.Log("Key Press");
				mainMenuToggle = !(mainMenuToggle);
				if(mainMenuToggle){
					source.clip = confirm;
					source.Play();
				}
				
		}
		
		if(Input.GetKeyDown(KeyCode.G)){
			source.clip = select;
			source.Play();
			jumpVolume = 5f;
		}
		if(Input.GetKeyDown(KeyCode.H)){
			source.clip = select;
			source.Play();
			jumpVolume = 10f;
		}
		if(Input.GetKeyDown(KeyCode.J)){
			source.clip = select;
			source.Play();
			jumpVolume = 0f;
		}
		if(Input.GetKeyDown(KeyCode.B)){
			source.clip = select;
			source.Play();
			slideVolume = 5f;
		}
		if(Input.GetKeyDown(KeyCode.N)){
			source.clip = select;
			source.Play();
			slideVolume = 10f;
		}
		if(Input.GetKeyDown(KeyCode.M)){
			source.clip = select;
			source.Play();
			slideVolume = 0f;
		}
		
		
		
		if(Input.GetKeyDown(KeyCode.Alpha1)){
				slideHeight = 0f;
				source.clip = select;
				source.Play();
			}
			if(Input.GetKeyDown(KeyCode.Alpha2)){
				source.clip = select;
				source.Play();
				slideHeight = 2f;
			}
			if(Input.GetKeyDown(KeyCode.Alpha3)){
				source.clip = select;
				source.Play();
				slideHeight = 4f;
			}
			if(Input.GetKeyDown(KeyCode.Alpha4)){
				source.clip = select;
				source.Play();
				slideHeight =6f;
			}
			if(Input.GetKeyDown(KeyCode.Alpha5)){
				source.clip = select;
				source.Play();
				slideHeight = 8f;
			}
		
		if(Input.GetKeyDown(KeyCode.Alpha6)){
				jumpHeight = 0f;
				source.clip = select;
				source.Play();
			}
			if(Input.GetKeyDown(KeyCode.Alpha7)){
				source.clip = select;
				source.Play();
				jumpHeight = 2f;
			}
			if(Input.GetKeyDown(KeyCode.Alpha8)){
				source.clip = select;
				source.Play();
				jumpHeight = 4f;
			}
			if(Input.GetKeyDown(KeyCode.Alpha9)){
				source.clip = select;
				source.Play();
				jumpHeight =6f;
			}
			if(Input.GetKeyDown(KeyCode.Alpha0)){
				source.clip = select;
				source.Play();
				jumpHeight = 8f;
			}
		
		
	}
	
	void OnGUI(){
		
		GUI.Box(new Rect(mainButtonX,mainButtonY,mainButtonWidth,mainButtonHeight), mainLogo);
		
		
		
		if(mainMenuToggle){
			GUI.Box(new Rect(mainButtonX- typeButtonWidth, mainButtonY + (mainButtonHeight/2) - (typeButtonHeight/2), typeButtonWidth, typeButtonHeight), jumpLogo);
			
			GUI.Box(new Rect(mainButtonX- typeButtonWidth, mainButtonY + mainButtonHeight, typeButtonWidth, typeButtonHeight), runLogo);
		
			GUI.Box(new Rect(mainButtonX+ (mainButtonWidth/2) - (typeButtonWidth/2), mainButtonY + mainButtonHeight, typeButtonWidth, typeButtonHeight),slideLogo);
		}
		
		if(Input.GetKeyDown(KeyCode.Y)){
			controlWindow = 0;
			source.clip = move;
			source.Play();
			
		}
		else if(Input.GetKeyDown(KeyCode.U)){
			controlWindow = 1;
			source.clip = move;
			source.Play();
			
		}
		else if(Input.GetKeyDown(KeyCode.I)){
			controlWindow = 2;
			source.clip = move;
			source.Play();
			
		}
		else if(Input.GetKeyDown(KeyCode.O)){
			controlWindow = 3;
			
			
		}
		
		if(Input.GetKeyDown(KeyCode.K)){
			source.clip=deny;
			source.Play();
		}
		
		switch(controlWindow){
		case 0:
			GUI.Window(0,new Rect(0,0,150,150),WindowFunction,"Jump Controls");
			break;
		case 1:
			GUI.Window(1,new Rect(0,0,150,150),WindowFunction,"Run Controls");
			break;
		case 2:
			GUI.Window(2,new Rect(0,0,150,150),WindowFunction,"Slide Controls");
			break;
		case 3:
			break;
		}
		
		
		
	}
	
	void WindowFunction(int windowID){
		if(windowID == 0){
//			jumpRValue= GUI.HorizontalSlider (new Rect (10, 30, 80, 30), jumpRValue, 0.0f, 10.0f);
//			jumpGValue = GUI.HorizontalSlider (new Rect (10, 60, 80, 30), jumpGValue, 0.0f, 10.0f);
//			jumpBValue = GUI.HorizontalSlider (new Rect (10, 90, 80, 30), jumpBValue, 0.0f, 10.0f);
//			GUI.Label(new Rect(95,30,10,20),"R");
//			GUI.Label(new Rect(95,60,10,20),"G");
//			GUI.Label(new Rect(95,90,10,20),"B");
//			GUI.Label(new Rect(10,130,100,20),"Jump Color");
			
			jumpHeight = GUI.HorizontalSlider (new Rect (10, 30, 80, 30), jumpHeight, 0.0f, 10.0f);
			GUI.Label(new Rect(10,60,100,20),"Jump Difficulty");
			
			jumpVolume = GUI.HorizontalSlider (new Rect (10, 90, 80, 30), jumpVolume, 0.0f, 10.0f);
			GUI.Label(new Rect(10,120,100,20),"Jump Volume");
			
		}
		if(windowID == 1){
//			runRValue= GUI.HorizontalSlider (new Rect (10, 30, 80, 30), runRValue, 0.0f, 10.0f);
//			runGValue = GUI.HorizontalSlider (new Rect (10, 60, 80, 30), runGValue, 0.0f, 10.0f);
//			runBValue = GUI.HorizontalSlider (new Rect (10, 90, 80, 30), runBValue, 0.0f, 10.0f);
//			GUI.Label(new Rect(95,30,10,20),"R");
//			GUI.Label(new Rect(95,60,10,20),"G");
//			GUI.Label(new Rect(95,90,10,20),"B");
//			GUI.Label(new Rect(10,130,100,20),"Run Color");
			
			runHeight = GUI.HorizontalSlider (new Rect (10, 30, 80, 30), runHeight, 0.0f, 10.0f);
			GUI.Label(new Rect(10,60,100,20),"Run Difficulty");
			
			runVolume = GUI.HorizontalSlider (new Rect (10,90, 80, 30), runVolume, 0.0f, 10.0f);
			GUI.Label(new Rect(10,120,100,20),"Run Volume");
			
		}
		if(windowID == 2){
//			slideRValue= GUI.HorizontalSlider (new Rect (10, 30, 80, 30), slideRValue, 0.0f, 10.0f);
//			slideGValue = GUI.HorizontalSlider (new Rect (10, 60, 80, 30), slideGValue, 0.0f, 10.0f);
//			slideBValue = GUI.HorizontalSlider (new Rect (10, 90, 80, 30), slideBValue, 0.0f, 10.0f);
//			GUI.Label(new Rect(95,30,10,20),"R");
//			GUI.Label(new Rect(95,60,10,20),"G");
//			GUI.Label(new Rect(95,90,10,20),"B");
//			GUI.Label(new Rect(10,130,100,20),"Run Color");
			
			slideHeight = GUI.HorizontalSlider (new Rect (10, 30, 80, 30), slideHeight, 0.0f, 10.0f);
			GUI.Label(new Rect(10,60,100,20),"Slide Difficulty");
			
			slideVolume = GUI.HorizontalSlider (new Rect (10,90, 80, 30), slideVolume, 0.0f, 10.0f);
			GUI.Label(new Rect(10,120,100,20),"Slide Volume");
			
		}
		
	}
}
