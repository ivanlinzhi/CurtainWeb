using System;
using System.Collections.Generic;

#nullable disable

namespace Curtain.Data
{
    public partial class Inventory
    {
        public long Id { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string Material { get; set; }
        public string Style { get; set; }
        public string Position { get; set; }
        public string Feature { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public string Supplier { get; set; }
        public double? Widthin { get; set; }
        public double? Lengthin { get; set; }
        public string Diameterin { get; set; }
        public double? Widthcm { get; set; }
        public double? Lengthcm { get; set; }
        public string Diametercm { get; set; }
        public double? Quantity { get; set; }
        public string Balance { get; set; }
        public string Unit { get; set; }
        public string Remarks { get; set; }
        public string CodeNumber { get; set; }
        public string GroupName { get; set; }
        public string Made { get; set; }
        public string WidthinF { get; set; }
        public string LengthinF { get; set; }
        public string DiameterinF { get; set; }
        public string Motor { get; set; }
        public string Locatedat { get; set; }
        public string UseforRollerShade { get; set; }
        public string UseforZebra { get; set; }
        public string UseforAurora { get; set; }
        public string UseforBlackOut { get; set; }
        public string UseforCassete { get; set; }
        public DateTime? InventoryDate { get; set; }
        public string InventoryNumber { get; set; }
        public string Partsin { get; set; }
        public string CurtainPartsDeductionin { get; set; }
        public string Partscm { get; set; }
        public string CurtainPartsDeductioncm { get; set; }
        public double? AvailableQtyin { get; set; }
        public string UsedProductionId { get; set; }
        public string Available { get; set; }
        public string UnitPrice { get; set; }
        public string Amount { get; set; }
        public string Tax { get; set; }
        public string PurchasedQuantity { get; set; }
        public string PurchasedUnit { get; set; }
        public string UsedFor { get; set; }
    }
}
