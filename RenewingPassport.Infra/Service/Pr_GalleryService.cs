using RenewingPassport.Core.Data;
using RenewingPassport.Core.Repository;
using RenewingPassport.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Infra.Service
{
    public class Pr_GalleryService : IPr_GalleryService
    {
        private readonly IPr_GalleryRepository _pr_GalleryRepository;
        public Pr_GalleryService(IPr_GalleryRepository pr_GalleryRepository)
        {
            _pr_GalleryRepository = pr_GalleryRepository;
        }
        public bool CreateGallery(Pr_Gallery pr_Gallery)
        {
            return _pr_GalleryRepository.CreateGallery(pr_Gallery);
        }

        public bool DeleteGallery(int id)
        {
            return _pr_GalleryRepository.DeleteGallery(id);
        }

        public List<Pr_Gallery> GetALLGallery()
        {
            return _pr_GalleryRepository.GetALLGallery();
        }

        public bool UpdateGallery(Pr_Gallery pr_Gallery)
        {
            return _pr_GalleryRepository.UpdateGallery(pr_Gallery);
        }
    }
}
