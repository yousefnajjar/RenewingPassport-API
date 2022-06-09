using RenewingPassport.Core.Data;
using RenewingPassport.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Core.Repository
{
    public interface IPr_AnnouncementRepository
    {
        //Read
        List<Pr_Announcement> GetAllAnnouncement();
        //Create
        bool CreateAnnouncementl(Pr_Announcement pr_Announcement);

        //Update
        bool UpdateAnnouncement(Pr_Announcement pr_Announcement);

        //Delete
        bool DeleteAnnouncement(int id);
        //search
        List<Pr_Announcement> SearchAnnouncement(SearchAnnouncementDTO searchAnnouncement);

    }
}
