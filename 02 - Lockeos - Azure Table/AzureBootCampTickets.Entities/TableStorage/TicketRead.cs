﻿using System;
using Microsoft.WindowsAzure.Storage.Table;

namespace AzureBootCampTickets.Entities.TableStorage
{
    //TODO : 08 - Creamos entidad de lectura para Tickets
    public class TicketRead: TableEntity
    {
        public string ParentEventName { get; set; }
        public string ParentEventDescription { get; set; }
        public DateTime ParentEventDate { get; set; }
        public string AttendeeName { get; set; }
        public double TotalPrice { get; set; }
        public string TicketStatus { get; set; }
        public string AccessCode { get; set; }
    }
}