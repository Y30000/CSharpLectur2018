using System;

class Card{
  public enum CardAttribute {UNIT, BULDING, MAGIC};
  public enum AttactAttribute {GROUND, AIR, GROUND_AND_AIR};

  public CardAttribute CA;
  public string name;
  public int hp;
  public int damage;
  public float attact_interval;
  public AttactAttribute AA;
  public float range;
  public float speed;
  public int cost;

  public Card(CardAttribute _CA, string _name, int _hp, int _damage, float _attact_interval, AttactAttribute _AA, float _range, float _speed, int _cost){
    CA = _CA;
    name = _name;
    hp = _hp;
    damage = _damage;
    attact_interval = _attact_interval;
    AA = _AA;
    range = _range;
    speed = _speed;
    cost = _cost;
  }

  public float GetDPS(){
    return damage / attact_interval;
  }
}

class MainClass {
  public static void Main (string[] args) {
    Card Knight     = new Card(Card.CardAttribute.UNIT,   "Knight",   637, 62,1.2f,Card.AttactAttribute.GROUND, 1.0f,1.0f,3);
    Card Musketeer  = new Card(Card.CardAttribute.UNIT,   "Musketeer",340,100,1.1f,Card.AttactAttribute.GROUND_AND_AIR,6.0f,1.0f,4);
    Card Giant      = new Card(Card.CardAttribute.UNIT,   "Giant",   1900,120,1.5f,Card.AttactAttribute.GROUND, 1.0f,0.5f,5);
    Card Bandit     = new Card(Card.CardAttribute.UNIT,   "Bandit",   780,160,1.0f,Card.AttactAttribute.GROUND, 1.0f,2.0f,3);
    Card Cannon     = new Card(Card.CardAttribute.BULDING,"Cannon",   350, 60,0.8f,Card.AttactAttribute.GROUND, 5.5f,0.0f,3);
    Card Mortar     = new Card(Card.CardAttribute.BULDING,"Mortar",   600,108,5.0f,Card.AttactAttribute.GROUND,11.5f,0.0f,4);

    Card[] deck = new Card[6];

    deck[0] = Knight;
    deck[1] = Musketeer;
    deck[2] = Giant;
    deck[3] = Bandit;
    deck[4] = Cannon;
    deck[5] = Mortar;
    for(int i = 0; i < deck.Length; ++i)
      Console.WriteLine(deck[i].CA + ", " + deck[i].name + ", " + deck[i].hp + ", " + deck[i].damage + ", " + deck[i].attact_interval + ", " + deck[i].GetDPS() + ", " + deck[i].AA + ", " + deck[i].range + ", " + deck[i].speed + ", " + deck[i].cost);
  }
}