using UnityEngine;
using UnityEngine.UI;

public class datos : MonoBehaviour
{
    public int liderazgo = 10;
    public int recursos = 100;

    public bool eventoLiderazgo1= false;

    public Text d1;
    public Text d2;

    // Use this for initialization
    void Start(){
        this.UpdateD1();
        this.UpdateD2();

    }

    // Update is called once per frame
    void Update(){
        if (eventoLiderazgo1 == true){
            this.liderazgo--;
            this.recursos+=10;
            this.UpdateD1();
            this.UpdateD2();
            eventoLiderazgo1 = false;
        }
    }

    void UpdateD1(){
        this.d1.text = "Liderazgo: " + this.liderazgo;
    }

    void UpdateD2(){
        this.d2.text = "Recursos: " + this.recursos;
    }
}
