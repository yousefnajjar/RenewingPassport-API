using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RenewingPassport.Core.Data;
using RenewingPassport.Core.DTO;
using RenewingPassport.Core.Service;
using System.Collections.Generic;

namespace RenewingPassport.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Pr_AnnouncementController : ControllerBase
    {
        private readonly IPr_AnnouncementService pr_AnnouncementService;

        public Pr_AnnouncementController(IPr_AnnouncementService _pr_AnnouncementService)
        {
            pr_AnnouncementService = _pr_AnnouncementService;
        }


        [HttpGet] 
        [ProducesResponseType(typeof(List<Pr_Announcement>), StatusCodes.Status200OK)]
        public List<Pr_Announcement> GetAllAnnouncement()
        {
            return pr_AnnouncementService.GetAllAnnouncement();
        }

        [HttpPost]
        public bool Create([FromBody] Pr_Announcement pr_Announcement)
        {
            return pr_AnnouncementService.CreateAnnouncementl(pr_Announcement);
        }

        [HttpDelete]
        [Route("delete/{id}")] 
        public bool Delete(int id)
        {
            return pr_AnnouncementService.DeleteAnnouncement(id);
        }

        [HttpPut]
        [Route("UpdateAnnouncement")]
        public bool Update([FromBody] Pr_Announcement pr_Announcement)
        {
            return pr_AnnouncementService.UpdateAnnouncement(pr_Announcement);
        }


        [HttpPost]
        [Route("Search")]
        public List<Pr_Announcement> SearchAnnouncement(SearchAnnouncementDTO searchAnnouncement)
        {
            return pr_AnnouncementService.SearchAnnouncement(searchAnnouncement);
        }
    }
}
