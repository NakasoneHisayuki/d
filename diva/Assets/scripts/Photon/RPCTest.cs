using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RPCTest : Photon.MonoBehaviour {

//	[PunRPC]
//	void SendMessageTest(string message) {
//		// 取得したメッセージを格納.
//		GameObject photonG = GameObject.Find("PvPBattlePlayer");
//		if (photonG == null) return;
//		PhotonCloudRPCTest script = photonG.GetComponent<PhotonCloudRPCTest>();
//		if (script == null) return;
//		script.messageText = message;
//	}

	[PunRPC]
	void SendMessageRightTest(string message) {
		// 取得したメッセージを格納.
		GameObject photonG = GameObject.Find("PvPBattlePlayer");
		if (photonG == null) return;
		PhotonCloudRPCTest script = photonG.GetComponent<PhotonCloudRPCTest>();
		if (script == null) return;
		script.messageRightText = message;
	}

	[PunRPC]
	void SendMessageLeftTest(string message) {
		// 取得したメッセージを格納.
		GameObject photonG = GameObject.Find("PvPBattlePlayer(Clone)");
		if (photonG == null) return;
		PhotonCloudRPCTest script = photonG.GetComponent<PhotonCloudRPCTest>();
		if (script == null) return;
		script.messageLeftText = message;
	}
}