using System;

class Program
{
    // Metoda koja pretvara broj dana u sate i sekunde
    static void ConvertDaysToHoursAndSeconds(int days, out int hours, out int seconds)
    {
        // 1 dan = 24 sata, 1 sat = 3600 sekundi
        hours = days * 24;
        seconds = days * 24 * 3600;
    }

    static void Main()
    {
        // Primer upotrebe
        int days = 2; // Unesite broj dana
        int hours, seconds;

        // Pozivanje metode
        ConvertDaysToHoursAndSeconds(days, out hours, out seconds);

        // Ispis rezultata
        Console.WriteLine($"{days} dana = {hours} sati i {seconds} sekundi.");
    }
}
