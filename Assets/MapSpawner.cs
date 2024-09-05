using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSpawner : MonoBehaviour
{
    public GameObject[] blockPrefabs;
    public int mapWidth;
    public int mapHeight;
    public float blockSize;

    void Start()
    {
        GenerateMap();
    }

    void GenerateMap()
    {
        for (int x = 0; x < mapWidth; x++)
        {
            for (int y = 0; y < mapHeight; y++)
            {
                GameObject block = Instantiate(GetRandomBlock(), new Vector3(x * blockSize, y * blockSize, 0), Quaternion.identity);
                // Проверяем, чтобы не было 3 блоков одного типа подряд
                if (x > 1 && AreThreeBlocksOfSameTypeInRow(x, y, block))
                {
                    // Генерируем новый блок
                    Destroy(block);
                    block = Instantiate(GetRandomBlock(), new Vector3(x * blockSize, y * blockSize, 0), Quaternion.identity);
                }
            }
        }
    }

    GameObject GetRandomBlock()
    {
        return blockPrefabs[Random.Range(0, blockPrefabs.Length)];
    }

    bool AreThreeBlocksOfSameTypeInRow(int x, int y, GameObject block)
    {
        GameObject[] blocksInRow = new GameObject[3];

        if (x > 1)
        {
            blocksInRow[0] = GetBlockAtPosition(x - 2, y);
            blocksInRow[1] = GetBlockAtPosition(x - 1, y);
            blocksInRow[2] = block;
            if (blocksInRow[0].tag == blocksInRow[1].tag && blocksInRow[1].tag == blocksInRow[2].tag)
            {
                return true;
            }
        }
        return false;
    }

    GameObject GetBlockAtPosition(int x, int y)
    {
        RaycastHit2D hit = Physics2D.Raycast(new Vector2(x * blockSize, y * blockSize), Vector2.zero);
        return hit.collider.gameObject;
    }
}
