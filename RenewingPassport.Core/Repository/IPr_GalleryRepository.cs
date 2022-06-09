using RenewingPassport.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Core.Repository
{
    public interface IPr_GalleryRepository
    {
        List<Pr_Gallery> GetALLGallery();
        bool CreateGallery(Pr_Gallery pr_Gallery);
        bool UpdateGallery(Pr_Gallery pr_Gallery);
        bool DeleteGallery(int id);
    }
}
