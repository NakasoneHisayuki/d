using UnityEngine;
using UnityEngine.UI;

public class Synchronizer : Photon.MonoBehaviour {
	
	private Text textRight;
	private Text textLeft;
	int aNum = 0;
	int bNum = 0;

//	void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info) {
//		if (stream.isWriting) {
//			//データの送信
//			stream.SendNext(transform.position);
//			stream.SendNext(transform.rotation);
//			stream.SendNext(rigidbody2D.velocity);
//		} else {
//			//データの受信
//			transform.position = (Vector3)stream.ReceiveNext();
//			transform.rotation = (Quaternion)stream.ReceiveNext();
//			rigidbody2D.velocity = (Vector2)stream.ReceiveNext();
//		}
//	}


	void OnPhotonText(){
		

	}



	public void OnClick2(){


	}



	public void OnClick3(){
		Debug.Log("3");
	}
}
