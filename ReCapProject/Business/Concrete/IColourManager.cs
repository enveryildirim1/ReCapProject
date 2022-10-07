using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
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

        public IResult Add(Colour colour)
        {
            _ColourDal.Add(colour);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(Colour colour)
        {
            _ColourDal.Delete(colour);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<Colour>> GetAll()
        {
            return new SuccessDataResult<List<Colour>>(_ColourDal.GetAll());
        }

        public IDataResult<Colour> GetbyId(int colorId)
        {
            return new SuccessDataResult<Colour>(_ColourDal.Get(p => p.ColourId == colorId));

        }

        public IResult Update(Colour colour)
        {
            _ColourDal.Update(colour);
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
