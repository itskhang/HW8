using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HW8.Models
{
    public class AnimalContextInitiaizer : DropCreateDatabaseAlways <AnimalContext>
    {
        protected override void Seed (AnimalContext context)
        {
            context.Animals.Add(
                new Animal() {
                    AnimalName = "Bulldog",
                    AnimalDescription = "Bulldogs originally were used to drive cattle to market and to compete in a bloody sport called bullbaiting. Today, they're gentle companions who love kids. A brief walk and a nap on the sofa is just this dog breed's speed.",
                    DateReceived = new DateTime(2016, 3, 9),
                    Quantity = 5,
                    Price = 150.00M,
                    });

            context.Animals.Add(
                new Animal()
                {
                    AnimalName = "German Shepherd",
                    AnimalDescription = "The German Shepherd Dog is one of America's most popular dog breeds — for good reason. He's an intelligent and capable working dog. His devotion and courage are unmatched. And he's amazingly versatile, excelling at most anything he's trained to do: guide and assistance work for the handicapped, police and military service, herding, search and rescue, drug detection, competitive obedience and, last but not least, faithful companion.",
                    DateReceived = new DateTime(2016, 3, 7),
                    Quantity = 3,
                    Price = 500.00M,
                    });

            context.Animals.Add(
                new Animal()
                        {
                    AnimalName = "Shiba Inu",
                    AnimalDescription = "The Shiba Inu dog breed was originally bred to flush birds and small game, and was occasionally used to hunt wild boar. He is one of Japan's six native breeds: Akita (large), Kishu, Hokkaido, Kai, Shikoku (medium), and Shiba (small). He is known for his spirited personality, small upright ears, and cat-like agility. Today he serves primarily as a companion dog in Japan and the United States.",
                    DateReceived = new DateTime(2016, 3, 8),
                    Quantity = 2,
                    Price = 350.00M,
                    });

            context.Animals.Add(
                new Animal()
                {
                    AnimalName = "Siberian Husky",
                    AnimalDescription = "The Siberian Husky is a beautiful dog breed with a thick coat that comes in a multitude of colors and markings. Their blue or multi-colored eyes and striking facial masks only add to the appeal of this breed, which originated in Siberia. It is easy to see why many are drawn to the Siberian's wolf-like looks, but be aware that this athletic, intelligent dog can be independent and challenging for first-time dog owners.",
                    DateReceived = new DateTime(2016, 3, 10),
                    Quantity = 3,
                    Price = 250.00M,
                    });

            context.SaveChanges();
        }
    }
}