

Hero hero = new Hero("Ada", 100);
Monster monster = new Monster("Ork", 45);
Item item = new Item("Miecz", 40);
Item item2 = new Item("Mikstura", 15);
Inventory inventory = new Inventory();

inventory.Add(item);
inventory.Add(item2);

int damage = CombatRules.CalculateDamage(7, 5);
monster.TakeDamage(damage);

ArenaPrinter.ShowTitle("Rogue Arena");
Console.WriteLine($"Przedmioty: {item.Name}, {item2.Name}");
Console.WriteLine($"Wartość ekwipunku: {inventory.CalculateValue()}");
Console.WriteLine($"{hero.Name} zadaje {damage} obrażeń.");
ArenaPrinter.ShowHealth(monster.Name, monster.Health);
