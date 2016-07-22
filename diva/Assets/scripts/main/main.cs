using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class main : MonoBehaviour
{

    public Image topImage;
    public Button startButton;

    public GameObject[] globalNavi;
    bool is_global_move = false;

    void Awake()
    {
        //        globalNavi[0].transform.localPosition = new Vector2(0, 115.0f);
        //       globalNavi[1].transform.localPosition = new Vector2(-115.0f, 0);
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (is_global_move)
        {
            globalMove();
            is_global_move = false;
        }
    }

    public void globalMove()
    {

        if (globalNavi[1].transform.localPosition.x >= 0.0f)
        {
            iTween.Stop(globalNavi[1]);
            globalNavi[1].transform.localPosition = new Vector2(0, 0);
            //is_global_move = false;
        }
        else
        {
            iTween.MoveTo(globalNavi[1], iTween.Hash("x", 0.0f, "time", 20));
        }
    }

    public void OnClickStartButton()
    {

        topImage.gameObject.SetActive(false);
        startButton.gameObject.SetActive(false);
        is_global_move = true;
    }

}
