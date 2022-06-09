using RenewingPassport.Core.Data;
using RenewingPassport.Core.DTO;
using RenewingPassport.Core.Repository;
using RenewingPassport.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Infra.Service
{
    public class Pr_AnnouncementService: IPr_AnnouncementService
    {
        private readonly IPr_AnnouncementRepository _AnnouncementRepository;

        public Pr_AnnouncementService(IPr_AnnouncementRepository AnnouncementRepository)
        {
            _AnnouncementRepository = AnnouncementRepository;
        }

        public bool CreateAnnouncementl(Pr_Announcement pr_Announcement)
        {
            return _AnnouncementRepository.CreateAnnouncementl(pr_Announcement);
        }

        public bool DeleteAnnouncement(int id)
        {
            return _AnnouncementRepository.DeleteAnnouncement(id);
        }

        public List<Pr_Announcement> GetAllAnnouncement()
        {
            return _AnnouncementRepository.GetAllAnnouncement();
        }

        public bool UpdateAnnouncement(Pr_Announcement pr_Announcement)
        {
            return _AnnouncementRepository.UpdateAnnouncement(pr_Announcement);
        }

        public List<Pr_Announcement> SearchAnnouncement(SearchAnnouncementDTO searchAnnouncement)
        {
            return _AnnouncementRepository.SearchAnnouncement(searchAnnouncement);
        }
    }
}
