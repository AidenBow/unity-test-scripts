using UnityEngine;
using System.Collections;

public class FirstScript : MonoBehaviour
{

    public float speed = 0.01f;
    public Color[] colors = new Color[] {new Color(0, 0, 1, 1), new Color(0, 1, 1, 1), new Color(1, 0, 1, 1)};
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        print("console is running");
        colors[0] = new Color(255, 0, 0, 1);
    }

    // Update is called once per FRAME 
    void Update()
    {
            transform.Translate(speed, 0, 0);
            ChangeColor();
            StartCoroutine("wait");
    }

    void ChangeColor() {
        if (counter < 2){
            counter = counter + 1;
        } else {
            counter = 0;
        };
        
        gameObject.GetComponent<Renderer>().material.color = colors[counter];
       

        
    }

    IEnumerator wait(){
        yield return new WaitForSeconds(1);
    }
}
