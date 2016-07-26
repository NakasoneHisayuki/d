using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

[Serializable]
public class PvPBattleUserData{
	public int playerId;
	public string userName;
	public bool isBattle = false;
	public int OpponentBattleId;
}


public class PvPBattlePlayer : MonoBehaviour {
	public List<PvPBattleUserData> pvpUserData;
}


