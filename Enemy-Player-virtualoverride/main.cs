using System;

class LivingEntity{
  public float health = 100;
  
  public virtual void TakeDamage(float damage){
    health -= damage;
    Console.WriteLine("HP: " + health);
  }
}

class Enemy : LivingEntity{
  public override void TakeDamage(float damage){
    if(damage >= health){
      Console.WriteLine("Add user's xp point");
      Console.WriteLine("Death effect");
      health = 0;
    }
    else{
      Console.Write("Enemy  ");
      base.TakeDamage(damage);
    }
  }
}

class Player : LivingEntity{
  public override void TakeDamage(float damage){
    if(damage >= health){
      Console.WriteLine("Revive");
      health = 100;
    }
    else{
      Console.Write("Player ");
      base.TakeDamage(damage);
    }
  }
}

class MainClass {
  public static void Main (string[] args) {
    Enemy e = new Enemy();
    Player p = new Player();

    e.TakeDamage(10);
    Console.WriteLine(e.health == 90);
    p.TakeDamage(100);
    Console.WriteLine(p.health == 100);

    LivingEntity[] le = new LivingEntity[2]{new Enemy(), new Player()};

    foreach(var l in le){
      l.TakeDamage(20);
    }
    Console.WriteLine(le[0].health == 80);
    Console.WriteLine(le[1].health == 80);
  }
}