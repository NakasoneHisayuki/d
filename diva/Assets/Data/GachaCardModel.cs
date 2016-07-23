using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

[Serializable]
public class GachaCardMaster{

	public string cardName;
	public string rarerty;

}
public class GachaCardModel : ScriptableObject {
	public List<GachaCardMaster> gachaCardModelList;

	public void setCardData(){
		int num = 100;
		for (int i = 0; i < num; i ++){
			if(i <= 4){
				int n = 1 + i;
				this.gachaCardModelList[i].cardName = "card_" + n.ToString();
				this.gachaCardModelList[i].rarerty = "SSR";
			}
			if(i >= 5 && i <= 9){
				int n = 1 + i;
				this.gachaCardModelList[i].cardName = "card_" + n.ToString();
				this.gachaCardModelList[i].rarerty = "SR";
			}
			if(i >= 10){
				int n = 1 + i;
				this.gachaCardModelList[i].cardName = "card_" + n.ToString();
				this.gachaCardModelList[i].rarerty = "R";
			}

		}
	}
}


