using Single_Responsibility_Principle.Product;
using Single_Responsibility_Principle.ProductClasses;
using Single_Responsibility_Principle.ProductPrinter;
using Single_Responsibility_Principle.ProductRepository;

FruitRepository fruitRepository = new FruitRepository();
ProductInfos.getProductsInfos(fruitRepository.products);

Console.WriteLine("====================== Changing Price ==========================");

ChangePrice.ChangeFruitPrice(2, fruitRepository.products, 11.5f);
ProductInfos.getProductsInfos(fruitRepository.products);