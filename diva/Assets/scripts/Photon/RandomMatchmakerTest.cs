using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RandomMatchmakerTest : Photon.PunBehaviour {

	public PvPBattlePlayer pvPBattlePlayer;
	public PvPCharaManager pvPCharaManager;
	private PhotonView myPhotonView;
	private GameObject staugeObj;
	public GameObject rightCharaContent;
	public GameObject leftCharaContent;
	public Text name1;
	public Text name2;
	public int testInt1;
	public int testInt2;

	private string setName = "";

	// Use this for initialization
	public void Start()
	{

		PhotonNetwork.ConnectUsingSettings("0.1");
		if (string.IsNullOrEmpty(PhotonNetwork.playerName))
		{
			PhotonNetwork.playerName = "guest" + Random.Range(1, 99999);
			setName = PhotonNetwork.playerName;
		}
	}


	public override void OnJoinedLobby()
	{
		Debug.Log("JoinRandom");
		PhotonNetwork.JoinRandomRoom();
	}

	public override void OnConnectedToMaster()
	{
		// when AutoJoinLobby is off, this method gets called when PUN finished the connection (instead of OnJoinedLobby())
		PhotonNetwork.JoinRandomRoom();
	}

	public void OnPhotonRandomJoinFailed()
	{
		PhotonNetwork.CreateRoom(null);
	}

	public override void OnJoinedRoom()
	{

		if(pvPBattlePlayer == null)return;
		pvPBattlePlayer.pvpUserData[0].playerId = 0;
		pvPBattlePlayer.pvpUserData[0].userName = "";

		pvPBattlePlayer.pvpUserData[1].playerId = 0;
		pvPBattlePlayer.pvpUserData[1].userName = "";

		GameObject player = PhotonNetwork.Instantiate("PvPBattlePlayer", Vector3.zero, Quaternion.identity, 0);
		player.transform.name = "PvPBattlePlayer";
		myPhotonView = player.GetComponent<PhotonView>();
		name1.text = setName;

		staugeObj = GameObject.Find("Stauge").gameObject;
		player.transform.parent = staugeObj.gameObject.transform;
		rightCharaContent.transform.parent = player.gameObject.transform;

		pvPBattlePlayer.pvpUserData[0].playerId = PhotonNetwork.player.ID;
		pvPBattlePlayer.pvpUserData[0].userName = setName;

//		rightCharaContent.SetActive(true);
//		pvPCharaManager.RightChara();



	}

//	public void OnGUI()
//	{
//		GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
//
//		if (PhotonNetwork.inRoom)
//		{
//			bool shoutMarco = GameLogic.playerWhoIsIt == PhotonNetwork.player.ID;
//
//			if (shoutMarco && GUILayout.Button("Marco!"))
//			{
//				myPhotonView.RPC("Marco", PhotonTargets.All);
//			}
//			if (!shoutMarco && GUILayout.Button("Polo!"))
//			{
//				myPhotonView.RPC("Polo", PhotonTargets.All);
//			}
//		}
//	}
}
