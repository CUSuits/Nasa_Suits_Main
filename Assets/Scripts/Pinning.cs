using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace HoloToolkit.Unity.InputModule
{
    public class Pinning : MonoBehaviour
    {
        public float moveSpeed = 10f;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //left, right, up, down, back, forward, stop
            //determine whether its ego or exo or the third option
            // visible and invisible
        }
        public void Left()
        {
            
        }
        public void Right()
        {

        }
        public void Up()
        {
            transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        }
        public void Down()
        {
            
        }
        public void Stop()
        {

        }
        public void Forward()
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
    }
}