using PasswordManager.Core;
namespace PasswordManager.Application
{
    public class ShortCardAppAplication
    {
        public ShortCardAppAplication()
        {
            ListShortCardApp cards = new ListShortCardApp();
            this.allCards = cards.ShortCards;
        }

        public void Create(ShortCardApp card)
        {
            allCards.Add(card);
        }

        public ShortCardApp Read(int id)
        {
            return allCards.Where(i => i.Id == id).First();
        }

        public void Update(ShortCardApp card)
        {
            ShortCardApp? selectCard = allCards.Where(i => i.Id == card.Id).FirstOrDefault();
            if(selectCard is not null)
            {
                selectCard.NameService = card.NameService;
                selectCard.DateUpdate = card.DateUpdate;
            }
        }

        public void Delete(int id)
        {
            ShortCardApp? selectCard = allCards.Where(i => i.Id == id).FirstOrDefault();
            if (selectCard is not null)
            {
                allCards.Remove(selectCard);
            }
        }

        private List<ShortCardApp> allCards;

    }
}
