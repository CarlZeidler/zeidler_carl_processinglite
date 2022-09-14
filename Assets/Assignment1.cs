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


        ////shapes
        //Stroke(0, 0, 0);

        //Fill(255, 165, 0);
        //Triangle(0, 0, 1, 1, 2, 0);

        //Fill(255, 165, 0);
        //Triangle(2, 0, 3, 1, 4, 0);


        //Parabolic loop



        ////First quadrant
        //Line(1, 1, 1, 9);
        //Line(1, 2, 2, 9);
        //Line(1, 3, 3, 9);
        //Line(1, 4, 4, 9);
        //Line(1, 5, 5, 9);
        //Line(1, 6, 6, 9);
        //Line(1, 7, 7, 9);
        //Line(1, 8, 8, 9);
        //Line(1, 9, 9, 9);

        ////Second quadrant
        //Line(1, 9, 9, 9);
        //Line(2, 9, 9, 8);
        //Line(3, 9, 9, 7);
        //Line(4, 9, 9, 6);
        //Line(5, 9, 9, 5);
        //Line(6, 9, 9, 4);
        //Line(7, 9, 9, 3);
        //Line(8, 9, 9, 2);
        //Line(9, 9, 9, 1);

        ////Third quadrant
        //Line(9, 9, 9, 1);
        //Line(9, 8, 8, 1);
        //Line(9, 7, 7, 1);
        //Line(9, 6, 6, 1);
        //Line(9, 5, 5, 1);
        //Line(9, 4, 4, 1);
        //Line(9, 3, 3, 1);
        //Line(9, 2, 2, 1);
        //Line(9, 1, 1, 1);

        ////Fourth quadrant
        //Line(9, 1, 1, 1);
        //Line(8, 1, 1, 2);
        //Line(7, 1, 1, 3);
        //Line(6, 1, 1, 4);
        //Line(5, 1, 1, 5);
        //Line(4, 1, 1, 6);
        //Line(3, 1, 1, 7);
        //Line(2, 1, 1, 8);
        //Line(1, 1, 1, 9);

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