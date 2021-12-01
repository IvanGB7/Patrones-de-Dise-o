namespace BridgePattern
{
    public interface IWeapon
    {
        //Creamos los metodos que puede hacer el arma fisica
        void Wield();
        void Swing();
        void Unwield();
        IEnchantment GetEnchantment();
    }
}