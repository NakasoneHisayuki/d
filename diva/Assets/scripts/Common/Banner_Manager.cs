using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Banner_Manager : MonoBehaviour {

	public Button okButton;
	private GameObject gachaContent;
	private GameObject gachaBnrContent;


	void Start(){
		this.gachaContent = GameObject.Find("Gacha_Content");
		this.gachaBnrContent = GameObject.Find("Gacha_Bnr_Content");

	}

	public void OnClickGachaBnr1(){
		StartCoroutine ("GachaContent");
	}
	public void OnClickGachaBnr2(){
		StartCoroutine ("GachaContent");
	}
	public void OnClickGachaBnr3(){
		StartCoroutine ("GachaContent");
	}
	public void OnClickGachaBnr4(){
		StartCoroutine ("GachaContent");
	}
	public void OnClickGachaBnr5(){
		StartCoroutine ("GachaContent");
	}
	public void OnClickGachaBnr6(){
		StartCoroutine ("GachaContent");
	}

    public void OnClickMyButton() {

    }


	private IEnumerator GachaContent() {
		iTween.MoveTo(this.gachaBnrContent, iTween.Hash("x", 870.0f, "time", 0.5));

		yield return new WaitForSeconds (0.5f); 
		iTween.MoveTo(this.gachaContent, iTween.Hash("x", 0.0f, "time", 0.5));

	}

}
