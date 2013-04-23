using UnityEngine;
using System.Collections;

//The Timer class is used to handle times in the game
//By default, the timer counts down from maxTime until it reaches 0.
public class Timer {
	
	public float maxTime, startTime; 
	public bool isRunning, countdown, finished; //countdown determines if the timer counts from maxTime to zero, or from zero to maxTime
	
	// Use this for initialization
	public Timer (float time) {
		startTime = Time.time;
		maxTime = time;
	}

	//This initializes the timer to its max time and whether it counts down or not
	public void SetTimer(float time){
		this.maxTime = time;		
	}
	
	// Restarts the timer
	public void Restart(){
		this.startTime = Time.time;	
	}
	
	//Checks if the timer is finished
	public bool isFinished(){
		if (Time.time >= (startTime + maxTime))
			finished = true;
		else
			finished = false;
		return finished;	
	}
	
	//Returns the % completion of the timer as a float (ex: .38 is 38% done)
	public float progress(){
		if (isFinished())
			return 1f;
		else
			return (Time.time-(startTime))/maxTime;
	}
	
	public float TimeElapsed(){
		return Time.time - this.startTime;	
	}
	
	//Takes in a time in seconds and return a string
	public static string TimeAsString(float time){
		string result;	
		if(((int)time)/3600 > 0) result = string.Format("{0:00}:{1:00}:{2:00}:{3:00}",(((int)time)/3600),(((int)time/60)%60),(((int)time)%60),(time%1)*100);
		else result = string.Format("{0:00}:{1:00}:{2:00}",(((int)time/60)%60),(((int)time)%60),(time%1)*100);
		//result = string.Format("{0:00}:{1:00}:{2:00}:{3:00}",(((int)time)/3600),(((int)time/60)%60),(((int)time)%60),(time%1)*100);
		return result;
	}
}