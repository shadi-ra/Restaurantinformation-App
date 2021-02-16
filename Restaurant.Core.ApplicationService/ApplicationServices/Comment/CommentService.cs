using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Core.ApplicationService.Dtos.Comment;
using Restaurant.Core.ApplicationService.IRepository;
using System.Linq;


namespace Restaurant.Core.ApplicationService.ApplicationServices.Comment
{
    public class CommentService : ICommentService
    {
        private readonly IRepository<Entities.Models.Comment> repository;
        public async Task<string> Create(CommentInsertInputDto input)
        {
            repository.Insert(new Entities.Models.Comment()
            {
                comment = input.comment,
                Rate = input.Rate,
                UserId = input.UserId,
                RestaurantId = input.RestaurantId,
            });
           await repository.Save();
            return $"{input.comment} Was Created ";
        }

        public async Task<string> Delete(int id)
        {
            var Item = repository.GetQuery().Where(x => x.Id == id).FirstOrDefault();
            if (Item != null)
            {
                repository.Delete(id);
               await repository.Save();
                return $"{id} was Deleted ";
            }
            return $"this {id} Does not Exist";
        }

        public Task<List<CommentOutputDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CommentOutputDto> GetSingle(int id)
        {
            throw new NotImplementedException();
        }

        public Task<string> Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
