using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PhotonCloudRPCTest : Photon.MonoBehaviour {
	private GameObject m_photonViewObj;
	private PhotonView m_photonView = null;
	public string messageRightText = "";
	public string messageLeftText = "";
	public PvPBattlePlayer pvPBattlePlayer;
	private Text textRight;
	private Text textLeft;
	int aNum = 0;
	int bNum = 0;
	bool isRightMessage = false;
	bool isLeftMessage = false;

	void Start(){

		textRight = GameObject.Find("Right_Text").GetComponent<Text>();
		textLeft = GameObject.Find("Left_Text").GetComponent<Text>();
	}

	void Update(){
		if(messageRightText != ""){
			textRight.text = messageRightText;
		}
		if(messageLeftText != ""){
			textLeft.text = messageLeftText;
		}

	}




	public void OnClick1(){

		int otherPlayers = PhotonNetwork.otherPlayers.Length;
		if(otherPlayers == 0)return;
		GameObject cloneObj = GameObject.Find("PvPBattlePlayer(Clone)").gameObject;
		GameObject staugeObj = GameObject.Find("Stauge").gameObject;
		staugeObj = GameObject.Find("Stauge").gameObject;
		cloneObj.transform.parent = staugeObj.gameObject.transform;

		GameObject leftCharaContent = GameObject.Find("Left_Pleyer").gameObject;;
		leftCharaContent.transform.parent = cloneObj.gameObject.transform;


		Text name2 = GameObject.Find("OpponentUserName").GetComponent<Text>();


		name2.text = PhotonNetwork.otherPlayers[0].name;
		int otherPlayersId = PhotonNetwork.otherPlayers[0].ID;
		pvPBattlePlayer.pvpUserData[1].playerId = otherPlayersId;
		pvPBattlePlayer.pvpUserData[1].userName = PhotonNetwork.otherPlayers[0].name;
		//				pvPCharaManager.StartMoveChara();

	}

	public void OnClick2(){
		string text = "";
		if(m_photonViewObj == null){
			m_photonViewObj = GameObject.Find("PvPBattlePlayer");
		}

		if(m_photonView == null){
			m_photonView = m_photonViewObj.GetComponent<PhotonView>();
		}


		if(pvPBattlePlayer.pvpUserData[0].playerId == 1){
			
			aNum ++;
			text = string.Format("{0}",aNum);
			SendRPCRight(text);

		}else{
			bNum ++;
			text = string.Format("{0}",bNum);
			SendRPCLeft(text);
		}


	}

	private void SendRPCRight(string str) {
		Debug.Log(m_photonView);
		if (m_photonView != null) {
			Debug.Log("SendRPCRight");
			m_photonView.RPC("SendMessageRightTest", PhotonTargets.All, str);
		}
	}

	private void SendRPCLeft(string str) {
		if (m_photonView != null) {
			m_photonView.RPC("SendMessageLeftTest", PhotonTargets.All, str);
		}
	}
}