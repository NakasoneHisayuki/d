
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

[Serializable]
public class ResultGachaDataManager{

	public String gachaName;

}
public class ResultGachaData : ScriptableObject {
	public List<ResultGachaDataManager> resultGachaDataList;
}
