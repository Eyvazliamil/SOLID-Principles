using Interface_Segregation_Principle.Classes;


Dog dog= new Dog();
dog.MakeNoise();
Console.WriteLine();
Parrot parrot = new Parrot();
parrot.SpeakLikeHuman();
parrot.MakeNoise();