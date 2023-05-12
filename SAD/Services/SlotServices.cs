namespace SAD.Services
{
    public class SlotService
    {
        //This method returns a string representing the CSS class for a card based on availability and date criteria.
        public string GetCardColor(bool isAvailable, bool isToday, bool isOld)
        {
            if (isToday)
            {
                //If the card is available and represents the current day, it should have a special CSS class 'cardToday'.
                return "card cardToday";
            }
            else if (!isAvailable)
            {
                //If the card is not available, it should have a red background color.
                return "card bg-danger";
            }
            else if (isOld)
            {
                //If the card is available but represents an older day, it should have a special CSS class 'cardOld'.
                return "card cardOld";
            }
            else
            {
                //For all other cards, the card should be white.
                return "card";
            }
        }
    }

}
