using Microsoft.EntityFrameworkCore;
using Sales_System_API.Model;

namespace API_Gestao_Sock.Data
{
    public class DataContext
    {
        public DbSet<ProdutoModel> Protudos {get; set;}
        public DbSet<StockModel> Stocks {get; set;}
        public DbSet<VendaModel> vendas {get; set;}
        public DbSet<MovimentosStockModel> MovimentosStocks {get; set;}
        public DbSet<CarinhoModel> carinhos {get;set;}
    }
}
