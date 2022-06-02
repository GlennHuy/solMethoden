using assignmentMuziekEnMethoden;
Playlist songPlayer = new Playlist();

Console.WriteLine("Choose 1 for You Are My Sunshine, 2 for Do Re Mi");
int input = Convert.ToInt32(Console.ReadLine());
switch (input)
{
    case 1:
        songPlayer.YouAreMySunshine();
        break;
    case 2:
        songPlayer.DoReMi();
        break;
    default:
        Console.WriteLine("Incorrect choice");
        break;
}