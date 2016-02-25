using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalServices.DatabaseHandler;

namespace Model
{
    class Recipe
    {
        List<List<string>> IList = new List<List<string>>();
        public Recipe(string pName, string pType)
        {
            ProductDocumationAccess p = new ProductDocumationAccess();
            IList = p.GetIngredients(pName);
        }
        private void CalculateUse()
        {

        }

    }
}
