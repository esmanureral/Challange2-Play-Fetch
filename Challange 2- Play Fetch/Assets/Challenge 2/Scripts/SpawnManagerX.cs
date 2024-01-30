using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;//yumurtalama sol sınır
    private float spawnLimitXRight = 7;// yumurtlama sağ sınır
    private float spawnPosY = 30;

    private float startDelay = 1.0f;//gecikme
    private float spawnInterval = 2.0f;//yumurtlama aralığı

    
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
        //InvokeRepeating:belirli bir metodu belirli bir süre aralığında tekrarlı bir şekilde çağırmak 
    }

    //rastgele top oluşturma
    void SpawnRandomBall ()
    {
        //rastgele topları rastgele yerlerde oluşturmak

        int ballIndex = Random.Range(0, ballPrefabs.Length);
        //yukarıdaki satır 3 toptan hangisi atılacağını seçer.


        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        //yukarıdaki satır seçilen topun hangi konuma düşeceğini belirler.

        // topu rastgele ortaya çıkma konumunda başlat
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
        //Instantiate:belirli bir prefab'ın kopyasını belirli bir konum ve rotasyonda sahneye eklemek için kullanılır.
    }

}
