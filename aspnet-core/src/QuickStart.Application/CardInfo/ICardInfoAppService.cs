using QuickStart.CardInfo.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart.CardInfo
{
    public interface ICardInfoAppService
    {
        Task<List<GetCardDto>> GetAllCardInfo();
        void CreateCard(CreateCardDto input);

        void UpdateCard(UpdateCardDto input);

        void DeleteCard(int  cardId);
    }
}
