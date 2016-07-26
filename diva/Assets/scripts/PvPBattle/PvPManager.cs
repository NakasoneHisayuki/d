using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PvPManager : MonoBehaviour {

	public PvPBattlePlayer pvpBattlePlayer;
	public Text userName;
	bool isStartBattle = false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	private void SetPvPBattlePlayer(){
		
	}

	public void OnClickRegistration(){
//		int listCount = this.pvpBattlePlayer.pvpUserData.Count;
//
//		for(int i = 0; i < listCount; i ++){
//			if(this.pvpBattlePlayer.pvpUserData[i].playerId == 0){
//				this.pvpBattlePlayer.pvpUserData[i].playerId = i + 1;
//				this.pvpBattlePlayer.pvpUserData[i].userName = this.userName.text;
//				this.isStartBattle = true;
//				break;
//			}
//		}

	}

	public void OnClickPvPBattleStart(){
		SceneManager.LoadScene ("PvPBattle");
//		if(!this.isStartBattle)return;
	}
}
