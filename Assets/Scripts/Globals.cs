using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using UnityEngine.UI;

public class Globals : MonoBehaviour
{
    public static Story InkStory { get; set; }
    public static string SavedState {get;set;}
    public static Result ResultDemon { get; set; } = null;

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

    public static bool CreateResult(List<string> tags, Image happyImage, Sprite angrySprite){
        if(tags != null && tags.Count > 0){
            var split = tags[0].Split(':');
            Globals.ResultDemon = new Globals.Result(split[1],int.Parse(split[2]),split[3]);
            Debug.Log(Globals.ResultDemon);
            if(Globals.ResultDemon.Rate >= 4){
                happyImage.sprite = angrySprite;
            }
            return true;
        }
        return false;
    }
}
