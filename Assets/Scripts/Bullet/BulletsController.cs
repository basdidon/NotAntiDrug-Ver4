using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BulletsController : MonoBehaviour
{
    public static BulletsController instance;

    public static int bullet01_qty;
    public static int bullet02_qty;
    public static int bullet03_qty;
    public static int bullet04_qty;

    public Sprite[] sprites;
    public GameObject[] bulletsPrefab;
    public List<Bullets> bullets = new List<Bullets>();

    [Header("Bullet")]
    public Bullets antiDepressants;
    public Bullets antiHallucinogens;
    public Bullets antiStimulants;
    public Bullets antiMultipleEffect;

    void Start()
    {
        instance = this;
        
        antiDepressants = new Bullets(Bullets.BulletsType.antiDepressants, "ประเภทกดประสาท", 50, 5, "Depressants", sprites[0], bulletsPrefab[0]);
        antiStimulants = new Bullets(Bullets.BulletsType.antiStimulants, "ประเภทกระตุ้นประสาท", 50, 5, "", sprites[1], bulletsPrefab[1]);
        antiHallucinogens = new Bullets(Bullets.BulletsType.antiHallucinogens, "ประเภทหลอนประสาท", 50, 5, "Hallucinogens", sprites[2], bulletsPrefab[2]);
        antiMultipleEffect = new Bullets(Bullets.BulletsType.antiMultipleEffect, "ประเภทออกฤทษ์ผสมผสาน", 50, 5, "", sprites[3], bulletsPrefab[3]);
        
        if (LevelManager.instance.currentLv == 1)
        {
            bullets.Add(antiDepressants);
            if (LevelManager.isLoadGameSave)
            {
                bullets[0].currentBullets = bullet01_qty;
            }
        }
        if (LevelManager.instance.currentLv == 2)
        {
            bullets.Add(antiDepressants);
            bullets.Add(antiStimulants);
        }
        if (LevelManager.instance.currentLv == 3)
        {
            bullets.Add(antiDepressants);
            bullets.Add(antiStimulants);
            bullets.Add(antiHallucinogens);
            bullets.Add(antiMultipleEffect);
        }
    }
}