// Задача с собакой и друзьями
Console.Clear();

Console.Write("Введите дистанцию между друзьями: ");
int distance = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите скорость первого друга: ");
int first_friend_speed = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите скорость второго друга: ");
int second_friend_speed = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите скорость собаки: ");
int dog_speed = Convert.ToInt32(Console.ReadLine());
Console.Write("Собака бежит к первому (1) или ко второму (2) другу? ");
int friend = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (distance > 10)
{
    if (friend == 1)
    {
        int time = distance / (first_friend_speed + dog_speed);
        friend = 2;
        distance = distance - (first_friend_speed + second_friend_speed) * time;
    }
    else
    {
        int time = distance / (second_friend_speed + dog_speed);
        friend = 2;
        distance = distance - (first_friend_speed + second_friend_speed) * time;
    }
    count++;
}
Console.Write("Собака пробежала " + count + " раз");