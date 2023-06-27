namespace DevFreela.Infrastructure.CloudServices.Interfaces
{
    public interface IFileStorageService
    {
        void Upload(byte[] bytes, string fileName);
    }
}
