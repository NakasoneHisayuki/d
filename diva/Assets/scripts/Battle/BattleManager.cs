using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class BattleManager : MonoBehaviour {

	public UserDataModel userDataModel;
	public MypageManager mypageManager;
	public ExperienceData experienceData;
	public CharaManager charaManager;
	public BossManager bossManager;
	public EventBattleManager eventBattleManager;
	public Button enterButton;

	public Text[] userDataText;
	int battleCount = 0;
	int battleMaxCount = 3;
	int nextExperience = 0;
	int levelNum = 0;
	int stageExperience = 35;

	// Use this for initialization
	void Start () {


	}

	void OnEnable(){
		this.battleCount = 0;
		this.userDataText[3].text = string.Format("BattleCount : {0}" , this.battleCount);
		this.levelNum = this.userDataModel.userDataManager.level;
		this.nextExperience = this.experienceData.experienceManager[levelNum].experience;
		this.userDataText[0].text = string.Format("UserName : {0}" , this.userDataModel.userDataManager.userName);
		this.userDataText[1].text = string.Format("Level : {0}" , this.userDataModel.userDataManager.level);
		this.userDataText[2].text = string.Format("Experience : {0}" , this.userDataModel.userDataManager.experience);

	}
	public void OnClickEnterButton(){
		if(this.battleCount == 3)return;
		if(this.eventBattleManager.isBattle)return;
		this.BattleLogic();
	}

	private void BattleLogic(){
		this.battleCount ++;
		this.userDataText[3].text = string.Format("BattleCount : {0}" , this.battleCount);

		// 攻撃が終わるまでボタンを押せなくする
		this.enterButton.enabled = false;
		this.PlayerAttack();

		// 獲得経験値
		int getBattleExperience = this.stageExperience + this.levelNum;
		// Modelにセット
		this.userDataModel.userDataManager.experience = this.userDataModel.userDataManager.experience + getBattleExperience;

		if(this.userDataModel.userDataManager.experience >= this.nextExperience){
			this.userDataModel.userDataManager.level++;
			this.userDataModel.userDataManager.experience = this.userDataModel.userDataManager.experience - this.nextExperience;
		}

		this.userDataText[1].text = string.Format("Level : {0}" , this.userDataModel.userDataManager.level);
		this.userDataText[2].text = string.Format("Experience : {0}" , this.userDataModel.userDataManager.experience);

		if(this.battleCount == 3){
			this.battleCount = 0;
			StartCoroutine ("EndBattle");

			return;	
		}
	}


	private void PlayerAttack(){
		StartCoroutine ("PlayerAttackStart");

	}

	private IEnumerator PlayerAttackStart() {
		yield return new WaitForSeconds (0.5f);
		this.bossManager.DamageMove();
		yield return new WaitForSeconds (1.0f);
		this.enterButton.enabled = true;
	}

	private IEnumerator EndBattle() {
		this.mypageManager.isMypage = true;
		this.eventBattleManager.isBattle = true;
		yield return new WaitForSeconds (1.0f);
		SceneManager.LoadScene ("main");
	}


}
