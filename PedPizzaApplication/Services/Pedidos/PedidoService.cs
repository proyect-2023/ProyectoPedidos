using PedPizzaApplication.Models;
using System.Runtime.InteropServices;

namespace PedPizzaApplication.Services.Pedidos
{
    public class PedidoService : IPedidoService
    {
        private readonly AppDbContext _appDbContext;

        public PedidoService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public object CrearPedido(string nombre, List<DetalleItem> detalle)
        {
            Producto? delivery=verificarDelivery();
            Promocion? descuento = _appDbContext.promocion.Where(p => p.Dia == (int)DateTime.Now.DayOfWeek ).FirstOrDefault();
            int descuentoid = descuento == null ? 0 : descuento.Id;

            _ = _appDbContext.pedido.Add(entity: new Pedido{ Fecha=DateTime.Now,PromocionId=descuentoid, Nombre=nombre });
            _appDbContext.SaveChanges();

            int idPedido=_appDbContext.pedido.Max(p => p.Id);

            int descuentoDelivery = 0;
            int descuentoItem = 0;

            if (descuento != null && descuento.TipoConcepto == 1)
                descuentoDelivery = descuento.Descuento;
            if (descuento != null && descuento.TipoConcepto != 1)
                descuentoItem = descuento.Descuento;

            // Item Delivery
            int deliveryid=delivery==null?0:delivery.Id;
            crearItem(idPedido,1, deliveryid, descuentoDelivery);


            // Detalle Productos

            foreach (DetalleItem item in detalle)
            {
                crearItem(idPedido, item.Cantidad, item.ItemProducto, descuentoItem);
               
            }


            return generarComprobante(idPedido);


        }

        public Producto? verificarDelivery()
        {
            Producto? delivery = _appDbContext.producto.Where(p => p.Concepto == 1).FirstOrDefault();
            
            if (delivery!=null)
            {
                _ = _appDbContext.producto.Add(entity: new Producto() { Nombre = "Delivery", Precio = 20, Concepto = 1 });
                _appDbContext.SaveChanges();

                delivery= _appDbContext.producto.Where(p=> p.Concepto == 1).FirstOrDefault();
            }

            return delivery;
        }
        public void crearItem(int pedido,int cantidad,int producto,int  descuento)
        {
            Producto _producto = _appDbContext.producto.Where(p => p.Id == producto).First();

            _ = _appDbContext.detallePedido.Add(new DetallePedido() { PedidoId = pedido, Cantidad = cantidad, Producto = _producto.Id, Importe = _producto.Precio * cantidad, ImporteDescuento = (_producto.Precio * cantidad) * (descuento / 100) });
            
            _appDbContext.SaveChanges();
        }

        public object generarComprobante(int pedido)
        {
            decimal importe_ = 0;
            _appDbContext.detallePedido.Where(p => p.PedidoId == pedido).ToList().ForEach(x => importe_ += x.Importe);
            decimal importedes_ = 0;
            _appDbContext.detallePedido.Where(p => p.PedidoId == pedido).ToList().ForEach(x => importedes_ += x.ImporteDescuento);


           return _appDbContext.pedido.Where(p => p.Id == pedido).Select(p =>
                 new {
                     NroPedido = p.Id,
                     Nombre = p.Nombre,
                     Importe = importe_,
                     Descuento = importedes_,
                     TotalPedido = importe_ - importedes_
                 }

                  );

          
        }

    }
}
