using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickController : MonoBehaviour
{
    public int numberOfHits = 0;
    public int maxHits;

    public SpriteRenderer brickSprite;
    public float brickValue;

    public GameMaster gameMaster;

    public int whichpowerup;
    public Transform powerupExtend;
    public Transform powerupSpeed;

    // Start is called before the first frame update
    void Start()
    {
        brickSprite = GetComponent<SpriteRenderer>();
        gameMaster.GetComponent<GameMaster>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        numberOfHits++;
        brickSprite.color = Color.magenta;
        if(numberOfHits >= maxHits)
        {
            gameMaster.playerPoints = gameMaster.playerPoints + brickValue;
            Destroy(this.gameObject);
        }

        whichpowerup = Random.Range(1, 10);

        if (whichpowerup == 1)
        {
            Instantiate(powerupExtend, transform.position, powerupExtend.rotation);
        }

        if (whichpowerup == 2)
        {
            Instantiate(powerupSpeed, transform.position, powerupSpeed.rotation);
        }
    }
}
