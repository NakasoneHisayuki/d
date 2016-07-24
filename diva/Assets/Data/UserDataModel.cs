using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

[Serializable]
public class userData{
	public string userName;
	public int level;
	public float experience;

}
public class UserDataModel : MonoBehaviour {
	public userData userDataManager;
}
