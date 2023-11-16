using BuilderDemoSoldier;

SoldierBuilder soldierBuilder = new SoldierBuilder();
ArmorBuilder armorBuilder = new ArmorBuilder();
WeaponBuilder weaponBuilder = new WeaponBuilder();

soldierBuilder
    .Name("Ragnar")
    .Health(100)
    .Age(27);

armorBuilder
    .Name("Nordic")
    .Durability(100)
    .Defence(300);

weaponBuilder
    .Name("Draugr Slayer")
    .Durability(100)
    .Strength(250)
    .Weight(5.7);


Soldier soldier = soldierBuilder.Build();
Armor armor = armorBuilder.Build();
Weapon weapon = weaponBuilder.Build();

Console.WriteLine(soldier.Name);
Console.WriteLine(soldier.Health);
Console.WriteLine(soldier.Age);
Console.WriteLine();
Console.WriteLine(armor.Name);
Console.WriteLine(armor.Durability);
Console.WriteLine(armor.Defence);
Console.WriteLine();
Console.WriteLine(weapon.Name);
Console.WriteLine(weapon.Durability);
Console.WriteLine(weapon.Strength);
Console.WriteLine(weapon.Weight);