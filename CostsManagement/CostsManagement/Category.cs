using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostsManagement
{
    /// <summary>
    /// Types of costs
    /// </summary>
    class Category
    {
        private string _name;  //Category name
        private bool _categoryType; //Category type: true - income, false - cost

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Category name</param>
        /// <param name="categoryType">Category type: true - income, false - cost</param>
        public Category(string name, bool categoryType)
        {
            _name = name;
            _categoryType = categoryType;
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (value == "")
                    throw new Exception("Name cannot be empty");
                else
                    _name = value;
            }
        }

        public bool Type
        {
            get { return _categoryType; }
            set { _categoryType = value; }
        }
    }
}
