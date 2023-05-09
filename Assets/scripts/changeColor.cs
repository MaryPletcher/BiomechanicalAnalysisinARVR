using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class changeColor : MonoBehaviour
{

    [SerializeField] private RawImage image; 

    //[SerializeField] private GameObject testInput; 

    private float l5s1RF;
    private string currentRF;



    // Start is called before the first frame update
    void Start()
    {
        l5s1RF = 2400;
        //noramlize l5s1RF
        image.GetComponent<RawImage>().color = new Color32(100,245,66,100);
        
    }

    // Update is called once per frame
    void Update()
    {
        //currentRF = testInput.GetComponent<TextMeshPro-InputField>().text;
        getColor(l5s1RF);
    }

    public void updateColor() {
        //image.color = Color;
    }

    //uses HSB to evenly go from green to yellow to orange to red conriniously 
    public void getColor(float l5s1RF) {
        //l5s1RF = l5s1RF/2400;
        float H = (1-(l5s1RF/3400))*.4f; //Hue (.4 is green)
        float S = .9f; // saturation
        float B = .9f; // brightness 
        Color newColor =  Color.HSVToRGB(H,S,B);
        image.GetComponent<RawImage>().color = Color.HSVToRGB(H,S,B);

    }

    public void getSize(float l5s1RF) {

        float currSize = 125 + (l5s1RF/3400)*75.00f;
        GetComponent<RectTransform>().image = new Vector2(currSize, currSize);
    }

    public void normalizeL5s1RF(float l5s1RF) {
      
    }



    
}
