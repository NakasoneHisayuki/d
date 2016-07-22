using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class main : MonoBehaviour {

    public Image topImage;
    public Button startButton;

    void Awake() {
    
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnClickStartButton()
    {

        topImage.gameObject.SetActive(false);
        startButton.gameObject.SetActive(false);
    }

}
