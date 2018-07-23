using System;

delegate void Callback();
// delegate void Event();   이벤트용 콜벡

class LivingEntity{
  public float health = 100;
  
  public virtual void TakeDamage(float damage){
    health -= damage;
    Console.WriteLine("HP: " + health);
  }
}

class Enemy : LivingEntity{
  public event Callback OnDeath;                  //이벤트 선언하면 밖에서 선언 불가능 (한정자, 제한자)
  // public event Event OnDeath;     이름 깔끔

  public override void TakeDamage(float damage){
    if(damage >= health){
      OnDeath();
      health = 0;
    }
    else{
      Console.Write("Enemy ");
      base.TakeDamage(damage);
    }
  }

  public void DrawEffect(){
    Console.WriteLine("Death effect");
  }

}

class Player : LivingEntity{
  public int XP{get; private set;} = 100;
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

  public void IncreaseExp(){
    XP += 50;
    Console.WriteLine("Add user's xp point: " + XP);
  }
}

class MainClass {
  public static void Main (string[] args) {
    Enemy e = new Enemy();
    Player p = new Player();

    e.OnDeath += p.IncreaseExp;
    e.OnDeath += e.DrawEffect;

    Console.WriteLine(p.XP == 100);
    e.TakeDamage(120);
    Console.WriteLine(p.XP == 150);

    // e.OnDeath;  //이벤트 선언하면 밖에서 선언 불가능
    /*
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
    */
  }

}