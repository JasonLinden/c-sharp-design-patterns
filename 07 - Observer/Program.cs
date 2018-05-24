using _07___Observer.Newspaper.ConcreteObserver;
using _07___Observer.Newspaper.ConcreteSubject;
using _07___Observer.VeggieTracker.ConcreteObserver;
using _07___Observer.VeggieTracker.ConcreteSubject;
using System;

namespace _07___Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Veggies

            // Create price watch for Carrots and attach restaurants that buy carrots from suppliers.
            Carrots carrots = new Carrots(0.82);
            carrots.Attach(new Restaurant("Mackay's", 0.77));
            carrots.Attach(new Restaurant("Johnny's Sports Bar", 0.74));
            carrots.Attach(new Restaurant("Salad Kingdom", 0.75));

            // Fluctuating carrot prices will notify subscribing restaurants.
            carrots.PricePerPound = 0.79;
            carrots.PricePerPound = 0.76;
            carrots.PricePerPound = 0.74;
            carrots.PricePerPound = 0.81;

            Console.ReadKey();

            #endregion

            #region Newspaper

            // Create news agencies (providers).
            var associatedPress = new Agency("Associated Press");
            var reuters = new Agency("Reuters");

            // Create newspapers (observers).
            var newYorkTimes = new NewspaperClass("The New York Times");
            var washingtonPost = new NewspaperClass("The Washington Post");

            // AP publication.  Neither newspaper subscribes, so no output.
            associatedPress.Publish("Waiting the worst with Harvey, the storm that won’t go away", "Juliet Linderman");

            // Times subscribes to AP.
            newYorkTimes.Subscribe(associatedPress);

            // Post subscribes to Reuters.
            washingtonPost.Subscribe(reuters);

            // Reuters publications.
            reuters.Publish("Japan retail sales slow in July, still top expectations", "Stanley White");
            reuters.Publish("Transgender members in U.S. military may serve until study completed: Mattis", "Reuters Staff");

            // AP publications.
            associatedPress.Publish("Chicago changes course, wants police reforms with court role", "Don Babwin and Michael Tarm");
            associatedPress.Publish("US Open fashion: Crystals, shapes and knee-high socks", "James Martinez");

            // Post subscribes to AP.
            washingtonPost.Subscribe(associatedPress);

            // AP Publications, both Times and Post should receive.
            associatedPress.Publish("Game of Thrones: Trust me, I’m a Targaryen", "Paul Wiseman, Josh Boak, and Christopher Rugaber");
            associatedPress.Publish("Merkel: Europe still ‘hasn’t done homework’ on refugees", "Geir Moulson");

            // Post unsubscribes from AP.
            washingtonPost.Unsubscribe(associatedPress);

            // AP publication, should only be picked up by Times.
            associatedPress.Publish("Hajj pilgrimage entangled in web of Saudi politics", "Aya Batrawy");

            // Perform cleanup for AP.
            associatedPress.Shutdown();

            // Few more Reuters publications.
            reuters.Publish("Google, Apple face off over augmented reality technology", "Stephen Nellis");
            reuters.Publish("Under investor pressure, Goldman to explain trading strategy", "Olivia Oran");
            reuters.Publish("UK retailers see Brexit hit to consumers without detailed customs plans", "Reuters Staff");

            Console.ReadKey();

            #endregion
        }
    }
}
