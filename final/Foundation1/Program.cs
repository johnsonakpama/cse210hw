using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._author = "Mary James";
        video1._title = "Cat drama";
        video1._length = 60;

        Video video2 = new Video();
        video2._author = "Adam Smith";
        video2._title = "Firefighter Clip";
        video2._length = 120;

        Video video3 = new Video();
        video3._author = "Sam Patrick";
        video3._title = "Animal World";
        video3._length = 180;

        Comment myComment = new Comment();
        myComment._name = "Solomon Usman";
        myComment._text = "It's cute and dramatical";

        myComment.Videos.Add(video1);
        myComment.Videos.Add(video2);
        myComment.Videos.Add(video3);
    }
}