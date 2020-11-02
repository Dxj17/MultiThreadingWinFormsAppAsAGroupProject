/*
 * 
 * Dominic Johnson
 * johnodx@mail.uc.edu
 * Assignment 07
 * Refrences:None 
 * Have a fantastic beast of your choice after working w
 */
using System;
using System.Threading;

namespace MultiThreadingWinFormsAppAsAGroupProject {
    /// <summary>
    /// A Fantastic Beast that will help us maintain a secure world
    /// </summary>
    class ObedientOwl : FantasticBeast {
        public override void SayHello() {

            Console.WriteLine("Hello from " + this.GetType());
        }
        public override void RunThread()
        {
            // Use the value in request, compute the largest prime factor,
            // store in response
            msg = "Hello from AbiogeneticTestCase.RunThread and Obedient Owl()";
            Thread.Sleep(2000);
            long num = Convert.ToInt64(request);
            response = Convert.ToString(19541);
        }
     
          
        

    }
}
