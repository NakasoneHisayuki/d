using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class QuestManager : MonoBehaviour {
	
	public GameObject mainContent;
	public GameObject questContent;
	public MypageManager mypageManager;

	Animation animationMainContent;

	void Start(){
		this.animationMainContent = this.mainContent.GetComponent<Animation>();
	}
	public void OnClickQuestStartButton(){
		StartCoroutine ("BattleStart");
	}

	public void OnClickReturnMypage(){
		StartCoroutine ("ReturnBotton");
	}

	private IEnumerator ReturnBotton() {
		iTween.MoveTo(this.questContent, iTween.Hash("x", 870.0f, "time", 0.5));
		yield return new WaitForSeconds (1.0f); 
		this.animationMainContent.Play("Mypage_Content_Up");
	}

	private IEnumerator BattleStart() {

		yield return new WaitForSeconds (1.0f); 
		SceneManager.LoadScene ("EventBattle");
	}
}
