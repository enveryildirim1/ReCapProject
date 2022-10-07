using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface IColourService
    {
        IDataResult<List<Colour>> GetAll();
        IDataResult<Colour> GetbyId(int colorId);
        IResult Add(Colour colour);
        IResult Delete(Colour colour);
        IResult Update(Colour colour);
    }
}
