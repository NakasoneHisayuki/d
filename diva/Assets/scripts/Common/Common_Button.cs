using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Common_Button : MonoBehaviour {
	
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
		this.OnClickScaleUp(this.questButton.gameObject, 1.0f);
	}

	public void OnClickGachaButtonDown(){
		this.OnClickScaleDown(this.gachaButton.gameObject, 0.8f);
	}

	public void OnClickGachaButtonUp(){
		this.OnClickScaleUp(this.gachaButton.gameObject, 1.0f);
	}

	public void OnClickPvPButtonDown(){
		this.OnClickScaleDown(this.pvpButton.gameObject, 0.8f);
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


	private void OnClickScaleDown(GameObject btn, float size){
		iTween.ScaleTo (btn, iTween.Hash ("x", size, "y", size, "delay", 0f));
	}

	private void OnClickScaleUp(GameObject btn, float size){
		iTween.ScaleTo (btn, iTween.Hash ("x", size, "y", size, "delay", 0f));
	}
}
