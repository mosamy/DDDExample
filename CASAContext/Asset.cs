namespace CASAContext
{
    public class Asset : DomainObject
    {
       

        public string AssetName
        {
            get => _assetName;
            set => _assetName = value;
        }

        public decimal Value
        {
            get => _value;
            set => _value = value;
        }

        
        private string _assetName;
        private decimal _value;
    }
}