using System.Diagnostics;
using DataGridCRUDExample.Models;

namespace DataGridCRUDExample.Services {
    public class WebApiService {
        public void SaveProduct(Product product) {
            //This is just a stubbed out method for "saving a product", this would contain web service call logic
            Debug.WriteLine(string.Format("Saving Product {0}", product.Name));
        }
    }
}
