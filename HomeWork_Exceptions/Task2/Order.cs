namespace HomeWork_Exceptions.Task2;
using System.Collections.Generic;

public class Order
{
    public int OrderNumber { get; set; }
    public List<string> ProductsInOrder = new List<string>();
    public string DeliveryInfo { get; set; }
    

        
    public Order(int orderNumber, List<string> productsInOrder, string deliveryInfo)
    {

            OrderNumber = orderNumber;
            ProductsInOrder = productsInOrder;
            DeliveryInfo = deliveryInfo;
            
    }
}