using PasswordManager.Core;
using System.Runtime.InteropServices;

namespace PasswordManager.Application
{
    public class CardAppApplication
    {
        public CardAppApplication()
        {
            ListCardApp cards = new ListCardApp();
            allCards = cards.Cards;
        }

        public void Create(CardsApp card)
        {
            allCards.Add(card);
        }

        public CardsApp Read(int id)
        {
            return allCards.Where(i => i.Id == id).First();
        }

        public void Update(CardsApp card)
        {
            CardsApp? selectCard = allCards.Where(i => i.Id == card.Id).FirstOrDefault();
            if (selectCard is not null)
            {
                selectCard.Name = card.Name;
                selectCard.Login = card.Login;
                selectCard.Password = card.Password;
                selectCard.Description = card.Description;
                selectCard.Url = card.Url;
                selectCard.DateCreated = card.DateCreated;
            }
        }

        public void Delete(int id)
        {
            CardsApp? selectCard = allCards.Where(i => i.Id == id).FirstOrDefault();
            if (selectCard is not null)
            {
                allCards.Remove(selectCard);
            }
        }

        private List<CardsApp> allCards;
    }
}
