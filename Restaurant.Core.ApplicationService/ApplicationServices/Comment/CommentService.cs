using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Core.ApplicationService.Dtos.Comment;
using Restaurant.Core.ApplicationService.IRepository;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
            var Item =  repository.GetQuery();
            return Item.Select(x => new CommentOutputDto()
            {
                Id = x.Id,
                comment = x.comment,
                Rate = x.Rate,
                UserId = x.UserId,
                RestaurantId = x.RestaurantId
            }).ToListAsync();
        }

        public async Task<CommentOutputDto> GetSingle(int id)
        {
            var Item = await repository.GetQuery().Where(x => x.Id == id).FirstOrDefaultAsync();
            return new CommentOutputDto()
            {
                Id = Item.Id,
                comment = Item.comment,
                Rate = Item.Rate,
                UserId = Item.UserId,
                RestaurantId = Item.RestaurantId
            };
        }

        public async Task<string> Update(CommentUpdateDto input)
        {
            var Item = repository.GetSingel(input.Id);

            if (Item == null)
            {
                return "null";
            }
            Item.Id = input.Id;
            Item.comment = input.comment;
            Item.Rate = input.Rate;
            Item.RestaurantId = input.RestaurantId;
           await repository.Save();
            return $"This {input.Id} Was Updated ";
        }
    }
}
