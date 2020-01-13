using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    int score = 0; //スコアの変数を定義
    GameObject scoreText;

    void Start () {
        scoreText = GameObject.Find("ScoreText");
    }

    void Update () {
        
    }
    // 衝突時の関数
    void OnCollisionEnter(Collision collision) {
        string collisionTag = collision.gameObject.tag;
        int tempScore = score;
        switch(collisionTag){
            case "SmallStarTag":
                this.score += 5;
                break;
            case "LargeStarTag":
                this.score += 30;
                break;
            case "SmallCloudTag":
                this.score += 20;
                break;
            case "LargeCloudTag":
                this.score += 8000;
                break;
        }
        if(tempScore != score){
            scoreText.GetComponent<Text> ().text = "Score " + this.score;
        }
    }
}
