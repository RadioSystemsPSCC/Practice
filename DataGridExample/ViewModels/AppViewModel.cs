using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Data;
using DataGridCRUDExample.Models;

namespace DataGridCRUDExample.ViewModels {
    public class AppViewModel {
        public ICollectionView Products { get; set; }

        public AppViewModel() {
            var products = new List<Product> {
                new Product {
                    Name = "Boundary Plus",
                    Sku = "BP1210?",
                    Price = 1095.00
                },
                new Product {
                    Name = "Indoor Shields Plus",
                    Sku = "SH117?",
                    Price = 39.95
                },
                new Product {
                    Name = "Outdoor Shields Plus",
                    Sku = "OS118?",
                    Price = 49.95
                },
                new Product {
                    Name = "Doorman Pet Door",
                    Sku = "DM210?",
                    Price = 249.95
                }
            };

            Products = CollectionViewSource.GetDefaultView(products);
        }
    }
}
