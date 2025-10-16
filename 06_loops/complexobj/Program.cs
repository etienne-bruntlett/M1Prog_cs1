namespace complexobj;

class Program
{
    static void Main(string[] args)
    {
        Enemy[] enemies = new Enemy[]
        {
            new Enemy() { defeated = true, name = "isdead" },
            new Enemy() { defeated = false, name = "stillalive" },
            new Enemy() { defeated = true, name = "goblin" },
            new Enemy() { defeated = false, name = "hunter" }
        };

        for(int i = 0; i< enemies.Length; i++)
        {
            Enemy enemy = enemies[i];
            if (enemy.defeated == true)
            {
                Console.WriteLine($"enemy {i} with name {enemy.name} was defeated");
            }
            else
            {
                Console.WriteLine($"enemy {i} with name {enemy.name} is still alive and keeps attacking!");
            }
        }
    }
}
