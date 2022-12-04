using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

using System;


public class WorldGeneration : MonoBehaviour
{
    public Tilemap grid;
    public Tile grass;
    public Transform player;
    public Transform enemy;
    // Start is called before the first frame update
    void Start()
    {
        int x0 = (int)Math.Ceiling(player.position.x);
        int y0 = (int)Math.Ceiling(player.position.y);

        for (int x = -7; x < 15; x++)
        {
            for (int y = -5; y < 10; y++)
            {
                grid.SetTile(new Vector3Int(x0 + x, y0 + y, 0), grass);
            }
        }


        InvokeRepeating("SpawnEnemy", 1f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        int x0 = (int)Math.Ceiling(player.position.x);
        int y0 = (int)Math.Ceiling(player.position.y);

        for (int x = -7; x < 15; x++)
        {
            for (int y = -5; y < 10; y++)
            {
                grid.SetTile(new Vector3Int(x0 + x, y0 + y, 0), grass);
            }
        }

    }

    void SpawnEnemy()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            Instantiate(enemy, new Vector3(player.position.x + 5, player.position.y + 1), Quaternion.identity);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            Instantiate(enemy, new Vector3(player.position.x - 5, player.position.y - 1), Quaternion.identity);
        }
        else if (Input.GetAxis("Vertical") > 0)
        {
            Instantiate(enemy, new Vector3(player.position.x + 1, player.position.y + 5), Quaternion.identity);
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            Instantiate(enemy, new Vector3(player.position.x - 1, player.position.y - 5), Quaternion.identity);
        }


    }
}