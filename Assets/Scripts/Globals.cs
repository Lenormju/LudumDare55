using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using UnityEngine.UI;

public class Globals : MonoBehaviour
{
    public static Story InkStory { get; set; }
    public static bool IsCurrentStoryEnding { get; set; }
    public static string SavedState {get;set;}
    public static List<Result> ResultDemons { get; set; } = new List<Result>();

    public class Result{
        public Result(string demon, int rate, string review, Sprite image){
            Demon = demon;
            Rate = rate;
            Review = review;
            Image = image;
        }
        public string Demon {get;set;}
        public int Rate {get;set;}
        public string Review {get;set;}
        public Sprite Image {get;set;}

        public override string ToString(){
            return $"{nameof(Demon)}: {Demon} | {nameof(Rate)}: {Rate} | {nameof(Review)}: {Review} ";
        }
    }

    public static bool CreateResult(List<string> tags, Image happyImage, Sprite angrySprite){
        if(tags != null && tags.Count > 0){
            var split = tags[0].Split(':');
            int note = int.Parse(split[2]);
            if(note >= 4){
                happyImage.sprite = angrySprite;
            }
            ResultDemons.Add(new Globals.Result(split[1],note,split[3], happyImage.sprite));
            IsCurrentStoryEnding = true;
            return true;
        }
        return false;
    }
}
