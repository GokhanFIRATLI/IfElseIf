int time = DateTime.Now.Hour;

if (time >=6 && time <11)
    Console.WriteLine("Günadın!");
else if (time <= 18)
    Console.WriteLine("İyi Günler!");
else
    Console.WriteLine("İyi Geceler!");

string sonuc = time >= 6 ? "Günaydın!" : time <=18 ? "İyi Günler!" : "İyi Geceler!";
    Console.WriteLine(sonuc);
