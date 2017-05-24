using Business.Entities;
using System.ServiceModel;

namespace Businnes.Services
{
    [ServiceContract]
    public interface IBlogService
    {
        [OperationContract]
        void Add(Blog blog);

        [OperationContract]
        void Update(Blog blog);

        [OperationContract]
        void Delete(Blog blog);

        [OperationContract]
        Blog GetById(int id);

        [OperationContract]
        Blog[] GetAll();
    }


    [ServiceContract]
    public interface IArticleService
    {
        [OperationContract]
        void Add(Article article);

        [OperationContract]
        void Update(Article article);

        [OperationContract]
        void Delete(Article article);

        [OperationContract]
        Article GetById(int id);

        [OperationContract]
        Article[] GetAll();
    }
}
