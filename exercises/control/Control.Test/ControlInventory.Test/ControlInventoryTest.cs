using control_inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventory.Test
{
    public class ControlInventoryTest
    {
        [Fact]
        public void AddProduct()
        {
            var inventory = new InventoryControl();
            var productExistent = new Product("Maçã", 5);
            var productNew = new Product("Banana", 3);

            inventory.Addproduct(productExistent);
            inventory.Addproduct(productNew);

            Assert.Equal(5, inventory.GetQuantityProduct("Maçã"));
            Assert.Equal(3, inventory.GetQuantityProduct("Banana"));
        }

        [Fact]
        public void AddProductInexistent()
        {
            var inventory = new InventoryControl();
            var product = new Product("Uva", 10);

            inventory.Addproduct(product);

            Assert.Equal(10, inventory.GetQuantityProduct("Uva"));
        }

        [Fact]
        public void ReturnsZeroIfProductDoesNotExist()
        {
            var inventory = new InventoryControl();

            Assert.Equal(0, inventory.GetQuantityProduct("Abacaxi"));
        }
    }
}
