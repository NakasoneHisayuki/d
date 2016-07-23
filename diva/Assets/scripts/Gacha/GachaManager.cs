using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class GachaManager : MonoBehaviour {

	public GachaModel gachaModel;
	public GachaCardModel gachaCardModel;
	public ResultGachaData resultGachaData;
	public GameObject gachaContent;
	public GameObject gachaBnrContent;
	public GameObject gachaResultContent;
	public Text[] resultText;

	int num10 = 10;

	public void OnClickGachaReturnButton(){
		StartCoroutine ("ReturnGachaBnrContent");
	}

	public void OnClickGachaOkButton(){
		StartCoroutine ("startGacha");

	}

	public void OnClickGachaResultReturnButton(){
		StartCoroutine ("ReturnGachaContent");

	}

	private IEnumerator ReturnGachaBnrContent() {
		iTween.MoveTo(this.gachaContent, iTween.Hash("x", 870.0f, "time", 0.5));

		yield return new WaitForSeconds (0.5f); 
		iTween.MoveTo(this.gachaBnrContent, iTween.Hash("x", 0.0f, "time", 0.5));
	}

	private IEnumerator ReturnGachaContent() {
		iTween.MoveTo(this.gachaResultContent, iTween.Hash("x", 870.0f, "time", 0.5));

		yield return new WaitForSeconds (0.5f); 
		iTween.MoveTo(this.gachaContent, iTween.Hash("x", 0.0f, "time", 0.5));
	}

	private IEnumerator startGacha() {
		this.gachaModel.isGacha = true;
		this.GachaLogic();
		this.setResultGachaName();

		iTween.MoveTo(this.gachaContent, iTween.Hash("x", 870.0f, "time", 0.5));

		yield return new WaitForSeconds (1.0f); 
		iTween.MoveTo(this.gachaResultContent, iTween.Hash("x", 0.0f, "time", 0.5));
		this.gachaModel.isGacha = false;
	}

	private void setResultGachaName(){

		for(int i = 0; i < this.num10; i ++){
			this.resultText[i].text = this.resultGachaData.resultGachaDataList[i].gachaName;
		}
	}

	private void GachaLogic(){

		// SSR
		int ssrNum = 100 * (int)this.gachaModel.unitModelList[0].probability;
		// SR
		int srNum = 100 * (int)this.gachaModel.unitModelList[1].probability;
		// R
		int rNum = 100 * (int)this.gachaModel.unitModelList[2].probability;
		int maxNum = ssrNum + srNum + rNum;
//		Debug.Log(maxNum);
		// ModelにCardName Rarertyセット
//		this.gachaCardModel.setCardData();

		// 10連ガチャ結果をmodelにセット
		for(int i = 0; i < this.num10; i ++){
			int iRandNum = UnityEngine.Random.Range(0, 100);
			string name = this.gachaCardModel.gachaCardModelList[iRandNum].cardName + "_" + this.gachaCardModel.gachaCardModelList[iRandNum].rarerty;

			this.resultGachaData.resultGachaDataList[i].gachaName = name;
		}

	}
}
