class Player
{
    private int _health;

    public bool IsDead { get; private set; }

    public void TakeDamade(int damage)
    {
        if (damage >= 0)
            _health -= damage;

        if (_health <= 0)
            IsDead = true;
    }
}

class Weapon
{
    private int _bullets;
    private int _damage;

    public void Fire(Player player)
    {
        if (_bullets > 0)
            _bullets -= 1;

        player.TakeDamade(_damage);
    }
}

class Bot
{
    private Weapon _weapon;

    public void OnSeePlayer(Player player)
    {
        if (player.IsDead == false)
            _weapon.Fire(player);
    }
}
