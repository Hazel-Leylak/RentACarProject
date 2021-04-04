using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CreditCardManager : ICreditCardService
    {
        ICreditCardDal _creditCardDal;
        public CreditCardManager(ICreditCardDal creditCardDal)
        {
            _creditCardDal = creditCardDal;
        }
        public IResult Add(CreditCard creditCard)
        {
            if (creditCard.CardNumber.StartsWith("4"))
            {
                creditCard.CardType = "VISA";
            }
            else if (creditCard.CardNumber.StartsWith("5"))
            {
                creditCard.CardType = "MasterCard";
            }
            _creditCardDal.Add(creditCard);
            return new SuccessResult(Messages.CardAdded);
        }

        public IResult Delete(CreditCard creditCard)
        {
            _creditCardDal.Delete(creditCard);
            return new SuccessResult(Messages.CardDeleted);
        }

        public IDataResult<List<CreditCard>> GetAll()
        {
            return new SuccessDataResult<List<CreditCard>>(_creditCardDal.GetAll(), Messages.CardsListed);
        }

        public IDataResult<CreditCard> GetByCustomerId(int customerId)
        {
            return new SuccessDataResult<CreditCard>(_creditCardDal.Get(c => c.CustomerId == customerId));
        }

        public IResult Payment(CreditCard creditCard)
        {
            //payment process
            return new SuccessResult(Messages.PaymentSuccess);
        }

        public IResult Update(CreditCard creditCard)
        {
            _creditCardDal.Update(creditCard);
            return new SuccessResult(Messages.CardUpdated);
        }
    }
}
