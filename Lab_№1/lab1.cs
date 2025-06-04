using System;

// оголошення класу 
class Product{
    
    // приватні поля для інкапсуляції
    private string name;
    private int quantity;
    private decimal price;

    // конструктор для ініціалізації значень полів
    public Product(string name, int quantity, demical price){
            Name = name;
            Price =price;
            this.quantity = quantity >=0 ? quantity:  throw new ArgumentException("Кількість товару не може бути від'ємною");
        }

    // властивість нейм з перевіркою на порожнє значення
    public string Name{
        get{return name;}
        set{
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Назва товару не може бути пустою");
            name = value;    
        }
    }

    // властивість прайс з перевіркою, що ціна не від'ємна
    public decimal Price{
        get {return price; }
        set{
            if(value <0)
                throw new ArgumentException("Ціна товару не може бути від'ємною");
            price =  value;    
        }
    }

    // властивість тільки для читання к-сті товарів
    public int Quantity{
        get {return quantity; }
        
    }

    // властивість для обчислення загальної вартості товарів на складі
    public demical TotalValue{
        get {return price * quantity; }
    }

    // метод для поповнення запасів
    public void Restock(int amount){
        if( amount <=0)
          throw new ArgumentException("Кількість для постачання має бути більше 0");
        quantity += amount;    
    }

    // метод для продажу
    public void Sell(int amount){
        if(amount <=0)
            throw new ArgumentException("Кількість для продажу має бути більше 0");

        if(amount > quantity){
            Console.WriteLine("Недостатньо товару на складі");
            return;
        }    
        quantity -= amount;
    }

    // метод для отримання інформації про товар
    public string GetInfo(){
        return $"Товар: {Name}, Ціна: {Price}, Кількість: {Quantity}, Загальна вартість: {TotalValue} грн";
    }
}

class Program{
    static void Main(){
        try{
            Product apple = new Product("Яблуко", 5, 100);
            Console.WriteLine(apple.GetInfo());

            apple.Sell(20);
            Console.WriteLine(apple.GetInfo());

            apple.Restock(50);
            Console.WriteLine(apple.GetInfo());

            apple.Price = 7;
            Console.WriteLine(apple.GetInfo());

            apple.Name = "Зелене яблуко";
            Console.WriteLine(apple.GetInfo());

            apple.Price =-10;
            apple.Name ="";
            apple.Sell(200);

        }
    }
}
