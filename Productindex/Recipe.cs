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
        public Recipe(string pName, string pType, string pDocumation)
        {
            ProducttInfoAccess pa = new ProducttInfoAccess();
            pa.GetRecipe(pName, pType, pDocumation);
        }
        private void CalculateUse()
        {

        }

    }
}
