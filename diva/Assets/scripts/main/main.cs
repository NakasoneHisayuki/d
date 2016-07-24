using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class main : MonoBehaviour{
	
	public EventBattleManager eventBattleManager;
	public MypageManager mypageManager;
	public UserDataModel userDataModel;
	public GameObject topContent;
	public GameObject mainContent;
	public GameObject questContent;
    public GameObject[] globalNavi;

	private Animation mainAnimation;

	float resetPositionX = 0.0f;
	float resetPositionY = 0.0f;

    void Awake(){

		this.globalNavi[0].transform.localPosition = new Vector2(this.resetPositionX,115.0f);
		this.globalNavi[1].transform.localPosition = new Vector2(-11.5f,this.resetPositionY);
		this.mainContent.transform.localScale = new Vector2(this.resetPositionX,this.resetPositionY);
		this.mainAnimation = this.mainContent.GetComponent<Animation>();
	}

    // Use this for initialization
    void Start(){

    }

    // Update is called once per frame
    void Update(){
		
		if(this.mypageManager.isMypage){
			if(this.eventBattleManager.isBattle){
				this.EndQuest();
			}

		}
	}
	void OnEnable(){

	}


	private void EndQuest(){

		this.topContent.SetActive(false);
		this.globalMove();
		iTween.MoveTo(this.questContent, iTween.Hash("x", 0.0f, "time", 0.5));
		this.eventBattleManager.isBattle = false;
	}
    public void OnClickStartButton(){
		this.topContent.SetActive(false);
		this.mainAnimation.Play();
		this.mypageManager.isMypage = true;
		this.globalMove();
    }

	public void globalMove(){

		iTween.MoveTo(this.globalNavi[0], iTween.Hash("y", 0.0f, "time", 0.5));
		iTween.MoveTo(this.globalNavi[1], iTween.Hash("x", 0.0f, "time", 0.5));
	}


}
