using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using TechnicalServices.DatabaseHandler;

namespace Controller
{
    class ProductIndex
    {
        public List<string> pNameList = new List<string>();
        public List<string> pTypeList = new List<string>();
        public List<string> pDocumationList = new List<string>();

        public ProductIndex()
        {
            MakepNameList();
            MakepTypeList();
            MakepDocumationList();
        }
        public string ShowProductDocumation(string pName, string pType, string pDocumation)
        {
            if (pNameList.Contains(pName) && pTypeList.Contains(pType) && pDocumationList.Contains(pDocumation))
            {
                if (pDocumation == "Product Infomation")
                {
                    ProductInfo pi = new ProductInfo(pName, pType);

                }
                else if (pDocumation == "Recipe")
                {
                    Recipe r = new Recipe(pName, pType, pDocumation);
                }
                else if (pDocumation == "Correspondance")
                {

                }
                else if (pDocumation == "QualityAssurance")
                {

                }
                //database metode til at give data tilbage i en string
            }
            return null;
        }
        public void MakepNameList()
        {
            ProducttIndexAccess p = new ProducttIndexAccess();
            String[] a = p.GetpNameString().Split(';');
            foreach (var item in a)
            {
                pNameList.Add(item);
            }            
        }
        public void MakepTypeList()
        {
            ProducttIndexAccess p = new ProducttIndexAccess();
            String[] a = p.GetpTypeString().Split(';');             
            foreach (var item in a)
            {
                pTypeList.Add(item);
            }
        }
        public void MakepDocumationList()
        {
            ProducttIndexAccess p = new ProducttIndexAccess();
            String[] a = p.GetpDocumationString().Split(';');
            foreach (var item in a)
            {
                pDocumationList.Add(item);
            }
        }
    }
}
