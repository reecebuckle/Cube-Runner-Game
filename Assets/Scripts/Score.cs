using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Transform player;
	public Text scoreText;
	
	// Update is called once per frame
	void Update () {
        //-498 is offset in z direction
		scoreText.text = (player.position.z + 498).ToString("0");
	}
}