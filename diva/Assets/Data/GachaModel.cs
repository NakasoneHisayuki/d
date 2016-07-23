using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

[Serializable]
public class GachaMaster{

	public float probability;

}
public class GachaModel : ScriptableObject {
	public bool isGacha = false;
	public List<GachaMaster> unitModelList;
}

