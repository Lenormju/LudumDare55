using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

public class Globals : MonoBehaviour
{
    public static Story InkStory { get; set; }

    public static Result ResultDemon {get;set;}

    public class Result{
        public Result(string demon, int rate, string review){
            Demon = demon;
            Rate = rate;
            Review = review;
        }
        public string Demon {get;set;}
        public int Rate {get;set;}
        public string Review {get;set;}

        public override string ToString(){
            return $"{nameof(Demon)}: {Demon} | {nameof(Rate)}: {Rate} | {nameof(Review)}: {Review} ";
        }
    }
}
