using UnityEngine;
using System.Collections;

public class CharaManager : MonoBehaviour {

	private Animation charaImg1;
	private Animation charaImg2;
	private Animation charaImg3;
	private Animation charaImg4;
	private Animation charaImg5;

	// Use this for initialization
	void Start () {
		this.charaImg1 = GameObject.Find("Chara_1").gameObject.GetComponent<Animation>();
		this.charaImg2 = GameObject.Find("Chara_2").gameObject.GetComponent<Animation>();
		this.charaImg3 = GameObject.Find("Chara_3").gameObject.GetComponent<Animation>();
		this.charaImg4 = GameObject.Find("Chara_4").gameObject.GetComponent<Animation>();
		this.charaImg5 = GameObject.Find("Chara_5").gameObject.GetComponent<Animation>();

		StartCoroutine ("StartCharaAnimation");
	}



	private IEnumerator StartCharaAnimation() {
		this.charaImg3.Play();
		yield return new WaitForSeconds (0.2f); 
		this.charaImg1.Play();
		this.charaImg5.Play();
		yield return new WaitForSeconds (0.5f); 
		this.charaImg2.Play();
		this.charaImg4.Play(); 
	}
}
