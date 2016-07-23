using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class main : MonoBehaviour{

	public GameObject topContent;
	public GameObject mainContent;
    public GameObject[] globalNavi;

	private Animation mainAnimation;

	bool is_global_move = false;

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

        if (this.is_global_move){
            globalMove();
			this.is_global_move = false;
        }
    }

    public void globalMove(){

		iTween.MoveTo(this.globalNavi[0], iTween.Hash("y", 0.0f, "time", 0.5));
		iTween.MoveTo(this.globalNavi[1], iTween.Hash("x", 0.0f, "time", 0.5));
    }

    public void OnClickStartButton(){
		this.topContent.SetActive(false);
		this.mainAnimation.Play();
		this.is_global_move = true;
    }

}
