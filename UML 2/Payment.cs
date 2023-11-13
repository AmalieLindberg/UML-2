using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public class Payment
{
    private string _cardType;
    private int _cardNumber;
    private string _nameOnCard;

    public Payment() { CardType = "Visa"; CardNumber = 164537827; NameOnCard = "Jonas"; }
    public Payment(string cardType, int cardNumber, string nameOnCard)
    {
        _cardType = cardType;
        _cardNumber = cardNumber;
        _nameOnCard = nameOnCard;
    }

    public string CardType
    {
        get { return _cardType; }
        set { _cardType = value; }
    }

    public int CardNumber
    {
        get { return _cardNumber; }
        set { _cardNumber = value; }
    }

    public string NameOnCard
    {
        get { return _nameOnCard; }
        set { _nameOnCard = value; }
    }

    public override string ToString()
    {
        return "Card type= " + CardType + ",Card number= " + CardNumber + ",Name on card= " + NameOnCard;
    }
}
