using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Position : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int rand_y = Random.Range(0, 100);
        transform.position = new Vector3(0, rand_y, 0);
        StartCoroutine(DestroyTarget());
    }

    // Update is called once per frame
    void Update()
    {
    }
    IEnumerator DestroyTarget()
    {
        int randTime = Random.Range(1, 10); //Time it takes for platform to disapear
        Vector3 green_win = Vector3.up;
        while (true) //Something with the camera going to green
        {
            UnityEngine.WaitForSeconds wait = new WaitForSeconds(randTime);
            yield return wait; 
            { Destroy(gameObject);} //Destorys Object after wait
        }
    }
}
