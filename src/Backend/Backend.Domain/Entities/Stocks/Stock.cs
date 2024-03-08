﻿using Backend.Domain.Entities.Products;
using Backend.Domain.Entities.Agents;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Domain.Entities.Base;

namespace Backend.Domain.Entities.Stock
{
    [Table("Stock")]
    public class Stock : Model
    {
        [Key]
        public Guid StockMovementId { get; set; }
        [Required]
        public Guid TenantId { get; set; }
        public Guid UserId { get; set; }
        public int Quantity { get; set; }
        public DateTime? MovementDate { get; set; }
        public string? MovementType { get; set; }
        public int MovementStatusId { get; set; }
         


        //Chaves estrangeiras de outras tabelas 
        [ForeignKey("VariantId")]
        public Guid VariantId { get; set; }
        
        [ForeignKey("AgentId")]
        public Guid AgentId { get; set; }

        [ForeignKey("ProductId")]
        public Guid ProductId { get; set; }
    }

    public class StockDetail : Stock
    {
        public string ProductName { get; set; }
        public string? VariantName { get; set; }
        public string AgentName { get; set; }
    }
}