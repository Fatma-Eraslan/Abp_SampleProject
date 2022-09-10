using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ProductManagement.Products
{
    public interface IProductAppService:IApplicationService
    {
        Task<PagedResultDto<ProductDto>> GetListAsync(PagedAndSortedResultRequestDto input);
        /* 
         • IProductAppService,  IApplicationService arabiriminden türetilmiştir.  Bu sayede ABP, uygulama hizmetlerini tanıyabilir. 
         • GetListAsync yöntemi, ABP Framework'ün standart DTO sınıfı olan PagedAndSortedResultRequestDto'yu alır.
    MaxResultCount (int), SkipCount (int) ve Sorting (string) özellikleri. 
         • GetListAsync yöntemi, TotalCount  (long) özelliğini ve  ProductDto  nesnelerinin Items koleksiyonunu  içeren  PagedResultDto<ProductDto> döndürür  . Bu, ABP Framework ile sayfalanmış sonuçları döndürmenin uygun bir yoludur. 
         */
    }
}
