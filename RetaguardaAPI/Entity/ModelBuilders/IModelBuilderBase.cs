using Microsoft.EntityFrameworkCore;
namespace RetaguardaAPI.Entity.ModelBuilders;

interface IModelBuilderBase
{
    public void create(ModelBuilder builder);
}
