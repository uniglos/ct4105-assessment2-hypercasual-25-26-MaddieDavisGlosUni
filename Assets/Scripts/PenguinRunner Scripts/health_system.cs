using UnityEngine;
using UnityEngine.UI;

public class health_system : MonoBehaviour{

    public int health;
    public int numOfHearts;

    public Image[] hearts;

    void Update(){

        if(health > numOfHearts){
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++) {

            if (i < numOfHearts){
                hearts[i].enabled = true;
            }else {
                hearts[i].enabled = false;
            }
        }
    }

    public void SubtractHearts(){

        health--;
    }
}
