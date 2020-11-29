using BusinessLayer.Interfaces;
using BusinessLayer.Levels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class BusinessManager
    {
        public IServices Services()
        {
            return new ServicesLevel();
        }
    }
}
