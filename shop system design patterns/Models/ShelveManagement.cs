using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shop_system_design_patterns.models.Stocker_Creator;

namespace shop_system_design_patterns.models
{
    class ShelveManagement
    {
        public List<StockerCreator> Stockers { get; set; } = new List<StockerCreator>();

        public void Subscribe(ProductCategory shelveType, StockerCreator stocker) 
        {
            throw new NotImplementedException();
        }

        public void UnSubscribe(ProductCategory shelveType, StockerCreator stocker)
        {
            throw new NotImplementedException();
        }

        //TODO: Check data type
        public void Notify(ProductCategory shelveType, string data)
        {
            throw new NotImplementedException();
        }
    }
}
