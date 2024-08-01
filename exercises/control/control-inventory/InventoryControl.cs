using System.Collections.Generic;

namespace control_inventory
{
    public class InventoryControl
    {
        private Dictionary<string, Product> products = new Dictionary<string, Product>();

        public void Addproduct(Product product)
        {

            // ContainsKey: Serve para verificar se o dictionary possui a chave necessária antes de executar o método
            if (products.ContainsKey(product.Name!))
            {
                products[product.Name!].Quantity += product.Quantity;
            }
            else
            {
                products.Add(product.Name!, product);
            }
        }

        public int GetQuantityProduct(string name)
        {
            //TryGetValue: Se o valor especificado não for encontrado este paramêtro especialidazo não é retornado
            if (products.TryGetValue(name, out Product? product))
            {
                return product.Quantity;
            }
            return 0;
        }

    }
}
