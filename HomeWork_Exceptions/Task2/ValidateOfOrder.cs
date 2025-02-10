namespace HomeWork_Exceptions.Task2;

public class ValidateOfOrder
{
    public void OrderValidate(Order order)
    {
        try
        {
            if (order.OrderNumber < 0)
            {
                throw new InvalidNumberOfOrderException("Номер заказа указан некорректно!");
            }

            if (order.ProductsInOrder == null || order.ProductsInOrder.Count == 0)
            {
                throw new EmptyListOfOrderException("Пустой список товаров!"); // если указать так, то выведется сообщение из класса EmptyListOfOrderException, а под ним из блока catch
            }

            if (string.IsNullOrEmpty(order.DeliveryInfo) || string.IsNullOrWhiteSpace(order.DeliveryInfo))
            {
                throw new DeliveryException("Недостаточно информации"); // если указать так, то выведется сообщение из класса DeliveryException, а под ним из блока catch 
            }
            else
            {
                Console.WriteLine("Заказ корректен!");
            }
        }
        catch (InvalidNumberOfOrderException)
        {
            Console.WriteLine(); // если указать так, то будет выводится сообщение, указанное в классе InvalidNumberOfOrderException
        }
        catch (EmptyListOfOrderException ex)
        {
            Console.WriteLine("Нет товаров в списке");
        }
        catch (DeliveryException ex)
        {
            Console.WriteLine(ex);
        }
        finally
        {
            Console.WriteLine($"Валидация заказа № {order.OrderNumber} завершена!");
        }
    }
}