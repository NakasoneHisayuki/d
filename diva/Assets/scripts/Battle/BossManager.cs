using UnityEngine;
using System.Collections;

public class BossManager : MonoBehaviour {

	private Animation bossImg;
	// Use this for initialization
	void Start () {
		this.bossImg = GameObject.Find("Boss_Image").gameObject.GetComponent<Animation>();
	}
	

	public void DamageMove(){
		this.bossImg.Play("Boss_damage");
	}
}
