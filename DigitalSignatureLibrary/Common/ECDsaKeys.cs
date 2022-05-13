namespace DigitalSignatureLibrary.Common
{
    /// <summary>
    /// Структура, представляющая
    /// пару ключей алгоритма ECDSA
    /// (открытый и закрытый)
    /// </summary>
    public struct ECDsaKeys
    {
        public byte[] privateKey;
        public byte[] publicKey;
    };
}
