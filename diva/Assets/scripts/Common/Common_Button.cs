﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Common_Button : MonoBehaviour {

	private GameObject mainContent;
	private GameObject gachaBnrContent;
	private GameObject questContent;
	private GameObject pvpContent;

	public Button menuButton;
	public Button myButton;

	public Button dorifesuButton;
	public Button unitButton;
	public Button abilityButton;
	public Button questButton;
	public Button gachaButton;
	public Button pvpButton;
	public Button newsButton;
	public Button resqueButton;
	public Button compButton;
    private bool isMuve = false;

	Animation animationMainContent;

	void Start(){
		this.mainContent = GameObject.Find("Main_Content");
		this.gachaBnrContent = GameObject.Find("Gacha_Bnr_Content");
		this.questContent = GameObject.Find("Quest_Content");
		this.pvpContent = GameObject.Find("PvP_Battle_Content");
		this.animationMainContent = this.mainContent.GetComponent<Animation>();
	}


	// GlobalButton
	public void OnClickMenuButtonDown(){
		iTween.MoveTo(this.menuButton.gameObject, iTween.Hash("x", 421.0f, "time", 0.5));
	}

	public void OnClickMenuButtonUp(){
		iTween.MoveTo(this.menuButton.gameObject, iTween.Hash("x", 403.0f, "time", 0.5));
	}

	public void OnClickMyButtonDown(){
		iTween.MoveTo(this.myButton.gameObject, iTween.Hash("x", -414.0f, "time", 0.5));
	}

	public void OnClickMyButtonUp(){
		iTween.MoveTo(this.myButton.gameObject, iTween.Hash("x", -402.0f, "time", 0.5));
        this.CheckContentPosition();


    }


    private void CheckContentPosition() {

        if (this.isMuve) return;
        if (this.mainContent.gameObject.transform.localScale.x == 1) return;

        if (this.gachaBnrContent.transform.localPosition.x == 0.0f) {
            iTween.MoveTo(this.gachaBnrContent, iTween.Hash("x", 870.0f, "time", 0.5));
        }

        if (this.questContent.transform.localPosition.x == 0.0f){
            iTween.MoveTo(this.questContent, iTween.Hash("x", 870.0f, "time", 0.5));
        }

        if (this.pvpContent.transform.localPosition.x == 0.0f){
            iTween.MoveTo(this.pvpContent, iTween.Hash("x", 870.0f, "time", 0.5));
        }

        StartCoroutine("OpenMyContent");


    }


	// MypageButton
	public void OnClickDorifesuButtonDown(){
		this.OnClickScaleDown(this.dorifesuButton.gameObject, 1.3f);
	}

	public void OnClickDorifesuButtonUp(){
		this.OnClickScaleUp(this.dorifesuButton.gameObject, 1.5f);
	}

	public void OnClickUnitButtonDown(){
		this.OnClickScaleDown(this.unitButton.gameObject, 0.8f);
	}

	public void OnClickUnitButtonUp(){
		this.OnClickScaleUp(this.unitButton.gameObject, 1.0f);
	}

	public void OnClickAbilityButtonDown(){
		this.OnClickScaleDown(this.abilityButton.gameObject, 0.8f);
	}

	public void OnClickAbilityButtonUp(){
		this.OnClickScaleUp(this.abilityButton.gameObject, 1.0f);
	}

	public void OnClickQuestButtonDown(){
		this.OnClickScaleDown(this.questButton.gameObject, 0.8f);
	}

	public void OnClickQuestButtonUp(){
        this.isMuve = true;
        this.OnClickScaleUp(this.questButton.gameObject, 1.0f);
		StartCoroutine ("OpenQuestContent");
	}

	// GachaButton
	public void OnClickGachaButtonDown(){
		this.OnClickScaleDown(this.gachaButton.gameObject, 0.8f);
	}

	public void OnClickGachaButtonUp(){
        this.isMuve = true;
        this.OnClickScaleUp(this.gachaButton.gameObject, 1.0f);
		StartCoroutine ("OpenGachaContent");
	}

	public void OnClickReturnButtonGachaContent(){
		StartCoroutine ("CloseGachaContent");
	}

	public void OnClickPvPButtonDown(){
        this.isMuve = true;
        this.OnClickScaleDown(this.pvpButton.gameObject, 0.8f);
		StartCoroutine ("OpenPvPContent");


	}

	public void OnClickPvPButtonUp(){
		this.OnClickScaleUp(this.pvpButton.gameObject, 1.0f);
	}

	public void OnClickNewsButtonDown(){
		this.OnClickScaleDown(this.newsButton.gameObject, 0.8f);
	}

	public void OnClickNewsButtonUp(){
		this.OnClickScaleUp(this.newsButton.gameObject, 1.0f);
	}

	public void OnClickResqueButtonDown(){
		this.OnClickScaleDown(this.resqueButton.gameObject, 0.8f);
	}

	public void OnClickResqueButtonUp(){
		this.OnClickScaleUp(this.resqueButton.gameObject, 1.0f);
	}

	public void OnClickCompButtonDown(){
		this.OnClickScaleDown(this.compButton.gameObject, 0.8f);
	}

	public void OnClickCompButtonUp(){
		this.OnClickScaleUp(this.compButton.gameObject, 1.0f);
	}


    private IEnumerator OpenMyContent()
    {
        yield return new WaitForSeconds(0.5f);
        this.animationMainContent.Play("Mypage_Content_Up");
    }

    private IEnumerator CloseGachaContent() {
		iTween.MoveTo(this.gachaBnrContent, iTween.Hash("x", 870.0f, "time", 0.5));

		yield return new WaitForSeconds (0.5f); 
		this.animationMainContent.Play("Mypage_Content_Up");
        this.isMuve = false;
    }

	private IEnumerator OpenGachaContent() {
		this.animationMainContent.Play("Mypage_Content_Down");
		yield return new WaitForSeconds (0.5f); 
		iTween.MoveTo(this.gachaBnrContent, iTween.Hash("x", 0.0f, "time", 0.5));
        this.isMuve = false;
    }

	private IEnumerator OpenPvPContent() {
		this.animationMainContent.Play("Mypage_Content_Down");
		yield return new WaitForSeconds (0.5f); 
		iTween.MoveTo(this.pvpContent, iTween.Hash("x", 0.0f, "time", 0.5));
        this.isMuve = false;
    }

	private IEnumerator OpenQuestContent() {
		this.animationMainContent.Play("Mypage_Content_Down");
		yield return new WaitForSeconds (0.5f); 
		iTween.MoveTo(this.questContent, iTween.Hash("x", 0.0f, "time", 0.5));
        this.isMuve = false;
    }

	private void OnClickScaleDown(GameObject btn, float size){
		iTween.ScaleTo (btn, iTween.Hash ("x", size, "y", size, "delay", 0f));
	}

	private void OnClickScaleUp(GameObject btn, float size){
		iTween.ScaleTo (btn, iTween.Hash ("x", size, "y", size, "delay", 0f));
	}
}
