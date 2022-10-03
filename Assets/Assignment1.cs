using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment1 : ProcessingLite.GP21
{
    //public float lineSize = 0.5f;


    // Start is called before the first frame update
    void Start()
    {

        Background(105, 105, 105);

        //StrokeWeight(0.5f);
        //Stroke(230, 0, 0, 85);

        //2. Namn

        ////E
        //Line(1, 3, 3, 3);
        //Line(1, 3, 1, 7);
        //Line(1, 7, 3, 7);
        //Line(1, 5, 2, 5);

        ////l
        //Line(4, 3, 4, 7);

        ////i
        //Line(5, 3, 5, 5);
        //Line(5, 6, 5, 6.5f);

        ////y
        //Line(5.5f, 5, 7, 3);
        //Line(8, 5, 6, 2);

        ////t
        //Line(9, 3, 9, 7);
        //Line(8.2f, 5.5f, 9.8f, 5.5f);

        ////r
        //Line(10.5f, 3, 10.5f, 5.5f);
        //Line(10.5f, 4.3f, 11.3f, 5.5f);
        //Line(11.3f, 5.5f, 12.4f, 4.3f);

        ////e
        //Line(13, 4.3f, 15, 4.3f);
        //Line(15, 4.3f, 14, 5.5f);
        //Line(14, 5.5f, 13, 4.3f);
        //Line(13, 4.3f, 14, 3);
        //Line(14, 3, 14.5f, 3.5f);

        ////s
        //Line(17.5f, 5, 16.5f, 5.5f);
        //Line(16.5f, 5.5f, 15.5f, 5);
        //Line(15.5f, 5, 17.5f, 3.5f);
        //Line(17.5f, 3.5f, 16.5f, 3);
        //Line(16.5f, 3, 15.5f, 3.5f);


        ////3. Abstract shapes
        //Stroke(0, 0, 0);

        //Fill(Random.Range(0, 256), Random.Range(0, 256), Random.Range(0, 256));
        //Triangle(0, 0, 1, 1, 2, 0);

        //Fill(Random.Range(0, 256), Random.Range(0, 256), Random.Range(0, 256));
        //Rect(2, 3, 3, 1);

        //Fill(Random.Range(0, 256), Random.Range(0, 256), Random.Range(0, 256));
        //Circle(4, 1.2f, 1.5f);

        //Fill(Random.Range(0, 256), Random.Range(0, 256), Random.Range(0, 256));
        //Square(9, 5, 0.5f);

        //4. & 5. Parabolic loop
        float x1 = 1f;
        float y1 = 1f;
        float x2 = 1f;
        float y2 = 9f;

        StrokeWeight(0.2f);

        for (int i = 0; i < 33; i++)
        {
            if (i % 3 == 0)
            {
                Stroke(Random.Range(0, 256), Random.Range(0, 256), Random.Range(0, 256));
            }
            else
            {
                Stroke(255);
            }


            if (i < 8)
            {
                Line(x1, y1, x2, y2);
                y1++;
                x2++;
            }
            else if (i < 16)
            {
                Line(x1, y1, x2, y2);
                x1++;
                y2--;
            }
            else if (i < 24)
            {
                Line(x1, y1, x2, y2);
                y1--;
                x2--;
            }
            else if (i < 33)
            {
                Line(x1, y1, x2, y2);
                x1--;
                y2++;
            }


        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}