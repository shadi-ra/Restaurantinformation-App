using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Core.ApplicationService.Dtos.Comment;

namespace Restaurant.Core.ApplicationService.ApplicationServices.Comment
{
   public interface ICommentService
    {
        Task<string> Create(CommentInsertInputDto input);
        Task<CommentOutputDto> GetSingle(int id);
        Task<List<CommentOutputDto>> GetAll();
        Task<string> Update(CommentUpdateDto input);
        Task<string> Delete(int id);
    }
}
