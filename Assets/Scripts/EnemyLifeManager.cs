using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro; 
public class EnemyLifeManager : MonoBehaviour
{

    [SerializeField]List<GameObject> enemies;
    [SerializeField] TextMeshProUGUI scoreText; 
    private int ennemiesHit = 0; 
    void Start()
    {
        foreach(var enemy in enemies)
        {
            enemy.GetComponent<BulletHit>().whenHitWithBullet = whenHitWithBullet; 
        }
        
    }

    private void whenHitWithBullet(GameObject go)
    {

        go.SetActive(false);
        ennemiesHit++;
        updateScoreTextGUI(); 
    }

    private void updateScoreTextGUI()
    {
        scoreText.text = "";
        for (int i = 0; i < ennemiesHit; i++)
            scoreText.text += "* "; 
    }

    public void replay()
    {
        ennemiesHit = 0;
        foreach (var enemy in enemies)
        {
            enemy.SetActive(true);
        }
        updateScoreTextGUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
