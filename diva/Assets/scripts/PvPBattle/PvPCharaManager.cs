using UnityEngine;
using System.Collections;

public class PvPCharaManager : MonoBehaviour {

	private Animation rightCharaImg1;
	private Animation rightCharaImg2;
	private Animation rightCharaImg3;
	private Animation rightCharaImg4;
	private Animation rightCharaImg5;

	private Animation leftCharaImg1;
	private Animation leftCharaImg2;
	private Animation leftCharaImg3;
	private Animation leftCharaImg4;
	private Animation leftCharaImg5;

	// Use this for initialization
	void Start () {
		
	}
		

	public void LeftChara(){
		this.leftCharaImg1 = GameObject.Find("Left_1").gameObject.GetComponent<Animation>();
		this.leftCharaImg2 = GameObject.Find("Left_2").gameObject.GetComponent<Animation>();
		this.leftCharaImg3 = GameObject.Find("Left_3").gameObject.GetComponent<Animation>();
		this.leftCharaImg4 = GameObject.Find("Left_4").gameObject.GetComponent<Animation>();
		this.leftCharaImg5 = GameObject.Find("Left_5").gameObject.GetComponent<Animation>();
	}

	public void RightChara(){
		this.rightCharaImg1 = GameObject.Find("Right_1").gameObject.GetComponent<Animation>();
		this.rightCharaImg2 = GameObject.Find("Right_2").gameObject.GetComponent<Animation>();
		this.rightCharaImg3 = GameObject.Find("Right_3").gameObject.GetComponent<Animation>();
		this.rightCharaImg4 = GameObject.Find("Right_4").gameObject.GetComponent<Animation>();
		this.rightCharaImg5 = GameObject.Find("Right_5").gameObject.GetComponent<Animation>();
	}

	public void StartMoveChara(){
		StartCoroutine ("StartCharaAnimation");
	}


	private IEnumerator StartCharaAnimation() {
		this.rightCharaImg3.Play();
		this.leftCharaImg3.Play();
		yield return new WaitForSeconds (0.2f); 
		this.rightCharaImg1.Play();
		this.rightCharaImg5.Play();
		this.leftCharaImg1.Play();
		this.leftCharaImg5.Play();
		yield return new WaitForSeconds (0.5f); 
		this.rightCharaImg2.Play();
		this.rightCharaImg4.Play();
		this.leftCharaImg2.Play();
		this.leftCharaImg4.Play();
	}
}
