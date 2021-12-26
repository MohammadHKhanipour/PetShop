﻿namespace PetShop.Data.Models
{
    public class PetImage : BaseModel
    {
        public int Num { get; set; }
        public bool IsCover { get; set; }
        public string ImageLink { get; set; }

        public int PetId { get; set; }

        public Pet Pet { get; set; }
    }
}
