using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class main : MonoBehaviour{

    public Image topImage;
    public Button startButton;

    public GameObject[] globalNavi;
	public Animation mainContent;
	bool is_global_move = false;

    void Awake(){
    }

    // Use this for initialization
    void Start(){

    }

    // Update is called once per frame
    void Update(){

        if (is_global_move){
            globalMove();
            is_global_move = false;
        }
    }

    public void globalMove(){

		iTween.MoveTo(globalNavi[0], iTween.Hash("y", 0.0f, "time", 0.5));
		iTween.MoveTo(globalNavi[1], iTween.Hash("x", 0.0f, "time", 0.5));
    }

    public void OnClickStartButton(){

        topImage.gameObject.SetActive(false);
        startButton.gameObject.SetActive(false);
		mainContent.Play();
        is_global_move = true;
    }

}
