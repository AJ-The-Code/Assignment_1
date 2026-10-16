using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;
using System.Linq;
public class PlayerController : MonoBehaviour
{
    //private bool timerRunning = false;
   // private float timer = 0f;
    public GameObject red;
    public GameObject blue;
    public GameObject black;
    public GameObject orange;
    public GameObject brown;
    public GameObject purple;
    public GameObject yellow;
    public List<float> colors;
    private float max_col = colors.Max();

    // Start is called before the first frame update
    void Start()
    {
        int rand_y = Random.Range(0, 100);
        transform.position = new Vector3(0, rand_y, 0);
        blue = GameObject.Find("Blue");
        float bluePos = blue.transform.position.y;
        red = GameObject.Find("Red");
        float redPos = red.transform.position.y;
        black = GameObject.Find("Black");
        float blackPos = black.transform.position.y;
        orange = GameObject.Find("Orange");
        float orangePos = orange.transform.position.y;
        brown = GameObject.Find("Brown");
        float brownPos = brown.transform.position.y;
        purple = GameObject.Find("Purple");
        float purplePos = purple.transform.position.y;
        yellow = GameObject.Find("Yellow");
        float yellowPos = yellow.transform.position.y;
        colors = new List<float> { bluePos, redPos, orangePos, blackPos, brownPos, purplePos, yellowPos };

    }

    private void OnDestroy()
    {

        colors.Remove(transform.position.y); //Put this method on posistion, then call results back here.

    }

    // Update is called once per frame
    void Update()
    {
        while (true)  //Loops through max y's to see if green is max. If it is good.
        {
            float max = colors.Max();
            if (gameObject.transform.position.y < max)
            {
                Debug.Log(colors.Max());
            }

            if (gameObject.transform.position.y > max && Input.GetKeyDown(KeyCode.Space)) //Highest pos and space pressed
            {
                Debug.Log("Congragulations, You Won!");
                
                break;

            }
            else if (gameObject.transform.position.y < max && Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Nice Try, Better Luck Next Time!");
                
                break;
            }



        }
    }
}