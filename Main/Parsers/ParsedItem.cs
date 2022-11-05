namespace Main.Parsers
{
    public class ParsedItem
    {
        private string _item;

        
        public ParsedItem(string _item)
        {
            this._item = _item;
        }

        public string GetItem()
        {
            return this._item;
        }
    }
}
