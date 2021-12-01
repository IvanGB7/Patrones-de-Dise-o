namespace BridgePattern
{
    public interface IEnchantment
    {
        //Creamos los metodos que puede hacer el arma tipo hechizo
        void OnActivate();
        void Apply();
        void OnDeactivate();
    }
}