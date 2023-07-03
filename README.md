# Proyecto PedidosPizza
Se dispone de 3 endpoint
1. RegistrarPromocion: Registra las promociones disponibles
   Request  NombrePromocion:Nombre
            Descuento:Porcentaje descuento
            Dia:Dias de la semana 1=Lunes, 2=Martes, 3=Miercoles,4=Jueves
            Concepto:Valores 1=Descuento delivery, 2=Pizza

   Ejemplo:
            NombrePromocion:Promoción de Invierno
            Descuento:50
            Dia:1
            Concepto:2
3. CrearPizza: Crea las pizza predefinidas
   Request TipoPizza: 1=Americana, 2=Napolitana

   Ejemplo:
   TipoPizza:1
5. RegistrarPedido
   Request NombrePedido:Nombre del que realiza el pedido
           DetalleItem: Lista del pedido en formato JSON ,Donde los valores CANTIDAD: Cantidad de producto, ITEMPRODUCTO:Identificador del producto

   Ejemplo
   NombrePedido: Sonia Vargas
   DetalleItem: Cantidad=1
                ItemProducto=1
   
            
