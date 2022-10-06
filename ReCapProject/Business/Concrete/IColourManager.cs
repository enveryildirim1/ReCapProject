using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class IColourManager : IColourService
    {
        IColourDal _ColourDal;

        public IColourManager(IColourDal colourDal)
        {
            _ColourDal = colourDal;
        }
        public void Add(Colour colour)
        {
            if (colour.ColourName.Length > 2)
            {
                _ColourDal.Add(colour);
            }
            else
            {
                Console.WriteLine("Renk için en az 2 karakter girilmeli");
            }
        }

        public List<Colour> GetAll()
        {
            return _ColourDal.GetAll();
        }
    }
}
