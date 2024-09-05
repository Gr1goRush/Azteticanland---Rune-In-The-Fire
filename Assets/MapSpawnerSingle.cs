using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSpawnerSingle : MonoBehaviour
{
    public Transform[] SpawnPositions;
    public GameObject PurpleBlock;
    public GameObject BlueBlock;
    public GameObject GreenBlock;
    public GameObject YellowBlock;
    public GameObject MagicBlock;
    public bool isExited;
    public int Randomizer;

    public void Start()
    {
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[0].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[0].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[0].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[0].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[0].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[1].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[1].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[1].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[1].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[1].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[2].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[2].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[2].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[2].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[2].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[3].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[3].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[3].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[3].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[3].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[4].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[4].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[4].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[4].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[4].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[5].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[5].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[5].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[5].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[5].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[6].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[6].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[6].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[6].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[6].position, Quaternion.identity);
        }
        Instantiate(MagicBlock, SpawnPositions[7].position, Quaternion.identity);
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[8].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[8].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[8].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[8].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[8].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[9].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[9].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[9].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[9].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[9].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[10].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[10].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[10].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[10].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[10].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[11].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[11].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[11].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[11].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[11].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[12].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[12].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[12].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[12].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[12].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[13].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[13].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[13].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[13].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[13].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[14].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[14].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[14].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[14].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[14].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[15].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[15].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[15].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[15].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[15].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[16].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[16].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[16].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[16].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[16].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[17].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[17].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[17].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[17].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[17].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[18].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[18].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[18].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[18].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[18].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[19].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[19].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[19].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[19].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[19].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[20].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[20].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[20].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[20].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[20].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[21].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[21].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[21].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[21].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[21].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[22].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[22].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[22].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[22].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[22].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[23].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[23].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[23].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[23].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[23].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[24].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[24].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[24].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[24].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[24].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[25].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[25].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[25].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[25].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[25].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[26].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[26].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[26].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[26].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[26].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[27].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[27].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[27].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[27].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[27].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[28].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[28].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[28].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[28].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[28].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[29].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[29].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[29].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[29].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[29].position, Quaternion.identity);
        }
    }

    public void OnTriggerEnter2D(Collider2D coll)
    {
        isExited = true;
    }

    public void OnTriggerExit2D(Collider2D coll)
    {
        if(isExited == true)
        {
            isExited = false;

            Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[0].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[0].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[0].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[0].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[0].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[1].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[1].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[1].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[1].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[1].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[2].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[2].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[2].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[2].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[2].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[3].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[3].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[3].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[3].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[3].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[4].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[4].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[4].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[4].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[4].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[5].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[5].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[5].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[5].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[5].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[6].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[6].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[6].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[6].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[6].position, Quaternion.identity);
        }
        Instantiate(MagicBlock, SpawnPositions[7].position, Quaternion.identity);
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[8].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[8].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[8].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[8].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[8].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[9].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[9].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[9].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[9].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[9].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[10].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[10].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[10].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[10].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[10].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[11].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[11].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[11].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[11].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[11].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[12].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[12].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[12].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[12].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[12].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[13].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[13].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[13].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[13].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[13].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[14].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[14].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[14].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[14].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[14].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[15].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[15].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[15].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[15].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[15].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[16].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[16].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[16].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[16].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[16].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[17].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[17].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[17].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[17].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[17].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[18].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[18].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[18].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[18].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[18].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[19].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[19].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[19].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[19].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[19].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[20].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[20].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[20].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[20].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[20].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[21].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[21].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[21].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[21].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[21].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[22].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[22].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[22].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[22].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[22].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[23].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[23].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[23].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[23].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[23].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[24].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[24].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[24].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[24].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[24].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[25].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[25].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[25].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[25].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[25].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[26].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[26].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[26].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[26].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[26].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[27].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[27].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[27].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[27].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[27].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[28].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[28].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[28].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[28].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[28].position, Quaternion.identity);
        }
        Randomizer = Random.Range(1, 5);
        if (Randomizer == 1)
        {
            Instantiate(PurpleBlock, SpawnPositions[29].position, Quaternion.identity);
        }
        if (Randomizer == 2)
        {
            Instantiate(BlueBlock, SpawnPositions[29].position, Quaternion.identity);
        }
        if (Randomizer == 3)
        {
            Instantiate(GreenBlock, SpawnPositions[29].position, Quaternion.identity);
        }
        if (Randomizer == 4)
        {
            Instantiate(YellowBlock, SpawnPositions[29].position, Quaternion.identity);
        }
        if (Randomizer == 5)
        {
            Instantiate(YellowBlock, SpawnPositions[29].position, Quaternion.identity);
        }
        }
    }
}
