using System;

class Program
{
    static void Main(string[] args)
    {
        Event event = new Event();
        event.SetTitle("The important of Technology");
        event.SetDescription("Exposing to benefit of Technology in our present world");
        event.SetDate("10:00am");
        event.SetDate("3rd -Dec-2023");
        event.SetAddress("HillStation Hotel");

        Console.WriteLine(event.GetFullEventDetail());

        Address address = new Address();
        address.SetStreet("#3 Murtala Express road Bukuru");
        address.SetCity("Jos");
        address.SetState("Plateau state");
        address.SetCountry("Nigeria");

        Console.WriteLine(address.GetFullAddress());

        Lecture lecture = new Lecture();
        lecture.SetSpeakerName("Johnson Akpama");
        lecture.SetCapacity("500");

        Console.WriteLine(lecture.GetFullLecture());

        Outdoor outdoor = new Outdoor();
        outdoor.SetWeatherForecast("Rainy");
        outdoor.SetWeatherStatement("Haze 37/13");

        Console.WriteLine(outdoor.GetFullWeatherStatement());

        Reception reception = new Reception();
        reception.SetRsvpEmail("johnsonakpamaboy@gmail.com");

        Console.WriteLine(reception.GetFullReception());
    }
       
}