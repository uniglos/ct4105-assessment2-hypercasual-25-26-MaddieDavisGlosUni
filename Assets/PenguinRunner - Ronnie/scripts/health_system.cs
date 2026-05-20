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

            if (i < health){
                hearts[i].enabled = true;
            }else {
                hearts[i].enabled = false;
            }
        }
    }

    public void TakeDamage(GameObject hitObject){

        health = health - 1;

        Destroy(hitObject);
    }

    public void AddHealth(GameObject hitObject){
        if (health < numOfHearts) {
            health = health + 1;
        }
        Destroy(hitObject);
    }
}
