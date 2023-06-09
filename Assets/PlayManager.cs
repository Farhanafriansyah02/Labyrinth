using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayManager : MonoBehaviour
{
    [SerializeField] GameObject finishedCanvas;
    [SerializeField] TMP_Text finishedText;
    
    int coin = 100;

    public void Finish() {
        finishedText.text = "You Win!\nScore: " + GetScore();
        finishedCanvas.SetActive(true);
    }

    private int GetScore(){
        return coin * 10;
    }
}
