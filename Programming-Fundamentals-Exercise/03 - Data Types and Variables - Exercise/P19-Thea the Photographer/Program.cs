
namespace P19_Thea_the_Photographer
{
    using System;

    class Program
    {
        static void Main()
        {
            int numberOfPictures =int.Parse(Console.ReadLine());
            double pictureFilterTime = double.Parse(Console.ReadLine());
            double percentageOfApprovedPicture = double.Parse(Console.ReadLine());
            double uploadTimeForPucture = double.Parse(Console.ReadLine());

            double filteredPic = Math.Ceiling((numberOfPictures * percentageOfApprovedPicture / 100));
            double filteredTime = numberOfPictures * pictureFilterTime;
            double uploadedTime = filteredPic * uploadTimeForPucture;
            double totalTime = filteredTime + uploadedTime;
         
            TimeSpan timeInSecond = TimeSpan.FromSeconds(totalTime);

            string time = string.Format($"{timeInSecond.Days}:" +
                                        $"{timeInSecond.Hours:D2}:" +
                                        $"{timeInSecond.Minutes:D2}:" +
                                        $"{timeInSecond.Seconds:D2}");

           
              Console.WriteLine(time);
        }
    }
}
